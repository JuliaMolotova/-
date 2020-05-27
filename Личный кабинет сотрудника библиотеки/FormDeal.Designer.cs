namespace Личный_кабинет_сотрудника_библиотеки
{
    partial class FormDeal
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelBook = new System.Windows.Forms.Label();
            this.labelReader = new System.Windows.Forms.Label();
            this.labelDateDelivery = new System.Windows.Forms.Label();
            this.labelDateReturn = new System.Windows.Forms.Label();
            this.listViewDealSet = new System.Windows.Forms.ListView();
            this.textBoxDateDelivery = new System.Windows.Forms.TextBox();
            this.textBoxDateReturn = new System.Windows.Forms.TextBox();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.comboBoxReader = new System.Windows.Forms.ComboBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAdd.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(259, 230);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 35);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonEdit.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(392, 230);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(110, 35);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDel.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(519, 230);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(110, 35);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelBook.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBook.Location = new System.Drawing.Point(127, 23);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(43, 15);
            this.labelBook.TabIndex = 3;
            this.labelBook.Text = "Книга";
            // 
            // labelReader
            // 
            this.labelReader.AutoSize = true;
            this.labelReader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelReader.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReader.Location = new System.Drawing.Point(251, 23);
            this.labelReader.Name = "labelReader";
            this.labelReader.Size = new System.Drawing.Size(63, 15);
            this.labelReader.TabIndex = 4;
            this.labelReader.Text = "Читатель";
            // 
            // labelDateDelivery
            // 
            this.labelDateDelivery.AutoSize = true;
            this.labelDateDelivery.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelDateDelivery.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateDelivery.Location = new System.Drawing.Point(384, 23);
            this.labelDateDelivery.Name = "labelDateDelivery";
            this.labelDateDelivery.Size = new System.Drawing.Size(85, 15);
            this.labelDateDelivery.TabIndex = 5;
            this.labelDateDelivery.Text = "Дата выдачи";
            // 
            // labelDateReturn
            // 
            this.labelDateReturn.AutoSize = true;
            this.labelDateReturn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelDateReturn.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateReturn.Location = new System.Drawing.Point(511, 23);
            this.labelDateReturn.Name = "labelDateReturn";
            this.labelDateReturn.Size = new System.Drawing.Size(75, 15);
            this.labelDateReturn.TabIndex = 6;
            this.labelDateReturn.Text = "Дата сдачи";
            // 
            // listViewDealSet
            // 
            this.listViewDealSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewDealSet.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewDealSet.FullRowSelect = true;
            this.listViewDealSet.GridLines = true;
            this.listViewDealSet.HideSelection = false;
            this.listViewDealSet.Location = new System.Drawing.Point(28, 106);
            this.listViewDealSet.MultiSelect = false;
            this.listViewDealSet.Name = "listViewDealSet";
            this.listViewDealSet.Size = new System.Drawing.Size(601, 104);
            this.listViewDealSet.TabIndex = 8;
            this.listViewDealSet.UseCompatibleStateImageBehavior = false;
            this.listViewDealSet.View = System.Windows.Forms.View.Details;
            this.listViewDealSet.SelectedIndexChanged += new System.EventHandler(this.listViewDealSet_SelectedIndexChanged);
            // 
            // textBoxDateDelivery
            // 
            this.textBoxDateDelivery.Location = new System.Drawing.Point(387, 49);
            this.textBoxDateDelivery.Name = "textBoxDateDelivery";
            this.textBoxDateDelivery.Size = new System.Drawing.Size(115, 21);
            this.textBoxDateDelivery.TabIndex = 11;
            // 
            // textBoxDateReturn
            // 
            this.textBoxDateReturn.Location = new System.Drawing.Point(514, 49);
            this.textBoxDateReturn.Name = "textBoxDateReturn";
            this.textBoxDateReturn.Size = new System.Drawing.Size(115, 21);
            this.textBoxDateReturn.TabIndex = 12;
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(130, 49);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(115, 22);
            this.comboBoxBook.TabIndex = 13;
            // 
            // comboBoxReader
            // 
            this.comboBoxReader.FormattingEnabled = true;
            this.comboBoxReader.Location = new System.Drawing.Point(254, 49);
            this.comboBoxReader.Name = "comboBoxReader";
            this.comboBoxReader.Size = new System.Drawing.Size(115, 22);
            this.comboBoxReader.TabIndex = 14;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название книги";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Автор";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Имя читателя";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Фамилия читателя";
            this.columnHeader4.Width = 117;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Дата выдачи";
            this.columnHeader5.Width = 82;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Дата сдачи";
            this.columnHeader6.Width = 96;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Личный_кабинет_сотрудника_библиотеки.Properties.Resources._9cbca3705500971891f0503bf2e187d7;
            this.pictureBox1.Location = new System.Drawing.Point(28, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 286);
            this.Controls.Add(this.comboBoxReader);
            this.Controls.Add(this.comboBoxBook);
            this.Controls.Add(this.textBoxDateReturn);
            this.Controls.Add(this.textBoxDateDelivery);
            this.Controls.Add(this.listViewDealSet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelDateReturn);
            this.Controls.Add(this.labelDateDelivery);
            this.Controls.Add(this.labelReader);
            this.Controls.Add(this.labelBook);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormDeal";
            this.Text = "FormDeal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.Label labelReader;
        private System.Windows.Forms.Label labelDateDelivery;
        private System.Windows.Forms.Label labelDateReturn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewDealSet;
        private System.Windows.Forms.TextBox textBoxDateDelivery;
        private System.Windows.Forms.TextBox textBoxDateReturn;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.ComboBox comboBoxReader;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}