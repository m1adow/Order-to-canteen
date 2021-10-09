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
            this.buttonToCanteen = new System.Windows.Forms.Button();
            this.buttonToStudent = new System.Windows.Forms.Button();
            this.dataGridViewWithStudents = new System.Windows.Forms.DataGridView();
            this.NameOfStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyOfStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderOfStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpendMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonToCanteen
            // 
            this.buttonToCanteen.Location = new System.Drawing.Point(616, 12);
            this.buttonToCanteen.Name = "buttonToCanteen";
            this.buttonToCanteen.Size = new System.Drawing.Size(75, 23);
            this.buttonToCanteen.TabIndex = 0;
            this.buttonToCanteen.Text = "Меню";
            this.buttonToCanteen.UseVisualStyleBackColor = true;
            this.buttonToCanteen.Click += new System.EventHandler(this.buttonToCanteen_Click);
            // 
            // buttonToStudent
            // 
            this.buttonToStudent.Location = new System.Drawing.Point(697, 12);
            this.buttonToStudent.Name = "buttonToStudent";
            this.buttonToStudent.Size = new System.Drawing.Size(75, 23);
            this.buttonToStudent.TabIndex = 1;
            this.buttonToStudent.Text = "Ученики";
            this.buttonToStudent.UseVisualStyleBackColor = true;
            this.buttonToStudent.Click += new System.EventHandler(this.buttonToStudent_Click);
            // 
            // dataGridViewWithStudents
            // 
            this.dataGridViewWithStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWithStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfStudent,
            this.MoneyOfStudent,
            this.OrderOfStudent,
            this.SpendMoney});
            this.dataGridViewWithStudents.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewWithStudents.Name = "dataGridViewWithStudents";
            this.dataGridViewWithStudents.RowTemplate.Height = 25;
            this.dataGridViewWithStudents.Size = new System.Drawing.Size(598, 413);
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
            this.buttonOrder.Location = new System.Drawing.Point(616, 52);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(152, 23);
            this.buttonOrder.TabIndex = 3;
            this.buttonOrder.Text = "Создать заказ";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.dataGridViewWithStudents);
            this.Controls.Add(this.buttonToStudent);
            this.Controls.Add(this.buttonToCanteen);
            this.Name = "FormMain";
            this.Text = "Класс";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonToCanteen;
        private System.Windows.Forms.Button buttonToStudent;
        private System.Windows.Forms.DataGridView dataGridViewWithStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyOfStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderOfStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpendMoney;
        private System.Windows.Forms.Button buttonOrder;
    }
}