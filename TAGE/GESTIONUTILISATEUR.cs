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
    public partial class GESTIONUTILISATEUR : Form
    {
        public GESTIONUTILISATEUR()
        {
            InitializeComponent();
        }
        int cle = 0;
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RCCFLSL\SQLEXPRESS;Initial Catalog=stage;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("completez les informations sulvouplait!!!");

            }
                      else
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnx;
                    cmd.CommandText = "insert into utilisateur values(" + int.Parse(textBox2.Text) + "," + int.Parse(textBox5.Text) + ", '" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ajout réussi");


                affii();
                reii();
                cnx.Close();

            }
            }
        

        private void GESTIONUTILISATEUR_Load(object sender, EventArgs e)
        {
            cnx.Open();
            affii();
        }
        public void reii()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
           textBox6.Text = "";
            

        }
        public void affii()
        {


            SqlCommand c = new SqlCommand();
            c.Connection = cnx;
            c.CommandText = "select *from utilisateur";
            SqlDataReader dr = c.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            dr.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["idutilisateur"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["nom"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["prenom"].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["telephone"].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["responsabilité"].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idutilisateur = (int)dataGridView1.CurrentRow.Cells[0].Value;
            SqlCommand c = new SqlCommand();
            c.Connection = cnx;
            c.CommandText = "update utilisateur set telephone=" +textBox5.Text + ",nom='" + textBox3.Text + "',prenom='" + textBox4.Text + "',responsabilité='" + textBox6.Text + "' where idutilisateur=" + idutilisateur + "";
            c.ExecuteNonQuery();
            MessageBox.Show("modification réussi");
            affii();
            reii();
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idutilisateur = (int)dataGridView1.CurrentRow.Cells[0].Value;
            SqlCommand c = new SqlCommand();
            c.Connection = cnx;
            c.CommandText = "delete from  utilisateur where idutilisateur=" + idutilisateur + "";
            c.ExecuteNonQuery();
            MessageBox.Show("sup réussi");
            affii();
            reii();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            affii();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            GESTIONDESADMINISTRATEURS a = new GESTIONDESADMINISTRATEURS();
            a.ShowDialog();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GESTIONDESADMINISTRATEURS ag = new GESTIONDESADMINISTRATEURS();
            ag.ShowDialog();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            document ag = new document();
            ag.ShowDialog();
            this.Hide();
        }
    }
}
