using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary1;

namespace windform
{
    public partial class FormMain : Form

    {
        private string name;
        public FormMain()
        {
            InitializeComponent();
        }

        static string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789-!)(_№;%:?*+=/.,";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_ForEncrypt(object sender, EventArgs e)
        {

        }

        private void textBox1_ForDecrypt(object sender, EventArgs e)
        {
            
        }

        private void button_SaveFileForDecrypt(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox1.Text);
            }
        }

        private void button_OpenFileForEncrypt(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                textBox2.Clear();
                textBox2.Text = File.ReadAllText(name);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = crypt.ForEncrypt(textBox2.Text, alphabet, numericUpDown1.Value);
            textBox2.Clear();
        }

        private Class1 crypt = new Class1();
        
        
        private void button6_Click(object sender, EventArgs e)
        {
            {
                textBox2.Text = decrypt.ForDecrypt(textBox1.Text, alphabet, numericUpDown1.Value);
                textBox1.Clear();            
            }
        }

        private Class1 decrypt = new Class1();


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

       

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox2.Text);
            }
        }

        private void button_OpenFileForDecrypt(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = File.ReadAllText(name);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уверены?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            textBox1.Clear();
            textBox2.Clear();
            numericUpDown1.Value = 0;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }

       

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 3;
            textBox2.Text = "Чтобы воспользоваться программой, первым делом, задайте количество символов, на которое будет сдвигаться текст (свой ключ шифровки), затем внесите свой текст в одно из двух полей (Для шифровки или расшифровки). Для теста можете зашифровать и расшифровать этот текст.";
        }
    }
}
