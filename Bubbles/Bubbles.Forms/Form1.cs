using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubbles.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            string[] phrases = new string[] { "You clicked a button!", "Your hands are shaking!", "I know you are lying!"};
            Random r = new Random();
            int stringNumber = r.Next(0, phrases.Length);
            MessageBox.Show(phrases[stringNumber]);
        }
    }
}
