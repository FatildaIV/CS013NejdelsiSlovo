using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS013NejdelsiSLovo
{
    public partial class NejdelsiSlovoForm : Form
    {
        public NejdelsiSlovoForm()
        {
            InitializeComponent();
        }

        static string NejdelsiSlovo(string text)
        {
            string[] words = text.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
            return word;
        }

        private void VstupTextBox_TextChanged(object sender, EventArgs e)
        { 
            NejdelsiSlovoLabel.Text = SlovoDelkaLabel(VstupTextBox.Text);
            SlovoDelkaLabel.Text = NejdelsiSlovoLabel.Text.Length.ToString();
        }
    }
}
