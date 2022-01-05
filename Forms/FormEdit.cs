using Order_to_canteen.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Order_to_canteen.Forms
{
    public partial class FormEdit : Form
    {
        //variables
        List<Student> students = new();
        List<Canteen> canteens = new();
        string name = string.Empty;

        public FormEdit()
        {
            InitializeComponent();

            labelValue.Visible = false;
            textBoxSetValue.Visible = false;
            labelValueForComboBox.Visible = false;
            comboBoxSetValue.Visible = false;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            students = LoadMethod<Student>(Settings.StudentFileName);
            canteens = LoadMethod<Canteen>(Settings.CanteensFileName);
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

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            name = textBoxSearch.Text;
        }

        private void ClearFields()
        {
            textBoxSearch.Clear();
            textBoxSetValue.Clear();
            comboBoxSetValue.SelectedIndex = -1;
            comboBoxTakeElement.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSetValue.Visible = false;
            labelValue.Visible = false;
            comboBoxSetValue.Visible = false;
            labelValueForComboBox.Visible = false;
            comboBoxSetValue.Items.Clear();

            switch (comboBoxTakeElement.SelectedIndex)
            {
                case 0:
                    textBoxSetValue.Visible = true;
                    labelValue.Visible = true;
                    break;
                case 1:
                    textBoxSetValue.Visible = true;
                    labelValue.Visible = true;
                    break;
                case 2:
                    comboBoxSetValue.Visible = true;
                    labelValueForComboBox.Visible = true;
                    canteens.ForEach(a => comboBoxSetValue.Items.Add(a.NameOfDish));                    
                    break;
                case 3:
                    comboBoxSetValue.Visible = true;
                    labelValueForComboBox.Visible = true;
                    comboBoxSetValue.Items.Add("Присутній");
                    comboBoxSetValue.Items.Add("Відсутній");
                    break;
                case 4:
                    comboBoxSetValue.Visible = true;
                    labelValueForComboBox.Visible = true;
                    comboBoxSetValue.Items.Add("Присутній");
                    comboBoxSetValue.Items.Add("Відсутній");
                    break;
                case 5:
                    comboBoxSetValue.Visible = true;
                    labelValueForComboBox.Visible = true;
                    comboBoxSetValue.Items.Add("Присутній");
                    comboBoxSetValue.Items.Add("Відсутній");
                    break;
                case 6:
                    comboBoxSetValue.Visible = true;
                    labelValueForComboBox.Visible = true;
                    comboBoxSetValue.Items.Add("Присутній");
                    comboBoxSetValue.Items.Add("Відсутній");
                    break;
                case 7:
                    comboBoxSetValue.Visible = true;
                    labelValueForComboBox.Visible = true;
                    comboBoxSetValue.Items.Add("Присутній");
                    comboBoxSetValue.Items.Add("Відсутній");
                    break;
            }                
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (students.Any(a => a.Name.Contains(name)))
                {
                    int index = students.FindIndex(a => a.Name.Contains(name));

                    switch (comboBoxTakeElement.SelectedIndex)
                    {
                        case 0:
                            students[index].Name = textBoxSetValue.Text;
                            break;
                        case 1:
                            int.TryParse(textBoxSetValue.Text, out int result);
                            students[index].Money = result;
                            break;
                        case 2:
                            students[index].Order = comboBoxSetValue.SelectedItem.ToString();
                            students[index].CostOfOrder = canteens.FirstOrDefault(a => a.NameOfDish == comboBoxSetValue.SelectedItem.ToString()).CostOfDish;
                            break;
                        case 3:
                            if (comboBoxSetValue.SelectedItem.ToString() == "Відсутній")
                                students[index].Monday = false;
                            else
                                students[index].Monday = true;
                            break;
                        case 4:
                            if (comboBoxSetValue.SelectedItem.ToString() == "Відсутній")
                                students[index].Tuesday = false;
                            else
                                students[index].Tuesday = true;
                            break;
                        case 5:
                            if (comboBoxSetValue.SelectedItem.ToString() == "Відсутній")
                                students[index].Wednesday = false;
                            else
                                students[index].Wednesday = true;
                            break;
                        case 6:
                            if (comboBoxSetValue.SelectedItem.ToString() == "Відсутній")
                                students[index].Thursday = false;
                            else
                                students[index].Thursday = true;
                            break;
                        case 7:
                            if (comboBoxSetValue.SelectedItem.ToString() == "Відсутній")
                                students[index].Friday = false;
                            else
                                students[index].Friday = true;
                            break;
                    }
                }
                ClearFields();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, "Помилка!", MessageBoxButtons.OK); }
        }

        private void FormEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveMethod(students);
        }

        private void comboBoxSetValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}