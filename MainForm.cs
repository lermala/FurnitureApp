using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bogus;


namespace FurnitureApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "furniture_kolDataSet.select_contract". При необходимости она может быть перемещена или удалена.
            this.select_contractTableAdapter.Fill(this.furniture_kolDataSet.select_contract);

            // GeneratorClass.GenerateCustomers(5);
            //GeneratorClass.GenerateManufacturers(3);
            GeneratorClass.GenerateModels(5);

        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            // код для обратного размещения сделанных изменений в БД:
            //sqlDataAdapter1.Update(furniture_kolDataSet);
        }

        // добавить
        private void Button1_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            sqlInsertCommand1.Parameters["@ID_customer"].Value = 1;
           // sqlInsertCommand1.Parameters["@date_of_issue"].Value = maskedTextBox1.Text;
            //sqlInsertCommand1.Parameters["@due_date"].Value = maskedTextBox1.Text;
            //sqlInsertCommand1.Parameters["@price"].Value = Convert.ToSingle(maskedTextBox2.Text);
            sqlInsertCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        // функция для нахождения текущей записи:
        public DataRow GetCurrentRow(DataGridView dg)
        {
            CurrencyManager cm = (CurrencyManager)dg.BindingContext[dg.DataSource, dg.DataMember];
            if (cm.Count == 0) { return null; }
            DataRowView drv = (DataRowView)cm.Current;
            return drv.Row;
        }

        // найти
        private void Button2_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView1);
            //maskedTextBox1.Text = row["date_of_issue"].ToString();
            //textBox2.Text = row["Price"].ToString();

        }

        // изменить
        private void Button3_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView1);
            int CurrentTourId = (int)row["ID_contract"];
            sqlConnection1.Open();
            //sqlUpdateCommand1.Parameters["@date_of_issue"].Value = maskedTextBox1.Text;
            //sqlUpdateCommand1.Parameters["@price"].Value = Convert.ToInt32(textBox2.Text);
            sqlUpdateCommand1.Parameters["@ID_contract"].Value = CurrentTourId;
            sqlUpdateCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        // удалить
        private void Button4_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView1);
            int CurrentTourId = (int)row["ID_contract"];
            sqlConnection1.Open();
            sqlDeleteCommand1.Parameters["@ID_contract"].Value = CurrentTourId;
            sqlDeleteCommand1.ExecuteNonQuery();
            sqlConnection1.Close();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
