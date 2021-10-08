using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Order_to_canteen.Models;

namespace Order_to_canteen.Forms
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        List<Canteen> canteens = new();
        List<Student> students = new();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            canteens = LoadMethod<Canteen>(Settings.CanteensFileName);
            students = LoadMethod<Student>(Settings.StudentFileName);
        }

        private void buttonToCanteen_Click(object sender, EventArgs e)
        {
            FormAddCanteen formAddCanteen = new();
            formAddCanteen.Show();
            formAddCanteen.FormClosed += FormAddCanteen_FormClosed;
        }

        private void FormAddCanteen_FormClosed(object sender, FormClosedEventArgs e)
        {
            canteens = LoadMethod<Canteen>(Settings.CanteensFileName);
        }

        private void buttonToStudent_Click(object sender, EventArgs e)
        {
            FormAddStudent formAddStudent = new();
            formAddStudent.Show();
            formAddStudent.FormClosed += FormAddStudent_FormClosed;
        }

        private void FormAddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            students = LoadMethod<Student>(Settings.StudentFileName);
        }

        private List<T> LoadMethod<T>(string fileName)
        {
            try
            {
                using StreamReader sr = new($@"{Environment.CurrentDirectory}\{fileName}");
                List<T> listOfCanteens = JsonSerializer.Deserialize<List<T>>(sr.ReadLine());
                return listOfCanteens;
            }
            catch { }

            return new List<T>();
        }
    }
}
