using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sun
{
    public partial class Form1 : Form
    {
        Sun Solar;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Solar = new Sun();
            double result = Solar.Calculate(longitude.Value, date.Value, time.Value, (int)dTime.Value);
            MessageBox.Show("Angle is: " + Math.Truncate(result) + "* " + Math.Truncate(Math.Abs((result - Math.Truncate(result)) * 60.0)) + "'", "Angle");
        }
    }
}
