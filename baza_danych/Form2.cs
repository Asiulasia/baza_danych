using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace projekt9
{
    public partial class Form2 : Form
    {
        public Form2(DataTable data)
        {
            InitializeComponent();

            BindingSource SBind = new BindingSource();
            SBind.DataSource = data;


            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = data;

            dataGridView1.DataSource = SBind;
            dataGridView1.Refresh();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
