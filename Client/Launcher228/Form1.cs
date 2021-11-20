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
    public partial class Login : Form
    {
        string domen = "http://fan9.ru/"; // доменное имя вашего сайта + путь до папки с php скриптами
        public Login()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length >= 6)
            {
                string username = textBox1.Text;
                string pass = crypt.Cryptor228(textBox2.Text, "pass");
                WebClient wc = new WebClient();
                if (wc.DownloadString(domen + "login.php?username=" + username + "&password=" + pass).Contains("da"))
                {
                    log.Text = "Вы успешно авторизовались!";
                }
                else
                {
                    log.Text = "Неверные логин/пароль";
                }
            }
            else
            {
                log.Text = "Ваш пароль меньше 6 символов!";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            registration reg = new registration();
            reg.Show();
        }
    }
}
