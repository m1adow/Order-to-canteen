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
            this.NameOfStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyOfStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderOfStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpendMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonToCanteen
            // 
            this.buttonToCanteen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.buttonToCanteen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToCanteen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToCanteen.Location = new System.Drawing.Point(616, 12);
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
            this.buttonToStudent.Location = new System.Drawing.Point(697, 12);
            this.buttonToStudent.Name = "buttonToStudent";
            this.buttonToStudent.Size = new System.Drawing.Size(75, 52);
            this.buttonToStudent.TabIndex = 1;
            this.buttonToStudent.Text = "Ученики";
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
            this.SpendMoney});
            this.dataGridViewWithStudents.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewWithStudents.Name = "dataGridViewWithStudents";
            this.dataGridViewWithStudents.RowTemplate.Height = 25;
            this.dataGridViewWithStudents.Size = new System.Drawing.Size(598, 586);
            this.dataGridViewWithStudents.TabIndex = 2;
            // 
            // NameOfStudent
            // 
            this.NameOfStudent.HeaderText = "Имя Фамиллия";
            this.NameOfStudent.Name = "NameOfStudent";
            this.NameOfStudent.ReadOnly = true;
            this.NameOfStudent.Width = 200;
            // 
            // MoneyOfStudent
            // 
            this.MoneyOfStudent.HeaderText = "Количество денег";
            this.MoneyOfStudent.Name = "MoneyOfStudent";
            this.MoneyOfStudent.ReadOnly = true;
            // 
            // OrderOfStudent
            // 
            this.OrderOfStudent.HeaderText = "Заказ";
            this.OrderOfStudent.Name = "OrderOfStudent";
            this.OrderOfStudent.ReadOnly = true;
            this.OrderOfStudent.Width = 150;
            // 
            // SpendMoney
            // 
            this.SpendMoney.HeaderText = "Остаток/Долг";
            this.SpendMoney.Name = "SpendMoney";
            this.SpendMoney.ReadOnly = true;
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.buttonOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Location = new System.Drawing.Point(616, 128);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(156, 52);
            this.buttonOrder.TabIndex = 3;
            this.buttonOrder.Text = "Создать заказ";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(616, 186);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(156, 52);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(616, 70);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(156, 52);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(782, 631);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewWithStudents);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonToStudent);
            this.Controls.Add(this.buttonToCanteen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Text = "Класс";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyOfStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderOfStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpendMoney;
        private System.Windows.Forms.Button buttonEdit;
    }
}