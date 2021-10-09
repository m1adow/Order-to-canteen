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
    public partial class FormAddCanteen : Form
    {
        List<Canteen> canteens = new();

        public FormAddCanteen()
        {
            InitializeComponent();
        }

        private void FormAddCanteen_Load(object sender, EventArgs e)
        {
            canteens = LoadMethod<Canteen>(Settings.CanteensFileName);
            RefreshMethod();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNameOfDish.Text != null && textBoxPrice.Text != null)
                canteens.Add(new(textBoxNameOfDish.Text, Int32.Parse(textBoxPrice.Text)));
            SaveMethod(canteens);
            textBoxNameOfDish.Clear();
            textBoxPrice.Clear();
            RefreshMethod();          
        }

        private void RefreshMethod()
        {
            if (canteens.Count > 0)
            {
                listBox1.Items.Clear();
                foreach (var item in canteens)
                    listBox1.Items.Add($"Название: {item.NameOfDish}\tЦена: {item.CostOfDish} грн.");
            }
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

        private void SaveMethod(List<Canteen> listOfCanteens)
        {
            using StreamWriter sw = new($@"{Environment.CurrentDirectory}\{Settings.CanteensFileName}");
            sw.WriteLine(JsonSerializer.Serialize(listOfCanteens));
        }
    }
}