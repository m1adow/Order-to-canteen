using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_to_canteen
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

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNameOfDish.Text != null)
                canteens.Add(new(textBoxNameOfDish.Text));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (canteens.Count > 0)
                foreach (var item in canteens)
                    listBox1.Items.Add(item.NameOfDish);
        }
    }
}
