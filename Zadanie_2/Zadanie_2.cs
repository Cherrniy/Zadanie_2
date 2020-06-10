using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_2
{
    public partial class Zadanie_2 : Form
    {
        public Zadanie_2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double z1 = 0, z2 = 0;
            int b = 359;
            this.chart1.Series[0].Points.Clear();
            
            for (int i = 0; i < b; i++)
            {
                z1 = Math.Sqrt(2 * i + 2 * Math.Sqrt(Math.Pow(i, 2) - 4))
                    / (i + 2 + Math.Sqrt(i * i - 4));
                this.chart1.Series[0].Points.AddXY(i, z1);
                z2 = (1) / (Math.Sqrt(i + 2));
                this.chart1.Series[1].Points.AddXY(i, z2);
            }
        }

    }
}
