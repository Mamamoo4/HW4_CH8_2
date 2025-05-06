using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ch8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void bubbleSort(int[] data)
        {
            int i, j, len, temp;
            len = data.GetUpperBound(0);
            for (i = len; i >= 0; i--)
                for (j = 0; j <= (len - 1); j++)
                    if (data[j + 1] < data[j])
                    {
                        temp = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = temp;
                    }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] data = new int[5];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(1, 200);
            }
            bubbleSort(data);
            label1.Text = $"{data[0]} . {data[1]} . {data[2]} . {data[3]} . {data[4]} ";
        }    
    }
}
