using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211214_ArrrayOrnek
{
    public partial class Form1 : Form
    {
        int[] numbers = { 14, 2, 30, 54, 59 };
        ArrayList logs = new ArrayList();
        int index = 1;
        

        public Form1()
        {
            InitializeComponent();            
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            ShowMethod();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            EnterMethod();
        }

        private void random_button_Click(object sender, EventArgs e)
        {
            RandomMethod();
        }

        void ShowMethod()
        {
            int max_number = numbers.Max();
            int min_number = numbers.Min();

            MessageBox.Show($"Serideki en küçük sayı {min_number}, en büyük sayı ise {max_number}.");
        }

        void EnterMethod()
        {
            if (input_textbox.Text.Trim() != "")
            {
                string text = input_textbox.Text;
                logs.Add(input_textbox.Text);
                display_listbox.Items.Add(index.ToString()+"-"+text);
                index++;
            }
        }

        void RandomMethod()
        {
            Random rand = new Random();
            MessageBox.Show(numbers[rand.Next(0, numbers.Length)].ToString());
        }
    }
}
