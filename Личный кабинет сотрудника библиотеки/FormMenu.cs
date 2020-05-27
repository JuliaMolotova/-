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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            labelHello.Text = "Hello, " + FormAuthorization.users.login;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            Form formBook = new FormBook();
            formBook.Show();
        }

        private void buttonReader_Click(object sender, EventArgs e)
        {
            Form formReader = new FormReader();
            formReader.Show();

        }

        private void buttonDeal_Click(object sender, EventArgs e)
        {
            Form formDeal = new FormDeal();
            formDeal.Show();
        }
    }
}
