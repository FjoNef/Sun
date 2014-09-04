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
            double[] result = Solar.Calculate((double)latitude.Value, (double)longitude.Value, (int)year.Value, (int)month.Value, (int)day.Value, (int)hour.Value, (int)minute.Value, (int)second.Value);
            SunIco.Location = new Point((int)(589 + (Math.Cos((result[2]-90) * Math.PI / 180) * (result[1] * 2.6))), (int)(247 + (Math.Sin((result[2]-90) * Math.PI / 180) * (result[1] * 2.6))));
            MessageBox.Show("Elevation is: " + result[0] + "* \nZenith Angle: " + result[1] + "* \nAzimuth :" + result[2] + "*", "Angle");
        }
    }
}