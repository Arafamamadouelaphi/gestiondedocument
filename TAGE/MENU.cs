﻿using System;
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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RCCFLSL\SQLEXPRESS;Initial Catalog=stage;Integrated Security=True");

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADMINENTREPRISE a = new ADMINENTREPRISE();
            a.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            document d = new document();
            d.ShowDialog();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CONTACT ag = new CONTACT();
            ag.ShowDialog();
            this.Hide();
        }
    }
}
