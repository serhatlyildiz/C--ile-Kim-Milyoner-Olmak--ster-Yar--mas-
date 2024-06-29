
namespace kimMilyonerOlmakIster
{
    partial class frm_ana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ana));
            this.btn_oyna = new System.Windows.Forms.Button();
            this.btn_yoneticiGirisi = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_oyna
            // 
            this.btn_oyna.BackColor = System.Drawing.Color.Blue;
            this.btn_oyna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_oyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oyna.Location = new System.Drawing.Point(38, 157);
            this.btn_oyna.Margin = new System.Windows.Forms.Padding(4);
            this.btn_oyna.Name = "btn_oyna";
            this.btn_oyna.Size = new System.Drawing.Size(150, 150);
            this.btn_oyna.TabIndex = 0;
            this.btn_oyna.Text = "OYNA";
            this.btn_oyna.UseVisualStyleBackColor = false;
            this.btn_oyna.Click += new System.EventHandler(this.btn_oyna_Click);
            // 
            // btn_yoneticiGirisi
            // 
            this.btn_yoneticiGirisi.BackColor = System.Drawing.Color.Blue;
            this.btn_yoneticiGirisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_yoneticiGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yoneticiGirisi.Location = new System.Drawing.Point(594, 157);
            this.btn_yoneticiGirisi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_yoneticiGirisi.Name = "btn_yoneticiGirisi";
            this.btn_yoneticiGirisi.Size = new System.Drawing.Size(150, 150);
            this.btn_yoneticiGirisi.TabIndex = 1;
            this.btn_yoneticiGirisi.Text = "Yönetici Girişi";
            this.btn_yoneticiGirisi.UseVisualStyleBackColor = false;
            this.btn_yoneticiGirisi.Click += new System.EventHandler(this.btn_yoneticiGirisi_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.BackgroundImage")));
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.Location = new System.Drawing.Point(743, 13);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(25, 25);
            this.btn_cikis.TabIndex = 2;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // frm_ana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_yoneticiGirisi);
            this.Controls.Add(this.btn_oyna);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_ana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_ana_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_oyna;
        private System.Windows.Forms.Button btn_yoneticiGirisi;
        private System.Windows.Forms.Button btn_cikis;
    }
}

