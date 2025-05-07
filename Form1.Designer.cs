namespace RequirementsConverter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.ComboBox cmbFormats;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label labelFormat;

        /// <summary>
        /// Temizleme işlemi
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelHeader = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.cmbFormats = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.labelFormat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelHeader.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelHeader.Location = new System.Drawing.Point(123, 28);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(361, 41);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Requirements Converter";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelectFile.FlatAppearance.BorderSize = 0;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSelectFile.ForeColor = System.Drawing.Color.White;
            this.btnSelectFile.Location = new System.Drawing.Point(100, 90);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(400, 40);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Dosya Seç";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // cmbFormats
            // 
            this.cmbFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormats.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFormats.FormattingEnabled = true;
            this.cmbFormats.Items.AddRange(new object[] {
            "XML",
            "YAML",
            "CSV"});
            this.cmbFormats.Location = new System.Drawing.Point(100, 185);
            this.cmbFormats.Name = "cmbFormats";
            this.cmbFormats.Size = new System.Drawing.Size(200, 31);
            this.cmbFormats.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConvert.FlatAppearance.BorderSize = 0;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.Location = new System.Drawing.Point(320, 185);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(180, 40);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Dönüştür";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblResult.ForeColor = System.Drawing.Color.Maroon;
            this.lblResult.Location = new System.Drawing.Point(100, 250);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 5;
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelFormat.Location = new System.Drawing.Point(100, 160);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(234, 23);
            this.labelFormat.TabIndex = 2;
            this.labelFormat.Text = "Hangi formata dönüştürelim?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 320);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cmbFormats);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.labelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Veri Dönüştürücü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
