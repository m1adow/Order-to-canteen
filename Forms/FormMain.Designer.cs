namespace Order_to_canteen.Forms
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonToCanteen = new System.Windows.Forms.Button();
            this.buttonToStudent = new System.Windows.Forms.Button();
            this.dataGridViewWithStudents = new System.Windows.Forms.DataGridView();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.NameOfStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyOfStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderOfStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpendMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Понедельник = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Вторник = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Среда = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Четверг = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Пятница = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonToCanteen
            // 
            this.buttonToCanteen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.buttonToCanteen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToCanteen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToCanteen.Location = new System.Drawing.Point(1112, 16);
            this.buttonToCanteen.Name = "buttonToCanteen";
            this.buttonToCanteen.Size = new System.Drawing.Size(75, 52);
            this.buttonToCanteen.TabIndex = 0;
            this.buttonToCanteen.Text = "Меню";
            this.buttonToCanteen.UseVisualStyleBackColor = false;
            this.buttonToCanteen.Click += new System.EventHandler(this.buttonToCanteen_Click);
            // 
            // buttonToStudent
            // 
            this.buttonToStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.buttonToStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToStudent.Location = new System.Drawing.Point(1193, 16);
            this.buttonToStudent.Name = "buttonToStudent";
            this.buttonToStudent.Size = new System.Drawing.Size(75, 52);
            this.buttonToStudent.TabIndex = 1;
            this.buttonToStudent.Text = "Учні";
            this.buttonToStudent.UseVisualStyleBackColor = false;
            this.buttonToStudent.Click += new System.EventHandler(this.buttonToStudent_Click);
            // 
            // dataGridViewWithStudents
            // 
            this.dataGridViewWithStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(137)))), ((int)(((byte)(136)))));
            this.dataGridViewWithStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWithStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfStudent,
            this.MoneyOfStudent,
            this.OrderOfStudent,
            this.SpendMoney,
            this.Понедельник,
            this.Вторник,
            this.Среда,
            this.Четверг,
            this.Пятница});
            this.dataGridViewWithStudents.Location = new System.Drawing.Point(12, 16);
            this.dataGridViewWithStudents.Name = "dataGridViewWithStudents";
            this.dataGridViewWithStudents.RowTemplate.Height = 25;
            this.dataGridViewWithStudents.Size = new System.Drawing.Size(1094, 586);
            this.dataGridViewWithStudents.TabIndex = 2;
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.buttonOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Location = new System.Drawing.Point(1112, 132);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(156, 52);
            this.buttonOrder.TabIndex = 3;
            this.buttonOrder.Text = "Створити замовлення";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(1112, 190);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(156, 52);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(1112, 74);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(156, 52);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Змінити";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // NameOfStudent
            // 
            this.NameOfStudent.HeaderText = "Прізвище Ім\'я";
            this.NameOfStudent.Name = "NameOfStudent";
            this.NameOfStudent.ReadOnly = true;
            this.NameOfStudent.Width = 200;
            // 
            // MoneyOfStudent
            // 
            this.MoneyOfStudent.HeaderText = "Кількість грошей";
            this.MoneyOfStudent.Name = "MoneyOfStudent";
            this.MoneyOfStudent.ReadOnly = true;
            // 
            // OrderOfStudent
            // 
            this.OrderOfStudent.HeaderText = "Замовлення";
            this.OrderOfStudent.Name = "OrderOfStudent";
            this.OrderOfStudent.ReadOnly = true;
            this.OrderOfStudent.Width = 150;
            // 
            // SpendMoney
            // 
            this.SpendMoney.HeaderText = "Залишок/Борг";
            this.SpendMoney.Name = "SpendMoney";
            this.SpendMoney.ReadOnly = true;
            // 
            // Понедельник
            // 
            this.Понедельник.HeaderText = "Понеділок";
            this.Понедельник.Name = "Понедельник";
            this.Понедельник.ReadOnly = true;
            // 
            // Вторник
            // 
            this.Вторник.HeaderText = "Вівторок";
            this.Вторник.Name = "Вторник";
            this.Вторник.ReadOnly = true;
            // 
            // Среда
            // 
            this.Среда.HeaderText = "Середа";
            this.Среда.Name = "Среда";
            this.Среда.ReadOnly = true;
            // 
            // Четверг
            // 
            this.Четверг.HeaderText = "Четвер";
            this.Четверг.Name = "Четверг";
            this.Четверг.ReadOnly = true;
            // 
            // Пятница
            // 
            this.Пятница.HeaderText = "П\'ятниця";
            this.Пятница.Name = "Пятница";
            this.Пятница.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1275, 631);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewWithStudents);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonToStudent);
            this.Controls.Add(this.buttonToCanteen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Text = "Клас";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonToCanteen;
        private System.Windows.Forms.Button buttonToStudent;
        private System.Windows.Forms.DataGridView dataGridViewWithStudents;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyOfStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderOfStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpendMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn Понедельник;
        private System.Windows.Forms.DataGridViewTextBoxColumn Вторник;
        private System.Windows.Forms.DataGridViewTextBoxColumn Среда;
        private System.Windows.Forms.DataGridViewTextBoxColumn Четверг;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пятница;
    }
}