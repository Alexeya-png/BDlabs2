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
    public partial class createTimeTable : Form
    {
        db db = new db();

        public createTimeTable()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Import] (Id_plants, Id_country, datePlants) VALUES (@plants, @country, @date)", db.GetConnection());
            command.Parameters.Add("@plants", SqlDbType.VarChar).Value = comboBox1.SelectedValue.ToString();
            command.Parameters.Add("@country", SqlDbType.VarChar).Value = comboBox2.SelectedValue.ToString();
            command.Parameters.Add("@date", SqlDbType.VarChar).Value = monthCalendar1.TodayDate.ToString();

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Партію додано");
            }
            else
            {
                MessageBox.Show("Помилка");
            }
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void createTimeTable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "plantsDataSet.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.plantsDataSet.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "plantsDataSet.Plants". При необходимости она может быть перемещена или удалена.
            this.plantsTableAdapter.Fill(this.plantsDataSet.Plants);

        }
    }
}
