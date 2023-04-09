using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int count = 0;

            string c = "Резюме";
            string c1 = "Имя: User";
            string c2 = "Фамилия: Windows";
            string c3 = "Должность: Program";

            int l = (c1.Length+c2.Length+c3.Length)/3;
            string length = l.ToString();

            MessageBox.Show(c1 , c, MessageBoxButtons.OK, MessageBoxIcon.Question);
            MessageBox.Show(c2, c, MessageBoxButtons.OK, MessageBoxIcon.Question);
            MessageBox.Show(c3, length, MessageBoxButtons.OK, MessageBoxIcon.Question);


            Random r = new Random();
            while(true)
            {
                int rand = r.Next(1, 2000);
                DialogResult result = MessageBox.Show($"Ваше число{rand}?", "Угадывание числа", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"На отгадывания ушло: {count} попыток", "Угадывание числа");
                }
                else if (result == DialogResult.No)
                {
                    count++;
                }
            }
        }
    }
}
