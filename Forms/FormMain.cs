using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using Order_to_canteen.Models;

namespace Order_to_canteen.Forms
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        //list with datas
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
            RefreshMethod();
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
            RefreshMethod();
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
            RefreshMethod();
        }

        //load data from .json file
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

        //save data to .json file
        private void SaveMethod(List<Student> listOfStudents)
        {
            using StreamWriter sw = new($@"{Environment.CurrentDirectory}\{Settings.StudentFileName}");
            sw.WriteLine(JsonSerializer.Serialize(listOfStudents));
        }

        //show data in control
        private void RefreshMethod()
        {
            dataGridViewWithStudents.Rows.Clear();
            foreach (var item in students)
                dataGridViewWithStudents.Rows.Add(item.Name, item.Money, item.Order, item.SpendMoney());                   
        }

        //count price of all dishes
        private string CountPrices()
        {
            return $"Общая сумма: {students.Sum(a => a.PriceOfOrder)/7} грн.";
        }

        //count the amount the same dishes
        private string CountOrders()
        {
            string text = "";
            foreach (var item in canteens)           
                text += $"Блюдо: {item.NameOfDish}. Количество - {students.Count(a => a.Order.Contains(item.NameOfDish))}.{Environment.NewLine}";
            return text;
        }

        //show prepared order to canteen
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CountOrders() + "\n" + CountPrices(), "Заказ", MessageBoxButtons.OK);
        }

        //delete data from 1 row and from .json file
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int? index = dataGridViewWithStudents?.CurrentRow?.Index;

            if(index == null) { return; }

            if (dataGridViewWithStudents.Rows[(int)index].Cells[0].Value != null)
                students.RemoveAt((int)index);
            SaveMethod(students);
            RefreshMethod();
        }

        //press "Enter" for add or "Delete" for delete
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
                buttonOrder_Click(buttonOrder, null);
            if (e.KeyValue == (char)Keys.Delete)
                buttonDelete_Click(buttonDelete, null);
        }
    }
}