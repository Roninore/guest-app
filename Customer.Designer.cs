namespace guest_app
{
    partial class Customer
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
            this.card_visits = new System.Windows.Forms.GroupBox();
            this.delete_visit_button = new System.Windows.Forms.Button();
            this.add_visit_button = new System.Windows.Forms.Button();
            this.visits = new System.Windows.Forms.DataGridView();
            this.coming = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additional_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additional_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comment_label = new System.Windows.Forms.Label();
            this.comment_input = new System.Windows.Forms.RichTextBox();
            this.phone_input = new System.Windows.Forms.TextBox();
            this.phone_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.card_visits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visits)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // card_visits
            // 
            this.card_visits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.card_visits.Controls.Add(this.delete_visit_button);
            this.card_visits.Controls.Add(this.add_visit_button);
            this.card_visits.Controls.Add(this.visits);
            this.card_visits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.card_visits.Location = new System.Drawing.Point(12, 150);
            this.card_visits.Name = "card_visits";
            this.card_visits.Size = new System.Drawing.Size(1074, 371);
            this.card_visits.TabIndex = 6;
            this.card_visits.TabStop = false;
            this.card_visits.Text = "Посещения";
            // 
            // delete_visit_button
            // 
            this.delete_visit_button.Enabled = false;
            this.delete_visit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.delete_visit_button.Location = new System.Drawing.Point(151, 23);
            this.delete_visit_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_visit_button.Name = "delete_visit_button";
            this.delete_visit_button.Size = new System.Drawing.Size(127, 39);
            this.delete_visit_button.TabIndex = 9;
            this.delete_visit_button.Text = "Удалить";
            this.delete_visit_button.UseVisualStyleBackColor = true;
            this.delete_visit_button.Click += new System.EventHandler(this.delete_visit_button_Click);
            // 
            // add_visit_button
            // 
            this.add_visit_button.Enabled = false;
            this.add_visit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.add_visit_button.Location = new System.Drawing.Point(18, 23);
            this.add_visit_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_visit_button.Name = "add_visit_button";
            this.add_visit_button.Size = new System.Drawing.Size(127, 39);
            this.add_visit_button.TabIndex = 3;
            this.add_visit_button.Text = "Добавить";
            this.add_visit_button.UseVisualStyleBackColor = true;
            this.add_visit_button.Click += new System.EventHandler(this.add_visit_button_Click);
            // 
            // visits
            // 
            this.visits.AllowUserToAddRows = false;
            this.visits.AllowUserToDeleteRows = false;
            this.visits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.visits.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.visits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.visits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.visits.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.visits.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.visits.ColumnHeadersHeight = 29;
            this.visits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.visits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coming,
            this.departure,
            this.room_type,
            this.doc_type,
            this.room_cost,
            this.additional_cost,
            this.additional_type,
            this.violations,
            this.comment});
            this.visits.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.visits.Location = new System.Drawing.Point(18, 66);
            this.visits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visits.MultiSelect = false;
            this.visits.Name = "visits";
            this.visits.ReadOnly = true;
            this.visits.RowHeadersVisible = false;
            this.visits.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.visits.RowTemplate.Height = 24;
            this.visits.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.visits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visits.Size = new System.Drawing.Size(1050, 289);
            this.visits.TabIndex = 2;
            this.visits.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.visits_CellDoubleClick);
            // 
            // coming
            // 
            this.coming.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coming.HeaderText = "Заезд";
            this.coming.MinimumWidth = 6;
            this.coming.Name = "coming";
            this.coming.ReadOnly = true;
            this.coming.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // departure
            // 
            this.departure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departure.HeaderText = "Выезд";
            this.departure.MinimumWidth = 100;
            this.departure.Name = "departure";
            this.departure.ReadOnly = true;
            this.departure.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.departure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // room_type
            // 
            this.room_type.HeaderText = "Номер";
            this.room_type.Name = "room_type";
            this.room_type.ReadOnly = true;
            this.room_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // doc_type
            // 
            this.doc_type.HeaderText = "Документ";
            this.doc_type.Name = "doc_type";
            this.doc_type.ReadOnly = true;
            this.doc_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // room_cost
            // 
            this.room_cost.HeaderText = "Оплата номера";
            this.room_cost.Name = "room_cost";
            this.room_cost.ReadOnly = true;
            this.room_cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // additional_cost
            // 
            this.additional_cost.HeaderText = "Доп. покупки";
            this.additional_cost.Name = "additional_cost";
            this.additional_cost.ReadOnly = true;
            this.additional_cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // additional_type
            // 
            this.additional_type.HeaderText = "Наименование";
            this.additional_type.Name = "additional_type";
            this.additional_type.ReadOnly = true;
            this.additional_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // violations
            // 
            this.violations.HeaderText = "Нарушения";
            this.violations.Name = "violations";
            this.violations.ReadOnly = true;
            this.violations.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // comment
            // 
            this.comment.HeaderText = "Дополнительно";
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            this.comment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comment_label);
            this.groupBox1.Controls.Add(this.comment_input);
            this.groupBox1.Controls.Add(this.phone_input);
            this.groupBox1.Controls.Add(this.phone_label);
            this.groupBox1.Controls.Add(this.name_label);
            this.groupBox1.Controls.Add(this.name_input);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 132);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о клиенте";
            // 
            // comment_label
            // 
            this.comment_label.AutoSize = true;
            this.comment_label.Location = new System.Drawing.Point(265, 19);
            this.comment_label.Name = "comment_label";
            this.comment_label.Size = new System.Drawing.Size(113, 17);
            this.comment_label.TabIndex = 5;
            this.comment_label.Text = "Дополнительно";
            // 
            // comment_input
            // 
            this.comment_input.Location = new System.Drawing.Point(268, 39);
            this.comment_input.Name = "comment_input";
            this.comment_input.Size = new System.Drawing.Size(663, 79);
            this.comment_input.TabIndex = 4;
            this.comment_input.Text = "";
            this.comment_input.TextChanged += new System.EventHandler(this.textBox_textChanged150);
            this.comment_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress150);
            // 
            // phone_input
            // 
            this.phone_input.Location = new System.Drawing.Point(18, 89);
            this.phone_input.Name = "phone_input";
            this.phone_input.Size = new System.Drawing.Size(241, 23);
            this.phone_input.TabIndex = 3;
            this.phone_input.TextChanged += new System.EventHandler(this.textBox_textChanged50);
            this.phone_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress50);
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(15, 69);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(60, 17);
            this.phone_label.TabIndex = 2;
            this.phone_label.Text = "Номер *";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(15, 19);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(51, 17);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "ФИО *";
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(18, 39);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(244, 23);
            this.name_input.TabIndex = 0;
            this.name_input.TextChanged += new System.EventHandler(this.textBox_textChanged50);
            this.name_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress50);
            // 
            // save_button
            // 
            this.save_button.Enabled = false;
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.save_button.Location = new System.Drawing.Point(959, 59);
            this.save_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(127, 39);
            this.save_button.TabIndex = 8;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 535);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.card_visits);
            this.Name = "Customer";
            this.Text = "Клиент";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customer_FormClosed);
            this.Load += new System.EventHandler(this.Customer_Load);
            this.card_visits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visits)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox card_visits;
        private System.Windows.Forms.Button add_visit_button;
        private System.Windows.Forms.DataGridView visits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.TextBox phone_input;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label comment_label;
        private System.Windows.Forms.RichTextBox comment_input;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button delete_visit_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn coming;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn additional_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn additional_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn violations;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
    }
}