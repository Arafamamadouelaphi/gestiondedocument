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

namespace TAGE
{
    public partial class ADMINENTREPRISE : Form
    {
        public ADMINENTREPRISE()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RCCFLSL\SQLEXPRESS;Initial Catalog=stage;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("entrer le mot de passe d un administrateur");
            }
            
            else if (textBox1.Text == "adminENTREPRISE")
            {

                GESTIONUTILISATEUR ag = new GESTIONUTILISATEUR();
                ag.ShowDialog();
                this.Hide();

            }
            else
            {
                MessageBox.Show("contactez l 'administrateur");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ADMINITPE i = new ADMINITPE();
            i.ShowDialog();
            this.Hide();

        }
    }
}
