using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;
 

namespace astolfo_clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Hide();
            pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); // hides femboys
            button3.Hide(); button4.Hide(); button12.Hide(); button13.Hide(); button14.Hide(); // hides astolfo upgrade buttons
            button7.Hide(); button8.Hide(); button9.Hide(); button10.Hide(); button11.Hide(); // hides fembo upgrade buttons
            timer2.Start(); //refresh money
            label3.Hide(); //not enough money error message
            label5.Hide(); label6.Hide(); label7.Hide(); label8.Hide(); label9.Hide(); label10.Hide(); label11.Hide(); label12.Hide(); label13.Hide(); label14.Hide(); // hide prices

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
            if (button12.Enabled == false)  //+4 money 4de level
            {
                _money += 3;
            }
            if (button13.Enabled == false)  //+4 money 4de level
            {
                _money += 5;
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
                button3.Show();
                label5.Show();
                label4.Hide();
            }
            else // display not enough money ErrorMsg
            {
                label3.Show();
                timer7.Start();
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (_money > 500)                //level 3
            {
                if (button2.Enabled == false)
                {
                    button1.BackgroundImage = Properties.Resources.SaberAstolfoStage3;
                    _money -= 500;

                    button3.Visible = false;
                    button3.Enabled = false;
                    button4.Show();
                    label6.Show();
                    label5.Hide();
                }

            }
            else
            {
                label3.Show();
                timer7.Start();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_money > 1500)                //level 4
            {
                if (button3.Enabled == false)
                {

                    button1.BackgroundImage = Properties.Resources.lv4_astolfo;
                    _money -= 1500;

                    button4.Visible = false;
                    button4.Enabled = false;
                    button12.Show();
                    button7.Show();
                    label7.Show();
                    label9.Show();
                    label6.Hide();
                }
            }
            else
            {
                label3.Show();
                timer7.Start();
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
            if (_money > 3000)           //femboy lv1
            {

                timer1.Start();
                _money -= 3000;
                button7.Visible = false;
                pictureBox1.Show();
                button8.Show();
                label10.Show();
                label9.Hide();
            }
            else
            {
                label3.Show();
                timer7.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _money += 3;

        }
        private void form1_load(object sender, EventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            textBox1.Text = _money.ToString();
            if (_money > 1000000)
            {
                button14.Show();
                label14.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_money > 7500)               //femboy lv2

            {
                if (button7.Visible == false)
                {
                    timer3.Start();
                    _money -= 7500;
                    button8.Visible = false;
                    pictureBox2.Show();
                    button9.Show();
                    label11.Show();
                    label10.Hide();
                }

            }
            else
            {
                label3.Show();
                timer7.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            _money += 15;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_money > 15500)           //femboy lv3

            {
                if (button8.Visible == false)
                {
                    timer4.Start();
                    _money -= 15500;
                    button9.Visible = false;
                    pictureBox3.Show();
                    button10.Show();
                    label12.Show();
                    label11.Hide();
                }
            }
            else
            {
                label3.Show();
                timer7.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            _money += 20;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (_money > 30500)          //femboy lv4

            {
                if (button9.Visible == false)
                {
                    timer5.Start();
                    _money -= 30500;
                    button10.Visible = false;
                    pictureBox4.Show();
                    button11.Show();
                    label13.Show();
                    label12.Hide();
                }
            }
            else
            {
                label3.Show();
                timer7.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            _money += 25;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (_money > 60500)                //femboy lv5

            {
                if (button10.Visible == false)
                {
                    timer6.Start();
                    _money -= 60500;
                    button11.Visible = false;
                    pictureBox5.Show();
                    label13.Hide();
                }
            }
            else
            {
                label3.Show();
                timer7.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            _money += 35;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (_money > 5500)                //level 5
            {
                if (button2.Enabled == false)
                {
                    button1.BackgroundImage = Properties.Resources.lvl5_astolfo;
                    _money -= 5500;

                    button12.Visible = false;
                    button12.Enabled = false;
                    button13.Show();
                    label8.Show();
                    label7.Hide();
                }
            }
            else
            {
                label3.Show();
                timer7.Start();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (_money > 10500)                //level 6
            {
                if (button2.Enabled == false)
                {
                    button1.BackgroundImage = Properties.Resources.lv6_astolfo;
                    _money -= 10500;

                    button13.Visible = false;
                    button13.Enabled = false;
                    label8.Hide();
                }
            }
            else
            {
                label3.Show();
                timer7.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e) //timer not enough money error
        {
            label3.Hide();
            timer7.Stop();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (_money > 1000000)                //level 6
            {
                if (button13.Enabled == false)
                {
                    button1.BackgroundImage = Properties.Resources.rareastolf;
                    _money -= 1000000;

                    button14.Hide();
                    label14.Hide();
                }
            }
            else
            {
                label3.Show();
                timer7.Start();
            }
        }
        public DiscordRpcClient client;
        bool initialized = false;

        private void Form1_Load_1(object sender, EventArgs e)
        {
            initialized = true;
            client = new DiscordRpcClient("838795684634296371");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();
            client.SetPresence(new DiscordRPC.RichPresence()
            {
                Details = "Playing with femboys",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = "lv6_astolfo",
                    LargeImageText = "Astolfo UwU3",
                    SmallImageKey = "lv4_astolfo"
                }
            });
            
        }
    }
    }


