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

namespace Notepad
{
    public partial class FormNote : Form
    {
        public int fontSize = 0;
        public System.Drawing.FontStyle fsT = FontStyle.Regular;
        public string filename;
        public bool isFileChanged;
        public FormSettings fontSetts;
        public FormNote()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            filename = "";
            isFileChanged = false;
            updateText();
        }

        public void createDoc(object sender, EventArgs e)
        {
            saveFileBeforeClose();
            textBox1.Text = "";
            filename = "";
            updateText();
        }

        public void openFile(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            saveFileBeforeClose();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    textBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    filename = openFileDialog1.FileName;
                    isFileChanged = false;
                } catch
                {
                    MessageBox.Show("невозможно открыть файл");
                }
            }
        }

         public void SaveFile(string _filename) 
         {
            if(_filename == "")
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _filename = saveFileDialog1.FileName;
                }
                try
                {
                    StreamWriter sw = new StreamWriter(_filename + ".txt");
                    sw.Write(textBox1.Text);
                    sw.Close();
                    filename = _filename;
                    isFileChanged = false;
                } catch
                {
                    MessageBox.Show("Не удалось сохранить файл");
                }
            }
            updateText();
         }

        public void Save(object sender, EventArgs e)
        {
            SaveFile(filename);
        }

        public void SaveAs(object sender, EventArgs e)
        {
            SaveFile("");
        }
        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void onTextChange(object sender, EventArgs e)
        {
            
            if(!isFileChanged)
            {
                this.Text = this.Text.Replace('*', ' ');
                isFileChanged = true;
                this.Text = "*" + this.Text;
            }
            
        }

        public void updateText()
        {
            if (filename != "") this.Text = filename + " - блокнот";
            else this.Text = "Безымянный блокнот";
            
        }

        public void saveFileBeforeClose()
        {
            if(isFileChanged) {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "Сохранить", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if(result == DialogResult.Yes)
                {
                    SaveFile(filename);
                }
            }
        }

        public void copyTextP()
        {
            Clipboard.SetText(textBox1.SelectedText);
        }
        public void cutTextp()
        {
            Clipboard.SetText(textBox1.Text.Substring(textBox1.SelectionStart, textBox1.SelectionLength));
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength); // итоговый текст без того что вырезали
        }
        public void putTextp()
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.SelectionStart) + Clipboard.GetText() + textBox1.Text.Substring(textBox1.SelectionStart, textBox1.Text.Length-textBox1.SelectionStart);
        }

        private void copyText(object sender, EventArgs e)
        {
            copyTextP();
        }
        private void cutText(object sender, EventArgs e)
        {
            cutTextp();
        }

        private void putText(object sender, EventArgs e)
        {
            putTextp();
        }
        private void closingOmg(object sender, FormClosingEventArgs e)
        {
            saveFileBeforeClose();
        }

        private void onFontOpen(object sender, EventArgs e)
        {
            fontSetts = new FormSettings();
            fontSetts.Show();
        }

        private void onFocus(object sender, EventArgs e)
        {
            if(fontSetts != null)
            {
                fontSize = fontSetts.fontSize;
                fsT = fontSetts.fsT;
                textBox1.Font = new Font(textBox1.Font.FontFamily, fontSize, fsT);
                fontSetts.Close();
            }
        }
    }
}
