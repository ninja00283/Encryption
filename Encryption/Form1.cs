using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class Form1 : Form
    {

        string FilePath = "";
        bool HasFile = false;

        Random rnd = new Random();

        public Form1()
        {

            InitializeComponent();
        }

        private void EncryptClick(object sender, EventArgs e)
        {
            if (HasFile)
            {
                string TextToEncrypt = File.ReadAllText(FilePath);
                char[] Split = TextToEncrypt.ToCharArray();
                List<byte> Bytes = new List<byte>();
                foreach (byte b in Encoding.UTF8.GetBytes(Split)) { Bytes.Add(b); };

                char[] FinalChar = new char[Bytes.Count];
                string Binary = "";

                for (int i = 0; i < Bytes.Count; i++)
                {
                    int Direction = rnd.Next(2);

                    Binary += Direction.ToString();

                    Direction = 1 - Direction * 2;

                    FinalChar[i] = Convert.ToChar(Bytes[i]+ Direction);
                }

                KeyTextBox.Text = Binary;

                using (var tw = new StreamWriter(Path.GetDirectoryName(FilePath)+"\\" + Path.GetFileNameWithoutExtension(FilePath) + "_Encrpyted.txt" , true))
                {
                    tw.WriteLine(new string(FinalChar));
                }
            }
        }

        private void DecryptClick(object sender, EventArgs e)
        {
            if (HasFile)
            {
                char[] Key = KeyTextBox.Text.ToCharArray();
                Console.WriteLine(Key);
                string TextToDecrypt = File.ReadAllText(FilePath);
                char[] Split = TextToDecrypt.ToCharArray();


                List<byte> Bytes = new List<byte>();
                foreach (byte b in Encoding.UTF8.GetBytes(Split)) { Bytes.Add(b); };

                char[] FinalChar = new char[Bytes.Count];

                for (int i = 0; i < Key.Count(); i++)
                {
                    int Direction = 1 - int.Parse(Key[i].ToString()) * 2;
                    FinalChar[i] = Convert.ToChar(Bytes[i] - Direction);
                }

                using (var tw = new StreamWriter(Path.GetDirectoryName(FilePath) + "\\" + Path.GetFileNameWithoutExtension(FilePath) + "_Decrpyted.txt", true))
                {
                    tw.WriteLine(new string(FinalChar));
                }
            }
        }
        /// <summary>
        /// get a file and store it's path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseFileClick(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                if (Path.GetExtension(file) == ".txt")
                {
                    try
                    {
                        string text = File.ReadAllText(file);
                        size = text.Length;
                        FilePath = file;
                    }
                    catch (IOException)
                    {
                    }
                    PathTextBox.Text = FilePath;
                    HasFile = true;

                }
                else{
                    PathTextBox.Text = "Not a .txt file.";
                }

            }
            
        }

        
    }

}
