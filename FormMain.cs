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
    public partial class FormMain : System.Windows.Forms.Form
    {
        List<Canteen> _canteens = new()
        {
            new Canteen("Пицца"),
            new Canteen("Порция"),
            new Canteen("Чай")
        };

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
