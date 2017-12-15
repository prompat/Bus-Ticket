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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        int i= 1; //กำหนดตัวแปร
        private void Login_bt_Click(object sender, EventArgs e)
        {
            if ((ID_text.Text == "admin") && (PW_text.Text == "123321"))//ถ้า username="admin" และ password="123321"
            {
                //เข้าสู่ระบบ
                Main f2 = new Main();
                f2.Show();
                this.Hide();
            }
            else if (ID_text.Text == "")//ถ้าไม่มีการพิมพ์ username จะมีข้อความเตือนโชว์ขึ้น
            {
                //ข้อความเตือนให้ใส่ username
                MessageBox.Show("กรุณาพิมพ์ username", "แจ้งเตือน");
                ID_text.Focus();
            }
            else if (PW_text.Text == "")
            {
                //ข้อความเตือนให้ใส่ Password
                MessageBox.Show("กรุณาพิมพ์ Password", "แจ้งเตือน");
                PW_text.Focus();
            }
            else if (ID_text.Text != "admin")
            {
                //ข้อความเตือนว่า username ผิด
                MessageBox.Show("username ของคุณผิด", "แจ้งเตือน");
                ID_text.Focus();//โฟกัสที่ username
                ID_text.SelectAll();//เลือกข้อความใน textboxทั้งหมด (เพื่อให้ง่ายต่อการลบ)
            }
            else if (PW_text.Text != "123321")
            {
                MessageBox.Show("Password ของคุณผิด", "แจ้งเตือนครั้งที่" + i);
                PW_text.Focus();//โฟกัสที่ Password
                PW_text.SelectAll();//เลือกข้อความใน textboxทั้งหมด (เพื่อให้ง่ายต่อการลบ)
                i++; // บวก i หนึ่งครั้ง
                if(i>3) //ถ้า i มากกว่าสาม
                {
                    //จะมีข้อความเตือนว่า เข้าระบบครบที่กำหนด แล้วจะออกจากโปรแกรม
                    MessageBox.Show("คุณพิมพ์ Passwrod ครบ 3 ครั้งแล้ว....ทำการปิดโปรแกรม", "แจ้งเตือน");
                    Application.Exit();
                }
            }
        }

        private void ID_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) BottonExit_Click(sender, e); //ถ้ากดปุ่ม "escape" ตอนอยู่ที่ textbox ของ username จะกดปุ่ม exit โดยอัตโนมัติ 
            if (e.KeyCode == Keys.Enter)//ถ้ากด enter
                if (ID_text.Text == "")//ถ้า ID_text ว่าง จะมีข้อความให้พิมพ์ username
                {
                    MessageBox.Show("กรุณาพิมพ์ username", "แจ้งเตือน");
                    ID_text.Focus();//โฟกัสที่ ID_text
                }
                else if (ID_text.Text != "admin")
                {
                    MessageBox.Show("username ของคุณผิด", "แจ้งเตือน");
                    ID_text.Focus();//โฟกัสที่ ID_text
                    ID_text.SelectAll();//ครอบtext ในID_text (เพื่อง่ายต่อการแก้ไข)
                }
                else PW_text.Focus();//โฟกัสที่PW_text

        }

        private void PW_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) BottonExit_Click(sender, e);//ถ้ากดปุ่ม "escape" ตอนอยู่ที่ textbox ของ username จะกดปุ่ม exit โดยอัตโนมัติ 
            if (e.KeyCode == Keys.Enter)//ถ้ากด enter
                if (PW_text.Text == "")//ถ้า PW_text ว่าง จะมีข้อความให้พิมพ์ password
                {
                    MessageBox.Show("กรุณาพิมพ์ Password", "แจ้งเตือน");
                    PW_text.Focus();//โฟกัสที่  PW_text
                }
                else if (ID_text.Text != "123321")
                {
                    MessageBox.Show("Password ของคุณผิด", "แจ้งเตือนครั้งที่"+i);
                    PW_text.Focus();//โฟกัสที่  PW_text
                    PW_text.SelectAll();//ครอบtext ใน PW_text (เพื่อง่ายต่อการแก้ไข)
                    i++;//เพิ่มค่า i
                    if (i > 3)//ถ้าค่าiเกิน สาม
                    {
                        //ถ้ารหัสไม่ถูก 3 ครั้ง จะออกจากระบบอัตโนมัติ
                        MessageBox.Show("คุณพิมพ์ Passwrod ครบ 3 ครั้งแล้ว....ทำการปิดโปรแกรม", "แจ้งเตือน");
                        Application.Exit();
                    }
                }
                else Login_bt_Click(sender,e);//กดLogin อัตโนมัติ


        }

        private void PW_text_TextChanged(object sender, EventArgs e)
        {
            if(PW_text.TextLength==6) Login_bt_Click(sender, e);//ถ้าpassword ครบ6ตัว จะกดปุ่ม Login อัตโนมัติ
        }

        private void BottonExit_Click(object sender, EventArgs e)//ปุ่มออกจาระบบ
        {
            //ถ้ากดปุ่มออกจะมีข้อความถามว่าจะออกจาระบบหรือไม่
            if (MessageBox.Show("คุณต้องการออกจากระบบหรือไม่", "แจ้งเตือน",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //ถ้ากดตกลงจะออกจากระบบ
                Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
