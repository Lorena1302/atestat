using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace agenda_electronica_atestat
{
    public partial class Form1 : Form
    {
        public static MySqlConnection conn;
        public Form1()
        {
            conn = new MySqlConnection("Data Source = localhost; UserId =root;PWD='';");
            conn.Open();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ///aici este stocata data
            int zi, an;
            string data,luna;
            data = monthCalendar1.SelectionRange.Start.ToShortDateString();
            ///caut eventul in baza de date 

            string comanda = "select * from text";
            MySqlDataAdapter da = new MySqlDataAdapter(comanda, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            
        }

        
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            string s;
            MySqlCommand cmd;
         
            /// LUNA  ZI ORA EVENIMENT important
           /// MAI 15                  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string data;
            
            
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
