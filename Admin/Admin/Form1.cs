using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Admin
{
    public partial class Form1 : Form
    {

        string stdEm;
        string stdNik;
        string aboutSt;
        string time;
        string adress;
        string thame;
        string moderator;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == stdNik)
            {
                button4.Text = "sucsses";
                button4.BackColor = Color.Lime;
                timer1.Start();
                sendEmail(textBox1.Text, stdEm);
            }
            else
                textBox2.Text = "wrong nik";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "bek" && textBox4.Text == "123")
            {
                panel2.Visible = false;
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else
            {
                textBox3.Text = "wrong login or password";
            }
        }

        private void sendEmail(string str, string stEmail)
        {
            try
            {


                MailAddress from = new MailAddress("bekabotclient@yandex.ru", "Client");
                MailAddress to = new MailAddress(stEmail);//Email  wich will get messege
                MailMessage message = new MailMessage(from, to);
                message.Body = str;
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.yandex.ru";
                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 1000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("bekabotclient@yandex.ru", "qwertyegatef");//Email and password wich from will send messege

                System.Threading.Thread.Sleep(500);
                client.Send(message);




            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;

        }


        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            stdEm = textBox7.Text;
            aboutSt = textBox6.Text;
            stdNik = textBox5.Text;

            textBox7.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";

            stlist.Text = stlist.Text + " nik: " +  stdNik + '\r' + '\n' + " email: " + stdEm + '\r' + '\n' + " characteristick: "+  aboutSt + '\r' + '\n'+ '\r' + '\n' +'\r' + '\n';
            panel3.Visible = false;
        }

        Boolean bl = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bl)
            {
                button4.Text = "send";
                button4.BackColor = Color.White;
                timer1.Stop();
            }
            else
                bl = !bl;

        }

        private void button9_Click(object sender, EventArgs e)
        {


        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                time = textBox8.Text;
                adress = textBox9.Text;
                thame = textBox10.Text;
                moderator = textBox11.Text;
                panel4.Visible = false;

                textBox12.Text = textBox12.Text + " time: " + time.ToString() + '\r' + '\n' + " adress: " + adress + '\r' + '\n' + " thame: " + thame + '\r' + '\n' + " moderator: " + moderator + '\r' + '\n' + '\r' + '\n' + '\r' + '\n';
                panel4.Visible = false;

            }
            catch (Exception)
            {
                textBox8.Text = "ups, some problem";
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = " time: " + time + '\r' + '\n' + " adress: " + adress + '\r' + '\n' + " thame: " + thame + '\r' + '\n' + " moderator: " + moderator + '\r' + '\n';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }
    }

 

}
