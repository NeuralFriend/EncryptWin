using System;

namespace LibraryCrypt
{
    public class Class1
    {
        public string api(string api)

        {
            StringBuilder code = new StringBuilder();
            if (textBox2.Text != null && textBox2.Text != "") ;
            else
                MessageBox.Show("Введите или загрузите текст в поле для шифрования!", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            string a = textBox2.Text;
            int key;
            key = (int)numericUpDown1.Value;
            for (int i = 0; i < a.Length; i++)
                for (int e = 0; e < alphabet.Length; e++)
                    if (a[i] == alphabet[e]) code.Append(alphabet[(e + key) % alphabet.Length]);
            textBox2.Clear();
            return code.ToString();
        }
    }
}
