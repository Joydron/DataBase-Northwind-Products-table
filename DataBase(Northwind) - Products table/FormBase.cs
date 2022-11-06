using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Northwind____Products_table
{
    public partial class ProductsTable : Form
    {
        private SqlConnection nrthwndConnection = null;

        public ProductsTable()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Подключаем БД
            nrthwndConnection = new SqlConnection
                (ConfigurationManager.ConnectionStrings["NorthWindDB"].ConnectionString);
            nrthwndConnection.Open();

            // Выбираем все данные из Products
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Products", nrthwndConnection);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView_Base.DataSource = db.Tables[0];

            // Создаем checkBox для dataGridView_Base
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn() 
                { HeaderText = "Выбрать", 
                  Name = "checkBox" };
            dataGridView_Base.Columns.Insert(0, chkbox);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Создаем быстрый поиск продуктов
            (dataGridView_Base.DataSource as DataTable).DefaultView.RowFilter = $"ProductName LIKE '%{txtSearch.Text}%'";
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Сохранение данных

            TextWriter data = new StreamWriter(@"D:\\text file.txt");
            int rowcount = dataGridView_Add.Rows.Count-1;

            // Цикл для сохранения строки
            for (int i = 0; i < rowcount; i++)
            {
                // Цикл для сохранения ячеек (без столбца true)
                for (int j = 1 ; j < 9; j++)
                {
                    data.Write(dataGridView_Add.Rows[i].Cells[j].Value.ToString() + "\n");
                }
                data.Write("\n");

            }
            data.Close();
            MessageBox.Show("Сохранено на диск D");

        }

        // Добавляем выбранные файлы из таблицы и добавляем наименования колонн из 1-ой таблицы 

        private void btnAdd_Click(object sender, EventArgs e)
        {

            DataTable dataTable = new DataTable();

            // Добавляем цикл для названий колонн
            foreach (DataGridViewColumn column in dataGridView_Base.Columns)
            {
                dataTable.Columns.Add(column.Name);
            }

            // Проверка на checkBox
            foreach (DataGridViewRow drvRow in dataGridView_Base.Rows)
            {
                bool chkboxselect = Convert.ToBoolean(drvRow.Cells["checkBox"].Value);
                if (chkboxselect)
                {
                    DataRow dataRow = dataTable.NewRow();  
                    
                    for (int i = 0; i <= 9; i++)
                    {
                        dataRow[i] = drvRow.Cells[i].Value;
                    }
                    dataTable.Rows.Add(dataRow);
                }
                dataGridView_Add.DataSource = dataTable;
            }
        }
    }

}
