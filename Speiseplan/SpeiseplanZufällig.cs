using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speiseplan
{
    public partial class SpeiseplanZufällig : Form
    {
        internal static SpeiseplanZufällig f3;

        public SpeiseplanZufällig()
        {
            f3 = this;
            InitializeComponent();
        }

        Datenbank db;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
