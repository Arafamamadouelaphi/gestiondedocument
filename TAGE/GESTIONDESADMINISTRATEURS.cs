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
    public partial class GESTIONDESADMINISTRATEURS : Form
    {
        public GESTIONDESADMINISTRATEURS()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RCCFLSL\SQLEXPRESS;Initial Catalog=stage;Integrated Security=True");
             

        private void button4_Click(object sender, EventArgs e)
        {
            affii();        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == ""  || textBox3.Text == "" || dateTimePicker1.Text == "" || textBox4.Text == "" )
            {
                MessageBox.Show("completez les informations sulvouplait!!!");

            }
            else
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "insert into adminentreprise values(" + int.Parse(textBox2.Text) + ",'" + textBox3.Text + "','" + DateTime.Parse(dateTimePicker1.Text) + "', " + int.Parse(textBox4.Text) + ")";
                cmd.ExecuteNonQuery();
                MessageBox.Show("ajout réussi");


                affii();
                reii();
               

            }
        }
        public void reii()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Text = "";
            textBox4.Text = "";
           


        }
        public void affii()
        {


            SqlCommand c = new SqlCommand();
            c.Connection = cnx;
            c.CommandText = "select *from adminentreprise";
            SqlDataReader dr = c.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            dr.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["idutilisateur"].Value.ToString();
            dateTimePicker1.Text= dataGridView1.Rows[e.RowIndex].Cells["idutilisateur"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["nom"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["prenom"].Value.ToString();
            
        }

        private void GESTIONDESADMINISTRATEURS_Load(object sender, EventArgs e)
        {
            cnx.Open();
            affii();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = (int)dataGridView1.CurrentRow.Cells[0].Value;
            SqlCommand c = new SqlCommand();
            c.Connection = cnx;
            c.CommandText = "delete from  adminentreprise where numcompte=" + num + "";
            c.ExecuteNonQuery();
            MessageBox.Show("sup réussi");
            affii();
            reii();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = (int)dataGridView1.CurrentRow.Cells[0].Value;
            SqlCommand c = new SqlCommand();
            c.Connection = cnx;
            c.CommandText = "update adminentreprise set nomcompte='" + textBox3.Text + "',datenaissance='" + DateTime.Parse(dateTimePicker1.Text) + "',telephone=" + textBox4.Text + " where numcompte=" + num + "";
            c.ExecuteNonQuery();
            MessageBox.Show("modification réussi");
            affii();
            reii();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ADMINITPE O = new ADMINITPE();
            O.ShowDialog();
            this.Hide();
        }
    }
}
