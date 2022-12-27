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
    public partial class Form1 : Form
    {
        db db = new db();
        public Form1()
        {
            InitializeComponent();
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();
                SqlDataAdapter oda = new SqlDataAdapter("select * from plants", db.GetConnection());
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void списокЕдыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();
                SqlDataAdapter oda = new SqlDataAdapter("Select plantName, nameCountry, price, datePlants from Plants\r\ninner join Import on Plants.Id_plants = Import.Id_plants\r\ninner join Country on Import.Id_country = Country.Id_counrty", db.GetConnection());
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void создатьЕдуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            createPlant enter = new createPlant();
            enter.Show();
            Hide();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                db db = new db();
                SqlCommand command = new SqlCommand("Delete Plants WHERE [Id_plants] = @int", db.GetConnection());
                command.Parameters.Add("@int", SqlDbType.VarChar).Value = comboBox1.SelectedValue.ToString();

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Рослина видалена");
                }
                else
                {
                    MessageBox.Show("Рослина видалена!");
                }

                db.closeConnection();
            }
            catch
            {

            }
            
        }

        private void создатьРасписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createTimeTable enter = new createTimeTable();
            enter.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "plantsDataSet.Plants". При необходимости она может быть перемещена или удалена.
            this.plantsTableAdapter.Fill(this.plantsDataSet.Plants);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdlabsDataSet1.Food". При необходимости она может быть перемещена или удалена.

        }

        private void searchButt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(searchbox.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void просмотрДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TestInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestInput.Clear();
            TestInput.Text = "SELECT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();
                SqlDataAdapter oda = new SqlDataAdapter(TestInput.Text, db.GetConnection());
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }
    }
}
