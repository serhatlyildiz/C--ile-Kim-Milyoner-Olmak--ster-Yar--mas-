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
using System.IO;

namespace kimMilyonerOlmakIster
{
    public partial class frm_ySoruEkleme : Form
    {
        public frm_ySoruEkleme()
        {
            InitializeComponent();
        }
    
        OleDbConnection cnt_baglanti = new OleDbConnection("Provider = microsoft.ACE.OLEDB.12.0; Data Source = karisiksorular.accdb");
        int secilisoru;
        string kaynakDosyaIsmi = "";
        String kaynakDosya = "";
        string hedefKlasor = ""+Path.GetDirectoryName(Application.ExecutablePath).ToString()+"\\muzikler";
        int muzikSayisi;

        public void verigoster(string sorgu)
        {
            OleDbDataAdapter adp_veri = new OleDbDataAdapter(sorgu, cnt_baglanti);
            DataTable dtp_veriler = new DataTable();
            adp_veri.Fill(dtp_veriler);
            dtgrd_veriler.DataSource = dtp_veriler;
            muzikSayisi = Convert.ToInt32(dtp_veriler.Rows[dtp_veriler.Rows.Count-1][0].ToString());
        }

        public void temizle()
        {
            cmbx_derece.Text = "";
            rtxt_soru.Text = "";
            txt_dcevap.Text = "";
            txt_ycevap1.Text = "";
            txt_ycevap2.Text = "";
            txt_ycevap3.Text = "";
            btn_islem.Text = "EKLE";
            btn_sil.Enabled = false;
            cmbx_derece.Enabled = true;
            kaynakDosya = "";
            kaynakDosyaIsmi = "";
            txt_muzik.Enabled = true;
            txt_muzik.Text = "";
            txt_muzik.Enabled = false;
            btn_muzik.Visible = false;
            txt_muzik.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
        }

        private void frm_ySoruEkleme_Load(object sender, EventArgs e)
        {
            for (int i = 1; i<=10; i++)
            {
                cmbx_derece.Items.Add(i);
                cmbx_getirdereces.Items.Add(i);
            }
            btn_sil.Enabled = false;
            btn_muzik.Enabled = false;
            btn_muzik.Visible = false;
            txt_muzik.Visible = false;
            txt_muzik.Enabled = false;
            axWindowsMediaPlayer1.Visible = false;
        }

        private void cmbx_getirdereces_SelectedIndexChanged(object sender, EventArgs e)
        {
            temizle();
            cnt_baglanti.Open();
            verigoster("select * from soru"+cmbx_getirdereces.Text+"");
            cmbx_derece.Enabled = true;
            cmbx_derece.Text = cmbx_getirdereces.Text;
            cmbx_derece.Enabled = false;
            cnt_baglanti.Close();
            if (cmbx_getirdereces.SelectedIndex==5)
            {
                axWindowsMediaPlayer1.Visible = false;
                txt_muzik.Visible = false;
                btn_muzik.Visible = false;
            }
        }

        private void dtgrd_veriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temizle();
            int secilialan = dtgrd_veriler.SelectedCells[0].RowIndex;
            secilisoru = Convert.ToInt32(dtgrd_veriler.Rows[secilialan].Cells[0].Value.ToString());
            rtxt_soru.Text = dtgrd_veriler.Rows[secilialan].Cells[1].Value.ToString();
            txt_dcevap.Text = dtgrd_veriler.Rows[secilialan].Cells[2].Value.ToString();
            txt_ycevap1.Text = dtgrd_veriler.Rows[secilialan].Cells[3].Value.ToString();
            txt_ycevap2.Text = dtgrd_veriler.Rows[secilialan].Cells[4].Value.ToString();
            txt_ycevap3.Text = dtgrd_veriler.Rows[secilialan].Cells[5].Value.ToString();
            cmbx_derece.Enabled = true;
            cmbx_derece.Text = cmbx_getirdereces.Text;
            cmbx_derece.Enabled = false;
            btn_sil.Enabled = true;
            cmbx_derece.Enabled = false;
            btn_muzik.Visible = true;
            btn_muzik.Enabled = true;
            txt_muzik.Visible = true;
            txt_muzik.Enabled = false;
            if (cmbx_getirdereces.SelectedIndex==5)
            {
                axWindowsMediaPlayer1.Visible = true;
                axWindowsMediaPlayer1.URL = "muzikler\\" + secilisoru.ToString() + ".mp3";
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }
            else
            {
                axWindowsMediaPlayer1.Visible = false;
            }
            
            btn_islem.Text = "GÜNCELLE";
        }

        private void btn_islem_Click(object sender, EventArgs e)
        {
            if (cmbx_derece.Text=="" || rtxt_soru.Text=="" || txt_dcevap.Text=="" || txt_ycevap1.Text=="" || txt_ycevap2.Text=="" || txt_ycevap3.Text=="")
            {
                MessageBox.Show("Lütfen Alanları boş bırakmayınız...!","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {  
                if (btn_islem.Text == "EKLE")
                {
                    if (cmbx_derece.SelectedIndex==5)
                    {
                        if (kaynakDosya=="")
                        {
                            MessageBox.Show("Lütfen bir ses dosyası seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            cnt_baglanti.Open();
                            OleDbCommand komut = new OleDbCommand("insert into soru" + cmbx_derece.Text + " (soru,dogrucevap,yanliscevap1,yanliscevap2,yanliscevap3) values (@soru,@dogrucevap,@yanliscevap1,@yanliscevap2,@yanliscevap3) ", cnt_baglanti);
                            komut.Parameters.AddWithValue("@soru", rtxt_soru.Text);
                            komut.Parameters.AddWithValue("@dogrucevap", txt_dcevap.Text);
                            komut.Parameters.AddWithValue("@yanliscevap1", txt_ycevap1.Text);
                            komut.Parameters.AddWithValue("@yanliscevap2", txt_ycevap2.Text);
                            komut.Parameters.AddWithValue("@yanliscevap3", txt_ycevap3.Text);
                            komut.ExecuteNonQuery();
                            verigoster("select * from soru" + cmbx_derece.Text + "");
                            kaynakDosyaIsmi = (muzikSayisi).ToString()+".mp3";
                            File.Copy(kaynakDosya, hedefKlasor + "\\" + kaynakDosyaIsmi);
                            cnt_baglanti.Close();
                            cmbx_getirdereces.SelectedIndex = cmbx_derece.SelectedIndex;
                            temizle();
                        }
                    }
                    else
                    {
                        cnt_baglanti.Open();
                        OleDbCommand komut = new OleDbCommand("insert into soru" + cmbx_derece.Text + " (soru,dogrucevap,yanliscevap1,yanliscevap2,yanliscevap3) values (@soru,@dogrucevap,@yanliscevap1,@yanliscevap2,@yanliscevap3) ", cnt_baglanti);
                        komut.Parameters.AddWithValue("@soru", rtxt_soru.Text);
                        komut.Parameters.AddWithValue("@dogrucevap", txt_dcevap.Text);
                        komut.Parameters.AddWithValue("@yanliscevap1", txt_ycevap1.Text);
                        komut.Parameters.AddWithValue("@yanliscevap2", txt_ycevap2.Text);
                        komut.Parameters.AddWithValue("@yanliscevap3", txt_ycevap3.Text);
                        komut.ExecuteNonQuery();
                        verigoster("select * from soru" + cmbx_derece.Text + "");
                        cnt_baglanti.Close();
                        cmbx_getirdereces.Text = cmbx_derece.Text;
                        temizle();
                    }            
                }
                else
                {
                    if (cmbx_derece.SelectedIndex == 5)
                    {
                        if (kaynakDosya=="")
                        {
                            
                        }
                        else
                        {
                            
                            cnt_baglanti.Open();
                            verigoster("select * from soru" + cmbx_derece.Text + "");
                            kaynakDosyaIsmi = (secilisoru).ToString() + ".mp3";
                            System.IO.File.Delete(hedefKlasor + "\\" + secilisoru.ToString() + ".mp3");
                            File.Copy(kaynakDosya, hedefKlasor + "\\" + kaynakDosyaIsmi);
                            cnt_baglanti.Close();
                        }
                        btn_muzik.Visible = false;
                        btn_muzik.Enabled = false;
                        txt_muzik.Visible = false;
                        txt_muzik.Enabled = false;
                        axWindowsMediaPlayer1.Visible = false;
                        cnt_baglanti.Open();
                        OleDbCommand komut = new OleDbCommand("update soru" + cmbx_derece.Text + " set soru='" + rtxt_soru.Text + "',dogrucevap='" + txt_dcevap.Text + "',yanliscevap1='" + txt_ycevap1.Text + "',yanliscevap2='" + txt_ycevap2.Text + "',yanliscevap3='" + txt_ycevap3.Text + "' where soruNo=" + secilisoru.ToString() + "", cnt_baglanti);
                        komut.ExecuteNonQuery();
                        verigoster("select * from soru" + cmbx_derece.Text + "");
                        cnt_baglanti.Close();
                    }
                    else
                    {
                        btn_muzik.Visible = true;
                        btn_muzik.Enabled = true;
                        txt_muzik.Visible = true;
                        txt_muzik.Enabled = false;
                        axWindowsMediaPlayer1.Visible = true;
                        cnt_baglanti.Open();
                        OleDbCommand komut = new OleDbCommand("update soru" + cmbx_derece.Text + " set soru='" + rtxt_soru.Text + "',dogrucevap='" + txt_dcevap.Text + "',yanliscevap1='" + txt_ycevap1.Text + "',yanliscevap2='" + txt_ycevap2.Text + "',yanliscevap3='" + txt_ycevap3.Text + "' where soruNo=" + secilisoru.ToString() + "", cnt_baglanti);
                        komut.ExecuteNonQuery();
                        verigoster("select * from soru" + cmbx_derece.Text + "");
                        cnt_baglanti.Close();
                    }
                    cmbx_derece.Enabled = true;          
                    cmbx_getirdereces.SelectedIndex = cmbx_derece.SelectedIndex;
                    temizle();
                }               
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
            cmbx_getirdereces.Text = "";
            if (dtgrd_veriler.Rows.Count!=0)
            {
                dtgrd_veriler.DataSource = null;
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(hedefKlasor + "\\" + secilisoru.ToString()+".mp3");
            cnt_baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from soru"+cmbx_getirdereces.Text+" where soruNo="+secilisoru.ToString()+"",cnt_baglanti);
            komut.ExecuteNonQuery();
            verigoster("select * from soru"+cmbx_getirdereces.Text+"");
            cnt_baglanti.Close();
            temizle();
        }

        private void cmbx_derece_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_derece.SelectedIndex==5)
            {
                btn_muzik.Visible = true;
                btn_muzik.Enabled = true;
                txt_muzik.Visible = true;
                txt_muzik.Enabled = false;
                axWindowsMediaPlayer1.Visible = true;
            }
            else
            {
                btn_muzik.Visible = false;
                btn_muzik.Enabled = false;
                txt_muzik.Visible = false;
                txt_muzik.Enabled = false;
                axWindowsMediaPlayer1.Visible = false;
                kaynakDosya = "";
                kaynakDosyaIsmi = "";
            }
        }

        private void btn_muzik_Click(object sender, EventArgs e)
        {
            ofd_kaynak.Title = "Ses dosyasını seçiniz...";
            ofd_kaynak.FileName = "";
            ofd_kaynak.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (ofd_kaynak.ShowDialog()==DialogResult.OK)
            {
                kaynakDosya = ofd_kaynak.FileName.ToString();
                txt_muzik.Enabled = true;
                txt_muzik.Text = ofd_kaynak.SafeFileName.ToString();
                txt_muzik.Enabled = false;
                axWindowsMediaPlayer1.Visible = true;
            }
            else
            {
                MessageBox.Show("Ses dosyası Seçmediniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                axWindowsMediaPlayer1.Visible = false;
            }
        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "muzikler\\" + secilisoru.ToString() + ".mp3";
        }
    }
}
