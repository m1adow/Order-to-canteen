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
    public partial class FormAddStudent : Form
    {
        List<Student> students = new();
        List<Canteen> canteens = new();

        public FormAddStudent()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            try
            {
                students = LoadMethod<Student>(Settings.StudentFileName);
                canteens = LoadMethod<Canteen>(Settings.CanteensFileName);              
            }
            catch { }

            foreach (var item in canteens)
                comboBoxWithDishes.Items.Add(item.NameOfDish);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int index = comboBoxWithDishes.SelectedIndex;

            if (textBoxMoney.Text != null && textBoxName.Text != null && comboBoxWithDishes.SelectedIndex > -1)
                students.Add(new(textBoxName.Text, Int32.Parse(textBoxMoney.Text), comboBoxWithDishes.Text, canteens[index].CostOfDish));
            SaveMethod(students);
            textBoxMoney.Clear();
            textBoxName.Clear();
            comboBoxWithDishes.SelectedIndex = -1;                  
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

        private void SaveMethod(List<Student> listOfStudents)
        {
            using StreamWriter sw = new($@"{Environment.CurrentDirectory}\{Settings.StudentFileName}");
            sw.WriteLine(JsonSerializer.Serialize(listOfStudents));
        }
    }
}