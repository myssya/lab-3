using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            //Получаем значение текстового поля + отрезаем пробелы по краям:
            string userName = tbName.Text.Trim();
            if (userName.Length < 4)   //если длина имени пользователя слишком короткая, ошибка!
            {
                MessageBox.Show("Введите имя пользователя!");
            }
            else
            {
                MessageBox.Show("Привет " + userName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
