namespace Order_to_canteen.Forms
{
    partial class FormAddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddStudent));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.comboBoxWithDishes = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelDish = new System.Windows.Forms.Label();
            this.textBoxCountOfDays = new System.Windows.Forms.TextBox();
            this.labelCountOfDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(137)))), ((int)(((byte)(136)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Location = new System.Drawing.Point(5, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(107, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(137)))), ((int)(((byte)(136)))));
            this.textBoxMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMoney.Location = new System.Drawing.Point(136, 25);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(100, 23);
            this.textBoxMoney.TabIndex = 1;
            // 
            // comboBoxWithDishes
            // 
            this.comboBoxWithDishes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(137)))), ((int)(((byte)(136)))));
            this.comboBoxWithDishes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWithDishes.FormattingEnabled = true;
            this.comboBoxWithDishes.Location = new System.Drawing.Point(254, 25);
            this.comboBoxWithDishes.Name = "comboBoxWithDishes";
            this.comboBoxWithDishes.Size = new System.Drawing.Size(121, 23);
            this.comboBoxWithDishes.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(136, 54);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.labelName.Location = new System.Drawing.Point(5, 7);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(107, 15);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Название ученика";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.labelMoney.Location = new System.Drawing.Point(162, 7);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(46, 15);
            this.labelMoney.TabIndex = 7;
            this.labelMoney.Text = "Деньги";
            // 
            // labelDish
            // 
            this.labelDish.AutoSize = true;
            this.labelDish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.labelDish.Location = new System.Drawing.Point(292, 7);
            this.labelDish.Name = "labelDish";
            this.labelDish.Size = new System.Drawing.Size(44, 15);
            this.labelDish.TabIndex = 8;
            this.labelDish.Text = "Блюдо";
            // 
            // textBoxCountOfDays
            // 
            this.textBoxCountOfDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(137)))), ((int)(((byte)(136)))));
            this.textBoxCountOfDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCountOfDays.Location = new System.Drawing.Point(86, 54);
            this.textBoxCountOfDays.Name = "textBoxCountOfDays";
            this.textBoxCountOfDays.Size = new System.Drawing.Size(26, 23);
            this.textBoxCountOfDays.TabIndex = 9;
            // 
            // labelCountOfDays
            // 
            this.labelCountOfDays.AutoSize = true;
            this.labelCountOfDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.labelCountOfDays.Location = new System.Drawing.Point(5, 58);
            this.labelCountOfDays.Name = "labelCountOfDays";
            this.labelCountOfDays.Size = new System.Drawing.Size(75, 15);
            this.labelCountOfDays.TabIndex = 10;
            this.labelCountOfDays.Text = "Кол-во дней";
            // 
            // FormAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(387, 89);
            this.Controls.Add(this.labelCountOfDays);
            this.Controls.Add(this.textBoxCountOfDays);
            this.Controls.Add(this.labelDish);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxWithDishes);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.textBoxName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormAddStudent";
            this.Text = "Добавление ученика";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAddStudent_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.ComboBox comboBoxWithDishes;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelDish;
        private System.Windows.Forms.Label labelCountOfDays;
        private System.Windows.Forms.TextBox textBoxCountOfDays;
    }
}