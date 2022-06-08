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
    public partial class SERVICEGESTION : Form
    {
        public SERVICEGESTION()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RCCFLSL\SQLEXPRESS;Initial Catalog=stage;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "GESTION123")
            {
                MessageBox.Show("attention");

            }
            if (textBox1.Text == "GESTION123")

            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "insert into gestion values('" + textBox2.Text + "','" + DateTime.Parse(dateTimePicker1.Text) + "', '" + textBox3.Text + "' ,'" + textBox4.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("ajout réussi");


                affii();


            }
        
    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SERVICEGESTION_Load(object sender, EventArgs e)
        {
            cnx.Open();
        }
        public void reii()
        {
            textBox2.Text = "";
            dateTimePicker1.Text = "";
            textBox3.Text = "";

            textBox4.Text = "";



        }
        public void affii()
        {


            SqlCommand c = new SqlCommand();
            c.Connection = cnx;
            c.CommandText = "select *from gestion";
            SqlDataReader dr = c.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            dr.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "GESTION123")
            {
                MessageBox.Show("attention");

            }
            if (textBox1.Text == "GESTION123")

            {
                String titre = (String)dataGridView1.CurrentRow.Cells[0].Value;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "update gestion set date='" + DateTime.Parse(dateTimePicker1.Text) + "',motif='" + textBox3.Text + "' ,service='" + textBox4.Text + "' where titre='" + titre + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("modification réussi");
                affii();
                reii();





            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "GESTION123")
            {
                MessageBox.Show("GESTION123");

            }
            if (textBox1.Text == "GESTION123")

            {
                String titre = (String)dataGridView1.CurrentRow.Cells[0].Value;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "delete from  gestion where titre='" + titre + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("suppression réussi");
                affii();
                reii();





            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            document d = new document();
            d.ShowDialog();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ADMINITPE i = new ADMINITPE();
            i.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GESTIONDESADMINISTRATEURS ag = new GESTIONDESADMINISTRATEURS();
            ag.Hide();
            this.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UTILISATEUR u = new UTILISATEUR();
            u.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
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
