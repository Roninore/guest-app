using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Excel = Microsoft.Office.Interop.Excel;

namespace guest_app
{
    public partial class TotalTable : Form
    {
        public TotalTable()
        {
            InitializeComponent();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnection = null;
            SQLiteDataReader sqlReader = null;
            int room_cost = 0;
            int additional_cost = 0;
            room_cost_sum.Text = Convert.ToString(room_cost);
            additional_cost_sum.Text = Convert.ToString(additional_cost);
            total_sum.Text = Convert.ToString(room_cost + additional_cost);

            date_table.Rows.Clear();

            try
            {
                string connectionString = ConnectionString.SqliteString();
                sqlConnection = new SQLiteConnection(connectionString);
                sqlConnection.Open();

                SQLiteCommand command = new SQLiteCommand(
                    $"SELECT coming, departure,doc_type, room_type, room_cost, additional_cost, additional_type, name,phone " +
                    $"FROM[visits] " + 
                    $"JOIN[customers] ON visits.customer_id = customers.Id " +
                    $"WHERE visits.coming BETWEEN @first AND @second"
                        , sqlConnection);


                command.Parameters.AddWithValue("@first", first_input.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@second", second_input.Value.ToString("yyyy-MM-dd"));

                sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {

                    Visit_node temp = new Visit_node();

                    int index = date_table.Rows.Add();
                    
                    date_table.Rows[index].Cells["name"].Value = Convert.ToString(sqlReader["name"]).Trim();
                    date_table.Rows[index].Cells["phone"].Value = Convert.ToString(sqlReader["phone"]).Trim();
                    date_table.Rows[index].Cells["room_type"].Value = Convert.ToString(sqlReader["room_type"]).Trim();
                    date_table.Rows[index].Cells["room_cost"].Value = Convert.ToInt32(sqlReader["room_cost"]);
                    date_table.Rows[index].Cells["additional_cost"].Value = Convert.ToInt32(sqlReader["additional_cost"]);
                    date_table.Rows[index].Cells["additional_type"].Value = Convert.ToString(sqlReader["additional_type"]).Trim();
                    date_table.Rows[index].Cells["coming"].Value = temp.coming = DateTime.Parse(Convert.ToString(sqlReader["coming"])).ToString("dd.MM.yyyy");
                    date_table.Rows[index].Cells["departure"].Value = temp.departure = DateTime.Parse(Convert.ToString(sqlReader["departure"])).ToString("dd.MM.yyyy");

                    room_cost += Convert.ToInt32(sqlReader["room_cost"]);
                    additional_cost += Convert.ToInt32(sqlReader["additional_cost"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null) sqlReader.Close();
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                    sqlConnection.Close();
                room_cost_sum.Text = Convert.ToString(room_cost);
                additional_cost_sum.Text = Convert.ToString(additional_cost);
                total_sum.Text = Convert.ToString(room_cost + additional_cost);
                search_button.Enabled = false;
                convert_excel.Enabled = date_table.Rows.Count > 0;
            }
        }

        private void date_input_ValueChanged(object sender, EventArgs e)
        {
            search_button.Enabled = true;
        }

        private void TotalTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            CurrentForms.form1.Show();
            CurrentForms.table = null;
        }
        private void convert_excel_Click(object sender, EventArgs e)
        {
            Excel.Application app = null;
            Excel.Workbook workbook = null;
            try
            {
                int rows = date_table.Rows.Count;
                if (rows <= 0) throw new Exception("Невозможно создать отчет по пустым данным");

                app = new Excel.Application();
                workbook = app.Workbooks.Add(1);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                Excel.Range workSheet_range = null;

                object[] objHeaders = { "Заезд", "Выезд", "ФИО", "Телефон", "Номер", "Оплата номера", "Доп. покупки цена", "Доп. покупки" };
                workSheet_range = worksheet.get_Range("A1", "H1");
                workSheet_range.Value = objHeaders;
                Excel.Font m_objFont = workSheet_range.Font;
                m_objFont.Bold = true;

                int cols = date_table.Rows[0].Cells.Count;

                object[,] objData = new Object[rows, cols];
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        objData[r, c] = date_table.Rows[r].Cells[c].Value;
                    }
                }
                workSheet_range = worksheet.get_Range("A2", "H2");
                workSheet_range = workSheet_range.get_Resize(rows, cols);
                workSheet_range.Value = objData;
                workSheet_range.Columns.AutoFit();
                workSheet_range.Columns["F:H"].ColumnWidth = 20;
                workSheet_range.Columns.WrapText = true;
                workbook.SaveAs(System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile) + @"\Desktop\Отчет_" + ((DateTimeOffset)DateTime.Now).ToUnixTimeSeconds() + ".xlsx");
                workbook.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (app != null) app.Quit();
            }

        }
    }
}
