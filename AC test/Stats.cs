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
            if(a.kills > 0 && a.deaths > 0)
            {
                a.kd =(float)a.kills / a.deaths;
                a.kd = Math.Round(a.kd, 1);
            }
            KillsText.Text = "Kills: " + a.kills;
            DeathsText.Text = "Deaths: " + a.deaths;
            KDText.Text = "KD: " + a.kd;
            VictoriasText.Text = "Victorias: " + a.victories;
            DerrotasText.Text = "Derrotas: " + a.loses;
            if(a.victories > 0 && a.loses > 0)
            {
                a.wr = (float)a.victories / a.loses;
                a.wr = Math.Round(a.wr, 1);
            }
            WinRateText.Text = "WinRate: " + a.wr;
        }
    }
}
