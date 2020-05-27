namespace Личный_кабинет_сотрудника_библиотеки
{
    partial class FormMenu
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
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonReader = new System.Windows.Forms.Button();
            this.buttonDeal = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBook
            // 
            this.buttonBook.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonBook.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBook.Location = new System.Drawing.Point(12, 79);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(265, 48);
            this.buttonBook.TabIndex = 0;
            this.buttonBook.Text = "Книги";
            this.buttonBook.UseVisualStyleBackColor = false;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // buttonReader
            // 
            this.buttonReader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonReader.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReader.Location = new System.Drawing.Point(12, 157);
            this.buttonReader.Name = "buttonReader";
            this.buttonReader.Size = new System.Drawing.Size(265, 48);
            this.buttonReader.TabIndex = 1;
            this.buttonReader.Text = "Читатели";
            this.buttonReader.UseVisualStyleBackColor = false;
            this.buttonReader.Click += new System.EventHandler(this.buttonReader_Click);
            // 
            // buttonDeal
            // 
            this.buttonDeal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDeal.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeal.Location = new System.Drawing.Point(12, 237);
            this.buttonDeal.Name = "buttonDeal";
            this.buttonDeal.Size = new System.Drawing.Size(265, 48);
            this.buttonDeal.TabIndex = 2;
            this.buttonDeal.Text = "Взятое";
            this.buttonDeal.UseVisualStyleBackColor = false;
            this.buttonDeal.Click += new System.EventHandler(this.buttonDeal_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelHello.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.Location = new System.Drawing.Point(93, 12);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(47, 18);
            this.labelHello.TabIndex = 4;
            this.labelHello.Text = "Hello!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Личный_кабинет_сотрудника_библиотеки.Properties.Resources._9cbca3705500971891f0503bf2e187d7;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 307);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDeal);
            this.Controls.Add(this.buttonReader);
            this.Controls.Add(this.buttonBook);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonReader;
        private System.Windows.Forms.Button buttonDeal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHello;
    }
}