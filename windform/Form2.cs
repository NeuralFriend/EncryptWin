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

namespace windform
{


    public partial class Form2 : Form
    {
        private string name;
        public Form2()
        {
            InitializeComponent();
        }

        static string all = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789-!)(_№;%:?*+=/.,";

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button_GoToForm1(object sender, EventArgs e)
        {
            this.Hide();
            FormMain f1 = new FormMain();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = decrypt(textBox1.Text);
        }
        public string decrypt(string inp)
        {
            StringBuilder code = new StringBuilder();
            if (textBox1.Text != null && textBox1.Text != "") ;
            else
                MessageBox.Show("Введите или загрузите текст в поле для шифрования!", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            string a = textBox1.Text;
            int b = 4;

            for (int i = 0; i < a.Length; i++)
                for (int e = 0; e < all.Length; e++)
                    if (a[i] == all[e]) code.Append(all[(e + b + all.Length) % all.Length]);
            textBox1.Clear();
            return code.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = encrypt(textBox2.Text);
        }
        public string encrypt(string inp)
        {
            StringBuilder code = new StringBuilder();
            if (textBox2.Text != null && textBox2.Text != "");
            else
                MessageBox.Show("Введите или загрузите текст в поле расшифровки!", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            string a = textBox2.Text;
            int b = 4;

            for (int i = 0; i < a.Length; i++)
                for (int e = 0; e < all.Length; e++)
                    if (a[i] == all[e]) code.Append(all[(e - b + all.Length) % all.Length]);

            textBox2.Clear();
            return code.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox1.Text);
            }
        }

        private void button_OpenFile(object sender, EventArgs e)
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {
                name = openFileDialog1.FileName;
                textBox2.Clear();
                textBox2.Text = File.ReadAllText(name);
            }
        }

        private void button_SaveFile(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox2.Text);
            }
        }

        private void button_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_LoadAnotherForm(object sender, EventArgs e)
        {
            this.Hide();
            Form1 m = new Form1();
            m.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Чтобы воспользоваться программой, внесите свой текст в одно из двух полей (Для шифровки или расшифровки). Для теста можете зашифровать и расшифровать этот текст.";
        }
    }
}