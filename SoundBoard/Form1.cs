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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Crickets_Click(object sender, EventArgs e)
        {
            if(isPlaying) {
                return;
            }
            SoundPlayer cricketSound = new SoundPlayer(@"..\..\Sounds\Chatwheel_cricket.wav");
            isPlaying = true;
            isPlaying = true;
            cricketSound.Play();
            isPlaying = false;
        }

        private void Frog_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                return;
            }
            SoundPlayer frogSound = new SoundPlayer(@"..\..\Sounds\Chatwheel_frog.wav");
            isPlaying = true;
            frogSound.Play();
            isPlaying = false;
        }

        private void Disastah_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                return;
            }
            SoundPlayer disastahSound = new SoundPlayer(@"..\..\Sounds\Chatwheel_disastah.wav");
            isPlaying = true;
            disastahSound.Play();
            isPlaying = false;
        }

        private void CryBaby_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                return;
            }
            SoundPlayer cryBabySound = new SoundPlayer(@"..\..\Sounds\Chatwheel_crybaby.wav");
            isPlaying = true;
            cryBabySound.Play();
            isPlaying = false;
        }

        private void Patience_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                return;
            }
            SoundPlayer patienceSound = new SoundPlayer(@"..\..\Sounds\Chatwheel_patience.wav");
            isPlaying = true;
            patienceSound.Play();
            isPlaying = false;
        }

        private void Brutal_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                return;
            }
            SoundPlayer brutalSound = new SoundPlayer(@"..\..\Sounds\Chatwheel_brutal.wav");
            isPlaying = true;
            brutalSound.Play();
            isPlaying = false;
        }

        private void Ehto_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                return;
            }
            SoundPlayer ehtoSound = new SoundPlayer(@"..\..\Sounds\Chatwheel_ehto_g_g.wav");
            isPlaying = true;
            ehtoSound.Play();
            isPlaying = false;
        }

        private void AllDead_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                return;
            }
            SoundPlayer allDeadSound = new SoundPlayer(@"..\..\Sounds\Chatwheel_all_dead.wav");
            isPlaying = true;
            allDeadSound.Play();
            isPlaying = false;
        }
    }
}
