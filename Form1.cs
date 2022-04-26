using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2note
{
    public partial class note : Form
    {
        public note()
        {
            InitializeComponent();
            //выводим список всех заметок
            listNotes();
            // настраиваем кнопки жирного, курсива, подчеркнутого и подчеркнутого текста
            boldBtn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            italicBtn.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            underlineBtn.Font = new Font("Segoe UI", 9, FontStyle.Underline);
            strikeoutBtn.Font = new Font("Segoe UI", 9, FontStyle.Strikeout);
            // размеры
            splitContainer1.SplitterDistance = 500;
            richTextBox1.Width = 390;
            this.Width = 820;
            foreach (int size in arraySizeFont)
            {
                comboBox2.Items.Add(size);

            }
        }

        int[] arraySizeFont = { 8, 9, 10, 11, 12, 14, 16, 18, 28, 36, 48, 72 };
        public static List<RichTextBox> TextBoxes = new List<RichTextBox>();

        // данная переменная хранит в себе данные о высоте заметки
        // которую выводили на прошлой итерации
        int oldHeight;

        // хранит название файла, который мы открыли для просмотра
        // в будущем нужно для перезаписи данного файла
        string nameOpenFile;

        // метод выводит список заметок
        private void listNotes()
        {
            splitContainer1.Panel1.Controls.Clear();
            TextBoxes.Clear();
            int height = 150;

            string[] allfiles = Directory.GetFiles(@"..\..\", "*.rtf");

            foreach (string filename in allfiles)
            {
                RichTextBox newTextBox = new RichTextBox();
                RichTextBox lastOldTextBox = TextBoxes.LastOrDefault();
                Button openButton = new Button();
                Button deleteButton = new Button();

                // выводим заметку
                newTextBox.LoadFile(filename);
                newTextBox.Enabled = false;
                newTextBox.ScrollBars = RichTextBoxScrollBars.None;

                int textLength = newTextBox.Text.Length;
                int textLines = newTextBox.GetLineFromCharIndex(textLength) + 1;

                if ((newTextBox.Font.Height * textLines) > height) { newTextBox.Size = new Size(350, height); }
                else { newTextBox.Size = new Size(350, (newTextBox.Font.Height * textLines) + 20); }

                if (lastOldTextBox == null)
                {
                    newTextBox.Location = new Point(10, 40);
                    openButton.Location = new Point(10, 11);
                    deleteButton.Location = new Point(284, 11);


                }
                else
                {
                    newTextBox.Location = new Point(10, lastOldTextBox.Location.Y + oldHeight + 40);
                    openButton.Location = new Point(10, lastOldTextBox.Location.Y + oldHeight + 11);
                    deleteButton.Location = new Point(284, lastOldTextBox.Location.Y + oldHeight + 11);
                }

                newTextBox.BackColor = Color.FromArgb(187, 187, 187);
                newTextBox.Cursor = Cursors.Arrow;
                TextBoxes.Add(newTextBox);
                splitContainer1.Panel1.Controls.Add(newTextBox);
                oldHeight = newTextBox.Height;

                string nameBtn = filename.Substring(6, filename.Length - 10);

                // добавляем кнопку открыть
                openButton.Text = "открыть";
                openButton.BackColor = Color.White;
                openButton.FlatAppearance.BorderColor = Color.White;
                openButton.FlatStyle = FlatStyle.Flat;
                openButton.Size = new Size(75, 30);
                openButton.Click += openButtonClick;
                openButton.Name = nameBtn;
                splitContainer1.Panel1.Controls.Add(openButton);

                // добавляем кнопку удалить
                deleteButton.Text = "удалить";
                deleteButton.BackColor = Color.Red;
                deleteButton.FlatAppearance.BorderColor = Color.Red;
                deleteButton.FlatStyle = FlatStyle.Flat;
                deleteButton.Size = new Size(75, 30);
                deleteButton.Click += deleteButtonClick;
                deleteButton.Name = nameBtn;
                splitContainer1.Panel1.Controls.Add(deleteButton);
            }

        }

        // открытие заметки
        private void openButtonClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            richTextBox1.LoadFile("..\\..\\" + button.Name + ".rtf");
            nameOpenFile = button.Name;
        }

        // удаление заметки
        private void deleteButtonClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            FileInfo fileInf = new FileInfo("..\\..\\" + button.Name + ".rtf");
            if (fileInf.Exists)
            {
                fileInf.Delete();
            }
            listNotes();
            richTextBox1.Clear();
        }

        // событие ощищается область ввода заметок и удаляет значение переменной
        private void newNote_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            nameOpenFile = null;
        }

        // сохранение заметки
        private void saveNote_Click(object sender, EventArgs e)
        {
            // проверка на пустоту, чтобы не хранить пустые файлы
            if (richTextBox1.Text == "") { MessageBox.Show("Пустая заметка"); }
            else
            {
                // если раньше не открывали заметку
                // то гененируем новое имя для сохранения файла
                if (nameOpenFile == null)
                {

                    Random random = new Random();

                    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                    string[] allfiles = Directory.GetFiles(@"..\..\", "*.rtf");

                    string name_note = "..\\..\\" + new string(Enumerable.Repeat(chars, 10)
                      .Select(s => s[random.Next(s.Length)]).ToArray()) + ".rtf";

                    while (allfiles.Contains(name_note) == true)
                    {
                        name_note = "..\\..\\" + new string(Enumerable.Repeat(chars, 10)
                            .Select(s => s[random.Next(s.Length)]).ToArray()) + ".rtf";
                    }
                    richTextBox1.SaveFile(name_note);
                    nameOpenFile = name_note.Substring(6, name_note.Length - 10);
                }

                else
                {
                    string name_note = "..\\..\\" + nameOpenFile + ".rtf";
                    richTextBox1.SaveFile(name_note);
                }
                listNotes();
            }
        }

        // сделает текст жирным
        private void boldBtn_Click(object sender, EventArgs e)
        {
                if (richTextBox1.SelectionFont != null)
                {
                    Font currentFont = richTextBox1.SelectionFont;
                    FontStyle newFontStyle;

                    if (richTextBox1.SelectionFont.Bold == true)
                    {
                        newFontStyle = FontStyle.Regular;
                    }
                    else
                    {
                        newFontStyle = FontStyle.Bold;
                    }

                    richTextBox1.SelectionFont = new Font(
                    currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
          
        }

        // сделает текст курсивом
        private void italicBtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;

                if (richTextBox1.SelectionFont.Italic == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Italic;
                }

                richTextBox1.SelectionFont = new Font(
                currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        // подчеркнет текст
        private void underlineBtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;

                if (richTextBox1.SelectionFont.Underline == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Underline;
                }

                richTextBox1.SelectionFont = new Font(
                currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        // зачеркнет текст
        private void strikeoutBtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;

                if (richTextBox1.SelectionFont.Strikeout == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Strikeout;
                }

                richTextBox1.SelectionFont = new Font(
                currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        // меняем шрифт
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                richTextBox1.SelectionFont = new Font(
                comboBox1.SelectedItem.ToString(), currentFont.Size, currentFont.Style);
            }
        }
        // размер шрифта
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                richTextBox1.SelectionFont = new Font(
                currentFont.FontFamily, arraySizeFont[comboBox2.SelectedIndex], currentFont.Style);
            }
        }
    }
}
