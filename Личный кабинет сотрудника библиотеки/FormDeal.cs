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
    public partial class FormDeal : Form
    {
        public FormDeal()
        {
            InitializeComponent();
            ShowDeal();
            ShowBook();
            ShowReader();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxBook.SelectedItem != null && comboBoxReader.SelectedItem != null)
            {
                DealSet deal = new DealSet();
                deal.IdBook = Convert.ToInt32(comboBoxBook.SelectedItem.ToString().Split('.')[0]);
                deal.IdReader = Convert.ToInt32(comboBoxReader.SelectedItem.ToString().Split('.')[0]);
                deal.DateDelivery = textBoxDateDelivery.Text;
                deal.DateReturn = textBoxDateReturn.Text;
                Program.библиотека.DealSet.Add(deal);
                Program.библиотека.SaveChanges();
                ShowDeal();
            }
            else MessageBox.Show("Невозможно добавить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowDeal()
        {
            listViewDealSet.Items.Clear();
            foreach (DealSet deal in Program.библиотека.DealSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                deal.BookSet.Name,
                deal.BookSet.Author,
                deal.ReaderSet.FirstName,
                deal.ReaderSet.LastName,
                deal.DateDelivery,
                deal.DateReturn
                });
                item.Tag = deal;
                listViewDealSet.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDealSet.SelectedItems.Count == 1)
            {
                DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                deal.IdBook = Convert.ToInt32(comboBoxBook.SelectedItem.ToString().Split('.')[0]);
                deal.IdReader = Convert.ToInt32(comboBoxReader.SelectedItem.ToString().Split('.')[0]);
                deal.DateDelivery = textBoxDateDelivery.Text;
                deal.DateReturn = textBoxDateReturn.Text;
                Program.библиотека.SaveChanges();
                ShowDeal();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDealSet.SelectedItems.Count == 1)
                {
                    DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                    Program.библиотека.DealSet.Remove(deal);
                    Program.библиотека.SaveChanges();
                    ShowDeal();
                }
                comboBoxBook.SelectedItem = null;
                comboBoxReader.SelectedItem = null;
                textBoxDateDelivery.Text = "";
                textBoxDateReturn.Text = "";

            }
            catch
            {
                MessageBox.Show("Невозможно удалить!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewDealSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDealSet.SelectedItems.Count == 1)
            {
                DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                comboBoxBook.SelectedIndex = comboBoxBook.FindString(deal.IdBook.ToString());
                comboBoxReader.SelectedIndex = comboBoxBook.FindString(deal.IdReader.ToString());
                deal.DateDelivery = textBoxDateDelivery.Text;
                deal.DateReturn = textBoxDateReturn.Text;
            }
            else
            {
                comboBoxBook.SelectedItem = null;
                comboBoxReader.SelectedItem = null;
                textBoxDateDelivery.Text = "";
                textBoxDateReturn.Text = "";
            }
        }
        void ShowBook()
        {
            comboBoxBook.Items.Clear();
            foreach (BookSet bookSet in Program.библиотека.BookSet)
            {
                string[] item = { bookSet.Id.ToString() + ". ", "" + bookSet.Name, ", " + bookSet.Author };
                comboBoxBook.Items.Add(string.Join("", item));
            }
        }
        void ShowReader()
        {
            comboBoxReader.Items.Clear();
            foreach (ReaderSet readerSet in Program.библиотека.ReaderSet)
            {
                string[] item = { readerSet.Id.ToString() + ". ", "" + readerSet.FirstName, ", " + readerSet.LastName };
                comboBoxReader.Items.Add(string.Join("", item));
            }
        }
    }
}
