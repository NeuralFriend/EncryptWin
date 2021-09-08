using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Class1
    {
        public string ForEncrypt(string text, string alphabet, decimal value)

        {
            StringBuilder code = new StringBuilder();
            if (text != null && text != "") ;
            else
                MessageBox.Show("Введите или загрузите текст в поле для шифрования!", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            string a = text;
            int key;
            key = (int)value;
            for (int i = 0; i < a.Length; i++)
                for (int e = 0; e < alphabet.Length; e++)
                    if (a[i] == alphabet[e]) code.Append(alphabet[(e + key) % alphabet.Length]);
            
            return code.ToString();
        }
        public string ForDecrypt(string text, string alphabet, decimal value)
        {
            if (text != null && text != "") ;
            else
                MessageBox.Show("Введите или загрузите текст в поле расшифровки!", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            {
                StringBuilder code = new StringBuilder();
                string a = text;
                int key;
                key = (int)value;
                for (int i = 0; i < a.Length; i++)
                    for (int e = 0; e < alphabet.Length; e++)
                        if (a[i] == alphabet[e]) code.Append(alphabet[(e - key + alphabet.Length) % alphabet.Length]);
                return code.ToString();
            }
        }
    }

}
