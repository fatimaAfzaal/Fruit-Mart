using System;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void clearAll()
        {
            label69.Text = "";
            label67.Text = "";
            label61.Text = "";
            label72.Text = "";
            label62.Text = "";
            label56.Text = "";
            label73.Text = "";
            label63.Text = "";
            label59.Text = "";
            label74.Text = "";
            label64.Text = "";
            label71.Text = "";
            label65.Text = "";
            label57.Text = "";
            label68.Text = "";
            label66.Text = "";
            label58.Text = "";
            label60.Text = "";
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)              //apple checkbox
        {
            numericUpDown1.Enabled = true;
            comboBox1.Enabled = true;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)                   //Orange checkbox
        {
            numericUpDown2.Enabled = true;
            comboBox2.Enabled = true;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)                   //Mango checkbox
        {
            numericUpDown3.Enabled = true;
            comboBox3.Enabled = true;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)                   //Peach checkbox
        {
            numericUpDown6.Enabled = true;
            comboBox4.Enabled = true;
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)                   //Pineapple checkbox
        {
            numericUpDown5.Enabled = true;
            comboBox5.Enabled = true;
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)                   //Strawberries checkbox
        {
            numericUpDown4.Enabled = true;
            comboBox6.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)            //Generate bill button
        {
            clearAll();
            if((radioButton1.Checked==false&&radioButton2.Checked==false))
            {
                MessageBox.Show("Please tell you require bag or not", "Missing feild", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                label7.Visible = true;
                label9.Visible = true;
                groupBox1.Visible = true;
                int total_products = 0;
                int total_bill = 0;
                DateTime thisMoment = DateTime.Now;                        // printing date and time
                label8.Text = thisMoment.ToString();
                if (checkBox1.Checked == true)                          //if apple is selected
                {
                    if (comboBox1.Text.ToString() == "")            //if quantity is not selected
                    {
                        MessageBox.Show("Please Enter missing quality","Missing quality",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        label69.Text = checkBox1.Text;
                        label67.Text = numericUpDown1.Value.ToString();
                        if (comboBox1.Text.ToString() == "High")
                        {
                            label61.Text = 200.ToString();
                        }
                        else if (comboBox1.Text.ToString() == "Medium")
                        {
                            label61.Text = 150.ToString();
                        }
                        total_products++;
                        total_bill += (int.Parse(label67.Text) * int.Parse(label61.Text));
                    }
                }


                if (checkBox2.Checked == true)                          //if orange is selected
                {
                    if (comboBox2.Text.ToString() == "")            //if quantity is not selected
                    {
                        MessageBox.Show("Please Enter missing quality", "Missing quality", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        label72.Text = checkBox2.Text;
                        label62.Text = numericUpDown2.Value.ToString();
                        if (comboBox2.Text.ToString() == "High")
                        {
                            label56.Text = 300.ToString();
                        }
                        else if (comboBox2.Text.ToString() == "Medium")
                        {
                            label56.Text = 200.ToString();
                        }
                        total_products++;
                        total_bill += (int.Parse(label56.Text) * int.Parse(label62.Text));
                    }
                }

                if (checkBox3.Checked == true)                          //if mango is selected
                {
                    if (comboBox3.Text.ToString() == "")            //if quantity is not selected
                    {
                        MessageBox.Show("Please Enter missing quality", "Missing quality", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        label73.Text = checkBox3.Text;
                        label63.Text = numericUpDown3.Value.ToString();
                        if (comboBox3.Text.ToString() == "High")
                        {
                            label59.Text = 150.ToString();
                        }
                        else if (comboBox3.Text.ToString() == "Medium")
                        {
                            label59.Text = 120.ToString();
                        }
                        total_products++;
                        total_bill += (int.Parse(label59.Text) * int.Parse(label63.Text));
                    }
                }

                if (checkBox4.Checked == true)                          //if peach is selected
                {
                    if (comboBox4.Text.ToString() == "")            //if quantity is not selected
                    {
                        MessageBox.Show("Please Enter missing quality", "Missing quality", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        label74.Text = checkBox4.Text;
                        label64.Text = numericUpDown6.Value.ToString();
                        if (comboBox4.Text.ToString() == "High")
                        {
                            label60.Text = 250.ToString();
                        }
                        else if (comboBox4.Text.ToString() == "Medium")
                        {
                            label60.Text = 200.ToString();
                        }
                        total_products++;
                        total_bill += (int.Parse(label60.Text) * int.Parse(label64.Text));
                    } 
                }
                if (checkBox5.Checked == true)                          //if pineapple is selected
                {
                    if (comboBox5.Text.ToString() == "")            //if quantity is not selected
                    {
                        MessageBox.Show("Please Enter missing quality", "Missing quality", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        label71.Text = checkBox5.Text;
                        label65.Text = numericUpDown5.Value.ToString();
                        if (comboBox5.Text.ToString() == "High")
                        {
                            label57.Text = 1000.ToString();
                        }
                        else if (comboBox5.Text.ToString() == "Medium")
                        {
                            label57.Text = 800.ToString();
                        }
                        total_products++;
                        total_bill += (int.Parse(label57.Text) * int.Parse(label65.Text));
                    }
                }

                if (checkBox6.Checked == true)                          //if strawberrie is selected
                {
                    if (comboBox6.Text.ToString() == "")            //if quantity is not selected
                    {
                        MessageBox.Show("Please Enter missing quality", "Missing quality", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        label68.Text = checkBox6.Text;
                        label66.Text = numericUpDown4.Value.ToString();
                        if (comboBox6.Text.ToString() == "High")
                        {
                            label58.Text = 90.ToString();
                        }
                        else if (comboBox6.Text.ToString() == "Medium")
                        {
                            label58.Text = 60.ToString();
                        }
                        total_products++;
                        total_bill += (int.Parse(label58.Text) * int.Parse(label66.Text));
                    }
                }
                if (radioButton1.Checked == true)
                {
                    label45.Text = total_bill.ToString() + " + 20 = " + (total_bill + 20).ToString();
                }
                else
                {
                    label45.Text = total_bill.ToString();
                }
                label46.Text = total_products.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)              //reset button
        {
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
            comboBox4.ResetText();
            comboBox5.ResetText();
            comboBox6.ResetText();
            groupBox1.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;
            numericUpDown5.Enabled = false;
            numericUpDown6.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            label9.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            numericUpDown3.Value = 1;
            numericUpDown4.Value = 1;
            numericUpDown5.Value = 1;
            numericUpDown6.Value = 1;
        }
    }
}
