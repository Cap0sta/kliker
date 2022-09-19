using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kliker
{
    public partial class Form1 : Form
    {
        private int licznik = 0;
        private int sekundy = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //przycisk klikania
        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
            licznik++;
            button1.Text = licznik.ToString();
            
        }

    
        //timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            sekundy++;
            label1.Text = "Czas: " + sekundy.ToString();

        }

        
    }
}
