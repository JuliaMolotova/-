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
    public partial class FormReader : Form
    {
        public FormReader()
        {
            InitializeComponent();
            ShowReader();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ReaderSet readerSet = new ReaderSet();
            readerSet.FirstName = textBoxFirstName.Text;
            readerSet.MiddleName = textBoxMiddleName.Text;
            readerSet.LastName = textBoxLastName.Text;
            readerSet.Phone = textBoxPhone.Text;
            readerSet.Email = textBoxEmail.Text;
            Program.библиотека.ReaderSet.Add(readerSet);
            Program.библиотека.SaveChanges();
            ShowReader();
        }
        void ShowReader()
        {
            listViewReaderSet.Items.Clear();
            foreach (ReaderSet readerSet in Program.библиотека.ReaderSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    readerSet.Id.ToString(), readerSet.FirstName, readerSet.MiddleName, readerSet.LastName, readerSet.Phone, readerSet.Email
                });
                item.Tag = readerSet;
                listViewReaderSet.Items.Add(item);
            }
            listViewReaderSet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewReaderSet.SelectedItems.Count == 1)
            {
                ReaderSet readerSet = new ReaderSet();
                readerSet.FirstName = textBoxFirstName.Text;
                readerSet.MiddleName = textBoxMiddleName.Text;
                readerSet.LastName = textBoxLastName.Text;
                readerSet.Phone = textBoxPhone.Text;
                readerSet.Email = textBoxEmail.Text;
                Program.библиотека.SaveChanges();
                ShowReader();
            }

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewReaderSet.SelectedItems.Count == 1)
                {
                    ReaderSet readerSet = listViewReaderSet.SelectedItems[0].Tag as ReaderSet;
                    Program.библиотека.ReaderSet.Remove(readerSet);
                    Program.библиотека.SaveChanges();
                    ShowReader();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewReaderSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewReaderSet.SelectedItems.Count == 1)
            {
                ReaderSet readerSet = listViewReaderSet.SelectedItems[0].Tag as ReaderSet;
                readerSet.FirstName = textBoxFirstName.Text;
                readerSet.MiddleName = textBoxMiddleName.Text;
                readerSet.LastName = textBoxLastName.Text;
                readerSet.Phone = textBoxPhone.Text;
                readerSet.Email = textBoxEmail.Text;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }

        }
    }
}
