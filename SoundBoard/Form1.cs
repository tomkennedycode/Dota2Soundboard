using System;
using System.Windows.Forms;
using System.Media;

namespace SoundBoard
{
    public partial class Form1 : Form
    {
        bool isPlaying = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void playSound(string soundLoc)
        {
            if (isPlaying)
            {
                return;
            }
            SoundPlayer soundply = new SoundPlayer(soundLoc);
            isPlaying = true;
            soundply.Play();
            isPlaying = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Crickets_Click(object sender, EventArgs e)
        {
            playSound(@"..\..\Sounds\Chatwheel_cricket.wav");
        }

        private void Frog_Click(object sender, EventArgs e)
        {
            playSound(@"..\..\Sounds\Chatwheel_frog.wav");
        }

        private void Disastah_Click(object sender, EventArgs e)
        {
            playSound(@"..\..\Sounds\Chatwheel_disastah.wav");
        }

        private void CryBaby_Click(object sender, EventArgs e)
        {
            playSound(@"..\..\Sounds\Chatwheel_crybaby.wav");
        }

        private void Patience_Click(object sender, EventArgs e)
        {
            playSound(@"..\..\Sounds\Chatwheel_patience.wav");
        }

        private void Brutal_Click(object sender, EventArgs e)
        {
            playSound(@"..\..\Sounds\Chatwheel_brutal.wav");
        }

        private void Ehto_Click(object sender, EventArgs e)
        {
            playSound(@"..\..\Sounds\Chatwheel_ehto_g_g.wav");
        }

        private void AllDead_Click(object sender, EventArgs e)
        {
            playSound(@"..\..\Sounds\Chatwheel_all_dead.wav");
        }
    }
}
