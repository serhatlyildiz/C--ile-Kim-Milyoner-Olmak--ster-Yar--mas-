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
    public partial class frm_ana : Form
    {
        public frm_ana()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programı kapatmak üzeresiniz, çıkış yapmak istediğinize emin misiniz?","ÇIKIŞ",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frm_ana_Load(object sender, EventArgs e)
        {

        }

        private void btn_oyna_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_oyun oyun = new frm_oyun();
            oyun.Show();
            
        }

        private void btn_yoneticiGirisi_Click(object sender, EventArgs e)
        {
            frm_ygiris ygiris = new frm_ygiris();
            ygiris.Show();
        }
    }
}
