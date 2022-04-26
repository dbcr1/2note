namespace _2note
{
    partial class note
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.newNote = new System.Windows.Forms.Button();
            this.saveNote = new System.Windows.Forms.Button();
            this.boldBtn = new System.Windows.Forms.Button();
            this.italicBtn = new System.Windows.Forms.Button();
            this.underlineBtn = new System.Windows.Forms.Button();
            this.strikeoutBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.strikeoutBtn);
            this.splitContainer1.Panel2.Controls.Add(this.underlineBtn);
            this.splitContainer1.Panel2.Controls.Add(this.italicBtn);
            this.splitContainer1.Panel2.Controls.Add(this.boldBtn);
            this.splitContainer1.Panel2.Controls.Add(this.saveNote);
            this.splitContainer1.Panel2.Controls.Add(this.newNote);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1011, 689);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(383, 626);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // newNote
            // 
            this.newNote.Location = new System.Drawing.Point(3, 663);
            this.newNote.Name = "newNote";
            this.newNote.Size = new System.Drawing.Size(103, 23);
            this.newNote.TabIndex = 1;
            this.newNote.Text = "Новая заметка";
            this.newNote.UseVisualStyleBackColor = true;
            this.newNote.Click += new System.EventHandler(this.newNote_Click);
            // 
            // saveNote
            // 
            this.saveNote.Location = new System.Drawing.Point(311, 663);
            this.saveNote.Name = "saveNote";
            this.saveNote.Size = new System.Drawing.Size(75, 23);
            this.saveNote.TabIndex = 2;
            this.saveNote.Text = "Сохранить";
            this.saveNote.UseVisualStyleBackColor = true;
            this.saveNote.Click += new System.EventHandler(this.saveNote_Click);
            // 
            // boldBtn
            // 
            this.boldBtn.Location = new System.Drawing.Point(3, 3);
            this.boldBtn.Name = "boldBtn";
            this.boldBtn.Size = new System.Drawing.Size(25, 25);
            this.boldBtn.TabIndex = 3;
            this.boldBtn.Text = "Ж";
            this.boldBtn.UseVisualStyleBackColor = true;
            this.boldBtn.Click += new System.EventHandler(this.boldBtn_Click);
            // 
            // italicBtn
            // 
            this.italicBtn.Location = new System.Drawing.Point(34, 3);
            this.italicBtn.Name = "italicBtn";
            this.italicBtn.Size = new System.Drawing.Size(25, 25);
            this.italicBtn.TabIndex = 4;
            this.italicBtn.Text = "К";
            this.italicBtn.UseVisualStyleBackColor = true;
            this.italicBtn.Click += new System.EventHandler(this.italicBtn_Click);
            // 
            // underlineBtn
            // 
            this.underlineBtn.Location = new System.Drawing.Point(65, 3);
            this.underlineBtn.Name = "underlineBtn";
            this.underlineBtn.Size = new System.Drawing.Size(25, 25);
            this.underlineBtn.TabIndex = 5;
            this.underlineBtn.Text = "Ч";
            this.underlineBtn.UseVisualStyleBackColor = true;
            this.underlineBtn.Click += new System.EventHandler(this.underlineBtn_Click);
            // 
            // strikeoutBtn
            // 
            this.strikeoutBtn.Location = new System.Drawing.Point(96, 3);
            this.strikeoutBtn.Name = "strikeoutBtn";
            this.strikeoutBtn.Size = new System.Drawing.Size(39, 25);
            this.strikeoutBtn.TabIndex = 6;
            this.strikeoutBtn.Text = "abc";
            this.strikeoutBtn.UseVisualStyleBackColor = true;
            this.strikeoutBtn.Click += new System.EventHandler(this.strikeoutBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Arial",
            "Comic Sans MS",
            "Georgia",
            "Impact",
            "Verdana",
            "Segoe UI"});
            this.comboBox1.Location = new System.Drawing.Point(142, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(246, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(98, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 689);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "note";
            this.ShowIcon = false;
            this.Text = "2note";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button strikeoutBtn;
        private System.Windows.Forms.Button underlineBtn;
        private System.Windows.Forms.Button italicBtn;
        private System.Windows.Forms.Button boldBtn;
        private System.Windows.Forms.Button saveNote;
        private System.Windows.Forms.Button newNote;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

