namespace Nöbetci_UI_v2
{
    partial class AnalistNobetci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_Excel = new System.Windows.Forms.DataGridView();
            this.dgv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_nobetci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_SetExcel = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_GetExcel = new System.Windows.Forms.Button();
            this.btn_Auto = new System.Windows.Forms.Button();
            this.cmb_Ay = new System.Windows.Forms.ComboBox();
            this.cmb_Nobetci = new System.Windows.Forms.ComboBox();
            this.cmb_Multi = new System.Windows.Forms.ComboBox();
            this.dtp_Tarih = new System.Windows.Forms.DateTimePicker();
            this.chc_Degisim = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Excel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Excel
            // 
            this.dgv_Excel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Excel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_id,
            this.dgv_nobetci,
            this.dgv_tarih});
            this.dgv_Excel.Location = new System.Drawing.Point(12, 355);
            this.dgv_Excel.Name = "dgv_Excel";
            this.dgv_Excel.Size = new System.Drawing.Size(438, 215);
            this.dgv_Excel.TabIndex = 0;
            // 
            // dgv_id
            // 
            this.dgv_id.HeaderText = "ID";
            this.dgv_id.Name = "dgv_id";
            this.dgv_id.Width = 50;
            // 
            // dgv_nobetci
            // 
            this.dgv_nobetci.HeaderText = "NÖBETÇİ";
            this.dgv_nobetci.Name = "dgv_nobetci";
            this.dgv_nobetci.Width = 150;
            // 
            // dgv_tarih
            // 
            this.dgv_tarih.HeaderText = "TARİH";
            this.dgv_tarih.Name = "dgv_tarih";
            this.dgv_tarih.Width = 200;
            // 
            // btn_SetExcel
            // 
            this.btn_SetExcel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SetExcel.Location = new System.Drawing.Point(12, 576);
            this.btn_SetExcel.Name = "btn_SetExcel";
            this.btn_SetExcel.Size = new System.Drawing.Size(438, 59);
            this.btn_SetExcel.TabIndex = 1;
            this.btn_SetExcel.Text = "Excel\'e Aktar";
            this.btn_SetExcel.UseVisualStyleBackColor = true;
            this.btn_SetExcel.Click += new System.EventHandler(this.Btn_SetExcel_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Add.Location = new System.Drawing.Point(350, 221);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 38);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // btn_GetExcel
            // 
            this.btn_GetExcel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GetExcel.Location = new System.Drawing.Point(343, 39);
            this.btn_GetExcel.Name = "btn_GetExcel";
            this.btn_GetExcel.Size = new System.Drawing.Size(107, 94);
            this.btn_GetExcel.TabIndex = 3;
            this.btn_GetExcel.Text = "Excel\'i Yükle";
            this.btn_GetExcel.UseVisualStyleBackColor = true;
            this.btn_GetExcel.Click += new System.EventHandler(this.Btn_GetExcel_Click);
            // 
            // btn_Auto
            // 
            this.btn_Auto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Auto.Location = new System.Drawing.Point(12, 86);
            this.btn_Auto.Name = "btn_Auto";
            this.btn_Auto.Size = new System.Drawing.Size(155, 47);
            this.btn_Auto.TabIndex = 4;
            this.btn_Auto.Text = "Otomatik Nöbet Listesi Oluştur";
            this.btn_Auto.UseVisualStyleBackColor = true;
            this.btn_Auto.Click += new System.EventHandler(this.Btn_Auto_Click);
            // 
            // cmb_Ay
            // 
            this.cmb_Ay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Ay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_Ay.FormattingEnabled = true;
            this.cmb_Ay.Items.AddRange(new object[] {
            "Analist",
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmb_Ay.Location = new System.Drawing.Point(12, 39);
            this.cmb_Ay.Name = "cmb_Ay";
            this.cmb_Ay.Size = new System.Drawing.Size(155, 27);
            this.cmb_Ay.TabIndex = 5;
            this.cmb_Ay.SelectedValueChanged += new System.EventHandler(this.Cmb_Ay_SelectedValueChanged);
            // 
            // cmb_Nobetci
            // 
            this.cmb_Nobetci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Nobetci.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_Nobetci.FormattingEnabled = true;
            this.cmb_Nobetci.Location = new System.Drawing.Point(12, 227);
            this.cmb_Nobetci.Name = "cmb_Nobetci";
            this.cmb_Nobetci.Size = new System.Drawing.Size(121, 27);
            this.cmb_Nobetci.TabIndex = 6;
            // 
            // cmb_Multi
            // 
            this.cmb_Multi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Multi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_Multi.FormattingEnabled = true;
            this.cmb_Multi.Items.AddRange(new object[] {
            "2",
            "3"});
            this.cmb_Multi.Location = new System.Drawing.Point(173, 106);
            this.cmb_Multi.Name = "cmb_Multi";
            this.cmb_Multi.Size = new System.Drawing.Size(121, 27);
            this.cmb_Multi.TabIndex = 7;
            // 
            // dtp_Tarih
            // 
            this.dtp_Tarih.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_Tarih.Location = new System.Drawing.Point(144, 227);
            this.dtp_Tarih.Name = "dtp_Tarih";
            this.dtp_Tarih.Size = new System.Drawing.Size(200, 26);
            this.dtp_Tarih.TabIndex = 8;
            this.dtp_Tarih.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dtp_Tarih_KeyDown);
            // 
            // chc_Degisim
            // 
            this.chc_Degisim.AutoSize = true;
            this.chc_Degisim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chc_Degisim.Location = new System.Drawing.Point(12, 326);
            this.chc_Degisim.Name = "chc_Degisim";
            this.chc_Degisim.Size = new System.Drawing.Size(133, 23);
            this.chc_Degisim.TabIndex = 9;
            this.chc_Degisim.Text = "Değişime İzin Ver";
            this.chc_Degisim.UseVisualStyleBackColor = true;
            this.chc_Degisim.CheckedChanged += new System.EventHandler(this.Chc_Degisim_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nöbetçi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(140, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Aylar";
            // 
            // AnalistNobetci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 647);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chc_Degisim);
            this.Controls.Add(this.dtp_Tarih);
            this.Controls.Add(this.cmb_Multi);
            this.Controls.Add(this.cmb_Nobetci);
            this.Controls.Add(this.cmb_Ay);
            this.Controls.Add(this.btn_Auto);
            this.Controls.Add(this.btn_GetExcel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_SetExcel);
            this.Controls.Add(this.dgv_Excel);
            this.Name = "AnalistNobetci";
            this.Text = "Analist";
            this.Load += new System.EventHandler(this.AnalistNobetci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Excel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Excel;
        private System.Windows.Forms.Button btn_SetExcel;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_GetExcel;
        private System.Windows.Forms.Button btn_Auto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_nobetci;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tarih;
        private System.Windows.Forms.ComboBox cmb_Ay;
        private System.Windows.Forms.ComboBox cmb_Nobetci;
        private System.Windows.Forms.ComboBox cmb_Multi;
        private System.Windows.Forms.DateTimePicker dtp_Tarih;
        private System.Windows.Forms.CheckBox chc_Degisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

