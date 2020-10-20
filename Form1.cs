using Microsoft.Office.Interop.Excel;
using System;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace Nöbetci_UI_v2
{
    public partial class AnalistNobetci : Form
    {
        public AnalistNobetci()
        {
            InitializeComponent();
        }

        Application m_XlApp = new Application();
        Workbook m_XlWorkbook;
        Worksheet m_XlWorkSheet;

        string fileName;
        string ay;

        bool dosyaAcik = false;

        int indexRow;

        private void AnalistNobetci_Load(object sender, EventArgs e)
        {
            cmb_Multi.SelectedIndex = 0;
            cmb_Ay.SelectedIndex = DateTime.Today.Month - 1;
        }

        private void Btn_GetExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Nöbetçi Listesi",
                Filter = "Excel File|*.xlsx; *.xls"
            };

            if (!dosyaAcik)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;

                    dosyaAcik = true;

                    GetAnalistList(cmb_Nobetci, 2);

                    ExceltoGrid();
                }
                else
                {
                    MessageBox.Show("Nöbetçi Excel Dosyasını Seçin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Yüklü Excel Var!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (cmb_Nobetci.Text != "" )
            {
                YeniNobetciEkle(cmb_Nobetci, dtp_Tarih);
            }
            else
            {
                MessageBox.Show("Nöbetçi Atamalarını Yap", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Auto_Click(object sender, EventArgs e)
        {
            if (m_XlWorkbook != null)
            {
                AutoNobetciOlustur();
            }
            else
            {
                MessageBox.Show("Excel Yükle", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_SetExcel_Click(object sender, EventArgs e)
        {
            if (m_XlWorkbook != null)
            {
                ExcelUpdate();
            }
            else
            {
                MessageBox.Show("Excel Yükle", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dtp_Tarih_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void Chc_Degisim_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_Degisim.Checked)
            {
                dgv_Excel.ReadOnly = false;
            }
            else
            {
                dgv_Excel.ReadOnly = true;
            }
        }

        private void Cmb_Ay_SelectedValueChanged(object sender, EventArgs e)
        {
            if (dosyaAcik)
            {
                dgv_Excel.Rows.Clear();

                ExceltoGrid();
            }
        }

        private void Baglantı(string _fileName)
        {
            ay = cmb_Ay.Text;

            m_XlWorkbook = m_XlApp.Workbooks.Open(_fileName);
            m_XlWorkSheet = m_XlWorkbook.Worksheets[ay];
        }

        private void ExceltoGrid()
        {
            Baglantı(fileName);

            for (indexRow = 2; indexRow <= m_XlWorkSheet.Rows.Count; indexRow++)
            {
                if (m_XlWorkSheet.Cells[indexRow, 1].value == null)
                {
                    break;
                }
                else
                {
                    string[] row = new string[]
                    {
                        m_XlWorkSheet.Cells[indexRow, 1].value.ToString(),
                        m_XlWorkSheet.Cells[indexRow, 2].value.ToString(),
                        m_XlWorkSheet.Cells[indexRow, 3].value.ToString()
                    };

                    dgv_Excel.Rows.Add(row);
                }
            }

            m_XlWorkbook.Close();
            m_XlApp.Quit();
        }

        private void ExcelUpdate()
        {
            Baglantı(fileName);
            dgv_Excel.AllowUserToAddRows = false;

            int rowIndex = 2;

            foreach (DataGridViewRow row in dgv_Excel.Rows)
            {
                for (int i = 0; i < dgv_Excel.Columns.Count; i++)
                {
                    m_XlWorkSheet.Cells[rowIndex, i + 1] = row.Cells[i].Value.ToString();
                }

                rowIndex++;
            }

            dgv_Excel.AllowUserToAddRows = true;
            
            m_XlApp.Visible = true;
            m_XlWorkbook.Close();
            m_XlApp.Quit();
        }

        private void AutoNobetciOlustur()
        {
            DateTime bugun = DateTime.Today;
            DateTime sonGun = new DateTime(bugun.Year, bugun.Month + 1, 1);

            for (int i = 0; i < cmb_Nobetci.Items.Count; i++)
            {
                for (int j = 0; bugun < sonGun; j++)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dgv_Excel);
                    newRow.Cells[0].Value = i + 1;

                    if (j < Convert.ToInt32(cmb_Multi.Text))
                    {
                        newRow.Cells[1].Value = cmb_Nobetci.Items[i];
                    }
                    else
                    {
                        break;
                    }

                    newRow.Cells[2].Value = bugun;

                    if (bugun.DayOfWeek == DayOfWeek.Friday)
                    {
                        bugun = bugun.AddDays(2);
                    }

                    bugun = bugun.AddDays(1);

                    dgv_Excel.Rows.Add(newRow);
                }
            }
        }

        private void GetAnalistList(ComboBox comboBox, int number)
        {
            m_XlWorkbook = m_XlApp.Workbooks.Open(fileName);
            m_XlWorkSheet = m_XlWorkbook.Worksheets["Analist"];

            for (indexRow = 2; indexRow <= m_XlWorkSheet.Rows.Count; indexRow++)
            {
                if (m_XlWorkSheet.Cells[indexRow, number].value == null)
                {
                    break;
                }
                else
                {
                    comboBox.Items.Add(m_XlWorkSheet.Cells[indexRow, number].value);
                }
            }
        }
    
        private void YeniNobetciEkle(ComboBox nobetci, DateTimePicker tarih)
        {
            int idIndex = dgv_Excel.Rows.Count;

            try
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgv_Excel);
                newRow.Cells[0].Value = idIndex;
                newRow.Cells[1].Value = nobetci.Text;
                newRow.Cells[2].Value = tarih.Text;
                dgv_Excel.Rows.Add(newRow);

                idIndex++;                    
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
