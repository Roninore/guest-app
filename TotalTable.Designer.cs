namespace guest_app
{
    partial class TotalTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.date_table = new System.Windows.Forms.DataGridView();
            this.coming = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additional_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additional_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_input = new System.Windows.Forms.DateTimePicker();
            this.first_input_label = new System.Windows.Forms.Label();
            this.second_input_label = new System.Windows.Forms.Label();
            this.second_input = new System.Windows.Forms.DateTimePicker();
            this.room_cost_sum = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.additional_cost_sum = new System.Windows.Forms.TextBox();
            this.total_sum = new System.Windows.Forms.TextBox();
            this.room_cost_sum_label = new System.Windows.Forms.Label();
            this.additional_cost_sum_label = new System.Windows.Forms.Label();
            this.total_sum_label = new System.Windows.Forms.Label();
            this.convert_excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.date_table)).BeginInit();
            this.SuspendLayout();
            // 
            // date_table
            // 
            this.date_table.AllowUserToAddRows = false;
            this.date_table.AllowUserToDeleteRows = false;
            this.date_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.date_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.date_table.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.date_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.date_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.date_table.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.date_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.date_table.ColumnHeadersHeight = 29;
            this.date_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.date_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coming,
            this.departure,
            this.name,
            this.phone,
            this.room_type,
            this.room_cost,
            this.additional_cost,
            this.additional_type});
            this.date_table.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.date_table.Location = new System.Drawing.Point(12, 83);
            this.date_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_table.MultiSelect = false;
            this.date_table.Name = "date_table";
            this.date_table.ReadOnly = true;
            this.date_table.RowHeadersVisible = false;
            this.date_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.date_table.RowTemplate.Height = 24;
            this.date_table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.date_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.date_table.Size = new System.Drawing.Size(1169, 469);
            this.date_table.TabIndex = 2;
            // 
            // coming
            // 
            this.coming.HeaderText = "Заезд";
            this.coming.Name = "coming";
            this.coming.ReadOnly = true;
            // 
            // departure
            // 
            this.departure.HeaderText = "Выезд";
            this.departure.Name = "departure";
            this.departure.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "ФИО";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // phone
            // 
            this.phone.HeaderText = "Телефон";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // room_type
            // 
            this.room_type.HeaderText = "Номер";
            this.room_type.Name = "room_type";
            this.room_type.ReadOnly = true;
            // 
            // room_cost
            // 
            this.room_cost.HeaderText = "Оплата номера";
            this.room_cost.Name = "room_cost";
            this.room_cost.ReadOnly = true;
            // 
            // additional_cost
            // 
            this.additional_cost.HeaderText = "Доп. покупки цена";
            this.additional_cost.Name = "additional_cost";
            this.additional_cost.ReadOnly = true;
            // 
            // additional_type
            // 
            this.additional_type.HeaderText = "Доп. Покупки";
            this.additional_type.Name = "additional_type";
            this.additional_type.ReadOnly = true;
            // 
            // first_input
            // 
            this.first_input.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.first_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.first_input.Location = new System.Drawing.Point(12, 38);
            this.first_input.Name = "first_input";
            this.first_input.Size = new System.Drawing.Size(200, 23);
            this.first_input.TabIndex = 3;
            this.first_input.ValueChanged += new System.EventHandler(this.date_input_ValueChanged);
            // 
            // first_input_label
            // 
            this.first_input_label.AutoSize = true;
            this.first_input_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.first_input_label.Location = new System.Drawing.Point(12, 18);
            this.first_input_label.Name = "first_input_label";
            this.first_input_label.Size = new System.Drawing.Size(118, 17);
            this.first_input_label.TabIndex = 4;
            this.first_input_label.Text = "Начало периода";
            // 
            // second_input_label
            // 
            this.second_input_label.AutoSize = true;
            this.second_input_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.second_input_label.Location = new System.Drawing.Point(230, 18);
            this.second_input_label.Name = "second_input_label";
            this.second_input_label.Size = new System.Drawing.Size(103, 17);
            this.second_input_label.TabIndex = 6;
            this.second_input_label.Text = "Конец Пеиода";
            // 
            // second_input
            // 
            this.second_input.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.second_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.second_input.Location = new System.Drawing.Point(230, 38);
            this.second_input.Name = "second_input";
            this.second_input.Size = new System.Drawing.Size(200, 23);
            this.second_input.TabIndex = 5;
            this.second_input.ValueChanged += new System.EventHandler(this.date_input_ValueChanged);
            // 
            // room_cost_sum
            // 
            this.room_cost_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.room_cost_sum.Location = new System.Drawing.Point(643, 45);
            this.room_cost_sum.Name = "room_cost_sum";
            this.room_cost_sum.ReadOnly = true;
            this.room_cost_sum.Size = new System.Drawing.Size(132, 23);
            this.room_cost_sum.TabIndex = 7;
            this.room_cost_sum.Text = "0";
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.search_button.Location = new System.Drawing.Point(436, 35);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(168, 33);
            this.search_button.TabIndex = 8;
            this.search_button.Text = "Отобразить данные";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // additional_cost_sum
            // 
            this.additional_cost_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.additional_cost_sum.Location = new System.Drawing.Point(781, 45);
            this.additional_cost_sum.Name = "additional_cost_sum";
            this.additional_cost_sum.ReadOnly = true;
            this.additional_cost_sum.Size = new System.Drawing.Size(132, 23);
            this.additional_cost_sum.TabIndex = 9;
            this.additional_cost_sum.Text = "0";
            // 
            // total_sum
            // 
            this.total_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.total_sum.Location = new System.Drawing.Point(919, 45);
            this.total_sum.Name = "total_sum";
            this.total_sum.ReadOnly = true;
            this.total_sum.Size = new System.Drawing.Size(132, 23);
            this.total_sum.TabIndex = 10;
            this.total_sum.Text = "0";
            // 
            // room_cost_sum_label
            // 
            this.room_cost_sum_label.AutoSize = true;
            this.room_cost_sum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.room_cost_sum_label.Location = new System.Drawing.Point(640, 25);
            this.room_cost_sum_label.Name = "room_cost_sum_label";
            this.room_cost_sum_label.Size = new System.Drawing.Size(122, 17);
            this.room_cost_sum_label.TabIndex = 11;
            this.room_cost_sum_label.Text = "Сумма за номера";
            // 
            // additional_cost_sum_label
            // 
            this.additional_cost_sum_label.AutoSize = true;
            this.additional_cost_sum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.additional_cost_sum_label.Location = new System.Drawing.Point(778, 25);
            this.additional_cost_sum_label.Name = "additional_cost_sum_label";
            this.additional_cost_sum_label.Size = new System.Drawing.Size(139, 17);
            this.additional_cost_sum_label.TabIndex = 12;
            this.additional_cost_sum_label.Text = "Сумма доп. покупки";
            // 
            // total_sum_label
            // 
            this.total_sum_label.AutoSize = true;
            this.total_sum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.total_sum_label.Location = new System.Drawing.Point(916, 25);
            this.total_sum_label.Name = "total_sum_label";
            this.total_sum_label.Size = new System.Drawing.Size(98, 17);
            this.total_sum_label.TabIndex = 13;
            this.total_sum_label.Text = "Общая сумма";
            // 
            // convert_excel
            // 
            this.convert_excel.Enabled = false;
            this.convert_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.convert_excel.Location = new System.Drawing.Point(1060, 38);
            this.convert_excel.Name = "convert_excel";
            this.convert_excel.Size = new System.Drawing.Size(120, 33);
            this.convert_excel.TabIndex = 14;
            this.convert_excel.Text = "Создать Excel";
            this.convert_excel.UseVisualStyleBackColor = true;
            this.convert_excel.Click += new System.EventHandler(this.convert_excel_Click);
            // 
            // TotalTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 563);
            this.Controls.Add(this.convert_excel);
            this.Controls.Add(this.total_sum_label);
            this.Controls.Add(this.additional_cost_sum_label);
            this.Controls.Add(this.room_cost_sum_label);
            this.Controls.Add(this.total_sum);
            this.Controls.Add(this.additional_cost_sum);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.room_cost_sum);
            this.Controls.Add(this.second_input_label);
            this.Controls.Add(this.second_input);
            this.Controls.Add(this.first_input_label);
            this.Controls.Add(this.first_input);
            this.Controls.Add(this.date_table);
            this.Name = "TotalTable";
            this.Text = "Сводная таблица";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TotalTable_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.date_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView date_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn coming;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn additional_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn additional_type;
        private System.Windows.Forms.DateTimePicker first_input;
        private System.Windows.Forms.Label first_input_label;
        private System.Windows.Forms.Label second_input_label;
        private System.Windows.Forms.DateTimePicker second_input;
        private System.Windows.Forms.TextBox room_cost_sum;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox additional_cost_sum;
        private System.Windows.Forms.TextBox total_sum;
        private System.Windows.Forms.Label room_cost_sum_label;
        private System.Windows.Forms.Label additional_cost_sum_label;
        private System.Windows.Forms.Label total_sum_label;
        private System.Windows.Forms.Button convert_excel;
    }
}