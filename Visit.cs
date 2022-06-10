using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace guest_app
{
    public partial class Visit : Form
    {
        Customer mainform;
        Visit_node current;
        int indexOnSender;
        public Visit(Customer sender, int customer_id, int index = -1, Visit_node item = null)
        {
            current = item;
            if (item == null)
                current = new Visit_node();

            current.customer_id = customer_id;
            mainform = sender;
            indexOnSender = index;
            InitializeComponent();
        }

        private void Visit_Load(object sender, EventArgs e)
        {
            save_button.Enabled = true;
            coming_input.Value = DateTime.Parse(current.coming);
            departure_input.Value = DateTime.Parse(current.departure);
            if (current.id == -1)
            {
            }
            else
            {
                room_type_input.Text = current.room_type;
                doc_type_input.Text = current.doc_type;
                room_cost_input.Text = Convert.ToString(current.room_cost);
                additional_cost_input.Text = Convert.ToString(current.additional_cost);
                additional_type_input.Text = current.additional_type;
                violations_input.Text = current.violations;
                comment_input.Text = current.comment;
            }
        }

 
        private void save_button_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnection = null;
            SQLiteDataReader reader = null;
            try
            {
                Visit_node temp = new Visit_node();
                temp.id = current.id;
                temp.customer_id = current.customer_id;
                temp.coming = coming_input.Value.ToString("yyyy-MM-dd"); //DateTime.Parse(temp.last_change).ToString("yyyy.MM.dd HH:mm:ss")
                temp.departure = departure_input.Value.ToString("yyyy-MM-dd");
                temp.room_type = room_type_input.Text;
                temp.doc_type = doc_type_input.Text;
                temp.room_cost = Convert.ToInt32(room_cost_input.Text);
                temp.additional_cost = Convert.ToInt32(additional_cost_input.Text);
                temp.additional_type = additional_type_input.Text;
                temp.violations = violations_input.Text;
                temp.comment = comment_input.Text;

                if (temp.equals(current) && current.id != -1)
                    throw new Exception("Чтобы сохранить, нужно записать данные");

                current = temp;

                string connectionString = ConnectionString.SqliteString();
                sqlConnection = new SQLiteConnection(connectionString);
                sqlConnection.Open();

                SQLiteCommand command = null;

                if (current.id == -1)
                {
                    command = new SQLiteCommand(
                        $"INSERT INTO [visits] " +
                        $"(coming,departure,customer_id,room_type,doc_type,room_cost,additional_cost,additional_type,violations,comment)" +
                        $"VALUES(@coming,@departure,@customer_id,@room_type,@doc_type,@room_cost,@additional_cost,@additional_type,@violations,@comment)"
                        , sqlConnection);
                }
                else
                {
                    command = new SQLiteCommand(
                        $"UPDATE [visits] " +
                        $"SET coming=@coming, departure=@departure, customer_id=@customer_id,room_type=@room_type,doc_type=@doc_type,violations=@violations," +
                        $"room_cost=@room_cost,additional_cost=@additional_cost,additional_type=@additional_type,comment=@comment " +
                        $"WHERE id = @id"
                        , sqlConnection);
                    command.Parameters.AddWithValue("@id", $"{current.id}");
                }
                command.Parameters.AddWithValue("@customer_id", $"{current.customer_id}");
                command.Parameters.AddWithValue("@room_type", $"{current.room_type}");
                command.Parameters.AddWithValue("@doc_type", $"{current.doc_type}");
                command.Parameters.AddWithValue("@violations", $"{current.violations}");
                command.Parameters.AddWithValue("@room_cost", $"{current.room_cost}");
                command.Parameters.AddWithValue("@additional_cost", $"{current.additional_cost}");
                command.Parameters.AddWithValue("@additional_type", $"{current.additional_type}");
                command.Parameters.AddWithValue("@comment", $"{current.comment}");
                command.Parameters.AddWithValue("@departure", current.departure);
                command.Parameters.AddWithValue("@coming", current.coming);

                
                command.ExecuteNonQuery();

                if (current.id == -1)
                {
                    command = new SQLiteCommand(
                            $"SELECT Id " +
                            $"FROM [visits] " +
                            $"WHERE customer_id = @customer_id"
                            , sqlConnection);
                    command.Parameters.AddWithValue("@customer_id", $"{current.customer_id}");

                    reader = command.ExecuteReader();
                    reader.Read();

                    current.id = Convert.ToInt32(reader["id"]);
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

        private void keyPressNumber(object sender, KeyPressEventArgs e)
        {
            int max = 30;
            TextBox tb = (TextBox)sender;
            bool a = e.KeyChar != Convert.ToChar(Keys.Back);
            bool b = e.KeyChar < '0' || e.KeyChar > '9';
            bool c = tb.TextLength > max - 1;
            if (a && (b || c))
                e.Handled = true;
        }

        private void Visit_FormClosed(object sender, FormClosedEventArgs e)
        {
            CurrentForms.customer.Show();
            CurrentForms.visit = null;
        }
    }
}
