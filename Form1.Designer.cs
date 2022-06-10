namespace guest_app
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolstripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сводкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьПолнуюИнформацюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.list_group = new System.Windows.Forms.GroupBox();
            this.name_search_group = new System.Windows.Forms.GroupBox();
            this.name_search_button = new System.Windows.Forms.Button();
            this.name_search_input = new System.Windows.Forms.TextBox();
            this.deleteEntry = new System.Windows.Forms.Button();
            this.not_found_label = new System.Windows.Forms.Label();
            this.date_search = new System.Windows.Forms.GroupBox();
            this.date_search_input = new System.Windows.Forms.DateTimePicker();
            this.date_search_button = new System.Windows.Forms.Button();
            this.createEnrty = new System.Windows.Forms.Button();
            this.customers_table = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_search_group = new System.Windows.Forms.GroupBox();
            this.phone_search_button = new System.Windows.Forms.Button();
            this.phone_search_input = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.list_group.SuspendLayout();
            this.name_search_group.SuspendLayout();
            this.date_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customers_table)).BeginInit();
            this.phone_search_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolstripMenu,
            this.сводкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1127, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolstripMenu
            // 
            this.helpToolstripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripItem});
            this.helpToolstripMenu.Name = "helpToolstripMenu";
            this.helpToolstripMenu.Size = new System.Drawing.Size(68, 20);
            this.helpToolstripMenu.Text = "Помощь";
            // 
            // aboutToolStripItem
            // 
            this.aboutToolStripItem.Name = "aboutToolStripItem";
            this.aboutToolStripItem.Size = new System.Drawing.Size(168, 22);
            this.aboutToolStripItem.Text = "О разработчиках";
            this.aboutToolStripItem.Click += new System.EventHandler(this.aboutToolStripItem_Click);
            // 
            // сводкаToolStripMenuItem
            // 
            this.сводкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посмотретьПолнуюИнформацюToolStripMenuItem});
            this.сводкаToolStripMenuItem.Name = "сводкаToolStripMenuItem";
            this.сводкаToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.сводкаToolStripMenuItem.Text = "Сводка";
            // 
            // посмотретьПолнуюИнформацюToolStripMenuItem
            // 
            this.посмотретьПолнуюИнформацюToolStripMenuItem.Name = "посмотретьПолнуюИнформацюToolStripMenuItem";
            this.посмотретьПолнуюИнформацюToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.посмотретьПолнуюИнформацюToolStripMenuItem.Text = "Посмотреть полную информацю";
            this.посмотретьПолнуюИнформацюToolStripMenuItem.Click += new System.EventHandler(this.посмотретьПолнуюИнформацюToolStripMenuItem_Click);
            // 
            // list_group
            // 
            this.list_group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_group.Controls.Add(this.name_search_group);
            this.list_group.Controls.Add(this.deleteEntry);
            this.list_group.Controls.Add(this.not_found_label);
            this.list_group.Controls.Add(this.date_search);
            this.list_group.Controls.Add(this.createEnrty);
            this.list_group.Controls.Add(this.customers_table);
            this.list_group.Controls.Add(this.phone_search_group);
            this.list_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.list_group.Location = new System.Drawing.Point(15, 26);
            this.list_group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_group.Name = "list_group";
            this.list_group.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_group.Size = new System.Drawing.Size(1100, 438);
            this.list_group.TabIndex = 0;
            this.list_group.TabStop = false;
            this.list_group.Text = "Данные";
            // 
            // name_search_group
            // 
            this.name_search_group.Controls.Add(this.name_search_button);
            this.name_search_group.Controls.Add(this.name_search_input);
            this.name_search_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.name_search_group.Location = new System.Drawing.Point(719, 20);
            this.name_search_group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_search_group.Name = "name_search_group";
            this.name_search_group.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_search_group.Size = new System.Drawing.Size(338, 68);
            this.name_search_group.TabIndex = 5;
            this.name_search_group.TabStop = false;
            this.name_search_group.Text = "Поиск клиента по ФИО";
            // 
            // name_search_button
            // 
            this.name_search_button.Location = new System.Drawing.Point(238, 22);
            this.name_search_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_search_button.Name = "name_search_button";
            this.name_search_button.Size = new System.Drawing.Size(93, 39);
            this.name_search_button.TabIndex = 2;
            this.name_search_button.Text = "Найти";
            this.name_search_button.UseVisualStyleBackColor = true;
            this.name_search_button.Click += new System.EventHandler(this.name_search_button_Click);
            // 
            // name_search_input
            // 
            this.name_search_input.Location = new System.Drawing.Point(8, 30);
            this.name_search_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_search_input.Name = "name_search_input";
            this.name_search_input.Size = new System.Drawing.Size(224, 23);
            this.name_search_input.TabIndex = 1;
            this.name_search_input.TextChanged += new System.EventHandler(this.textBox_textChanged50);
            this.name_search_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_search_input_KeyPress);
            // 
            // deleteEntry
            // 
            this.deleteEntry.Location = new System.Drawing.Point(179, 92);
            this.deleteEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteEntry.Name = "deleteEntry";
            this.deleteEntry.Size = new System.Drawing.Size(158, 39);
            this.deleteEntry.TabIndex = 4;
            this.deleteEntry.Text = "Удалить клиента";
            this.deleteEntry.UseVisualStyleBackColor = true;
            this.deleteEntry.Click += new System.EventHandler(this.deleteEntry_Click);
            // 
            // not_found_label
            // 
            this.not_found_label.AutoSize = true;
            this.not_found_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.not_found_label.Location = new System.Drawing.Point(404, 256);
            this.not_found_label.Name = "not_found_label";
            this.not_found_label.Size = new System.Drawing.Size(261, 31);
            this.not_found_label.TabIndex = 3;
            this.not_found_label.Text = "Ничего не найдено!";
            this.not_found_label.Visible = false;
            // 
            // date_search
            // 
            this.date_search.Controls.Add(this.date_search_input);
            this.date_search.Controls.Add(this.date_search_button);
            this.date_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.date_search.Location = new System.Drawing.Point(361, 20);
            this.date_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_search.Name = "date_search";
            this.date_search.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_search.Size = new System.Drawing.Size(338, 68);
            this.date_search.TabIndex = 2;
            this.date_search.TabStop = false;
            this.date_search.Text = "Поиск клиента по дате въезда";
            // 
            // date_search_input
            // 
            this.date_search_input.Location = new System.Drawing.Point(6, 28);
            this.date_search_input.Name = "date_search_input";
            this.date_search_input.Size = new System.Drawing.Size(226, 23);
            this.date_search_input.TabIndex = 3;
            // 
            // date_search_button
            // 
            this.date_search_button.Location = new System.Drawing.Point(238, 22);
            this.date_search_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_search_button.Name = "date_search_button";
            this.date_search_button.Size = new System.Drawing.Size(93, 39);
            this.date_search_button.TabIndex = 2;
            this.date_search_button.Text = "Найти";
            this.date_search_button.UseVisualStyleBackColor = true;
            this.date_search_button.Click += new System.EventHandler(this.date_search_button_Click);
            // 
            // createEnrty
            // 
            this.createEnrty.Location = new System.Drawing.Point(14, 92);
            this.createEnrty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createEnrty.Name = "createEnrty";
            this.createEnrty.Size = new System.Drawing.Size(158, 39);
            this.createEnrty.TabIndex = 1;
            this.createEnrty.Text = "Создать клиента";
            this.createEnrty.UseVisualStyleBackColor = true;
            this.createEnrty.Click += new System.EventHandler(this.createEnrty_Click);
            // 
            // customers_table
            // 
            this.customers_table.AllowUserToAddRows = false;
            this.customers_table.AllowUserToDeleteRows = false;
            this.customers_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customers_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customers_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customers_table.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.customers_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customers_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.customers_table.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.customers_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customers_table.ColumnHeadersHeight = 29;
            this.customers_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customers_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.phone,
            this.comment});
            this.customers_table.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.customers_table.Location = new System.Drawing.Point(6, 135);
            this.customers_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customers_table.MultiSelect = false;
            this.customers_table.Name = "customers_table";
            this.customers_table.ReadOnly = true;
            this.customers_table.RowHeadersVisible = false;
            this.customers_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.customers_table.RowTemplate.Height = 24;
            this.customers_table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.customers_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customers_table.Size = new System.Drawing.Size(1088, 292);
            this.customers_table.TabIndex = 1;
            this.customers_table.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customers_table_CellContentClick);
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
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.HeaderText = "Номер";
            this.phone.MinimumWidth = 100;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // comment
            // 
            this.comment.HeaderText = "Комментарий";
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            this.comment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // phone_search_group
            // 
            this.phone_search_group.Controls.Add(this.phone_search_button);
            this.phone_search_group.Controls.Add(this.phone_search_input);
            this.phone_search_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.phone_search_group.Location = new System.Drawing.Point(6, 20);
            this.phone_search_group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone_search_group.Name = "phone_search_group";
            this.phone_search_group.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone_search_group.Size = new System.Drawing.Size(338, 68);
            this.phone_search_group.TabIndex = 0;
            this.phone_search_group.TabStop = false;
            this.phone_search_group.Text = "Поиск клиента по номеру";
            // 
            // phone_search_button
            // 
            this.phone_search_button.Location = new System.Drawing.Point(238, 22);
            this.phone_search_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone_search_button.Name = "phone_search_button";
            this.phone_search_button.Size = new System.Drawing.Size(93, 39);
            this.phone_search_button.TabIndex = 2;
            this.phone_search_button.Text = "Найти";
            this.phone_search_button.UseVisualStyleBackColor = true;
            this.phone_search_button.Click += new System.EventHandler(this.phone_search_button_Click);
            // 
            // phone_search_input
            // 
            this.phone_search_input.Location = new System.Drawing.Point(8, 30);
            this.phone_search_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone_search_input.Name = "phone_search_input";
            this.phone_search_input.Size = new System.Drawing.Size(224, 23);
            this.phone_search_input.TabIndex = 1;
            this.phone_search_input.TextChanged += new System.EventHandler(this.textBox_textChanged50);
            this.phone_search_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_search_input_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 475);
            this.Controls.Add(this.list_group);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Учет клиентов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.list_group.ResumeLayout(false);
            this.list_group.PerformLayout();
            this.name_search_group.ResumeLayout(false);
            this.name_search_group.PerformLayout();
            this.date_search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customers_table)).EndInit();
            this.phone_search_group.ResumeLayout(false);
            this.phone_search_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolstripMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripItem;
        private System.Windows.Forms.GroupBox list_group;
        private System.Windows.Forms.DataGridView customers_table;
        private System.Windows.Forms.GroupBox phone_search_group;
        private System.Windows.Forms.Button phone_search_button;
        private System.Windows.Forms.TextBox phone_search_input;
        private System.Windows.Forms.Button createEnrty;
        private System.Windows.Forms.GroupBox date_search;
        private System.Windows.Forms.DateTimePicker date_search_input;
        private System.Windows.Forms.Button date_search_button;
        private System.Windows.Forms.Label not_found_label;
        private System.Windows.Forms.Button deleteEntry;
        private System.Windows.Forms.ToolStripMenuItem сводкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьПолнуюИнформацюToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.GroupBox name_search_group;
        private System.Windows.Forms.Button name_search_button;
        private System.Windows.Forms.TextBox name_search_input;
    }
}

