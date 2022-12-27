using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BDlabs
{
    public partial class createPlant : Form
    {
        db db = new db();

        public createPlant()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlCommand command = new SqlCommand("INSERT INTO [Plants] (plantName, class, color, price) VALUES (@name, @class, @color, @price)", db.GetConnection());
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@class", SqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@color", SqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@price", SqlDbType.VarChar).Value = textBox2.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Рослину записано");
            }
            else
            {
                MessageBox.Show("Помилка");
            }
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 enter = new Form1();
            enter.Show();
            Hide();
        }
    }
}
