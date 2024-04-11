using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MSS
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2FA3KGC;Initial Catalog=DBSECIMPROJE;Integrated Security=True");
        


        private void btnGiris_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE(ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values(@P1,@P2,@P3,@P4, @P5, @P6)", baglanti);

            komut.Parameters.AddWithValue("@P1", txtIlceAd.Text);
            komut.Parameters.AddWithValue("@P2", txtAparti.Text);
            komut.Parameters.AddWithValue("@P3", txtBparti.Text);
            komut.Parameters.AddWithValue("@P4", txtCparti.Text);
            komut.Parameters.AddWithValue("@P5", txtDparti.Text);
            komut.Parameters.AddWithValue("@P6", txtEparti.Text);
            

            komut.ExecuteNonQuery();
            MessageBox.Show("Veri Girişi Yapılmıştır");

            baglanti.Close();

        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmGrafikler = new FrmGrafikler();
            frmGrafikler.Show();
        }
    }
}
