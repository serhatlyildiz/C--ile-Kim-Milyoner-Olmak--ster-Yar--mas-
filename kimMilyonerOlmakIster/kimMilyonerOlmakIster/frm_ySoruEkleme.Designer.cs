
namespace kimMilyonerOlmakIster
{
    partial class frm_ySoruEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ySoruEkleme));
            this.grpbx_sorular = new System.Windows.Forms.GroupBox();
            this.txt_muzik = new System.Windows.Forms.TextBox();
            this.btn_muzik = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_islem = new System.Windows.Forms.Button();
            this.txt_ycevap3 = new System.Windows.Forms.TextBox();
            this.txt_ycevap2 = new System.Windows.Forms.TextBox();
            this.txt_ycevap1 = new System.Windows.Forms.TextBox();
            this.txt_dcevap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxt_soru = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_derece = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrd_veriler = new System.Windows.Forms.DataGridView();
            this.cmbx_getirdereces = new System.Windows.Forms.ComboBox();
            this.ofd_kaynak = new System.Windows.Forms.OpenFileDialog();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.grpbx_sorular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_veriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbx_sorular
            // 
            this.grpbx_sorular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpbx_sorular.Controls.Add(this.axWindowsMediaPlayer1);
            this.grpbx_sorular.Controls.Add(this.txt_muzik);
            this.grpbx_sorular.Controls.Add(this.btn_muzik);
            this.grpbx_sorular.Controls.Add(this.btn_temizle);
            this.grpbx_sorular.Controls.Add(this.btn_sil);
            this.grpbx_sorular.Controls.Add(this.btn_islem);
            this.grpbx_sorular.Controls.Add(this.txt_ycevap3);
            this.grpbx_sorular.Controls.Add(this.txt_ycevap2);
            this.grpbx_sorular.Controls.Add(this.txt_ycevap1);
            this.grpbx_sorular.Controls.Add(this.txt_dcevap);
            this.grpbx_sorular.Controls.Add(this.label6);
            this.grpbx_sorular.Controls.Add(this.label5);
            this.grpbx_sorular.Controls.Add(this.label4);
            this.grpbx_sorular.Controls.Add(this.label3);
            this.grpbx_sorular.Controls.Add(this.rtxt_soru);
            this.grpbx_sorular.Controls.Add(this.label2);
            this.grpbx_sorular.Controls.Add(this.cmbx_derece);
            this.grpbx_sorular.Controls.Add(this.label1);
            this.grpbx_sorular.Location = new System.Drawing.Point(12, 12);
            this.grpbx_sorular.Name = "grpbx_sorular";
            this.grpbx_sorular.Size = new System.Drawing.Size(408, 525);
            this.grpbx_sorular.TabIndex = 0;
            this.grpbx_sorular.TabStop = false;
            // 
            // txt_muzik
            // 
            this.txt_muzik.Location = new System.Drawing.Point(19, 398);
            this.txt_muzik.Name = "txt_muzik";
            this.txt_muzik.Size = new System.Drawing.Size(216, 23);
            this.txt_muzik.TabIndex = 15;
            // 
            // btn_muzik
            // 
            this.btn_muzik.Location = new System.Drawing.Point(265, 414);
            this.btn_muzik.Name = "btn_muzik";
            this.btn_muzik.Size = new System.Drawing.Size(113, 37);
            this.btn_muzik.TabIndex = 0;
            this.btn_muzik.Text = "Ses Dosyası";
            this.btn_muzik.UseVisualStyleBackColor = true;
            this.btn_muzik.Click += new System.EventHandler(this.btn_muzik_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(19, 482);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(99, 37);
            this.btn_temizle.TabIndex = 14;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(143, 482);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(114, 37);
            this.btn_sil.TabIndex = 13;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_islem
            // 
            this.btn_islem.Location = new System.Drawing.Point(282, 482);
            this.btn_islem.Name = "btn_islem";
            this.btn_islem.Size = new System.Drawing.Size(113, 37);
            this.btn_islem.TabIndex = 12;
            this.btn_islem.Text = "EKLE";
            this.btn_islem.UseVisualStyleBackColor = true;
            this.btn_islem.Click += new System.EventHandler(this.btn_islem_Click);
            // 
            // txt_ycevap3
            // 
            this.txt_ycevap3.Location = new System.Drawing.Point(143, 362);
            this.txt_ycevap3.Name = "txt_ycevap3";
            this.txt_ycevap3.Size = new System.Drawing.Size(252, 23);
            this.txt_ycevap3.TabIndex = 11;
            // 
            // txt_ycevap2
            // 
            this.txt_ycevap2.Location = new System.Drawing.Point(143, 317);
            this.txt_ycevap2.Name = "txt_ycevap2";
            this.txt_ycevap2.Size = new System.Drawing.Size(252, 23);
            this.txt_ycevap2.TabIndex = 10;
            // 
            // txt_ycevap1
            // 
            this.txt_ycevap1.Location = new System.Drawing.Point(143, 273);
            this.txt_ycevap1.Name = "txt_ycevap1";
            this.txt_ycevap1.Size = new System.Drawing.Size(252, 23);
            this.txt_ycevap1.TabIndex = 9;
            // 
            // txt_dcevap
            // 
            this.txt_dcevap.Location = new System.Drawing.Point(143, 231);
            this.txt_dcevap.Name = "txt_dcevap";
            this.txt_dcevap.Size = new System.Drawing.Size(252, 23);
            this.txt_dcevap.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Yanlış Cevap = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Yanlış Cevap = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yanlış Cevap = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doğru Cevap = ";
            // 
            // rtxt_soru
            // 
            this.rtxt_soru.Location = new System.Drawing.Point(83, 101);
            this.rtxt_soru.Name = "rtxt_soru";
            this.rtxt_soru.Size = new System.Drawing.Size(312, 124);
            this.rtxt_soru.TabIndex = 3;
            this.rtxt_soru.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soru = ";
            // 
            // cmbx_derece
            // 
            this.cmbx_derece.FormattingEnabled = true;
            this.cmbx_derece.Location = new System.Drawing.Point(203, 55);
            this.cmbx_derece.Name = "cmbx_derece";
            this.cmbx_derece.Size = new System.Drawing.Size(69, 24);
            this.cmbx_derece.TabIndex = 1;
            this.cmbx_derece.SelectedIndexChanged += new System.EventHandler(this.cmbx_derece_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru Zorluk Derecesi = ";
            // 
            // dtgrd_veriler
            // 
            this.dtgrd_veriler.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgrd_veriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_veriler.Location = new System.Drawing.Point(426, 67);
            this.dtgrd_veriler.Name = "dtgrd_veriler";
            this.dtgrd_veriler.Size = new System.Drawing.Size(748, 470);
            this.dtgrd_veriler.TabIndex = 1;
            this.dtgrd_veriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_veriler_CellClick);
            // 
            // cmbx_getirdereces
            // 
            this.cmbx_getirdereces.FormattingEnabled = true;
            this.cmbx_getirdereces.Location = new System.Drawing.Point(1105, 37);
            this.cmbx_getirdereces.Name = "cmbx_getirdereces";
            this.cmbx_getirdereces.Size = new System.Drawing.Size(69, 24);
            this.cmbx_getirdereces.TabIndex = 13;
            this.cmbx_getirdereces.SelectedIndexChanged += new System.EventHandler(this.cmbx_getirdereces_SelectedIndexChanged);
            // 
            // ofd_kaynak
            // 
            this.ofd_kaynak.FileName = "openFileDialog1";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(19, 427);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(216, 49);
            this.axWindowsMediaPlayer1.TabIndex = 16;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter_1);
            // 
            // frm_ySoruEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 549);
            this.Controls.Add(this.cmbx_getirdereces);
            this.Controls.Add(this.dtgrd_veriler);
            this.Controls.Add(this.grpbx_sorular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_ySoruEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soru İşlemleri";
            this.Load += new System.EventHandler(this.frm_ySoruEkleme_Load);
            this.grpbx_sorular.ResumeLayout(false);
            this.grpbx_sorular.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_veriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbx_sorular;
        private System.Windows.Forms.Button btn_islem;
        private System.Windows.Forms.TextBox txt_ycevap3;
        private System.Windows.Forms.TextBox txt_ycevap2;
        private System.Windows.Forms.TextBox txt_ycevap1;
        private System.Windows.Forms.TextBox txt_dcevap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxt_soru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_derece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrd_veriler;
        private System.Windows.Forms.ComboBox cmbx_getirdereces;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_muzik;
        private System.Windows.Forms.OpenFileDialog ofd_kaynak;
        private System.Windows.Forms.TextBox txt_muzik;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}