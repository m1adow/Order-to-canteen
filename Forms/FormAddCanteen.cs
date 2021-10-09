using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
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
            try
            {
                if (textBoxNameOfDish.Text != null && textBoxPrice.Text != null)
                    canteens.Add(new(textBoxNameOfDish.Text, Int32.Parse(textBoxPrice.Text)));                
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, "Ошибка!", MessageBoxButtons.OK); }

            SaveMethod(canteens);
            textBoxNameOfDish.Clear();
            textBoxPrice.Clear();
            RefreshMethod();
        }

        //show all data in listbox
        private void RefreshMethod()
        { 
            listBoxWithDishes.Items.Clear();

            if (canteens.Count > 0)
            {               
                foreach (var item in canteens)
                    listBoxWithDishes.Items.Add($"Название: {item.NameOfDish} Цена: {item.CostOfDish} грн.");
            }
        }

        //load data to list from .json file
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
        private void SaveMethod(List<Canteen> listOfCanteens)
        {
            using StreamWriter sw = new($@"{Environment.CurrentDirectory}\{Settings.CanteensFileName}");
            sw.WriteLine(JsonSerializer.Serialize(listOfCanteens));
        }

        //delete data from listbox and list
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxWithDishes.SelectedIndex;

            if(index > -1)            
                canteens.RemoveAt(index);

            SaveMethod(canteens);
            RefreshMethod();
        }

        //press "Enter" for add or "Delete" for delete
        private void FormAddCanteen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
                buttonAdd.PerformClick();
            if (e.KeyValue == (char)Keys.Delete)
                buttonDelete.PerformClick();
        }
    }
}