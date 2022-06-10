using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace guest_app
{
    public partial class Form1 : Form
    {
        List<Customer_node> list;

        public Form1()
        {
            InitializeComponent();
        }
        public void setOnIndex(int index, Customer_node item = null)
        {
            if (item == null)
            {
                SQLiteConnection sqlConnection = null;
                try
                {
                    string connectionString = ConnectionString.SqliteString();
                    sqlConnection = new SQLiteConnection(connectionString);
                    sqlConnection.Open();

                    SQLiteCommand command = new SQLiteCommand(
                            $"DELETE FROM [visits] " +
                            $"WHERE customer_id = @id; " +
                            $"DELETE FROM [customers] " +
                            $"WHERE id = @id; "
                            , sqlConnection);
                    command.Parameters.AddWithValue("@id", $"{list[index].id}");

                    command.ExecuteNonQuery();

                    list.RemoveAt(index);
                    customers_table.Rows.RemoveAt(index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                        sqlConnection.Close();
                }
                return;
            }
            if (index == -1)
            {
                if (list == null)
                {
                    list = new List<Customer_node>();
                }
                index = customers_table.Rows.Add();
                Customer_node temp = new Customer_node();
                list.Add(temp);
            }
            list[index].id = item.id;
            customers_table.Rows[index].Cells["name"].Value = list[index].name = item.name;
            customers_table.Rows[index].Cells["phone"].Value = list[index].phone = item.phone;
            customers_table.Rows[index].Cells["comment"].Value = list[index].comment = item.comment;

        }
        private void load_table(string filterType = "", string filter = "")
        {
            SQLiteConnection sqlConnection = null;
            SQLiteDataReader sqlReader = null;
            list = new List<Customer_node>();

            customers_table.Rows.Clear();

            try
            {

                string connectionString = ConnectionString.SqliteString();
                sqlConnection = new SQLiteConnection(connectionString);
                sqlConnection.Open();

                SQLiteCommand command = null;

                if (filterType != "date")
                {
                    command = new SQLiteCommand(
                        $"SELECT Id AS ident,name,phone,comment AS comm " +
                        $"FROM [customers] " +
                        $"WHERE({filterType} LIKE @filter) "
                        , sqlConnection);
                    command.Parameters.AddWithValue("@filter", $"%{filter}%");
                }
                else
                {
                    command = new SQLiteCommand(

                        $"SELECT customers.Id ident, name, phone, customers.comment comm " +
                        $"FROM[customers] " +
                        $"JOIN[visits] ON customers.Id = visits.customer_id " +
                        $"WHERE coming LIKE @filter " +
                        $"GROUP BY customers.Id, name, phone, customers.comment "
                        , sqlConnection);

                    command.Parameters.AddWithValue("@filter", $"%{DateTime.Parse(filter.Split(' ')[0]).ToString("yyyy-MM-dd")}%");

                }

                sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {

                    Customer_node temp = new Customer_node();

                    temp.id = Convert.ToInt32(sqlReader["ident"]);
                    temp.name = Convert.ToString(sqlReader["name"]).Trim();
                    temp.phone = Convert.ToString(sqlReader["phone"]).Trim();
                    temp.comment = Convert.ToString(sqlReader["comm"]).Trim();

                    int index = customers_table.Rows.Add();
                    customers_table.Rows[index].Cells["name"].Value = temp.name;
                    customers_table.Rows[index].Cells["phone"].Value = temp.phone;
                    customers_table.Rows[index].Cells["comment"].Value = temp.comment;

                    list.Add(temp);
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
                bool flag = list.Count > 0;
                customers_table.Visible = flag;
                not_found_label.Visible = !flag;
            }
        }

        private void phone_search_button_Click(object sender, EventArgs e)
        {
            load_table("phone", phone_search_input.Text);
        }

        private void name_search_button_Click(object sender, EventArgs e)
        {
            load_table("name", name_search_input.Text);
        }

        private void date_search_button_Click(object sender, EventArgs e)
        {
            load_table("date", Convert.ToString(date_search_input.Value));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customers_table.Rows.Clear();
            date_search_input.MaxDate = DateTime.Today.AddDays(1);
            date_search_input.Value = DateTime.Today;
        }

        private void createEnrty_Click(object sender, EventArgs e)
        {
            CurrentForms.customer = new Customer(this);
            CurrentForms.customer.Show();
            CurrentForms.form1.Hide();
        }

        private void textBox_textChanged50(object sender, EventArgs e)
        {
            try
            {
                TextBox tb = (TextBox)sender;

                if (tb.TextLength > 50)
                    tb.Text = tb.Text.Substring(0, 50);
            }
            catch (Exception) { }

        }

        private void aboutToolStripItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Roninore@github.com\nНикита", "О разработчиках", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void customers_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            CurrentForms.customer = new Customer(this, e.RowIndex, list[e.RowIndex]);
            CurrentForms.customer.Show();
            CurrentForms.form1.Hide();
        }

        private void deleteEntry_Click(object sender, EventArgs e)
        {
            int index = customers_table.CurrentRow.Index;
            if (!customers_table.Visible || index == -1)
                return;
            setOnIndex(index, null);
        }

        private void посмотретьПолнуюИнформацюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentForms.table = new TotalTable();
            CurrentForms.table.Show();
            CurrentForms.form1.Hide();
        }

        private void phone_search_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                load_table("phone", phone_search_input.Text);
            }
            if (e.KeyChar != Convert.ToChar(Keys.Back) && tb.TextLength > 49)
                e.Handled = true;
        }

        private void name_search_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                load_table("name", name_search_input.Text);
            }
            if (e.KeyChar != Convert.ToChar(Keys.Back) && tb.TextLength > 49)
                e.Handled = true;
        }
    }
}
