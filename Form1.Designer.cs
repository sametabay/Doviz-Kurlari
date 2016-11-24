namespace DovizKurlari
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnKurlariCek = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSatis = new System.Windows.Forms.Label();
            this.lblAlis = new System.Windows.Forms.Label();
            this.lblKurAdi = new System.Windows.Forms.Label();
            this.nSatis = new System.Windows.Forms.NumericUpDown();
            this.nAlis = new System.Windows.Forms.NumericUpDown();
            this.cmbSatis = new System.Windows.Forms.ComboBox();
            this.cmbAlis = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nSatis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAlis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKurlariCek
            // 
            this.btnKurlariCek.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKurlariCek.Location = new System.Drawing.Point(15, 15);
            this.btnKurlariCek.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnKurlariCek.Name = "btnKurlariCek";
            this.btnKurlariCek.Size = new System.Drawing.Size(210, 118);
            this.btnKurlariCek.TabIndex = 0;
            this.btnKurlariCek.Text = "Güncel Kurları Çek";
            this.btnKurlariCek.UseVisualStyleBackColor = true;
            this.btnKurlariCek.Click += new System.EventHandler(this.btnKurlariCek_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSatis
            // 
            this.lblSatis.AutoSize = true;
            this.lblSatis.ForeColor = System.Drawing.Color.Green;
            this.lblSatis.Location = new System.Drawing.Point(239, 107);
            this.lblSatis.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblSatis.Name = "lblSatis";
            this.lblSatis.Size = new System.Drawing.Size(58, 25);
            this.lblSatis.TabIndex = 2;
            this.lblSatis.Text = "Satış";
            // 
            // lblAlis
            // 
            this.lblAlis.AutoSize = true;
            this.lblAlis.ForeColor = System.Drawing.Color.Green;
            this.lblAlis.Location = new System.Drawing.Point(239, 61);
            this.lblAlis.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblAlis.Name = "lblAlis";
            this.lblAlis.Size = new System.Drawing.Size(54, 25);
            this.lblAlis.TabIndex = 3;
            this.lblAlis.Text = "Alış ";
            // 
            // lblKurAdi
            // 
            this.lblKurAdi.AutoSize = true;
            this.lblKurAdi.ForeColor = System.Drawing.Color.Green;
            this.lblKurAdi.Location = new System.Drawing.Point(239, 15);
            this.lblKurAdi.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblKurAdi.Name = "lblKurAdi";
            this.lblKurAdi.Size = new System.Drawing.Size(78, 25);
            this.lblKurAdi.TabIndex = 4;
            this.lblKurAdi.Text = "Kur Adı";
            // 
            // nSatis
            // 
            this.nSatis.DecimalPlaces = 4;
            this.nSatis.Enabled = false;
            this.nSatis.Location = new System.Drawing.Point(15, 266);
            this.nSatis.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nSatis.Name = "nSatis";
            this.nSatis.Size = new System.Drawing.Size(210, 31);
            this.nSatis.TabIndex = 7;
            // 
            // nAlis
            // 
            this.nAlis.DecimalPlaces = 4;
            this.nAlis.Location = new System.Drawing.Point(15, 142);
            this.nAlis.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nAlis.Name = "nAlis";
            this.nAlis.Size = new System.Drawing.Size(210, 31);
            this.nAlis.TabIndex = 8;
            this.nAlis.ValueChanged += new System.EventHandler(this.cmbAlis_SelectedIndexChanged);
            // 
            // cmbSatis
            // 
            this.cmbSatis.FormattingEnabled = true;
            this.cmbSatis.Location = new System.Drawing.Point(15, 224);
            this.cmbSatis.Name = "cmbSatis";
            this.cmbSatis.Size = new System.Drawing.Size(210, 33);
            this.cmbSatis.TabIndex = 5;
            this.cmbSatis.SelectedIndexChanged += new System.EventHandler(this.cmbAlis_SelectedIndexChanged);
            // 
            // cmbAlis
            // 
            this.cmbAlis.FormattingEnabled = true;
            this.cmbAlis.Location = new System.Drawing.Point(15, 182);
            this.cmbAlis.Name = "cmbAlis";
            this.cmbAlis.Size = new System.Drawing.Size(210, 33);
            this.cmbAlis.TabIndex = 6;
            this.cmbAlis.SelectedIndexChanged += new System.EventHandler(this.cmbAlis_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 344);
            this.Controls.Add(this.nSatis);
            this.Controls.Add(this.nAlis);
            this.Controls.Add(this.cmbSatis);
            this.Controls.Add(this.cmbAlis);
            this.Controls.Add(this.lblSatis);
            this.Controls.Add(this.lblAlis);
            this.Controls.Add(this.lblKurAdi);
            this.Controls.Add(this.btnKurlariCek);
            this.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nSatis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAlis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKurlariCek;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSatis;
        private System.Windows.Forms.Label lblAlis;
        private System.Windows.Forms.Label lblKurAdi;
        private System.Windows.Forms.NumericUpDown nSatis;
        private System.Windows.Forms.NumericUpDown nAlis;
        private System.Windows.Forms.ComboBox cmbSatis;
        private System.Windows.Forms.ComboBox cmbAlis;
    }
}

