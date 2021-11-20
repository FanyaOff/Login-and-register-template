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
using CryptPass;

namespace Launcher228
{
    public partial class registration : Form
    {
        string domen = "http://fan9.ru/"; // доменное имя вашего сайта + путь до папки с php скриптами
        public registration()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }


        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text.Length >= 6)
            {
                WebClient wc = new WebClient();
                string username = textBox1.Text;
                string pass = crypt.Cryptor228(textBox2.Text, "pass");
                if (wc.DownloadString(domen + "reg.php?username=" + username + "&password=" + pass).Contains("reg"))
                {
                    log.Text = "Вы успешно зарегистрировались!";
                }
                else
                {
                    log.Text = "Данный ник уже занят!";
                }
            }
            else
            {
                log.Text = "Ваш пароль меньше 6 символов!";
            }
        }
    }
}
