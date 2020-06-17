using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_тимп
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button9.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
        }


        public void Lock (int i)
        {
            if (i == 1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
            if(i==0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
            }
        } 
        bool voda = false;
        int i;
        int tk;
        string c;
        string t;
        int interval;


        public void Stirka(int time)
        {
            while (time>time*0.95)
            {
                textBox9.Text = "Набираю воду";
                voda = true;

            }
            textBox9.Text = "Набираю воду";
            while (time > time * 0.9)
            {
                textBox9.Text = "Развожу порошок";
            }
            while (time > time * 0.2 && time < time * 0.89)
            {
                textBox9.Text = "Моем моем трубочиста, чисто чисто чисто чисто /n Будет будет трубочист чист чист чист чист";
            }
            while (time > time * 0.06 && time < time * 0.19)
            {
                textBox9.Text = "Идет отжим";
            }
            while (time > time * 0.01 && time < time * 0.05)
            {
                textBox9.Text = "Сливаю воду";
            }
            if (time == 0)
            {
                textBox9.Text = "Конец";
                pictureBox1.BackgroundImage = Properties.Resources.открытаяя_дверь;
            }
        }



        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

 

       
        // хлопок 95
        private void Button2_Click_1(object sender, EventArgs e)
        {
           
            textBox7.BackColor = Color.Gray;
            textBox6.BackColor = Color.Gray;
            textBox8.Text = "95";
            textBox2.Text = "Хлопок 95";
            textBox3.Text = "1200";
            t = "1:40";
            textBox4.Text = t;
            interval = 100;

            
        }

        // старт
        private void Button7_Click(object sender, EventArgs e)
        {
            
            pictureBox1.BackgroundImage = Properties.Resources.закрыто;
            Lock(1);
            button7.Enabled = false;
            button8.Enabled = true;
            i = interval;
            c = t;
            textBox9.Text = "Набираю воду...";
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
           
           

        }
        // эко
        private void Button3_Click(object sender, EventArgs e)
        {
           
                textBox7.BackColor = Color.Lime;
                textBox6.BackColor = Color.Gray;
                textBox8.Text = "35";
                textBox2.Text = "Эко";
                textBox3.Text = "800";
                t = "7:30";
                textBox4.Text = t;
                interval = 450;

            
        }

        // вкл
        private void Button6_Click(object sender, EventArgs e)
        {
            Lock(0);
            button6.Enabled = false;
            button9.Enabled = true;
            button8.Enabled = true;
            button7.Enabled = true;

        }

        // выкл
        private void Button9_Click(object sender, EventArgs e)
        {
            
            Lock(1);
            button6.Enabled = true;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            tk = --i;
            TimeSpan span = TimeSpan.FromMinutes(tk);
            string label = span.ToString(@"hh\:mm");
            textBox1.Text = label.ToString();
            if (i < 0)
                timer1.Stop();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.Gray;
            textBox6.BackColor = Color.Lime;
            textBox8.Text = "40";
            textBox2.Text = "Быстрая";
            textBox3.Text = "1400";
            t = "3:00";
            textBox4.Text = t;
            interval = 180;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.Gray;
            textBox6.BackColor = Color.Gray;
            textBox8.Text = "50";
            textBox2.Text = "Синтетика";
            textBox3.Text = "1000";
            t = "5:00";
            textBox4.Text = t;
            interval = 300;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.Gray;
            textBox6.BackColor = Color.Gray;
            textBox8.Text = "/--/";
            textBox2.Text = "Отжим";
            textBox3.Text = "1600";
            t = "1:30";
            textBox4.Text = t;
            interval = 90;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Lock(0);
            timer1.Stop();
            MessageBox.Show("Внимание! Сливаю оставшуюся воду...");
            if (voda == false)
                pictureBox1.BackgroundImage = Properties.Resources.открытаяя_дверь;
            else
                pictureBox1.BackgroundImage = Properties.Resources.закрыто;
        }
    }
}

    

