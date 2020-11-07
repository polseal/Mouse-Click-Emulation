using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mouse_Click_Emulation;

namespace Mouse_Click_Emulation
{
    public partial class Form1 : Form
    {
        private int _counter;

        public Form1()
        {
            
            InitializeComponent();
            this.timer1.Enabled = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            if (this.timer1.Enabled)
            { this.timer1.Start(); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                _counter++;
                this.textBox1.Text = "0:" + (_counter / 60).ToString("00") + ":"  + ( _counter - ((_counter / 60) * 60)).ToString("00");
                if (_counter % 120 == 0)
                {
                    Mouse_Click_Emulation.MouseClickEmulator.MouseClickEvent();
                }
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.timer1.Enabled = false;
        }
    }
}
