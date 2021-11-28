namespace Order_to_canteen.Forms
{
    partial class FormEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdit));
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.comboBoxTakeElement = new System.Windows.Forms.ComboBox();
            this.labelElement = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxSetValue = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.comboBoxSetValue = new System.Windows.Forms.ComboBox();
            this.labelValueForComboBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(137)))), ((int)(((byte)(136)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Location = new System.Drawing.Point(12, 21);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 23);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.labelSearch.Location = new System.Drawing.Point(42, 3);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(42, 15);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Поиск";
            // 
            // comboBoxTakeElement
            // 
            this.comboBoxTakeElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTakeElement.FormattingEnabled = true;
            this.comboBoxTakeElement.Items.AddRange(new object[] {
            "Название ученика",
            "Количество денег",
            "Заказ",
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница"});
            this.comboBoxTakeElement.Location = new System.Drawing.Point(128, 21);
            this.comboBoxTakeElement.Name = "comboBoxTakeElement";
            this.comboBoxTakeElement.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTakeElement.TabIndex = 2;
            this.comboBoxTakeElement.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelElement
            // 
            this.labelElement.AutoSize = true;
            this.labelElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.labelElement.Location = new System.Drawing.Point(163, 3);
            this.labelElement.Name = "labelElement";
            this.labelElement.Size = new System.Drawing.Size(54, 15);
            this.labelElement.TabIndex = 3;
            this.labelElement.Text = "Элемент";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(42, 96);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(175, 35);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxSetValue
            // 
            this.textBoxSetValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(137)))), ((int)(((byte)(136)))));
            this.textBoxSetValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSetValue.Location = new System.Drawing.Point(42, 67);
            this.textBoxSetValue.Name = "textBoxSetValue";
            this.textBoxSetValue.Size = new System.Drawing.Size(175, 23);
            this.textBoxSetValue.TabIndex = 5;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.labelValue.Location = new System.Drawing.Point(78, 49);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(104, 15);
            this.labelValue.TabIndex = 6;
            this.labelValue.Text = "Введите значение";
            // 
            // comboBoxSetValue
            // 
            this.comboBoxSetValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSetValue.FormattingEnabled = true;
            this.comboBoxSetValue.Location = new System.Drawing.Point(42, 67);
            this.comboBoxSetValue.Name = "comboBoxSetValue";
            this.comboBoxSetValue.Size = new System.Drawing.Size(175, 23);
            this.comboBoxSetValue.TabIndex = 7;
            // 
            // labelValueForComboBox
            // 
            this.labelValueForComboBox.AutoSize = true;
            this.labelValueForComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.labelValueForComboBox.Location = new System.Drawing.Point(78, 49);
            this.labelValueForComboBox.Name = "labelValueForComboBox";
            this.labelValueForComboBox.Size = new System.Drawing.Size(114, 15);
            this.labelValueForComboBox.TabIndex = 8;
            this.labelValueForComboBox.Text = "Выберете значение";
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(259, 143);
            this.Controls.Add(this.labelValueForComboBox);
            this.Controls.Add(this.comboBoxSetValue);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.textBoxSetValue);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelElement);
            this.Controls.Add(this.comboBoxTakeElement);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEdit";
            this.Text = "Изменение";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEdit_FormClosing);
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ComboBox comboBoxTakeElement;
        private System.Windows.Forms.Label labelElement;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxSetValue;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.ComboBox comboBoxSetValue;
        private System.Windows.Forms.Label labelValueForComboBox;
    }
}