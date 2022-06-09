using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Speech.Synthesis;

namespace Warn_Me_Please
{
    public partial class Form1 : Form
    {
        Ping pingSender = new Ping();
        PingOptions options = new PingOptions();
        bool alreadysaid = false;

        string euwAdress = "104.160.141.3";

        public Form1()
        {
            InitializeComponent();

            options.DontFragment = true;
            tbAdress.Text = "Riot Server EUW";
        }

        private void tmrDoThat_Tick(object sender, EventArgs e)
        {
            string adresstaking = tbAdress.Text;

            if (tbAdress.Text == "Riot Server EUW")
                adresstaking = euwAdress;

            if (cbShallDo.Checked)
            {
                string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 120;

                PingReply reply = pingSender.Send(adresstaking, timeout, buffer, options);

                if (reply.Status == IPStatus.Success)
                {
                    lbPing.Text = reply.RoundtripTime.ToString();
                    CheckIfGood(reply.RoundtripTime);
                }
                else
                {
                    lbPing.Text = "Error";
                    lbPing.ForeColor = Color.Purple;

                    if (cbWarnMe.Checked && alreadysaid == false)
                    {
                        SpeechSynthesizer synth = new SpeechSynthesizer();
                        synth.SetOutputToDefaultAudioDevice();
                        synth.SpeakAsync("Fehler bei Prüfung");

                        alreadysaid = true;
                    }
                }
            }
        }


        private void CheckIfGood(long ping)
        {
            // Good Ping
            if (ping < 40)
            {
                lbPing.ForeColor = Color.Green;
                alreadysaid = false;
                notIcon.Icon = Warn_Me_Please.Properties.Resources.errorGreen;
            }

            // Medium Ping
            else if (ping >= 40 && ping < 100)
            {
                lbPing.ForeColor = Color.Goldenrod;
                alreadysaid = false;
            }

            // Bad Ping
            else if (ping >= 100)
            {
                lbPing.ForeColor = Color.Red;

                if (alreadysaid == false && cbWarnMe.Checked)
                {
                    SpeechSynthesizer synth = new SpeechSynthesizer();
                    synth.SetOutputToDefaultAudioDevice();
                    synth.SpeakAsync("Hoher Ping");

                    alreadysaid = true;
                }
            }
        }

        private void cbShallDo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShallDo.Checked)
            {
                tbAdress.Enabled = false;
            }
            else
            {
                tbAdress.Enabled = true;
                lbPing.Text = "-";
                lbPing.ForeColor = SystemColors.ControlText;
            }
        }

        private void btnRiotGamesServer_Click(object sender, EventArgs e)
        {
            tbAdress.Text = "Riot Server EUW";
        }

        private void cbWarnMe_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWarnMe.Checked)
                alreadysaid = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notIcon.Visible = true;
                this.Hide();
            }
            else
            {
                notIcon.Visible = false;
            }
        }

        private void notIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
