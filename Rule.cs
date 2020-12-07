using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounterStrike
{
    public partial class Rule : Form
    {
        public Rule()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            GameLoadForm rules_obj = new GameLoadForm();
            rules_obj.Show();
            this.Hide();
        }
    }
}
