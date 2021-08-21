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
        public string CurrentRank;
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
            MMRText.Text = "MMR: " + a.MMR;

            SetRank();
            RankText.Text = CurrentRank;
        }
        private void SetRank()
        {
            if (a.MMR < 0)
            {
                a.MMR = 0;
            }
            //Copper
            else if(a.MMR > 0 && a.MMR < 1200)
            {
                CurrentRank = "Cobre 5";
                RankImage.Image = Properties.Resources.copper_5;
            }
            else if(a.MMR >= 1200 && a.MMR < 1300)
            {
                CurrentRank = "Cobre 4";
                RankImage.Image = Properties.Resources.copper_4;
            }
            else if (a.MMR >= 1300 && a.MMR < 1400)
            {
                CurrentRank = "Cobre 3";
                RankImage.Image = Properties.Resources.copper_3;
            }
            else if (a.MMR >= 1400 && a.MMR < 1500)
            {
                CurrentRank = "Cobre 2";
                RankImage.Image = Properties.Resources.copper_2;
            }
            else if (a.MMR >= 1500 && a.MMR < 1600)
            {
                CurrentRank = "Cobre 1";
                RankImage.Image = Properties.Resources.copper_1;
            }
            //Bronze
            else if (a.MMR >= 1600 && a.MMR < 1700)
            {
                CurrentRank = "Bronce 5";
                RankImage.Image = Properties.Resources.Bronze_5;
            }
            else if (a.MMR >= 1700 && a.MMR < 1800)
            {
                CurrentRank = "Bronce 4";
                RankImage.Image = Properties.Resources.Bronze_4;
            }
            else if (a.MMR >= 1800 && a.MMR < 1900)
            {
                CurrentRank = "Bronce 3";
                RankImage.Image = Properties.Resources.Bronze_3;
            }
            else if (a.MMR >= 1900 && a.MMR < 2000)
            {
                CurrentRank = "Bronce 2";
                RankImage.Image = Properties.Resources.Bronze_2;
            }
            else if (a.MMR >= 2000 && a.MMR < 2100)
            {
                CurrentRank = "Bronce 1";
                RankImage.Image = Properties.Resources.Bronze_1;
            }
            //Silver
            else if (a.MMR >= 2100 && a.MMR < 2200)
            {
                CurrentRank = "Plata 5";
                RankImage.Image = Properties.Resources.Silver_5;
            }
            else if (a.MMR >= 2200 && a.MMR < 2300)
            {
                CurrentRank = "Plata 4";
                RankImage.Image = Properties.Resources.Silver_4;
            }
            else if (a.MMR >= 2300 && a.MMR < 2400)
            {
                CurrentRank = "Plata 3";
                RankImage.Image = Properties.Resources.Silver_3;
            }
            else if (a.MMR >= 2400 && a.MMR < 2500)
            {
                CurrentRank = "Plata 2";
                RankImage.Image = Properties.Resources.Silver_2;
            }
            else if (a.MMR >= 2500 && a.MMR < 2600)
            {
                CurrentRank = "Plata 1";
                RankImage.Image = Properties.Resources.Silver_1;
            }
            //Gold
            else if (a.MMR >= 2600 && a.MMR < 2800)
            {
                CurrentRank = "Oro 3";
                RankImage.Image = Properties.Resources.Gold_3;
            }
            else if (a.MMR >= 2800 && a.MMR < 3000)
            {
                CurrentRank = "Oro 2";
                RankImage.Image = Properties.Resources.Gold_2;
            }
            else if (a.MMR >= 3000 && a.MMR < 3200)
            {
                CurrentRank = "Oro 1";
                RankImage.Image = Properties.Resources.Gold_1;
            }
            //Platinum
            else if (a.MMR >= 3200 && a.MMR < 2600)
            {
                CurrentRank = "Platino 3";
                RankImage.Image = Properties.Resources.Platinum_3;
            }
            else if (a.MMR >= 3600 && a.MMR < 4000)
            {
                CurrentRank = "Platino 2";
                RankImage.Image = Properties.Resources.Platinum_2;
            }
            else if (a.MMR >= 4000 && a.MMR < 4400)
            {
                CurrentRank = "Platino 1";
                RankImage.Image = Properties.Resources.Platinum_1;
            }
            //Diamond
            else if(a.MMR >= 4400)
            {
                CurrentRank = "Diamante";
                RankImage.Image = Properties.Resources.Diamond;
            }

            if(a.MMR < 2600)
            {
            }
        }
    }


}
