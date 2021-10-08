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
            this.SuspendLayout();
            // 
            // buttonToCanteen
            // 
            this.buttonToCanteen.Location = new System.Drawing.Point(632, 12);
            this.buttonToCanteen.Name = "buttonToCanteen";
            this.buttonToCanteen.Size = new System.Drawing.Size(75, 23);
            this.buttonToCanteen.TabIndex = 0;
            this.buttonToCanteen.Text = "Меню";
            this.buttonToCanteen.UseVisualStyleBackColor = true;
            this.buttonToCanteen.Click += new System.EventHandler(this.buttonToCanteen_Click);
            // 
            // buttonToStudent
            // 
            this.buttonToStudent.Location = new System.Drawing.Point(713, 12);
            this.buttonToStudent.Name = "buttonToStudent";
            this.buttonToStudent.Size = new System.Drawing.Size(75, 23);
            this.buttonToStudent.TabIndex = 1;
            this.buttonToStudent.Text = "Ученики";
            this.buttonToStudent.UseVisualStyleBackColor = true;
            this.buttonToStudent.Click += new System.EventHandler(this.buttonToStudent_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonToStudent);
            this.Controls.Add(this.buttonToCanteen);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonToCanteen;
        private System.Windows.Forms.Button buttonToStudent;
    }
}