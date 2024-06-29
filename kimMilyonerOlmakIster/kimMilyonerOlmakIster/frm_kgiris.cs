using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kimMilyonerOlmakIster
{
    public partial class frm_ygiris : Form
    {
        public frm_ygiris()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adp_veri;
            DataTable dtp_veriler;
            string sorgu = "select * from yonetici";
            string yol = "Provider = microsoft.ACE.OLEDB.12.0; Data Source = karisiksorular.accdb";
            OleDbConnection cnt_baglanti = new OleDbConnection(yol);
            cnt_baglanti.Open();
            adp_veri = new OleDbDataAdapter(sorgu, cnt_baglanti);
            dtp_veriler = new DataTable();
            adp_veri.Fill(dtp_veriler);
            
            
            frm_ana ana = new frm_ana();
            if (dtp_veriler.Rows[0][0].ToString()==txt_yadi.Text && dtp_veriler.Rows[0][1].ToString()==txt_ysifre.Text) {
                MessageBox.Show("Giriş Başarılı");
                this.Close();
                frm_ySoruEkleme soruIslem = new frm_ySoruEkleme();
                soruIslem.Show();
            }
            else
            {
                MessageBox.Show("Yönetici adı veya şifre hatalı","HATA");
            }
            cnt_baglanti.Close();
        }
    }
}
