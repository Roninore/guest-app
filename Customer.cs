using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace guest_app
{

    public partial class Customer : Form
    {
        Customer_node current;
        List<Visit_node> list;
        Form1 mainform;
        int indexOnSender;
        public Customer(Form1 sender, int index = -1, Customer_node item = null)
        {
            current = item;
            if (item == null)
                current = new Customer_node();

            mainform = sender;
            indexOnSender = index;
            InitializeComponent();

        }

        public void setOnIndex(int index, Visit_node item = null)
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
                            $"WHERE id = @id"
                            , sqlConnection);
                    command.Parameters.AddWithValue("@id", $"{list[index].id}");

                    command.ExecuteNonQuery();

                    list.RemoveAt(index);
                    visits.Rows.RemoveAt(index);
                    delete_visit_button.Enabled = list.Count > 0;
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
                    list = new List<Visit_node>();
                }
                index = visits.Rows.Add();
                Visit_node temp = new Visit_node();
                list.Add(temp);
            }
            list[index].id = item.id;
            list[index].customer_id = item.customer_id;

            visits.Rows[index].Cells["room_type"].Value = list[index].room_type = item.room_type;
            visits.Rows[index].Cells["doc_type"].Value = list[index].doc_type = item.doc_type;
            visits.Rows[index].Cells["room_cost"].Value = list[index].room_cost = item.room_cost;
            visits.Rows[index].Cells["additional_cost"].Value = list[index].additional_cost = item.additional_cost;
            visits.Rows[index].Cells["additional_type"].Value = list[index].additional_type = item.additional_type;
            visits.Rows[index].Cells["violations"].Value = list[index].violations = item.violations;
            visits.Rows[index].Cells["comment"].Value = list[index].comment = item.comment;
            visits.Rows[index].Cells["coming"].Value = list[index].coming = DateTime.Parse(item.coming).ToString("dd.MM.yyyy");
            visits.Rows[index].Cells["departure"].Value = list[index].departure = DateTime.Parse(item.departure).ToString("dd.MM.yyyy");
            delete_visit_button.Enabled = list.Count > 0;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            save_button.Enabled = true;
            if (current.id == -1)
            {

            }
            else
            {
                add_visit_button.Enabled = true;
                delete_visit_button.Enabled = true;

                name_input.Text = current.name;
                phone_input.Text = current.phone;
                comment_input.Text = current.comment;
                load_table();
            }
        }

        private void load_table()
        {
            SQLiteConnection sqlConnection = null;
            SQLiteDataReader sqlReader = null;
            list = new List<Visit_node>();

            visits.Rows.Clear();

            try
            {
                string connectionString = ConnectionString.SqliteString();
                sqlConnection = new SQLiteConnection(connectionString);
                sqlConnection.Open();

                SQLiteCommand command = new SQLiteCommand(
                        $"SELECT *" +
                        $"FROM [visits] " +
                        $"WHERE customer_id = @current_id"
                        , sqlConnection);


                command.Parameters.AddWithValue("@current_id", $"{current.id}");

                sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {

                    Visit_node temp = new Visit_node();

                    int index = visits.Rows.Add();

                    temp.id = Convert.ToInt32(sqlReader["Id"]);
                    visits.Rows[index].Cells["room_type"].Value = temp.room_type = Convert.ToString(sqlReader["room_type"]).Trim();
                    visits.Rows[index].Cells["doc_type"].Value = temp.doc_type = Convert.ToString(sqlReader["doc_type"]).Trim();
                    visits.Rows[index].Cells["room_cost"].Value = temp.room_cost = Convert.ToInt32(sqlReader["room_cost"]);
                    visits.Rows[index].Cells["additional_cost"].Value = temp.additional_cost = Convert.ToInt32(sqlReader["additional_cost"]);
                    visits.Rows[index].Cells["additional_type"].Value = temp.additional_type = Convert.ToString(sqlReader["additional_type"]).Trim();
                    visits.Rows[index].Cells["violations"].Value = temp.violations = Convert.ToString(sqlReader["violations"]).Trim();
                    visits.Rows[index].Cells["coming"].Value = temp.coming = DateTime.Parse(Convert.ToString(sqlReader["coming"])).ToString("dd.MM.yyyy");
                    visits.Rows[index].Cells["departure"].Value = temp.departure = DateTime.Parse(Convert.ToString(sqlReader["departure"])).ToString("dd.MM.yyyy");
                    visits.Rows[index].Cells["comment"].Value = temp.comment = Convert.ToString(sqlReader["comment"]).Trim();
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
                delete_visit_button.Enabled = flag;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnection = null;
            SQLiteDataReader reader = null;
            try
            {
                if (name_input.Text.Length < 1 || name_input.Text.Length > 50)
                    throw new Exception("Имя не может быть пустым");
                if (phone_input.Text.Length < 1 || phone_input.Text.Length > 50)
                    throw new Exception("Телефон не может быть пустым");
                if (current.phone == phone_input.Text &&
                    current.name == name_input.Text &&
                    current.comment == comment_input.Text)
                    throw new Exception("Чтобы сохранить, внесите изменения");

                current.phone = phone_input.Text;
                current.name = name_input.Text;
                current.comment = comment_input.Text;

                string connectionString = ConnectionString.SqliteString();
                sqlConnection = new SQLiteConnection(connectionString);
                sqlConnection.Open();

                SQLiteCommand command = null;

                if (current.id == -1)
                {
                    command = new SQLiteCommand(
                        $"INSERT INTO [customers]" +
                        $"(name,phone,comment)VALUES(@name,@phone,@comment)"
                        , sqlConnection);
                }
                else
                {
                    command = new SQLiteCommand(
                        $"UPDATE [customers]" +
                        $"SET name=@name, phone=@phone, comment=@comment " +
                        $"WHERE id = @id"
                        , sqlConnection);
                    command.Parameters.AddWithValue("@id", $"{current.id}");
                }
                command.Parameters.AddWithValue("@name", $"{current.name}");
                command.Parameters.AddWithValue("@phone", $"{current.phone}");
                command.Parameters.AddWithValue("@comment", $"{current.comment}");

                command.ExecuteNonQuery();

                if (current.id == -1)
                {
                    command = new SQLiteCommand(
                            $"SELECT Id " +
                            $"FROM [customers] " +
                            $"WHERE phone=@phone and name=@name"
                            , sqlConnection);
                    command.Parameters.AddWithValue("@name", $"{current.name}");
                    command.Parameters.AddWithValue("@phone", $"{current.phone}");
                    command.Parameters.AddWithValue("@comment", $"{current.comment}");

                    reader = command.ExecuteReader();
                    reader.Read();

                    current.id = Convert.ToInt32(reader["id"]);
                    add_visit_button.Enabled = true;
                }
                mainform.setOnIndex(indexOnSender, current);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                    sqlConnection.Close();
            }
        }

        private void add_visit_button_Click(object sender, EventArgs e)
        {
            CurrentForms.visit = new Visit(this, current.id);
            CurrentForms.visit.Show();
            CurrentForms.customer.Hide();

        }

        private void visits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            CurrentForms.visit = new Visit(this, current.id, e.RowIndex, list[e.RowIndex]);
            CurrentForms.visit.Show();
            CurrentForms.customer.Hide();
        }

        private void delete_visit_button_Click(object sender, EventArgs e)
        {
            int index = visits.CurrentRow.Index;
            if (index == -1) return;
            setOnIndex(index, null);
        }

        private void keyPress(object sender, KeyPressEventArgs e, int max)
        {
            try
            {
                TextBox tb = (TextBox)sender;
                if (e.KeyChar != Convert.ToChar(Keys.Back) && tb.TextLength > max - 1)
                    e.Handled = true;
            }
            catch (Exception) { }
            try
            {
                RichTextBox tb = (RichTextBox)sender;
                if (e.KeyChar != Convert.ToChar(Keys.Back) && tb.TextLength > max - 1)
                    e.Handled = true;
            }
            catch (Exception) { }
        }
        private void textChanged(object sender, EventArgs e, int max)
        {
            try
            {
                TextBox tb = (TextBox)sender;

                if (tb.TextLength > 50)
                    tb.Text = tb.Text.Substring(0, max);
            }
            catch (Exception) { }

            try
            {
                RichTextBox tb = (RichTextBox)sender;

                if (tb.TextLength > 50)
                    tb.Text = tb.Text.Substring(0, max);
            }
            catch (Exception) { }
        }
        private void textBox_textChanged50(object sender, EventArgs e)
        {
            textChanged(sender, e, 50);
        }
        private void textBox_KeyPress50(object sender, KeyPressEventArgs e)
        {
            keyPress(sender, e, 50);
        }
        private void textBox_textChanged150(object sender, EventArgs e)
        {
            textChanged(sender, e, 150);
        }
        private void textBox_KeyPress150(object sender, KeyPressEventArgs e)
        {
            keyPress(sender, e, 150);
        }

        private void Customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            CurrentForms.form1.Show();
            CurrentForms.customer = null;
        }
    }
}
