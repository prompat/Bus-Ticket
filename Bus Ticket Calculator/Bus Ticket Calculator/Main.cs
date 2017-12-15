using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Ticket_Calculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        int sum = 0;//ประกาศตัวแปร

        private void Main_Load(object sender, EventArgs e)
        {
            // Add จังหวัด และ Add ที่นั่ง
            comboBox1.Items.Add("อุดร");
            comboBox1.Items.Add("บุรีรัมย์");
            comboBox1.Items.Add("ขอนแก่น");
            comboBox1.Items.Add("ร้อยเอ็ด");
            comboBox1.Items.Add("เชียงใหม่");
            comboBox1.Items.Add("เชียงราย");
            comboBox1.Items.Add("ระยอง");
            comboBox1.Items.Add("กรุงเทพฯ");
            comboBox1.Items.Add("ชลบุรี");
            comboBox1.Items.Add("นครศรีฯ");
            comboBox1.Items.Add("ตาก");
            comboBox1.Items.Add("สระบุรี");
            comboBox2.Items.Add("ZoneA1");
            comboBox2.Items.Add("ZoneA2");
            comboBox2.Items.Add("ZoneA3");
            comboBox2.Items.Add("ZoneA4");
            comboBox2.Items.Add("ZoneA5");
            comboBox2.Items.Add("ZoneA6");
            comboBox2.Items.Add("ZoneA7");
            comboBox2.Items.Add("ZoneA8");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//ถ้ากด enter จะเข้าเงื่อนไขด้านล่าง
                if (textBox1.Text == "")//ถ้าtextbox1 ว่างจะมีข้อความแจ้งเตือนเด้งขึ้นมา
                {
                    MessageBox.Show("กรุณาพิมพ์ชื่อ-นามสกุล", "แจ้งเตือน");//แจ้งเตือน
                    textBox1.Focus();//โฟกัสที่textBox1
                }
                else//ถ้าtextbox1ไม่ว่าง
                {
                    comboBox1.Focus();//comboBox จะถูกโฟกัส
                }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;//สร้างตัวแปร
            str = comboBox1.SelectedItem.ToString();

            //ประตัวแปรให้เป็นตัวเลือก ใน comboBox1
            switch (str)//ประกาศราคา
            {
                case "อุดร": textBox2.Text = "180";break;
                case "บุรีรัมย์": textBox2.Text = "250"; break;
                case "ขอนแก่น": textBox2.Text = "250"; break;
                case "ร้อยเอ็ด": textBox2.Text = "300"; break;
                case "เชียงใหม่": textBox2.Text = "700"; break;
                case "เชียงราย": textBox2.Text = "700"; break;
                case "ระยอง": textBox2.Text = "600"; break;
                case "กรุงเทพฯ": textBox2.Text = "500"; break;
                case "ชลบุรี": textBox2.Text = "550"; break;
                case "นครศรีฯ": textBox2.Text = "360"; break;
                case "ตาก": textBox2.Text = "450"; break;
                case "สระบุรี": textBox2.Text = "360"; break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                if (textBox1.Text == "")//ถ้าtextbox1 ว่าง จะมีข้อความแจ้งเตือนโชว์ขึ้นมา
                {
                    MessageBox.Show("กรุณาพิมพ์ชื่อ-นามสกุล", "แจ้งเตือน");//ข้อความแจ้งเตือน
                    textBox1.Focus();//โฟกัสที่ textBox1
                }
                else if (comboBox1.Text == "--กรุณาเลือกจังหวัด--")//ถ้าtextbox1 เป็น "--กรุณาเลือกจังหวัด--" จะมีข้อความแจ้งเตือนโชว์ขึ้นมา
                {
                    MessageBox.Show("กรุณาระบุจังหวัดที่จะเดินทาง", "แจ้งเตือน");//ข้อความแจ้งเตือน
                    comboBox1.Focus();//โฟกัสที่ comboBox1
                }
                else if (comboBox2.Text == "--กรุณาเลือก--")
                {
                    MessageBox.Show("กรุณาระบุจังหวัดที่จะเดินทาง", "แจ้งเตือน");//ข้อความแจ้งเตือน
                    comboBox2.Focus();//โฟกัสที่  comboBox2
                }
                else if (numericUpDown1.Text == "0")
                {
                    MessageBox.Show("กรุณาระบุจำนวนผู้โดยสาร", "แจ้งเตือน");//ข้อความแจ้งเตือน
                    numericUpDown1.Focus();//โฟกัสที่  numericUpDown1
                }
                else
                {
                    if (checkBox5.Checked)//ถ้าcheckbox5 มีการcheck
                    {
                        double price = 0, num = 0, sum = 0;//ประกาศตัวแปร
                        num = double.Parse(numericUpDown1.Text);//ประกาศตัวแปรให้เท่ากับ numericUpDown1
                        price = double.Parse(textBox2.Text);//ประกาศตัวแปร priceให้เท่ากับ textBox2
                        sum = price * num;//สมการการหาค่ารวมของผู้โดยสาร
                        textBox3.Text = sum.ToString("#,##.00");//นำค่า ประกาศลงใน textBox3
                    }
                    if (checkBox4.Checked)//ถ้าcheckbox4 มีการcheck

                    {
                        double price = 0, num2 = 0, sum = 0;//ประกาศตัวแปร
                        num2 = double.Parse(numericUpDown2.Text);//ประกาศตัวแปรให้เท่ากับ numericUpDown2
                        price = double.Parse(textBox2.Text);//ประกาศตัวแปรpriceให้เท่ากับ textbox2
                        sum = (price * num2) * 50 / 100;//สมการการหาค่ารวมของผู้โดยสาร(เด็ก)
                        textBox3.Text = sum.ToString("#,##.00");//นำค่า ประกาศลงใน textBox3
                    }
                    if (checkBox4.Checked && checkBox5.Checked)//ถ้าcheckbox4 และ checkbox5 มีการcheck
                    {
                        double price = 0, num = 0, num2 = 0, sum = 0;//ประกาศตัวแปร
                        num = double.Parse(numericUpDown1.Text);//ประกาศตัวแปรให้เท่ากับ numericUpDown1
                        num2 = double.Parse(numericUpDown2.Text);//ประกาศตัวแปรให้เท่ากับ numericUpDown2
                        price = double.Parse(textBox2.Text);//ประกาศตัวแปรpriceให้เท่ากับ textbox2
                        sum = (price * num) + ((price * num2) * 50 / 100);//สมการการหาค่ารวมของผู้โดยสาร(เด็ก)และผู้ใหญ่
                        textBox3.Text = sum.ToString("#,##.00");//นำค่า ประกาศลงใน textBox3
                    }
                
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton3.Checked == true)//ถ้าradioButton3 มีการกด เช็ค
            {
                //ประกาศตัวแปร แล้วโชว์ราคา ต่อ1เที่ยว ไปที่ textbox4
                double price;
                price = double.Parse(textBox3.Text);
                textBox4.Text = price.ToString("#,##.00");

            }
            if (radioButton4.Checked == true)
            {
                //ประกาศตัวแปร แล้วโชว์ราคา ไป-กลับ ไปที่ textbox4
                double price,back;
                price = double.Parse(textBox3.Text);
                back = price * 2;//ไปกลับราคาจะ คูณ 2
                textBox4.Text = back.ToString("#,##.00");
            }
        }
        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);//กด button1 อัตโนมัติ
            if (checkBox5.Checked == false)//ถ้าcheckBox5 ไม่มีการกด เช็ค
            {
                MessageBox.Show("กรุณาเลือกวัยของผู้โดยสาร","แจ้งเตือน");//โชว์ข้อความแจ้งเตือน
                checkBox5.Focus();//โฟกัสที่checkBox5
            }

        }
        private void numericUpDown2_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);//กด button1 อัตโนมัติ
            if (checkBox4.Checked == false)//ถ้าcheckBox4 ไม่มีการกด เช็ค
            {
                MessageBox.Show("กรุณาเลือกวัยของผู้โดยสาร", "แจ้งเตือน");//ข้อความแจ้งเตือนโชว์ขึ้น
                checkBox4.Focus();//โฟกัสที่ checkBox4
            }
        }
        
        
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button2_Click(sender, e);//กด button2 อัตโนมัติ เพื่อคำนวนราคาต่อเที่ยว
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button2_Click(sender,e);//กด button2 อัตโนมัติ เพื่อคำนวนราคาต่อเที่ยว
        }
        private void button3_Click(object sender, EventArgs e)
        {
            sum = 0;//ประกาศตัวแปร
            if (checkBox1.Checked) sum += 100;//ถ้ากด check checkBox1 ราคาจะขึ้น 100
            if (checkBox2.Checked) sum += 50;//ถ้ากด check checkBox2 ราคาจะขึ้น 50
            if (checkBox3.Checked) sum += 100;//ถ้ากด check checkBox3 ราคาจะขึ้น 100
            textBox5.Text = sum.ToString("#,##.00");//ประกาศราคา ไปยัง  textBox5
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button3_Click(sender, e);//เมื่อกด check จะ click button3 อัตโนมัติเพื่อคำนวนราคา
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            button3_Click(sender, e);//เมื่อกด check จะ click button3 อัตโนมัติเพื่อคำนวนราคา
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            button3_Click(sender, e);//เมื่อกด check จะ click button3 อัตโนมัติเพื่อคำนวนราคา
        }

        private void button5_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "")
            {
                //ข้อความแจ้งเตือน และ โฟกัส
                MessageBox.Show("กรุณาพิมพ์ชื่อ-นามสกุล", "แจ้งเตือน");
                textBox1.Focus();
            }
            else if (comboBox1.Text == "--กรุณาเลือกจังหวัด--")
            {
                //ข้อความแจ้งเตือน และ โฟกัส
                MessageBox.Show("กรุณาระบุจังหวัดที่จะเดินทาง", "แจ้งเตือน");
                comboBox1.Focus();
            }
            else if (comboBox2.Text == "--กรุณาเลือก--")
            {
                //ข้อความแจ้งเตือน และ โฟกัส
                MessageBox.Show("กรุณาระบุจังหวัดที่จะเดินทาง", "แจ้งเตือน");
                comboBox2.Focus();
            }
            else if (numericUpDown1.Text == "0")
            {
                //ข้อความแจ้งเตือน และ โฟกัส
                MessageBox.Show("กรุณาระบุจำนวนผู้โดยสาร", "แจ้งเตือน");
                numericUpDown1.Focus();
            }

            else if (textBox3.Text == "")
            {
                //ข้อความแจ้งเตือน
                MessageBox.Show("กรุณาเลือกวัยของผู้โดยสาร", "แจ้งเตือน");

            }
            else if (textBox4.Text == "")
            {
                // ข้อความแจ้งเตือน
                MessageBox.Show("กรุณาเลือกเที่ยวโดยสาร ", "แจ้งเตือน");

            }
            
            else //ถ้าไม่มีข้อความแจ้งเตือน
            {
                //ประกาศตัวแปร
                double total1 = 0, total2 = 0, sum = 0;
                string name,num;
                name = textBox1.Text;
                num = comboBox2.Text;
                total1 = double.Parse(textBox4.Text);
                total2 = double.Parse(textBox5.Text);
                //สมการรวมค่าโดยสาร
                sum = total1 + total2;
                //โชว์ราคาที่ต้องจ่ายใน label7
                label7.Text = sum.ToString("#,##.00");
                label10.Text = name;//โชว์ชื่อใน label10
                label12.Text = num;//โชว์ที่นั่งใน label12
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ข้อความแจ้งเตือนว่าถามว่าจะล้างจริงหรือไม่
            if (MessageBox.Show("คุณต้องการล้างข้อมูลหรือไม่", "แจ้งเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //Clear ข้อความหน้า Main ทั้งหมด
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                checkBox5.Checked = false;
                checkBox4.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                numericUpDown1.Text = "0";
                comboBox1.Text = "--กรุณาเลือกจังหวัด--";
                comboBox2.Text = "--กรุณาเลือก--";
                label7.Text = "0.00";
                label10.Text = "";
                label12.Text = "";
                textBox1.Focus();//โฟกัสที่textBox1

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //ข้อความแจ้งเตือนว่าถามว่าจะออกจากระบบจริงหรือไม่
            if (MessageBox.Show("คุณต้องการออกจากระบบหรือไม่", "แจ้งเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();//ออกโปรแกรม
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            /*เมื่อกดclickที่ checkBox4 numericUpDown2 label14 จะปรากฏขึ้น*/
            numericUpDown2.Visible = true;
            label14.Visible = true;
            numericUpDown2.Focus();//โฟกัสที่ numericUpDown2
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Focus();//โฟกัสที่ numericUpDown1
        }

       
    }
}
