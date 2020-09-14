using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        int one = 1;
        int two = 2;
        int three = 3;
        int four = 4;
        int five = 5;
        int six = 6;
        int sev = 7;
        int eigh = 8;
        int nine = 9;
        int zero = 0;
        int[] numbs = { };
        int x;
        int y;
        List<string> division = new List<string>(2);
        List<string> subtraction = new List<string>(2);
        List<string> multi = new List<string>(2);
        List<string> addition = new List<string>(2);
        List<string> equal = new List<string>(2);

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            this.KeyPreview = true;
        }



        private double multipInt(double x, double y)
        {
            double sum1 = x;
            double sum2 = y;
            double taskm;
            taskm = sum1 * sum2;
            return taskm;
        }

        private double addInt(double x, double y)
        {
            double sum1 = x;
            double sum2 = y;
            double taska;
            taska = sum1 + sum2;
            return taska;

        }

        private double subtractInt(double x, double y)
        {
            double sum1 = x;
            double sum2 = y;
            double tasks;
            tasks = sum1 - sum2;
            return tasks;
        }

        private double divideInt(double x, double y)
        {
            double sum1 = x;
            double sum2 = y;
            double taskd;
            taskd = sum1 / sum2;
            return taskd;
        }

        private double percentInt(double x)
        {
            double myDouble = x;
            return myDouble / 100;
        }

        private double convertInt(double x)
        {
            double num = x;
            return num = num * -1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (equal.Count > 0)
            {
                equal.Clear();
                textBox1.Text = "0";
            };

            if (textBox1.Text == "0")
            {
                this.textBox1.ResetText();
                textBox1.Text = textBox1.Text + Convert.ToString(one);
            }

            else if (textBox1.Text == "0.")
            {
                textBox1.Text = textBox1.Text + Convert.ToString(one);
            }

            else
            {
                textBox1.Text = textBox1.Text + Convert.ToString(one);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (equal.Count > 0)
            {
                equal.Clear();
                textBox1.Text = "0";
            };

            if (textBox1.Text == "0")
            {
                this.textBox1.ResetText();
                textBox1.Text = textBox1.Text + Convert.ToString(two);
            }
           
            else if (textBox1.Text == "0.")
            {
                textBox1.Text = textBox1.Text + Convert.ToString(two);
            }
           
            else
            {
                textBox1.Text = textBox1.Text + Convert.ToString(two);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (equal.Count > 0)
            {
                equal.Clear();
                textBox1.Text = "0";
            };
          
            if (textBox1.Text == "0")
            {
                this.textBox1.ResetText();
                textBox1.Text = textBox1.Text + Convert.ToString(three);
            }
            
            else if (textBox1.Text == "0.")
            {
                textBox1.Text = textBox1.Text + Convert.ToString(three);
            }
            
            else
            {
                textBox1.Text = textBox1.Text + Convert.ToString(three);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (equal.Count > 0)
            {
                equal.Clear();
                textBox1.Text = "0";
            };

            if (textBox1.Text == "0")
            {
                this.textBox1.ResetText();
                textBox1.Text = textBox1.Text + Convert.ToString(four);
            }

            else if (textBox1.Text == "0.")
            {
                textBox1.Text = textBox1.Text + Convert.ToString(four);
            }

            else
            {
                textBox1.Text = textBox1.Text + Convert.ToString(four);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (equal.Count > 0)
            {
                equal.Clear();
                textBox1.Text = "0";
            };
           
            if (textBox1.Text == "0")
            {
                this.textBox1.ResetText();
                textBox1.Text = textBox1.Text + Convert.ToString(five);
            }

            else if (textBox1.Text == "0.")
            {
                textBox1.Text = textBox1.Text + Convert.ToString(five);
            }

            else
            {
                textBox1.Text = textBox1.Text + Convert.ToString(five);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (equal.Count > 0)
            {
                equal.Clear();
                textBox1.Text = "0";
            };
           
            if (textBox1.Text == "0")
            {
                this.textBox1.ResetText();
                textBox1.Text = textBox1.Text + Convert.ToString(six);
            }

            else if (textBox1.Text == "0.")
            {
                textBox1.Text = textBox1.Text + Convert.ToString(six);
            }

            else
            {
                textBox1.Text = textBox1.Text + Convert.ToString(six);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (equal.Count > 0)
            {
                equal.Clear();
                textBox1.Text = "0";
            };

            if (textBox1.Text == "0")
            {
                this.textBox1.ResetText();
                textBox1.Text = textBox1.Text + Convert.ToString(sev);
            }

            else if (textBox1.Text == "0.")
            {
                textBox1.Text = textBox1.Text + Convert.ToString(sev);
            }

            else
            {
                textBox1.Text = textBox1.Text + Convert.ToString(sev);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (equal.Count > 0)
            {
                equal.Clear();
                textBox1.Text = "0";
            };

            if (textBox1.Text == "0")
            {
                this.textBox1.ResetText();
                textBox1.Text = textBox1.Text + Convert.ToString(eigh);
            }

            else if (textBox1.Text == "0.")
            {
                textBox1.Text = textBox1.Text + Convert.ToString(eigh);
            }

            else
            {
                textBox1.Text = textBox1.Text + Convert.ToString(eigh);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (equal.Count > 0)
            {
                equal.Clear();
                textBox1.Text = "0";
            } 

            if (textBox1.Text == "0")
            {
                this.textBox1.ResetText();
                textBox1.Text = textBox1.Text + Convert.ToString(nine);
            }

            else if (textBox1.Text == "0.")
            {
                textBox1.Text = textBox1.Text + Convert.ToString(nine);
            }

            else
            {
                textBox1.Text = textBox1.Text + Convert.ToString(nine);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (equal.Count > 0)
            {
                equal.Clear();
                textBox1.Text = "0";
            }

            textBox1.Text = textBox1.Text + Convert.ToString(zero);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            if (addition.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(addition[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = addInt(x, y);
                textBox1.Text = Convert.ToString(result);
                addition.Clear();
                addition.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }
            else if (division.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(division[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = divideInt(x, y);
                textBox1.Text = Convert.ToString(result);
                division.Clear();
                addition.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }
            else if (multi.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(multi[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = multipInt(x, y);
                textBox1.Text = Convert.ToString(result);
                multi.Clear();
                addition.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }
            else if (subtraction.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(subtraction[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = subtractInt(x, y);
                textBox1.Text = Convert.ToString(result);
                subtraction.Clear();
                addition.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }
            else
            {
                addition.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }


        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            addition.Clear();
            subtraction.Clear();
            multi.Clear();
            division.Clear();
            textBox1.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
           
            if (addition.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(addition[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = addInt(x, y);
                textBox1.Text = Convert.ToString(result);
                addition.Clear();
                multi.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }
            else if (division.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(division[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = divideInt(x, y);
                textBox1.Text = Convert.ToString(result);
                division.Clear();
                multi.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }
            else if (multi.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(multi[0]);
                double y = Convert.ToDouble (textBox1.Text);
                result = multipInt(x, y);
                textBox1.Text = Convert.ToString(result);
                multi.Clear();
                multi.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }
            else if (subtraction.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(subtraction[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = subtractInt(x, y);
                textBox1.Text = Convert.ToString(result);
                subtraction.Clear();
                multi.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }
            else
            {
                multi.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }


        }

        private void button12_Click(object sender, EventArgs e)
        {

            
            if (addition.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(addition[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = addInt(x, y);
                textBox1.Text = Convert.ToString(result);
                addition.Clear();
                subtraction.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }
            else if (division.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(division[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = divideInt(x, y);
                textBox1.Text = Convert.ToString(result);
                division.Clear();
                subtraction.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }
            else if (multi.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(multi[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = multipInt(x, y);
                textBox1.Text = Convert.ToString(result);
                multi.Clear();
                subtraction.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }
            else if (subtraction.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(subtraction[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = subtractInt(x, y);
                textBox1.Text = Convert.ToString(result);
                subtraction.Clear();
                subtraction.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }
            else
            {
                subtraction.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (addition.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(addition[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = addInt(x, y);
                textBox1.Text = Convert.ToString(result);
                addition.Clear();
                division.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }
            else if (division.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(division[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = divideInt(x, y);
                textBox1.Text = Convert.ToString(result);
                division.Clear();
                division.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }
            else if (multi.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(multi[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = multipInt(x, y);
                textBox1.Text = Convert.ToString(result);
                multi.Clear();
                division.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }
            else if (subtraction.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(subtraction[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = subtractInt(x, y);
                textBox1.Text = Convert.ToString(result);
                subtraction.Clear();
                division.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }
            else
            {
                division.Add(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = "0";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (addition.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(addition[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = addInt(x, y);
                textBox1.Text = Convert.ToString(result);
                equal.Add(Convert.ToString(result));
                addition.Clear();
            }
            else if (division.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(division[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = divideInt(x, y);
                textBox1.Text = Convert.ToString(result);
                equal.Add(Convert.ToString(result));
                division.Clear();
            }
            else if (multi.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(multi[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = multipInt(x, y);
                textBox1.Text = Convert.ToString(result);
                equal.Add(Convert.ToString(result));
                multi.Clear();
            }
            else if (subtraction.Count > 0)
            {
                double result;
                double x = Convert.ToDouble(subtraction[0]);
                double y = Convert.ToDouble(textBox1.Text);
                result = subtractInt(x, y);
                textBox1.Text = Convert.ToString(result);
                equal.Add(Convert.ToString(result));
                subtraction.Clear();
            }
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double result;
            double x = Convert.ToDouble(textBox1.Text);
            result = percentInt(x);
            textBox1.Text = Convert.ToString(result);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + Convert.ToString(".");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double result;
            double x = Convert.ToDouble(textBox1.Text);
            result = convertInt(x);
            textBox1.Text = Convert.ToString(result);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    e.Handled = true;
                    button1.PerformClick();
                    break;

                case Keys.NumPad2:
                    e.Handled = true;
                    button2.PerformClick();
                    break;

                case Keys.NumPad3:
                    e.Handled = true;
                    button3.PerformClick();
                    break;

                case Keys.NumPad4:
                    e.Handled = true;
                    button4.PerformClick();
                    break;

                case Keys.NumPad5:
                    e.Handled = true;
                    button5.PerformClick();
                    break;

                case Keys.NumPad6:
                    e.Handled = true;
                    button6.PerformClick();
                    break;

                case Keys.NumPad7:
                    e.Handled = true;
                    button7.PerformClick();
                    break;

                case Keys.NumPad8:
                    e.Handled = true;
                    button8.PerformClick();
                    break;

                case Keys.NumPad9:
                    e.Handled = true;
                    button9.PerformClick();
                    break;

                case Keys.NumPad0:
                    e.Handled = true;
                    button17.PerformClick();
                    break;

                case Keys.Decimal:
                    e.Handled = true;
                    button16.PerformClick();
                    break;

                case Keys.Enter:
                    e.Handled = true;
                    button13.PerformClick();
                    break;

                case Keys.Subtract:
                    e.Handled = true;
                    button12.PerformClick();
                    break;

                case Keys.Add:
                    e.Handled = true;
                    button11.PerformClick();
                    break;

                case Keys.Multiply:
                    e.Handled = true;
                    button10.PerformClick();
                    break;

                case Keys.Divide:
                    e.Handled = true;
                    button18.PerformClick();
                    break;

                case Keys.C:
                    e.Handled = true;
                    button15.PerformClick();
                    break;

                case Keys.D5:
                    e.Handled = true;
                    button14.PerformClick();
                    break;

            }
        }
    }
    }


