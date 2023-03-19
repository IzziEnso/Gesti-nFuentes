using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDeFuentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelText_Click(object sender, EventArgs e)
        {

        }

        private void buttonNegrita_Click(object sender, EventArgs e)
        {
            labelText.Font = new Font(labelText.Font, FontStyle.Bold);
            labelText.Font = new Font(labelText.Font, FontStyle.Bold);
            changeFontStyle(FontStyle.Bold);
        }

        private void buttonCursiva_Click(object sender, EventArgs e)
        {
            labelText.Font = new Font(labelText.Font, FontStyle.Italic);
            labelText.Font = new Font(labelText.Font, FontStyle.Italic);
            changeFontStyle(FontStyle.Italic);
        }

        private void buttonSubrayada_Click(object sender, EventArgs e)
        {
            labelText.Font = new Font(labelText.Font, FontStyle.Underline);
            labelText.Font = new Font(labelText.Font, FontStyle.Underline);
            changeFontStyle(FontStyle.Underline);

        }
        public void changeFontStyle(FontStyle style)
        {
            labelText.Font = new Font(labelText.Font, style);
        }
    }
}
