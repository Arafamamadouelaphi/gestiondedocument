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
    public partial class text : Form
    {
        public text()
        {
            InitializeComponent();
        }SqlDataReader dr;
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RCCFLSL\SQLEXPRESS;Initial Catalog=stage;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" )
            {
                MessageBox.Show("entrer le nom  et  mot de passe");
            }
            else
            {
                SqlCommand c = new SqlCommand();
                c.Connection = cnx;
                c.CommandText = "select  matriculefinance  from matriculefinance";
                dr = c.ExecuteReader();
                bool exists;

                while (dr.Read())
                {

                    if (textBox1.Text == dr[0].ToString() )
                    {
                        exists = true;
                        MessageBox.Show("mdp valide");
                       
                    }

                    else
                    {
                        exists = false;
                    }

                    if (exists == false)
                    {
                        MessageBox.Show("seul les memebre du service financier ou les admins qui  peuvent ajouter modifier ou supprimer un dossier ......");
                    }

                }
                dr.Close();
            }
        }

        private void text_Load(object sender, EventArgs e)
        {
            cnx.Open();
            
        }
    }
}

