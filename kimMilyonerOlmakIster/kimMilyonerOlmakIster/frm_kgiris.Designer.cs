
namespace kimMilyonerOlmakIster
{
    partial class frm_ygiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_yadi = new System.Windows.Forms.TextBox();
            this.txt_ysifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetici Adı = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yönetici Şifre = ";
            // 
            // txt_yadi
            // 
            this.txt_yadi.Location = new System.Drawing.Point(118, 30);
            this.txt_yadi.Name = "txt_yadi";
            this.txt_yadi.Size = new System.Drawing.Size(213, 23);
            this.txt_yadi.TabIndex = 2;
            // 
            // txt_ysifre
            // 
            this.txt_ysifre.Location = new System.Drawing.Point(118, 59);
            this.txt_ysifre.Name = "txt_ysifre";
            this.txt_ysifre.Size = new System.Drawing.Size(213, 23);
            this.txt_ysifre.TabIndex = 3;
            this.txt_ysifre.UseSystemPasswordChar = true;
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(250, 88);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(81, 41);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // frm_ygiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 141);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_ysifre);
            this.Controls.Add(this.txt_yadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frm_ygiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_yadi;
        private System.Windows.Forms.TextBox txt_ysifre;
        private System.Windows.Forms.Button btn_giris;
    }
}