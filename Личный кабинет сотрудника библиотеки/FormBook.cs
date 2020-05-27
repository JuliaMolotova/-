using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Личный_кабинет_сотрудника_библиотеки
{
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
            ShowBook();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
                BookSet bookSet = new BookSet();
                bookSet.Name = textBoxName.Text;
                bookSet.Author = textBoxAuthor.Text;
                bookSet.Edition = textBoxEdition.Text;
                bookSet.DateOutput = textBoxDateOutput.Text;
                Program.библиотека.BookSet.Add(bookSet);
                Program.библиотека.SaveChanges();
                ShowBook();
        }
        void ShowBook()
        {
            listViewBookSet.Items.Clear();
            foreach (BookSet bookSet in Program.библиотека.BookSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    bookSet.Id.ToString(), bookSet.Name, bookSet.Author, bookSet.Edition, bookSet.DateOutput
                });
                item.Tag = bookSet;
                listViewBookSet.Items.Add(item);
            }
            listViewBookSet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewBookSet.SelectedItems.Count == 1)
            {
                BookSet bookSet = listViewBookSet.SelectedItems[0].Tag as BookSet;
                bookSet.Name = textBoxName.Text;
                bookSet.Author = textBoxAuthor.Text;
                bookSet.Edition = textBoxEdition.Text;
                bookSet.DateOutput = textBoxDateOutput.Text;
                Program.библиотека.SaveChanges();
                ShowBook();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewBookSet.SelectedItems.Count == 1)
                {
                    BookSet bookSet = listViewBookSet.SelectedItems[0].Tag as BookSet;
                    Program.библиотека.BookSet.Remove(bookSet);
                    Program.библиотека.SaveChanges();
                    ShowBook();
                }
                textBoxName.Text = "";
                textBoxAuthor.Text = "";
                textBoxEdition.Text = "";
                textBoxDateOutput.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewBookSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBookSet.SelectedItems.Count == 1)
            {
                BookSet bookSet = listViewBookSet.SelectedItems[0].Tag as BookSet;
                bookSet.Name = textBoxName.Text;
                bookSet.Author = textBoxAuthor.Text;
                bookSet.Edition = textBoxEdition.Text;
                bookSet.DateOutput = textBoxDateOutput.Text;
            }
            else
            {
                textBoxName.Text = "";
                textBoxAuthor.Text = "";
                textBoxEdition.Text = "";
                textBoxDateOutput.Text = "";
            }

        }
    }
}
