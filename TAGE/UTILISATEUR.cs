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
    public partial class UTILISATEUR : Form
    {
        public UTILISATEUR()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RCCFLSL\SQLEXPRESS;Initial Catalog=stage;Integrated Security=True");

        SqlDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("entrer le nom  et  mot de passe");
            }
            else
            {
                SqlCommand c = new SqlCommand();
                c.Connection = cnx;
                c.CommandText = "select  IDUTILISATEUR , nom from utilisateur";
                dr = c.ExecuteReader();
                bool exists;

                while (dr.Read())
                {

                    if (textBox1.Text == dr[0].ToString() && textBox2.Text == dr[1].ToString())
                    {
                        exists = true;
                        MessageBox.Show("mdp valide");
                        document t = new document();
                        t.ShowDialog();
                        this.Hide();
                        break;
                    }

                    else
                    {
                        exists = false;
                    }

                    if (exists == false)
                    {
                        MessageBox.Show("verification ......");
                    }

                }
                dr.Close();
            }
        }

        private void UTILISATEUR_Load(object sender, EventArgs e)
        {
            cnx.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
