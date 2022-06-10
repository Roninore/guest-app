namespace guest_app
{
    partial class Visit
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
            this.coming_label = new System.Windows.Forms.Label();
            this.coming_input = new System.Windows.Forms.DateTimePicker();
            this.departure_input = new System.Windows.Forms.DateTimePicker();
            this.departure_label = new System.Windows.Forms.Label();
            this.room_type_input = new System.Windows.Forms.ComboBox();
            this.room_type_label = new System.Windows.Forms.Label();
            this.doc_type_label = new System.Windows.Forms.Label();
            this.doc_type_input = new System.Windows.Forms.ComboBox();
            this.room_cost_input = new System.Windows.Forms.TextBox();
            this.room_cost_label = new System.Windows.Forms.Label();
            this.additional_cost_label = new System.Windows.Forms.Label();
            this.additional_cost_input = new System.Windows.Forms.TextBox();
            this.additional_type_input = new System.Windows.Forms.RichTextBox();
            this.additional_type_label = new System.Windows.Forms.Label();
            this.violations_label = new System.Windows.Forms.Label();
            this.violations_input = new System.Windows.Forms.RichTextBox();
            this.comment_label = new System.Windows.Forms.Label();
            this.comment_input = new System.Windows.Forms.RichTextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coming_label
            // 
            this.coming_label.AutoSize = true;
            this.coming_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.coming_label.Location = new System.Drawing.Point(13, 13);
            this.coming_label.Name = "coming_label";
            this.coming_label.Size = new System.Drawing.Size(48, 17);
            this.coming_label.TabIndex = 0;
            this.coming_label.Text = "Заезд";
            // 
            // coming_input
            // 
            this.coming_input.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.coming_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.coming_input.Location = new System.Drawing.Point(12, 34);
            this.coming_input.Name = "coming_input";
            this.coming_input.Size = new System.Drawing.Size(182, 23);
            this.coming_input.TabIndex = 1;
            this.coming_input.Value = new System.DateTime(2022, 4, 9, 0, 0, 0, 0);
            // 
            // departure_input
            // 
            this.departure_input.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.departure_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.departure_input.Location = new System.Drawing.Point(232, 34);
            this.departure_input.Name = "departure_input";
            this.departure_input.Size = new System.Drawing.Size(182, 23);
            this.departure_input.TabIndex = 3;
            this.departure_input.Value = new System.DateTime(2022, 4, 9, 0, 0, 0, 0);
            // 
            // departure_label
            // 
            this.departure_label.AutoSize = true;
            this.departure_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.departure_label.Location = new System.Drawing.Point(229, 13);
            this.departure_label.Name = "departure_label";
            this.departure_label.Size = new System.Drawing.Size(50, 17);
            this.departure_label.TabIndex = 2;
            this.departure_label.Text = "Выезд";
            // 
            // room_type_input
            // 
            this.room_type_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.room_type_input.FormattingEnabled = true;
            this.room_type_input.Items.AddRange(new object[] {
            "Люкс",
            "Полулюкс",
            "Комфорт"});
            this.room_type_input.Location = new System.Drawing.Point(12, 92);
            this.room_type_input.Name = "room_type_input";
            this.room_type_input.Size = new System.Drawing.Size(159, 24);
            this.room_type_input.TabIndex = 4;
            this.room_type_input.TextChanged += new System.EventHandler(this.textBox_textChanged50);
            this.room_type_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress50);
            // 
            // room_type_label
            // 
            this.room_type_label.AutoSize = true;
            this.room_type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.room_type_label.Location = new System.Drawing.Point(13, 72);
            this.room_type_label.Name = "room_type_label";
            this.room_type_label.Size = new System.Drawing.Size(51, 17);
            this.room_type_label.TabIndex = 5;
            this.room_type_label.Text = "Номер";
            // 
            // doc_type_label
            // 
            this.doc_type_label.AutoSize = true;
            this.doc_type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.doc_type_label.Location = new System.Drawing.Point(186, 72);
            this.doc_type_label.Name = "doc_type_label";
            this.doc_type_label.Size = new System.Drawing.Size(73, 17);
            this.doc_type_label.TabIndex = 7;
            this.doc_type_label.Text = "Документ";
            // 
            // doc_type_input
            // 
            this.doc_type_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.doc_type_input.FormattingEnabled = true;
            this.doc_type_input.Items.AddRange(new object[] {
            "Паспорт",
            "Водительское удостоверение"});
            this.doc_type_input.Location = new System.Drawing.Point(186, 92);
            this.doc_type_input.Name = "doc_type_input";
            this.doc_type_input.Size = new System.Drawing.Size(228, 24);
            this.doc_type_input.TabIndex = 6;
            this.doc_type_input.TextChanged += new System.EventHandler(this.textBox_textChanged50);
            this.doc_type_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress50);
            // 
            // room_cost_input
            // 
            this.room_cost_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.room_cost_input.Location = new System.Drawing.Point(12, 154);
            this.room_cost_input.Name = "room_cost_input";
            this.room_cost_input.Size = new System.Drawing.Size(108, 23);
            this.room_cost_input.TabIndex = 8;
            this.room_cost_input.Text = "0";
            this.room_cost_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressNumber);
            // 
            // room_cost_label
            // 
            this.room_cost_label.AutoSize = true;
            this.room_cost_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.room_cost_label.Location = new System.Drawing.Point(12, 134);
            this.room_cost_label.Name = "room_cost_label";
            this.room_cost_label.Size = new System.Drawing.Size(111, 17);
            this.room_cost_label.TabIndex = 9;
            this.room_cost_label.Text = "Оплата номера";
            // 
            // additional_cost_label
            // 
            this.additional_cost_label.AutoSize = true;
            this.additional_cost_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.additional_cost_label.Location = new System.Drawing.Point(12, 190);
            this.additional_cost_label.Name = "additional_cost_label";
            this.additional_cost_label.Size = new System.Drawing.Size(96, 17);
            this.additional_cost_label.TabIndex = 11;
            this.additional_cost_label.Text = "Доп. покупки";
            // 
            // additional_cost_input
            // 
            this.additional_cost_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.additional_cost_input.Location = new System.Drawing.Point(12, 210);
            this.additional_cost_input.Name = "additional_cost_input";
            this.additional_cost_input.Size = new System.Drawing.Size(108, 23);
            this.additional_cost_input.TabIndex = 10;
            this.additional_cost_input.Text = "0";
            this.additional_cost_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressNumber);
            // 
            // additional_type_input
            // 
            this.additional_type_input.Location = new System.Drawing.Point(143, 154);
            this.additional_type_input.Name = "additional_type_input";
            this.additional_type_input.Size = new System.Drawing.Size(271, 79);
            this.additional_type_input.TabIndex = 12;
            this.additional_type_input.Text = "";
            this.additional_type_input.TextChanged += new System.EventHandler(this.textBox_textChanged150);
            // 
            // additional_type_label
            // 
            this.additional_type_label.AutoSize = true;
            this.additional_type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.additional_type_label.Location = new System.Drawing.Point(140, 134);
            this.additional_type_label.Name = "additional_type_label";
            this.additional_type_label.Size = new System.Drawing.Size(163, 17);
            this.additional_type_label.TabIndex = 13;
            this.additional_type_label.Text = "Описание доп. покупок";
            // 
            // violations_label
            // 
            this.violations_label.AutoSize = true;
            this.violations_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.violations_label.Location = new System.Drawing.Point(13, 246);
            this.violations_label.Name = "violations_label";
            this.violations_label.Size = new System.Drawing.Size(84, 17);
            this.violations_label.TabIndex = 15;
            this.violations_label.Text = "Нарушения";
            // 
            // violations_input
            // 
            this.violations_input.Location = new System.Drawing.Point(16, 266);
            this.violations_input.Name = "violations_input";
            this.violations_input.Size = new System.Drawing.Size(398, 79);
            this.violations_input.TabIndex = 14;
            this.violations_input.Text = "";
            this.violations_input.TextChanged += new System.EventHandler(this.textBox_textChanged150);
            // 
            // comment_label
            // 
            this.comment_label.AutoSize = true;
            this.comment_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comment_label.Location = new System.Drawing.Point(13, 350);
            this.comment_label.Name = "comment_label";
            this.comment_label.Size = new System.Drawing.Size(113, 17);
            this.comment_label.TabIndex = 17;
            this.comment_label.Text = "Дополнительно";
            // 
            // comment_input
            // 
            this.comment_input.Location = new System.Drawing.Point(16, 370);
            this.comment_input.Name = "comment_input";
            this.comment_input.Size = new System.Drawing.Size(398, 79);
            this.comment_input.TabIndex = 16;
            this.comment_input.Text = "";
            this.comment_input.TextChanged += new System.EventHandler(this.textBox_textChanged150);
            // 
            // save_button
            // 
            this.save_button.Enabled = false;
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.save_button.Location = new System.Drawing.Point(16, 460);
            this.save_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(127, 39);
            this.save_button.TabIndex = 18;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Visit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 513);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.comment_label);
            this.Controls.Add(this.comment_input);
            this.Controls.Add(this.violations_label);
            this.Controls.Add(this.violations_input);
            this.Controls.Add(this.additional_type_label);
            this.Controls.Add(this.additional_type_input);
            this.Controls.Add(this.additional_cost_label);
            this.Controls.Add(this.additional_cost_input);
            this.Controls.Add(this.room_cost_label);
            this.Controls.Add(this.room_cost_input);
            this.Controls.Add(this.doc_type_label);
            this.Controls.Add(this.doc_type_input);
            this.Controls.Add(this.room_type_label);
            this.Controls.Add(this.room_type_input);
            this.Controls.Add(this.departure_input);
            this.Controls.Add(this.departure_label);
            this.Controls.Add(this.coming_input);
            this.Controls.Add(this.coming_label);
            this.MaximumSize = new System.Drawing.Size(446, 552);
            this.MinimumSize = new System.Drawing.Size(446, 552);
            this.Name = "Visit";
            this.Text = "Посещение";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Visit_FormClosed);
            this.Load += new System.EventHandler(this.Visit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label coming_label;
        private System.Windows.Forms.DateTimePicker coming_input;
        private System.Windows.Forms.DateTimePicker departure_input;
        private System.Windows.Forms.Label departure_label;
        private System.Windows.Forms.ComboBox room_type_input;
        private System.Windows.Forms.Label room_type_label;
        private System.Windows.Forms.Label doc_type_label;
        private System.Windows.Forms.ComboBox doc_type_input;
        private System.Windows.Forms.TextBox room_cost_input;
        private System.Windows.Forms.Label room_cost_label;
        private System.Windows.Forms.Label additional_cost_label;
        private System.Windows.Forms.TextBox additional_cost_input;
        private System.Windows.Forms.RichTextBox additional_type_input;
        private System.Windows.Forms.Label additional_type_label;
        private System.Windows.Forms.Label violations_label;
        private System.Windows.Forms.RichTextBox violations_input;
        private System.Windows.Forms.Label comment_label;
        private System.Windows.Forms.RichTextBox comment_input;
        private System.Windows.Forms.Button save_button;
    }
}