using System;
using System.Windows.Forms;

namespace REALPROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox11.Enabled = false;
            comboBox1.Enabled = true;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            groupBox9.Visible = false;
            label6.Visible = false;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            comboBox3.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {            
            comboBox3.Enabled = true;
            double ticket, dekticket, babyticket;
            if (comboBox1.Text == "กรีซ")
            {
                comboBox3.Items.Clear();
                if (comboBox2.Text == "First class") { 
                    ticket = 182000;
                    dekticket = 182000;
                    babyticket = 17100;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";                
                    comboBox3.Items.Add("(ATH) Emirates");
                    comboBox3.Items.Add("(ATH) Lufthansa");
                }
                else if (comboBox2.Text == "Business Class")
                {
                    ticket = 58000;
                    dekticket = 58000;
                    babyticket = 5000;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(ATH) Lufthansa");
                    comboBox3.Items.Add("(ATH) KLM");
                    comboBox3.Items.Add("(ATH) Air France");
                }
                else if (comboBox2.Text == "Premium economy Class")
                {
                    ticket = 75000;
                    dekticket = 58000;
                    babyticket = 6600;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(ATH) Lufthansa");
                }
                else if (comboBox2.Text == "Economy Class")
                {
                    ticket = 20000;
                    dekticket = 20000;
                    babyticket = 1100;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(ATH) Emirates");
                    comboBox3.Items.Add("(ATH) Lufthansa");
                    comboBox3.Items.Add("(ATH) KLM");
                    comboBox3.Items.Add("(ATH) Air France");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else if (comboBox1.Text == "เดนมาร์ก")
            {
                comboBox3.Items.Clear();
                if (comboBox2.Text == "First class")
                {
                    ticket = 192000;
                    dekticket = 192000;
                    babyticket = 18100;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(BLL) Lufthansa");

                }
                else if (comboBox2.Text == "Business Class")
                {
                    ticket = 58000;
                    dekticket = 58000;
                    babyticket = 4700;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(BLL) KLM");
                    comboBox3.Items.Add("(BLL) Etihad");
                    comboBox3.Items.Add("(BLL) Lufthansa");
                }
                else if (comboBox2.Text == "Premium economy Class")
                {
                    ticket = 78000;
                    dekticket = 61000;
                    babyticket = 7000;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(BLL) Lufthansa");
                }
                else if (comboBox2.Text == "Economy Class")
                {
                    ticket = 20000;
                    dekticket = 20000;
                    babyticket = 1100;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(BLL) KLM");
                    comboBox3.Items.Add("(BLL) Etihad");
                    comboBox3.Items.Add("(BLL) Lufthansa");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else if (comboBox1.Text == "นอร์เวย์")
            {
                comboBox3.Items.Clear();
                if (comboBox2.Text == "First class")
                {
                    ticket = 182000;
                    dekticket = 182000;
                    babyticket = 17000;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(OSL) Emirates");
                }
                else if (comboBox2.Text == "Business Class")
                {
                    ticket = 58000;
                    dekticket = 58000;
                    babyticket = 4700;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(OSL) Emirates");
                    comboBox3.Items.Add("(OSL) Lufthansa");
                    comboBox3.Items.Add("(OSL) KLM");
                    comboBox3.Items.Add("(OSL) Etihad");
                    comboBox3.Items.Add("(OSL) Qatar Airways");
                    comboBox3.Items.Add("(OSL) Ethiopian Airlines");
                    comboBox3.Items.Add("(OSL) Malaysia Airlines");
                    comboBox3.Items.Add("(OSL) British Airways");
                }
                else if (comboBox2.Text == "Premium economy Class")
                {
                    ticket = 74900;
                    dekticket = 58000;
                    babyticket = 6600;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(OSL) Lufthansa");
                }
                else if (comboBox2.Text == "Economy Class")
                {
                    ticket = 19700;
                    dekticket = 19700;
                    babyticket = 1100;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(OSL) Emirates");
                    comboBox3.Items.Add("(OSL) Ethiopian Airlines");
                    comboBox3.Items.Add("(OSL) Lufthansa");
                    comboBox3.Items.Add("(OSL) KLM");
                    comboBox3.Items.Add("(OSL) Etihad");
                    comboBox3.Items.Add("(OSL) Qatar Airways");
                    comboBox3.Items.Add("(OSL) Malaysia Airlines");
                    comboBox3.Items.Add("(OSL) British Airways");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else if (comboBox1.Text == "เนเธอร์แลนด์")
            {
                comboBox3.Items.Clear();
                if (comboBox2.Text == "First class")
                {
                    ticket = 182000;
                    dekticket = 182000;
                    babyticket = 17000;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(AMS) Emirates");
                    comboBox3.Items.Add("(AMS) Swiss International Air Lines");

                }
                else if (comboBox2.Text == "Business Class")
                {
                    ticket = 58000;
                    dekticket = 58000;
                    babyticket = 4700;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(AMS) Etihad");
                    comboBox3.Items.Add("(AMS) Emirates");
                    comboBox3.Items.Add("(AMS) Swiss International Air Lines");
                    comboBox3.Items.Add("(AMS) Lufthansa");
                    comboBox3.Items.Add("(AMS) KLM");
                    comboBox3.Items.Add("(AMS) Qatar Airways");
                    comboBox3.Items.Add("(AMS) British Airways");
                    comboBox3.Items.Add("(AMS) Malaysia Airlines");
                    comboBox3.Items.Add("(AMS) Delta Airlines");
                }
                else if (comboBox2.Text == "Premium economy Class")
                {
                    ticket = 74700;
                    dekticket = 58000;
                    babyticket = 6600;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(AMS) Lufthansa");
                }
                else if (comboBox2.Text == "Economy Class")
                {
                    ticket = 15690;
                    dekticket = 13500;
                    babyticket = 1800;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(AMS) Emirates");
                    comboBox3.Items.Add("(AMS) Qatar Airways");
                    comboBox3.Items.Add("(AMS) Etihad");
                    comboBox3.Items.Add("(AMS) Swiss International Air Lines");
                    comboBox3.Items.Add("(AMS) Austrian Airlines");
                    comboBox3.Items.Add("(AMS) Lufthansa");
                    comboBox3.Items.Add("(AMS) KLM");
                    comboBox3.Items.Add("(AMS) Malaysia Airlines");
                    comboBox3.Items.Add("(AMS) British Airways");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else if (comboBox1.Text == "เบลเยียม")
            {
                comboBox3.Items.Clear();
                if (comboBox2.Text == "First class")
                {
                    ticket = 182000;
                    dekticket = 182000;
                    babyticket = 17000;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(BRU) Emirates");
                    comboBox3.Items.Add("(BRU) Swiss International Air Lines");

                }
                else if (comboBox2.Text == "Business Class")
                {
                    ticket = 58000;
                    dekticket = 58000;
                    babyticket = 4700;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(BRU) Etihad");
                    comboBox3.Items.Add("(BRU) Swiss International Air Lines");
                    comboBox3.Items.Add("(BRU) Lufthansa");
                    comboBox3.Items.Add("(BRU) Emirates");
                    comboBox3.Items.Add("(BRU) KLM");
                    comboBox3.Items.Add("(BRU) Qatar Airways");
                    comboBox3.Items.Add("(BRU) Ethiopian Airlines");
                    comboBox3.Items.Add("(BRU) Malaysia Airlines");
                    comboBox3.Items.Add("(BRU) British Airways");
                }
                else if (comboBox2.Text == "Premium economy Class")
                {
                    ticket = 74700;
                    dekticket = 58000;
                    babyticket = 6600;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(BRU) Lufthansa");
                }
                else if (comboBox2.Text == "Economy Class")
                {
                    ticket = 17000;
                    dekticket = 14400;
                    babyticket = 1900;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(BRU) Emirates");
                    comboBox3.Items.Add("(BRU) Etihad");
                    comboBox3.Items.Add("(BRU) Qatar Airways");
                    comboBox3.Items.Add("(BRU) Ethiopian Airlines");
                    comboBox3.Items.Add("(BRU) Swiss International Air Lines");
                    comboBox3.Items.Add("(BRU) Lufthansa");
                    comboBox3.Items.Add("(BRU) KLM");
                    comboBox3.Items.Add("(BRU) Malaysia Airlines");
                    comboBox3.Items.Add("(BRU) British Airways");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else if (comboBox1.Text == "โปรตุเกส")
            {
                comboBox3.Items.Clear();
                if (comboBox2.Text == "First class")
                {
                    ticket = 182000;
                    dekticket = 182000;
                    babyticket = 17000;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(LIS) Emirates");
                    comboBox3.Items.Add("(LIS) Swiss International Air Lines");
                    comboBox3.Items.Add("(LIS) All Nippon Airways");

                }
                else if (comboBox2.Text == "Business Class")
                {
                    ticket = 58000;
                    dekticket = 58000;
                    babyticket = 4700;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(LIS) Etihad");
                    comboBox3.Items.Add("(LIS) Swiss International Air Lines");
                    comboBox3.Items.Add("(LIS) Lufthansa");
                    comboBox3.Items.Add("(LIS) KLM");
                    comboBox3.Items.Add("(LIS) Emirates");
                    comboBox3.Items.Add("(LIS) Ethiopian Airlines");
                    comboBox3.Items.Add("(LIS) Air France");
                    comboBox3.Items.Add("(LIS) Qatar Airways");
                    comboBox3.Items.Add("(LIS) Singapore Airlines");
                    comboBox3.Items.Add("(LIS) British Airways");
                    comboBox3.Items.Add("(LIS) All Nippon Airways");
                }
                else if (comboBox2.Text == "Premium economy Class")
                {
                    ticket = 74700;
                    dekticket = 58000;
                    babyticket = 6600;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(LIS) Lufthansa");
                    comboBox3.Items.Add("(LIS) All Nippon Airways");
                }
                else if (comboBox2.Text == "Economy Class")
                {
                    ticket = 19700;
                    dekticket = 19700;
                    babyticket = 1100;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(LIS) Qatar Airways");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else if (comboBox1.Text == "โปแลนด์")
            {
                comboBox3.Items.Clear();
                if (comboBox2.Text == "First class")
                {
                    ticket = 182000;
                    dekticket = 182000;
                    babyticket = 17000;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(WAW) Emirates");
                    comboBox3.Items.Add("(WAW) Swiss International Air Lines");

                }
                else if (comboBox2.Text == "Business Class")
                {
                    ticket = 58000;
                    dekticket = 58000;
                    babyticket = 4700;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(WAW) Swiss International Air Lines");
                    comboBox3.Items.Add("(WAW) Lufthansa");
                    comboBox3.Items.Add("(WAW) Emirates");
                    comboBox3.Items.Add("(WAW) KLM");
                    comboBox3.Items.Add("(WAW) Air France");
                    comboBox3.Items.Add("(WAW) British Airways");

                }
                else if (comboBox2.Text == "Premium economy Class")
                {
                    ticket = 74700;
                    dekticket = 58000;
                    babyticket = 6600;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("---");

                }
                else if (comboBox2.Text == "Economy Class")
                {
                    ticket = 19700;
                    dekticket = 19700;
                    babyticket = 1100;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(WAW) Emirates");
                    comboBox3.Items.Add("(WAW) Swiss International Air Lines");
                    comboBox3.Items.Add("(WAW) Austrian Airlines");
                    comboBox3.Items.Add("(WAW) Lufthansa");
                    comboBox3.Items.Add("(WAW) KLM");
                    comboBox3.Items.Add("(WAW) Air France");
                    comboBox3.Items.Add("(WAW) British Airways");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else if (comboBox1.Text == "ฝรั่งเศส")
            {
                comboBox3.Items.Clear();
                if (comboBox2.Text == "First class")
                {
                    ticket = 182000;
                    dekticket = 182000;
                    babyticket = 17000;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(PARA) Emirates");
                    comboBox3.Items.Add("(PARA) Swiss International Air Lines");
                }
                else if (comboBox2.Text == "Business Class")
                {
                    ticket = 58000;
                    dekticket = 58000;
                    babyticket = 4700;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(PARA) Etihad");
                    comboBox3.Items.Add("(PARA) Emirates");
                    comboBox3.Items.Add("(PARA) Swiss International Air Lines");
                    comboBox3.Items.Add("(PARA) Lufthansa");
                    comboBox3.Items.Add("(PARA) EVA Air ");
                    comboBox3.Items.Add("(PARA) Korean Air ");
                    comboBox3.Items.Add("(PARA) Qatar Airways");
                    comboBox3.Items.Add("(PARA) KLM");
                    comboBox3.Items.Add("(PARA) Ethiopian Airlines");
                    comboBox3.Items.Add("(PARA) Air France");
                    comboBox3.Items.Add("(PARA) British Airways");
                    comboBox3.Items.Add("(PARA) Malaysia Airlines");
                    comboBox3.Items.Add("(PARA) All Nippon Airways");
                }
                else if (comboBox2.Text == "Premium economy Class")
                {
                    ticket = 74700;
                    dekticket = 58000;
                    babyticket = 6600;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(PARA) Lufthansa");
                    comboBox3.Items.Add("(PARA) All Nippon Airways");
                }
                else if (comboBox2.Text == "Economy Class")
                {
                    ticket = 15100;
                    dekticket = 13200;
                    babyticket = 2000;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(PARA) Etihad");
                    comboBox3.Items.Add("(PARA) Emirates");
                    comboBox3.Items.Add("(PARA) Qatar Airways");
                    comboBox3.Items.Add("(PARA) EVA Air ");
                    comboBox3.Items.Add("(PARA) Ethiopian Airlines");
                    comboBox3.Items.Add("(PARA) Austrian Airlines");
                    comboBox3.Items.Add("(PARA) Lufthansa");
                    comboBox3.Items.Add("(PARA) Korean Air ");
                    comboBox3.Items.Add("(PARA) Air France");
                    comboBox3.Items.Add("(PARA) Malaysia Airlines");
                    comboBox3.Items.Add("(PARA) British Airways");
                    comboBox3.Items.Add("(PARA) Delta Airlines");
                    comboBox3.Items.Add("(PARA) All Nippon Airways");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else if (comboBox1.Text == "สเปน")
            {
                comboBox3.Items.Clear();
                if (comboBox2.Text == "First class")
                {
                    ticket = 182000;
                    dekticket = 182000;
                    babyticket = 17000;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(BCN) Swiss International Air Lines");

                }
                else if (comboBox2.Text == "Business Class")
                {
                    ticket = 58000;
                    dekticket = 58000;
                    babyticket = 4700;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(BCN) Swiss International Air Lines");
                    comboBox3.Items.Add("(BCN) Lufthansa");
                    comboBox3.Items.Add("(BCN) KLM");
                    comboBox3.Items.Add("(BCN) Qatar Airways");
                    comboBox3.Items.Add("(BCN) Air France");
                    comboBox3.Items.Add("(BCN) British Airways");
                }
                else if (comboBox2.Text == "Premium economy Class")
                {
                    ticket = 74700;
                    dekticket = 58000;
                    babyticket = 6600;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(BCN) Lufthansa");
                }
                else if (comboBox2.Text == "Economy Class")
                {
                    ticket = 17000;
                    dekticket = 13000;
                    babyticket = 1500;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(BCN) Qatar Airways");
                    comboBox3.Items.Add("(BCN) Swiss International Air Lines");
                    comboBox3.Items.Add("(BCN) Lufthansa");
                    comboBox3.Items.Add("(BCN) KLM");
                    comboBox3.Items.Add("(BCN) Austrian Airlines ");
                    comboBox3.Items.Add("(BCN) Air France");
                    comboBox3.Items.Add("(BCN) British Airways");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else if (comboBox1.Text == "สวีเดน")
            {
                comboBox3.Items.Clear();
                if (comboBox2.Text == "First class")
                {
                    ticket = 182000;
                    dekticket = 182000;
                    babyticket = 17000;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(GOT) Swiss International Air Lines");
                }
                else if (comboBox2.Text == "Business Class")
                {
                    ticket = 80200;
                    dekticket = 630000;
                    babyticket = 7200;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(GOT) Swiss International Air Lines");
                    comboBox3.Items.Add("(GOT) Lufthansa");
                    comboBox3.Items.Add("(GOT) KLM");
                    comboBox3.Items.Add("(GOT) British Airways");
                }
                else if (comboBox2.Text == "Premium economy Class")
                {
                    ticket = 74700;
                    dekticket = 58000;
                    babyticket = 6600;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(GOT) Lufthansa");
                }
                else if (comboBox2.Text == "Economy Class")
                {
                    ticket = 19600;
                    dekticket = 19600;
                    babyticket = 1100;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(GOT) Swiss International Air Lines");
                    comboBox3.Items.Add("(GOT) KLM");
                    comboBox3.Items.Add("(GOT) Lufthansa");
                    comboBox3.Items.Add("(GOT) Austrian Airlines");
                    comboBox3.Items.Add("(GOT) British Airways");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else if (comboBox1.Text == "เยอรมัน")
            {
                comboBox3.Items.Clear();
                if (comboBox2.Text == "First class")
                {
                    ticket = 182000;
                    dekticket = 182000;
                    babyticket = 17000;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(TXL) Lufthansa");
                }
                else if (comboBox2.Text == "Business Class")
                {
                    ticket = 58000;
                    dekticket = 58000;
                    babyticket = 4700;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(TXL) Lufthansa");
                    comboBox3.Items.Add("(TXL) KLM");
                    comboBox3.Items.Add("(TXL) Qatar Airways");
                    comboBox3.Items.Add("(TXL) British Airways");
                }
                else if (comboBox2.Text == "Premium economy Class")
                {
                    ticket = 74700;
                    dekticket = 58000;
                    babyticket = 6600;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(TXL) Lufthansa");
                }
                else if (comboBox2.Text == "Economy Class")
                {
                    ticket = 14000;
                    dekticket = 12200;
                    babyticket = 1700;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(TXL) Qatar Airways");
                    comboBox3.Items.Add("(TXL) KLM");
                    comboBox3.Items.Add("(TXL) British Airways");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else if (comboBox1.Text == "สวิตเซอร์แลนด์")
            {
                comboBox3.Items.Clear();
                if (comboBox2.Text == "First class")
                {
                    ticket = 182000;
                    dekticket = 182000;
                    babyticket = 17000;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(BLS) Swiss International Air Lines");

                }
                else if (comboBox2.Text == "Business Class")
                {
                    ticket = 80200;
                    dekticket = 630000;
                    babyticket = 7200;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(BSL) KLM");
                    comboBox3.Items.Add("(BSL) Swiss International Air Lines");
                    comboBox3.Items.Add("(BSL) Air France");
                    comboBox3.Items.Add("(BSL) British Airways");
                }
                else if (comboBox2.Text == "Premium economy Class")
                {
                    ticket = 74700;
                    dekticket = 58000;
                    babyticket = 6600;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(BSL) Lufthansa");
                }
                else if (comboBox2.Text == "Economy Class")
                {
                    ticket = 19600;
                    dekticket = 19600;
                    babyticket = 1100;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(BSL) KLM");
                    comboBox3.Items.Add("(BLS) Swiss International Air Lines");
                    comboBox3.Items.Add("(BSL) Air France");
                    comboBox3.Items.Add("(BSL) British Airways");

                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else if (comboBox1.Text == "สหราชอาณาจักร")
            {
                comboBox3.Items.Clear();
                if (comboBox2.Text == "First class")
                {
                    ticket = 182000;
                    dekticket = 182000;
                    babyticket = 17000;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(LON) Emirates");

                }
                else if (comboBox2.Text == "Business Class")
                {
                    ticket = 45000;
                    dekticket = 40000;
                    babyticket = 7400;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(LON) Etihad");
                    comboBox3.Items.Add("(LON) Emirates");
                    comboBox3.Items.Add("(LON) Qatar Airways");
                    comboBox3.Items.Add("(LON) Lufthansa");
                }
                else if (comboBox2.Text == "Premium economy Class")
                {
                    ticket = 77000;
                    dekticket = 60000;
                    babyticket = 6600;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(LON) Lufthansa");
                }
                else if (comboBox2.Text == "Economy Class")
                {
                    ticket = 17000;
                    dekticket = 13000;
                    babyticket = 1500;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(LON) Etihad");
                    comboBox3.Items.Add("(LON) Emirates");
                    comboBox3.Items.Add("(LON) Qatar Airways");
                    comboBox3.Items.Add("(LON) Lufthansa");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else if (comboBox1.Text == "ออสเตรีย")
            {
                comboBox3.Items.Clear();
                if (comboBox2.Text == "First class")
                {
                    ticket = 110000;
                    dekticket = 110000;
                    babyticket = 10500;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(VIE) Swiss International Air Lines");

                }
                else if (comboBox2.Text == "Business Class")
                {
                    ticket = 53300;
                    dekticket = 41300;
                    babyticket = 4800;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(VIE) Swiss International Air Lines");
                    comboBox3.Items.Add("(VIE) KLM");
                    comboBox3.Items.Add("(VIE) Air France");
                    comboBox3.Items.Add("(VIE) Singapore Airlines");
                    comboBox3.Items.Add("(VIE) British Airways");

                }
                else if (comboBox2.Text == "Premium economy Class")
                {
                    ticket = 74700;
                    dekticket = 58000;
                    babyticket = 6600;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(VIE) Lufthansa");
                }
                else if (comboBox2.Text == "Economy Class")
                {
                    ticket = 18000;
                    dekticket = 15300;
                    babyticket = 2000;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(VIE) Austrian Airlines");
                    comboBox3.Items.Add("(VIE) Swiss International Air Lines");
                    comboBox3.Items.Add("(VIE) KLM");
                    comboBox3.Items.Add("(VIE) Air France");
                    comboBox3.Items.Add("(VIE) Singapore Airlines");
                    comboBox3.Items.Add("(VIE) British Airways");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else if (comboBox1.Text == "อิตาลี")
            {
                comboBox3.Items.Clear();
                if (comboBox2.Text == "First class")
                {
                    ticket = 182000;
                    dekticket = 182000;
                    babyticket = 17000;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(MILA) Swiss International Air Lines");

                }
                else if (comboBox2.Text == "Business Class")
                {
                    ticket = 60000;
                    dekticket = 60000;
                    babyticket = 4700;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(MILA) Lufthansa");
                    comboBox3.Items.Add("(MILA) KLM");
                    comboBox3.Items.Add("(MILA) Qatar Airways");
                    comboBox3.Items.Add("(MILA) Air France");
                    comboBox3.Items.Add("(MILA) British Airways");
                }
                else if (comboBox2.Text == "Premium economy Class")
                {
                    ticket = 77000;
                    dekticket = 60500;
                    babyticket = 6600;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(MILA) Lufthansa");
                }
                else if (comboBox2.Text == "Economy Class")
                {
                    ticket = 14500;
                    dekticket = 12500;
                    babyticket = 1700;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(MILA) Qatar Airways");
                    comboBox3.Items.Add("(MILA) Lufthansa");
                    comboBox3.Items.Add("(MILA) KLM");
                    comboBox3.Items.Add("(MILA) British Airways");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else if (comboBox1.Text == "ไอซ์แลนด์")
            {
                comboBox3.Items.Clear();
                if (comboBox2.Text == "First class")
                {
                    ticket = 182000;
                    dekticket = 182000;
                    babyticket = 17000;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(KEF) Emirates");

                }
                else if (comboBox2.Text == "Business Class")
                {
                    ticket = 80200;
                    dekticket = 630000;
                    babyticket = 7200;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(KEF) Lufthansa");
                    comboBox3.Items.Add("(KEF) British Airways");
                }
                else if (comboBox2.Text == "Premium economy Class")
                {
                    ticket = 74700;
                    dekticket = 58000;
                    babyticket = 6600;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(KEF) Lufthansa");
                }
                else if (comboBox2.Text == "Economy Class")
                {
                    ticket = 19600;
                    dekticket = 19600;
                    babyticket = 1100;
                    label13.Text = ticket.ToString();
                    label14.Text = dekticket.ToString();
                    label15.Text = babyticket.ToString();
                    label19.Text = "ผู้ใหญ่ราคา " + ticket.ToString() + " บาท";
                    label20.Text = "เด็กราคาราคา " + dekticket.ToString() + " บาท";
                    label21.Text = "เด็กทารกราคา " + babyticket.ToString() + " บาท";
                    comboBox3.Items.Add("(KEF) Lufthansa");
                    comboBox3.Items.Add("(KEF) KLM");
                    comboBox3.Items.Add("(KEF) British Airways");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { textBox1.Enabled = true; }
            else
            {
                textBox1.Enabled = false;
                textBox1.Clear();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            { textBox2.Enabled = true; }
            else
            {
                textBox2.Enabled = false;
                textBox2.Clear();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {            
                if (checkBox3.Checked == true) 
                { textBox3.Enabled = true; }
                else
            {
                textBox3.Enabled = false;
                textBox3.Clear();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.traveloka.com/th-th/");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {           
            if (textBox4.Text == "") { MessageBox.Show("กรุณากรอกข้อความ", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1); }
            else
            {
                groupBox9.Visible = true;
                double man, dek, baby;
                if (checkBox1.Checked == true)
                {
                    if (textBox1.Text == "") { MessageBox.Show("กรุณากรอกข้อความ", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1); }
                    else if (textBox1.Text != "0")
                    {
                    }
                }
                if (checkBox2.Checked == true)
                {
                    if (textBox2.Text == "") { MessageBox.Show("กรุณากรอกข้อความ", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1); }
                    else if (textBox2.Text != "0")
                    {
                    }
                }
                if (checkBox3.Checked == true)
                {
                    if (textBox3.Text == "") { MessageBox.Show("กรุณากรอกข้อความ", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1); }
                    else if (textBox3.Text != "0")
                    {
                    }
                }
                label6.Visible = true;
                double Day, ticket, dektic, babytic, wom, dekx, babyx, totalmanticket,
                    totaldekticket, totalbabyticket, hotel, roomhotel, totalhotel,
                    food1, food2, food3, food4, food5, food6,
                    foodtime1, foodtime2, foodtime3, foodtime4, foodtime5,
                    ftx1, ftx2, ftx3, ftx4, ftx5, ftx6,
                    f1, f2, f3, f4, f5, f6, totalfood, totalticket,
                    totalhotleS, totalticS,totalfooS,total ;

                Day = double.Parse(textBox4.Text);

                ticket  = double.Parse(label13.Text);
                dektic  = double.Parse(label14.Text);
                babytic = double.Parse(label15.Text);

                wom     = double.Parse(label10.Text);
                dekx    = double.Parse(label11.Text);
                babyx   = double.Parse(label12.Text);  
                           
                hotel       = double.Parse(label17.Text);
                roomhotel   = double.Parse(label28.Text);

                food1 = double.Parse(label30.Text);
                food2 = double.Parse(label31.Text);
                food3 = double.Parse(label32.Text);
                food4 = double.Parse(label33.Text);
                food5 = double.Parse(label34.Text);
                food6 = double.Parse(label35.Text);

                ftx1 = double.Parse(label36.Text);
                ftx2 = double.Parse(label37.Text);
                ftx3 = double.Parse(label38.Text);
                ftx4 = double.Parse(label39.Text);
                ftx5 = double.Parse(label40.Text);
                ftx6 = double.Parse(label41.Text);

                totalmanticket = (ticket*2) * wom;
                totaldekticket = (dektic*2) * dekx;
                totalbabyticket = (babytic*2) * babyx;

                Day = Day - 1;

                totalhotel = hotel * Day * roomhotel ;

                f1 = food1 * ftx1;
                f2 = food2 * ftx2;
                f3 = food3 * ftx3;
                f4 = food4 * ftx4;
                f5 = food5 * ftx5;
                f6 = food6 * ftx6;

                foodtime1 = f1 * (wom + dekx);
                foodtime2 = f2 * (wom + dekx);
                foodtime3 = f3 * (wom + dekx);
                foodtime4 = f4 * (wom + dekx);
                foodtime5 = f5 * (wom + dekx);

                totalfood = foodtime1 + foodtime2 + foodtime3 + foodtime4 + foodtime5;

                totalticket = totalmanticket + totaldekticket + totalbabyticket;
                total = totalticket + totalhotel + totalfood;


                label6.Text = "รายจ่ายโดยประมาณ"+ "\n"
                            + "จ่ายค่าเครื่องบินทั้งหมด    " + totalticket.ToString()  + "      บาท\n"
                            + "จ่ายค่าโรงแรม                " + totalhotel.ToString()   + "      บาท\n" 
                            + "จ่ายค่าอาหาร                  " + totalfood.ToString()    + "      บาท\n" + "\n"+ "\n"+ "\n"
                            + "ต้องจ่ายทั้งหมด               " + total.ToString()        + "      บาท" + "\n" + "\n" + "\n" + "\n" + "\n" + "\n"
                            + "(ข้อมูลนี้เป็นการประมาณ อาจจะมากกว่าหรือน้อยกว่าก็ได้)";




            }                     
        }

                
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox4.Text == "1 ดาว")
            {
                System.Diagnostics.Process.Start("google");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double day;
            if (textBox4.Text == "")
            {
                day = 0;
                label16.Text = day.ToString();
                label18.Text = "";
            }
            else
            {
                day = double.Parse(textBox4.Text);
                label16.Text = day.ToString();
                day = day * 3;
                label18.Text =day.ToString()+" มื้อ";
            }
                       
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {                     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox9.Visible = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;

            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";
            label23.Text = "";
            label24.Text = "";
            label25.Text = "";
            label26.Text = "";
            label27.Text = "";
            label29.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            float Hotel;
            comboBox2.Enabled = true;
            if (comboBox4.SelectedIndex == -1)
            {
                label17.Text = "0";
            }
            else if (comboBox4.Text == "1 ดาว")
                {
                Hotel = 1700;
                label17.Text = Hotel.ToString();
                label22.Text = "ราคาโรงแรม ห้องละ "+Hotel.ToString()+" บาท / คืน";
                }
            else if (comboBox4.Text == "2 ดาว")
                {
                Hotel = 2000;
                label17.Text = Hotel.ToString();
                label22.Text = "ราคาโรงแรม ห้องละ " + Hotel.ToString() + " บาท / คืน";
            }
            else if (comboBox4.Text == "3 ดาว")
            {
                Hotel = 3000;
                label17.Text = Hotel.ToString();
                label22.Text = "ราคาโรงแรม ห้องละ " + Hotel.ToString() + " บาท / คืน";
            }
            else if (comboBox4.Text == "4 ดาว")
            {
                Hotel = 4000;
                label17.Text = Hotel.ToString();
                label22.Text = "ราคาโรงแรม ห้องละ " + Hotel.ToString() + " บาท / คืน";
            }
            else if (comboBox4.Text == "5 ดาว")
            {
                Hotel = 15000;
                label17.Text = Hotel.ToString();
                label22.Text = "ราคาโรงแรม ห้องละ " + Hotel.ToString() + " บาท / คืน";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int ax;
            ax = 3500;
            if (checkBox4.Checked == true)
            {
                label30.Text = ax.ToString();
                label23.Text = "มิชลินสตาร์ราคาต่อคน 2000-5000 บาท / มื้อ";
                textBox5.Enabled = true;
            }
            else
            {
                label30.Text = "0";
                label23.Text = "";
                textBox5.Enabled = false;
                textBox5.Clear();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            int ax;
            ax = 150;
            if (checkBox5.Checked == true)
            {
                label31.Text = ax.ToString();
                label24.Text = "สตรีทฟู้ดราคาต่อคน 100-200 บาท/มื้อ ";
                textBox6.Enabled = true; }
            else
            {
                label31.Text = "0";
                label24.Text = "";
                textBox6.Enabled = false;
                textBox6.Clear();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            int ax;
            ax = 250;
            if (checkBox6.Checked == true)
            {
                label32.Text = ax.ToString();
                label25.Text = "ฟาสฟู้ด ราคาต่อคน 200-300 บาท/มื้อ ";
                textBox7.Enabled = true; }
            else
            {
                label32.Text = "0";
                label25.Text = "";
                textBox7.Enabled = false;
                textBox7.Clear();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            int ax;
            ax = 400;
            if (checkBox8.Checked == true)
            {
                label33.Text = ax.ToString();
                label26.Text = "ทำกินเอง ราคาต่อคน 200-600 บาท/มื้อ ";
                textBox9.Enabled = true; }
            else
            {
                label33.Text = "0";
                label26.Text = "";
                textBox9.Enabled = false;
                textBox9.Clear();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            int ax;
            ax = 1400;
            if (checkBox7.Checked == true)
            {
                label34.Text = ax.ToString();
                label27.Text = "คาเฟ่ ราคาต่อคน 600-2000 บาท/มื้อ ";
                textBox8.Enabled = true; }
            else
            {
                label34.Text = "0";
                label27.Text = "";
                textBox8.Enabled = false;
                textBox8.Clear();
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            double roomhot;
            if (textBox10.Text == "")
            {
                roomhot = 0;
                label28.Text = roomhot.ToString();
            }
            else
            {
                roomhot = double.Parse(textBox10.Text);
                label28.Text = roomhot.ToString();
            }        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double man;
            if (textBox1.Text == "")
            {
                man = 0;
                label10.Text = man.ToString();
            }
            else
            {
                man = double.Parse(textBox1.Text);
                label10.Text = man.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double dek;
            if (textBox2.Text == "")
            {
                dek = 0;
                label11.Text = dek.ToString();
            }
            else
            {
                dek = double.Parse(textBox2.Text);
                label11.Text = dek.ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double baby;
            if (textBox3.Text == "")
            {
                baby = 0;
                label12.Text = baby.ToString();
            }
            else
            {
                baby = double.Parse(textBox3.Text);
                label12.Text = baby.ToString();
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            int ax;
            ax = 85;
            if (checkBox9.Checked == true)
            {
                label35.Text = ax.ToString();
                label29.Text = "ซุปเปอร์มาร์เก็ต ราคาต่อคน 30-200 บาท/มื้อ ";
                textBox11.Enabled = true;
            }
            else
            {
                label35.Text = "0";
                label29.Text = "";
                textBox11.Enabled = false;
                textBox11.Clear();
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double d;
            if (textBox5.Text == "")
            {
                d = 0;
                label11.Text = d.ToString();
            }
            else
            {
                d = double.Parse(textBox5.Text);
                label36.Text = d.ToString();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double dek;
            if (textBox6.Text == "")
            {
                dek = 0;
                label37.Text = dek.ToString();
            }
            else
            {
                dek = double.Parse(textBox6.Text);
                label37.Text = dek.ToString();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            double d;
            if (textBox7.Text == "")
            {
                d = 0;
                label38.Text = d.ToString();
            }
            else
            {
                d = double.Parse(textBox7.Text);
                label38.Text = d.ToString();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            double d;
            if (textBox8.Text == "")
            {
                d = 0;
                label39.Text = d.ToString();
            }
            else
            {
                d = double.Parse(textBox8.Text);
                label39.Text = d.ToString();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            double d;
            if (textBox9.Text == "")
            {
                d = 0;
                label40.Text = d.ToString();
            }
            else
            {
                d = double.Parse(textBox9.Text);
                label40.Text = d.ToString();
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            double d;
            if (textBox11.Text == "")
            {
                d = 0;
                label41.Text = d.ToString();
            }
            else
            {
                d = double.Parse(textBox11.Text);
                label41.Text = d.ToString();
            }
        }

        private void label36_VisibleChanged(object sender, EventArgs e)
        {
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label17.Visible = false;
            label28.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
