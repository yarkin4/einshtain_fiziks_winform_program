using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double c = 299792458;

        double v;
        double m;
        double Vm;
        double s;
        int n = 100000000;
        double dm;
        double dt;
        double dVm;

        public Form1()
        {
            InitializeComponent();
        }


        int n1 = 1;
        int sec = 0;
        int min = 0;
        int hour = 0;
        int day = 0;
        int year = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int a = 1; a <= n1; a++)
            {
                if (sec < 60)
                {
                    sec++;
                }
                else
                {
                    sec -= 60;
                    sec++;
                    //////////
                    ////////////////
                    /////////
                    ///
                    if (min < 60)
                    {
                        min++;
                    }
                    else
                    {
                        min -= 60;
                        min++;
                        //////////
                        ////////////////
                        /////////
                        ///
                        if (hour < 24)
                        {
                            hour++;
                        }
                        else
                        {
                            hour -= 24;
                            hour++;
                            //////////
                            ////////////////
                            /////////
                            ///
                            if (day < 365)
                            {
                                day++;
                            }
                            else
                            {
                                day -= 365;
                                day++;
                                //////////
                                ////////////////
                                /////////
                                ///

                                year++;


                            }
                        }
                    }
                }
                

            }
            if (progressBar1.Value + Convert.ToInt32(v/ n) < progressBar1.Maximum)
                progressBar1.Value += Convert.ToInt32(v/ n);
            else
            {
                timer1.Enabled = false;
                label4.Visible = true;
            }
            label6.Text = Convert.ToString(sec);
            label5.Text = Convert.ToString(min);
            label7.Text = Convert.ToString(hour);
            label8.Text = Convert.ToString(day);
            label9.Text = Convert.ToString(year);


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Input data
            v = Convert.ToDouble(textBox1.Text);
            m = Convert.ToDouble(textBox2.Text);
            Vm = Convert.ToDouble(textBox3.Text);
            s = Convert.ToDouble(textBox4.Text);

            //Input to rocket1
            label26.Text = Convert.ToString(m) + "кг";
            label27.Text = Convert.ToString(Vm) + "м3";
            //Input distantion
            label28.Text = Convert.ToString(s) + "км";
            label32.Text = Convert.ToString(s) + "км";

            //Calculate
            dm = m / Math.Sqrt(1 - Math.Pow(v, 2) / Math.Pow(c, 2));
            dVm = Vm * Math.Sqrt(1 - Math.Pow(v, 2) / Math.Pow(c, 2)); 
            dt = 1 / Math.Sqrt(1 - Math.Pow(v, 2) / Math.Pow(c, 2));

            //Input rocket2
            label39.Text = Convert.ToString(v) + @"м\с";
            label37.Text = Convert.ToString(dm) + "кг";
            label36.Text = Convert.ToString(dVm) + "м3";

            //Add speed of time
            double t = 1 * dt;
            n2 = Convert.ToInt32(t);

            //progressbar
            progressBar1.Maximum = Convert.ToInt32((s * c)/ n);
            progressBar2.Maximum = Convert.ToInt32((s * c)/ n);


            timer1.Interval = 1000;
            timer2.Interval = 1000;
            
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        int n2;
        int sec2 = 0;
        int min2 = 0;
        int hour2 = 0;
        int day2 = 0;
        int year2 = 0;

        private void Timer2_Tick(object sender, EventArgs e)
        {
            for (int b = 1; b <= n2; b++)
            {

                if (sec2 != 60)
                {
                    
                    sec2++;
                }
                else
                {
                    sec2 = 0;
                    
                    sec2++;
                    //////////
                    ////////////////
                    /////////
                    ///
                    if (min2 != 60)
                    {
                        
                        min2++;
                    }
                    else
                    {
                        min2 = 0;
                        min2++;
                        //////////
                        ////////////////
                        /////////
                        ///
                        if (hour2 != 24)
                        {
                            hour2++;
                        }
                        else
                        {
                            hour2 = 0;
                            hour2++;
                            //////////
                            ////////////////
                            /////////
                            ///
                            if (day2 != 365)
                            {
                                day2++;
                            }
                            else
                            {
                                day2 = 0;
                                day2++;
                                //////////
                                ////////////////
                                /////////
                                ///

                                year2++;


                            }
                        }
                    }
                }
                if (progressBar2.Value + Convert.ToInt32(v / n) < progressBar2.Maximum)
                    progressBar2.Value += Convert.ToInt32(v / n);
                else
                {
                    timer2.Enabled = false;
                    label3.Visible = true;
                }
            }

            
            label15.Text = Convert.ToString(sec2);
            label16.Text = Convert.ToString(min2);
            label14.Text = Convert.ToString(hour2);
            label13.Text = Convert.ToString(day2);
            label12.Text = Convert.ToString(year2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
        }
    }
}
