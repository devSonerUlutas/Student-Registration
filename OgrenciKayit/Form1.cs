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

namespace OgrenciKayit
{
    public partial class Form1 : Form
    {
        string path = @"C:\Users\uluta\OneDrive\Masaüstü\Ogrenci Dos\";
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string textInFile = "";
            string studentFilePath = path + NumberTxtB.Text + ".txt";
            
           
            textInFile += (NumberTxtB.Text) + Environment.NewLine;
            textInFile += (NameSurnameTxtB.Text) + Environment.NewLine;
            textInFile += (AdressTxtB.Text);

            using (StreamWriter sw = new StreamWriter(studentFilePath))
            {
                sw.WriteLine(textInFile.ToString());
                sw.Close();
            }
            
            NumberTxtB.Clear();
            NameSurnameTxtB.Clear();
            AdressTxtB.Clear();
        }
    }
}
