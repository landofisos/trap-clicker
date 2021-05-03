using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace astolfo_clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Hide();
            
        }
        private int _1;
        private int _money = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            _money += 1;                      //+1 money 1ste level
            textBox1.Text = _money.ToString();

            if (button2.Enabled == false)     //+2 money 2de level
            {
                _money += 1;
            }

            if (button3.Enabled == false)   //+3 money 3de level
            {
                _money += 1;
            }
            if (button4.Enabled == false)  //+4 money 4de level
            {
                _money += 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_money > 200)                //level 2
            {

                button1.BackgroundImage = Properties.Resources.lv2_astolfo;
                _money -= 200;

                button2.Visible = false;
                button2.Enabled = false;
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (_money > 500)                //level 3
            {

                button1.BackgroundImage = Properties.Resources.SaberAstolfoStage3;
                _money -= 500;

                button3.Visible = false;
                button3.Enabled = false;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_money > 1500)                //level 4
            {

                button1.BackgroundImage = Properties.Resources.lv4_astolfo;
                _money -= 1500;

                button4.Visible = false;
                button4.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_money > 3000)
            {
                timer1.Start();
                _money -= 3000;
                button7.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _money += 5;
        }
    }
}
