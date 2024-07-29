using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traffic_light_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        int counter1 = 0;
        int counter11 = 0;
        int counter2 = 0;
        int counter3 = 0;
        int counter4 = 0;
    

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "1")
            {
                pictureBox1.Visible = true;
                 counter1= 10;
                label1.Text = counter1.ToString();
            }
            else
                if (comboBox2.Text == "2")
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    counter1 = 13;
                    label1.Text = counter1.ToString(); 

                }
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter1 = counter1 - 1;
            counter11 = counter11 + 1;
            label1.Text = counter1.ToString();
            if (counter11 >= 1 && counter11 <= 2)
            {
                this.ovalShape1.BackColor = Color.Yellow;
            }
            else
                if (counter11 > 2 && counter1 >= 2)
                {
                    this.ovalShape1.BackColor = Color.Green;
                    if (pictureBox1.Visible == true)
                    {
                        pictureBox1.Left += 40;
                    }
                        if (pictureBox2.Visible == true)
                        {
                            pictureBox2.Left += 40;
                        }

                   

                }
                else
                    if (label1.Text == "0")
                    {
                        this.ovalShape1.BackColor = Color.Red;
                        timer1.Stop();
                        timer2.Start();
                        counter11 = 0;

                    }
        }

        private void btnstart_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            timer5.Start();
            timer6.Start();
            timer7.Start();
            timer8.Start();
           
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left >= 339)
            {
                pictureBox1.Visible = false;
                pictureBox7.Visible = true;
                pictureBox7.Top -= 20;
              
            }
            if (pictureBox2.Left >= 339)
            {
               
                pictureBox2.Left += 40;
            }
           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1")
            {
                pictureBox4.Visible = true;
                counter2 = 10;
                label2.Text = counter2.ToString();
            }
            if (comboBox1.Text == "2")
            {
                pictureBox9.Visible = true;
                counter2 = 13;
                label2.Text = counter2.ToString();
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter2 = counter2 - 1;
            counter11 = counter11 + 1;
            label2.Text = counter2.ToString();
            if (counter11 >= 1 && counter11 <= 2)
            {
                this.ovalShape2.BackColor = Color.Yellow;
            }
            else
                if (counter11 > 2 && counter2 >= 2)
                {
                    this.ovalShape2.BackColor = Color.Green;
                    if (pictureBox4.Visible == true)
                    {
                        pictureBox4.Top+= 50;
                    }
                    if (pictureBox9.Visible == true)
                    {
                        pictureBox9.Top += 50;
                    }
                   
                }
                else
                    if (label2.Text == "0")
                    {
                        this.ovalShape2.BackColor = Color.Red;
                        timer2.Stop();
                        timer3.Start();
                        counter11 = 0;

                    }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if(pictureBox4.Top>=283)
            {
                pictureBox4.Top +=50;
            }
            if (pictureBox9.Top >= 275)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
                pictureBox10.Left -= 50;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "1")
            {
                pictureBox5.Visible = true;
                counter3 = 10;
                label4.Text = counter3.ToString();
            }
            else
                if (comboBox3.Text == "2")
                {
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    counter3 = 15;
                    label4.Text = counter3.ToString();

                }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            counter3 = counter3 - 1;
            counter11 = counter11 + 1;
            label4.Text = counter3.ToString();
            if (counter11 >= 1 && counter11 <= 2)
            {
                this.ovalShape3.BackColor = Color.Yellow;
            }
            else
                if (counter11 > 2 && counter3 >= 2)
                {
                    this.ovalShape3.BackColor = Color.Green;
                    if (pictureBox5.Visible == true)
                    {
                        pictureBox5.Left -= 40;

                    }
                    
                        if (pictureBox6.Visible == true)
                        {
                            pictureBox6.Left -= 40;
                        }

                }
                else
                    if (label4.Text == "0")
                    {
                        this.ovalShape3.BackColor = Color.Red;
                        timer3.Stop();
                        timer4.Start();
                        counter11 = 0;

                    }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (pictureBox5.Left <= 470) 
            {
                pictureBox5.Visible = false;
                pictureBox8.Visible = true;
                pictureBox8.Top -= 40;
            }
            if(pictureBox6.Left<=470)
            {
                pictureBox6.Left-=40;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text =="1")
            {
                pictureBox3.Visible = true;
                counter4 = 10;
                label3.Text = counter4.ToString();
            }
            if (comboBox4.Text == "2")
            {
                pictureBox11.Visible = true;
                counter4 = 13;
                label3.Text = counter4.ToString();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            counter4 = counter4 - 1;
            counter11 = counter11 + 1;
            label3.Text = counter4.ToString();
            if (counter11 >= 1 && counter11 <= 2)
            {
                this.ovalShape4.BackColor = Color.Yellow;
            }
            else
                if (counter11 > 2 && counter4 >= 2)
                {
                    this.ovalShape4.BackColor = Color.Green;
                    if (pictureBox3.Visible == true)
                    {
                        pictureBox3.Top -= 40;

                    }
                    if (pictureBox11.Visible == true)
                    {
                        pictureBox11.Top -= 40;

                    }
                  

                }
                else
                    if (label3.Text == "0")
                    {
                        this.ovalShape4.BackColor = Color.Red;
                        timer4.Stop();
                        //imer2.Start();
                        counter11 = 0;

                    }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Top <= 267)
            {
                pictureBox3.Top -= 40;
            }
            if (pictureBox11.Top <= 267)
            {
                pictureBox11.Visible = false;
                pictureBox12.Visible = true;
                pictureBox12.Left+= 40;
            }
        }
    }
}
