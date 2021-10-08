using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_to_canteen.Forms
{
    public partial class FormAddStudent : Form
    {
        List<Student> _students = new();

        public FormAddStudent()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
