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
    public partial class ADMINITPE : Form
    {
        public ADMINITPE()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RCCFLSL\SQLEXPRESS;Initial Catalog=stage;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("entrer le mot de passe d un administrateur");
            }
            
            else if (textBox2.Text == "arafa")
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
    }
}
