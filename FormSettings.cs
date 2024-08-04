using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FormSettings : Form
    {
        public int fontSize = 0;
        public System.Drawing.FontStyle fsT = FontStyle.Regular; // отвечает за его размер и стиль
        public FormSettings()
        {
            InitializeComponent();
            fontBox.SelectedItem = fontBox.Items[0];
            styleBox.SelectedItem = styleBox.Items[0]; // базовые значения(comboBox - массив)
        }

        private void onClick(object sender, EventArgs e)
        {

        }

        private void onFontChanged(object sender, EventArgs e)
        {
            labelTextEx.Font = new Font(labelTextEx.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), labelTextEx.Font.Style);
            fontSize = int.Parse(fontBox.SelectedItem.ToString());
        }

        private void onStyleChange(object sender, EventArgs e)
        {
            switch(styleBox.SelectedItem.ToString())
            {
                case "обычный":
                    labelTextEx.Font = new Font(labelTextEx.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), FontStyle.Regular);
                    break;
                case "курсив":
                    labelTextEx.Font = new Font(labelTextEx.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), FontStyle.Italic);
                    break;
                case "жирный":
                    labelTextEx.Font = new Font(labelTextEx.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), FontStyle.Bold);
                    break;
            }
            fsT = labelTextEx.Font.Style; // начертание теста сохраняется в перменную fsT 
        }

        private void accept_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
