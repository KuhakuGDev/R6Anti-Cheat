using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AC_test
{
    public partial class Stats : Form
    {
        public Ahook a;
        public Stats(Ahook ahook)
        {
            InitializeComponent();

            a = ahook;
        }

        private void StatsTimer_Tick(object sender, EventArgs e)
        {
            KillsText.Text = "Kills: " + a.kills;
        }
    }
}
