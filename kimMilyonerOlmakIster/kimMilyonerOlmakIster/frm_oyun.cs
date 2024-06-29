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
    public partial class frm_oyun : Form
    {
        public frm_oyun()
        {
            InitializeComponent();
        }

        int yariyariya = 0;
        OleDbDataAdapter adp_soru;
        DataTable dtp_soru;
        int ciftcevap = 0;
        int asamasayaci = 1;
        int sayac = 59;
        int sorusayaci = 1;
        int parasayaci = 0;
        int rastgelesoru;
        int muziksayaci = 0;
        int ciftcevapKontrol = 0;
        List<Label> lbl_cevaplar = new List<Label>();
        List<Button> btn_cevaplar = new List<Button>();
        List<Label> siradaki = new List<Label>();
        Random rnd = new Random();
        List<string> paralar = new List<string> { "2500", "5000", "7500", "15000", "30000", "60000", "120000", "240000", "500000", "1000000" };
        List<string> muzikler = new List<string> { "animals", "bonbon", "bonenni", "bumbumtam", "despacito", "leon", "muslumgursesaffet", "olsunmuolmasin", "perasensizben", "shapeofyou" };
        List<Button> btn_paratablosu = new List<Button>();
        OleDbConnection cnt_baglanti = new OleDbConnection("Provider = microsoft.ACE.OLEDB.12.0; Data Source = karisiksorular.accdb");
        int veriSayisi;
        public void cevapp()
        {
            if (ciftcevap == 1)
            {
                if (MessageBox.Show("Son Kararınız mı?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (siradaki[0].Text == dtp_soru.Rows[rastgelesoru]["dogrucevap"].ToString())
                    {
                        if (asamasayaci == 1 || asamasayaci == 5)
                        {
                            btn_paratablosu[asamasayaci - 1].BackColor = Color.Orange;
                        }
                        else
                        {
                            btn_paratablosu[asamasayaci - 1].BackColor = Color.Green;
                        }
                        sorusayaci++;
                        parasayaci++;
                        asamasayaci++;
                        sayac = 59;
                        sorular();
                    }
                    else
                    {
                        ciftcevap++;
                        switch (ciftcevapKontrol)
                        {
                            case 1:
                                btn_aasikki.BackColor = Color.Gray;
                                btn_aasikki.Enabled = false;
                                break;
                            case 2:
                                btn_bbsikki.BackColor = Color.Gray;
                                btn_bbsikki.Enabled = false;
                                break;
                            case 3:
                                btn_ccsikki.BackColor = Color.Gray;
                                btn_ccsikki.Enabled = false;
                                break;
                            case 4:
                                btn_ddsikki.BackColor = Color.Gray;
                                btn_ddsikki.Enabled = false;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            else if (ciftcevap == 2)
            {
                if (MessageBox.Show("Son Kararınız mı?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (siradaki[0].Text == dtp_soru.Rows[rastgelesoru]["dogrucevap"].ToString())
                    {
                        if (asamasayaci == 1 || asamasayaci == 5)
                        {
                            btn_paratablosu[asamasayaci - 1].BackColor = Color.Orange;
                        }
                        else
                        {
                            btn_paratablosu[asamasayaci - 1].BackColor = Color.Green;
                        }
                        sorusayaci++;
                        parasayaci++;
                        asamasayaci++;
                        sayac = 59;
                        btn_aasikki.Enabled = true;
                        btn_aasikki.BackColor = Color.Blue;
                        btn_bbsikki.Enabled = true;
                        btn_bbsikki.BackColor = Color.Blue;
                        btn_ccsikki.Enabled = true;
                        btn_ccsikki.BackColor = Color.Blue;
                        btn_ddsikki.Enabled = true;
                        btn_ddsikki.BackColor = Color.Blue;
                        sorular();
                    }
                    else
                    {
                        cevap();
                    }
                }
            }
            else if (MessageBox.Show("Son Kararınız mı?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (siradaki[0].Text == dtp_soru.Rows[rastgelesoru]["dogrucevap"].ToString())
                {
                    if (asamasayaci == 1 || asamasayaci == 5)
                    {
                        btn_paratablosu[asamasayaci - 1].BackColor = Color.Orange;
                    }
                    else
                    {
                        btn_paratablosu[asamasayaci - 1].BackColor = Color.Green;
                    }
                    sorusayaci++;
                    parasayaci++;
                    asamasayaci++;
                    sayac = 59;
                    sorular();
                }
                else
                {
                    cevap();
                }
            }
        }
        public void sorular()
        {
            if (asamasayaci == 11)
            {
                if (MessageBox.Show("Tebrikler 1000000 TL Kazandınız Tekrar Oynamak İstermisiniz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                    frm_ana ana = new frm_ana();
                    ana.Show();
                }
                else
                {
                    this.Close();
                    frm_ana ana = new frm_ana();
                    ana.Show();
                }
            }
            tmr_zaman.Stop();
            btn_aasikki.Enabled = true;
            btn_bbsikki.Enabled = true;
            btn_ccsikki.Enabled = true;
            btn_ddsikki.Enabled = true;
            lbl_asikki.Visible = true;
            lbl_bsikki.Visible = true;
            lbl_csikki.Visible = true;
            lbl_dsikki.Visible = true;
            btn_aasikki.Visible = true;
            btn_bbsikki.Visible = true;
            btn_ccsikki.Visible = true;
            btn_ddsikki.Visible = true;
            lbl_cevaplar.Add(lbl_asikki);
            lbl_cevaplar.Add(lbl_bsikki);
            lbl_cevaplar.Add(lbl_csikki);
            lbl_cevaplar.Add(lbl_dsikki);
            lbl_asama.Text = sorusayaci.ToString() + ".Soru";
            lbl_para.Text = "Soru Değeri= " + paralar[parasayaci] + " TL";
            cnt_baglanti.Open();   
            adp_soru = new OleDbDataAdapter("select * from soru" + asamasayaci.ToString(), cnt_baglanti);
            dtp_soru = new DataTable();
            adp_soru.Fill(dtp_soru);
            veriSayisi = dtp_soru.Rows.Count;
            rastgelesoru = rnd.Next(1, veriSayisi);
            lbl_soru.Text = dtp_soru.Rows[rastgelesoru]["soru"].ToString();
            int rastgelecevap = rnd.Next(0, 4);
            lbl_cevaplar[rastgelecevap].Text = dtp_soru.Rows[rastgelesoru]["dogrucevap"].ToString();
            lbl_cevaplar.RemoveAt(rastgelecevap);
            int rastgelecevap1 = rnd.Next(0, 3);
            lbl_cevaplar[rastgelecevap1].Text = dtp_soru.Rows[rastgelesoru]["yanliscevap1"].ToString();
            lbl_cevaplar.RemoveAt(rastgelecevap1);
            int rastgelecevap2 = rnd.Next(0, 2);
            lbl_cevaplar[rastgelecevap2].Text = dtp_soru.Rows[rastgelesoru]["yanliscevap2"].ToString();
            lbl_cevaplar.RemoveAt(rastgelecevap2);
            lbl_cevaplar[0].Text = dtp_soru.Rows[rastgelesoru]["yanliscevap3"].ToString();
            lbl_cevaplar.RemoveAt(0);
            if (asamasayaci == 6)
            {
                int muzikNumarasi = Convert.ToInt32(dtp_soru.Rows[rastgelesoru]["soruNo"].ToString());
                axWindowsMediaPlayer1.URL = "muzikler\\" + muzikNumarasi.ToString() + ".mp3";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                tmr_muzik.Start();
            }
            else
            {
                tmr_zaman.Start();
            }
            cnt_baglanti.Close();
        }
        public void cevap()
        {
            if (lbl_asama.Text == "1.Soru")
            {
                tmr_zaman.Stop();
                if (MessageBox.Show("Malesef Cevabınız Yanlıştır Tekrar Oynamak İstermisiniz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                    frm_ana ana = new frm_ana();
                    ana.Show();
                }
                else
                {
                    this.Close();
                    frm_ana ana = new frm_ana();
                    ana.Show();
                }
            }
            if (lbl_asama.Text == "2.Soru" || lbl_asama.Text == "3.Soru" || lbl_asama.Text == "4.Soru" || lbl_asama.Text == "5.Soru")
            {
                tmr_zaman.Stop();
                if (MessageBox.Show("Malesef Cevabınız Yanlıştır Tebrikler 2500 TL Kazandınız.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                    frm_ana ana = new frm_ana();
                    ana.Show();
                }
                else
                {
                    this.Close();
                    frm_ana ana = new frm_ana();
                    ana.Show();
                }
            }
            if (lbl_asama.Text == "6.Soru" || lbl_asama.Text == "7.Soru" || lbl_asama.Text == "8.Soru" || lbl_asama.Text == "9.Soru" || lbl_asama.Text == "10.Soru")
            {
                tmr_zaman.Stop();
                if (MessageBox.Show("Malesef Cevabınız Yanlıştır Tebrikler 30000 TL Kazandınız.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                    frm_ana ana = new frm_ana();
                    ana.Show();
                }
                else
                {
                    this.Close();
                    frm_ana ana = new frm_ana();
                    ana.Show();
                }
            }
        }

        private void tmr_zaman_Tick(object sender, EventArgs e)
        {
            lbl_sure.Text = sayac.ToString();
            progressBar1.Value = sayac;
            if (progressBar1.Value >= 25 && progressBar1.Value < 40)
            {
                progressBar1.ForeColor = Color.Yellow;
            }
            else if (progressBar1.Value < 25 && progressBar1.Value > 10)
            {
                progressBar1.ForeColor = Color.Orange;
            }
            else if (progressBar1.Value <= 10)
            {
                progressBar1.ForeColor = Color.Red;
            }
            else
            {
                progressBar1.ForeColor = Color.Green;
            }
            sayac--;
            if (lbl_sure.Text == "0" && lbl_asama.Text == "1.Soru")
            {
                tmr_zaman.Stop();
                if (MessageBox.Show("Süreniz Dolmuştur Malesef 0 TL Kazandınız.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                    frm_ana ana = new frm_ana();
                    ana.Show();
                }
                else
                {
                    this.Close();
                    frm_ana ana = new frm_ana();
                    ana.Show();
                }
            }
            if (lbl_sure.Text == "0" && (lbl_asama.Text == "2.Soru" || lbl_asama.Text == "3.Soru" || lbl_asama.Text == "4.Soru" || lbl_asama.Text == "5.Soru"))
            {
                tmr_zaman.Stop();
                if (MessageBox.Show("Süreniz Dolmuştur Tebrikler 2500 TL Kazandınız Yeniden Oynamak İstermisiniz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                    frm_ana ana = new frm_ana();
                    ana.Show();
                }
                else
                {
                    this.Close();
                    frm_ana ana = new frm_ana();
                    ana.Show();
                }
            }
            if (lbl_sure.Text == "0" && (lbl_asama.Text == "6.Soru" || lbl_asama.Text == "7.Soru" || lbl_asama.Text == "8.Soru" || lbl_asama.Text == "9.Soru" || lbl_asama.Text == "10.Soru"))
            {
                tmr_zaman.Stop();
                if (MessageBox.Show("Süreniz Dolmuştur Tebrikler 30000 TL Kazandınız Yeniden Oynamak İstermisiniz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                    frm_ana ana = new frm_ana();
                    ana.Show();
                }
                else
                {
                    this.Close();
                    frm_ana ana = new frm_ana();
                    ana.Show();
                }
            }

        }

        private void btn_aasikki_Click(object sender, EventArgs e)
        {
            ciftcevapKontrol = 1;
            siradaki.Clear();
            siradaki.Add(lbl_asikki);
            cevapp();
        }
        private void btn_bbsikki_Click(object sender, EventArgs e)
        {
            ciftcevapKontrol = 2;
            siradaki.Clear();
            siradaki.Add(lbl_bsikki);
            cevapp();
        }

        private void btn_ccsikki_Click(object sender, EventArgs e)
        {
            ciftcevapKontrol = 3;
            siradaki.Clear();
            siradaki.Add(lbl_csikki);
            cevapp();
        }

        private void btn_ddsikki_Click(object sender, EventArgs e)
        {
            ciftcevapKontrol = 4;
            siradaki.Clear();
            siradaki.Add(lbl_dsikki);
            cevapp();
        }

        private void pct_yariyariya_Click(object sender, EventArgs e)
        {
            yariyariya++;
            if (lbl_asikki.Text == dtp_soru.Rows[rastgelesoru]["yanliscevap1"].ToString() || lbl_asikki.Text == dtp_soru.Rows[rastgelesoru]["yanliscevap2"].ToString())
            {
                btn_aasikki.Visible = false;
                lbl_asikki.Visible = false;
            }
            if (lbl_bsikki.Text == dtp_soru.Rows[rastgelesoru]["yanliscevap2"].ToString() || lbl_bsikki.Text == dtp_soru.Rows[rastgelesoru]["yanliscevap1"].ToString())
            {
                btn_bbsikki.Visible = false;
                lbl_bsikki.Visible = false;
            }
            if (lbl_csikki.Text == dtp_soru.Rows[rastgelesoru]["yanliscevap1"].ToString() || lbl_csikki.Text == dtp_soru.Rows[rastgelesoru]["yanliscevap2"].ToString())
            {
                btn_ccsikki.Visible = false;
                lbl_csikki.Visible = false;
            }
            if (lbl_dsikki.Text == dtp_soru.Rows[rastgelesoru]["yanliscevap1"].ToString() || lbl_dsikki.Text == dtp_soru.Rows[rastgelesoru]["yanliscevap2"].ToString())
            {
                btn_ddsikki.Visible = false;
                lbl_dsikki.Visible = false;
            }
            pct_yariyariya.Visible = false;
        }

        private void pct_ciftcevap_Click(object sender, EventArgs e)
        {
            pct_ciftcevap.Visible = false;
            if (yariyariya == 1)
            {
                if (asamasayaci == 1 || asamasayaci == 5)
                {
                    btn_paratablosu[asamasayaci - 1].BackColor = Color.Orange;
                }
                else
                {
                    btn_paratablosu[asamasayaci - 1].BackColor = Color.Green;
                }
                sorusayaci++;
                parasayaci++;
                asamasayaci++;
                sayac = 59;
                sorular();
            }
            else
            {
                ciftcevap++;
            }

        }

        private void pct_sorudegistir_Click(object sender, EventArgs e)
        {
            sayac = 59;
            sorular();
            pct_sorudegistir.Visible = false;
        }

        private void btn_cekil_Click(object sender, EventArgs e)
        {
            if (lbl_asama.Text == "1.Soru")
            {
                if (MessageBox.Show("Son Kararınız mı?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Malesef 0 TL Kazandınız Yeniden Oynamak İstermisiniz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.Close();
                        frm_ana ana = new frm_ana();
                        ana.Show();
                    }
                    else
                    {
                        this.Close();
                        frm_ana ana = new frm_ana();
                        ana.Show();
                    }
                }
            }
            if (lbl_asama.Text == "2.Soru" || lbl_asama.Text == "3.Soru" || lbl_asama.Text == "4.Soru" || lbl_asama.Text == "5.Soru")
            {
                if (MessageBox.Show("Son Kararınız mı?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Tebirkler 2500 TL Kazandınız Yeniden Oynamak İstermisiniz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.Close();
                        frm_ana ana = new frm_ana();
                        ana.Show();
                    }
                    else
                    {
                        this.Close();
                        frm_ana ana = new frm_ana();
                        ana.Show();
                    }
                }
            }
            if (lbl_asama.Text == "6.Soru")
            {
                if (MessageBox.Show("Son Kararınız mı?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Tebirkler 30000 TL Kazandınız Yeniden Oynamak İstermisiniz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.Close();
                        frm_ana ana = new frm_ana();
                        ana.Show();
                    }
                    else
                    {
                        this.Close();
                        frm_ana ana = new frm_ana();
                        ana.Show();
                    }
                }
            }
            if (lbl_asama.Text == "7.Soru")
            {
                if (MessageBox.Show("Son Kararınız mı?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Tebirkler 60000 TL Kazandınız Yeniden Oynamak İstermisiniz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.Close();
                        frm_ana ana = new frm_ana();
                        ana.Show();
                    }
                    else
                    {
                        this.Close();
                        frm_ana ana = new frm_ana();
                        ana.Show();
                    }
                }
            }
            if (lbl_asama.Text == "8.Soru")
            {
                if (MessageBox.Show("Son Kararınız mı?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Tebirkler 120000 TL Kazandınız Yeniden Oynamak İstermisiniz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.Close();
                        frm_ana ana = new frm_ana();
                        ana.Show();
                    }
                    else
                    {
                        this.Close();
                        frm_ana ana = new frm_ana();
                        ana.Show();
                    }
                }
            }
            if (lbl_asama.Text == "9.Soru")
            {
                if (MessageBox.Show("Son Kararınız mı?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Tebirkler 250000 TL Kazandınız Yeniden Oynamak İstermisiniz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.Close();
                        frm_ana ana = new frm_ana();
                        ana.Show();
                    }
                    else
                    {
                        this.Close();
                        frm_ana ana = new frm_ana();
                        ana.Show();
                    }
                }
            }
            if (lbl_asama.Text == "10.Soru")
            {
                if (MessageBox.Show("Son Kararınız mı?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Tebirkler 500000 TL Kazandınız Yeniden Oynamak İstermisiniz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.Close();
                        frm_ana ana = new frm_ana();
                        ana.Show();
                    }
                    else
                    {
                        this.Close();
                        frm_ana ana = new frm_ana();
                        ana.Show();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
            frm_ana ana = new frm_ana();
            ana.Show();
        }

        private void tmr_muzik_Tick(object sender, EventArgs e)
        {
            muziksayaci++;
            if (asamasayaci != 6)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            else
            {
                if (muziksayaci == 30)
                {
                    tmr_zaman.Start();
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    tmr_muzik.Stop();
                }
                else
                {
                    lbl_sure.Text = "60";
                    progressBar1.Value = 60;
                    progressBar1.ForeColor = Color.Green;
                }
            }
        }

        private void frm_oyun_Load(object sender, EventArgs e)
        {
            btn_soru1.Enabled = false;
            btn_soru2.Enabled = false;
            btn_soru3.Enabled = false;
            btn_soru4.Enabled = false;
            btn_soru5.Enabled = false;
            btn_soru6.Enabled = false;
            btn_soru7.Enabled = false;
            btn_soru8.Enabled = false;
            btn_soru9.Enabled = false;
            btn_soru10.Enabled = false;
            progressBar1.ForeColor = Color.Green;
            progressBar1.Value = 60;
            lbl_para.Visible = false;
            btn_paratablosu.Add(btn_soru1);
            btn_paratablosu.Add(btn_soru2);
            btn_paratablosu.Add(btn_soru3);
            btn_paratablosu.Add(btn_soru4);
            btn_paratablosu.Add(btn_soru5);
            btn_paratablosu.Add(btn_soru6);
            btn_paratablosu.Add(btn_soru7);
            btn_paratablosu.Add(btn_soru8);
            btn_paratablosu.Add(btn_soru9);
            btn_paratablosu.Add(btn_soru10);
            pct_yariyariya.ImageLocation = "50.png";
            pct_ciftcevap.ImageLocation = "ciftCevap.png";
            pct_sorudegistir.ImageLocation = "download.jpg";
            pictureBox1.ImageLocation = "resim.png";
            lbl_cevaplar.Add(lbl_asikki);
            lbl_cevaplar.Add(lbl_bsikki);
            lbl_cevaplar.Add(lbl_csikki);
            lbl_cevaplar.Add(lbl_dsikki);
            btn_cevaplar.Add(btn_aasikki);
            btn_cevaplar.Add(btn_bbsikki);
            btn_cevaplar.Add(btn_ccsikki);
            btn_cevaplar.Add(btn_ddsikki);
            sorular();
        }
    }
}
