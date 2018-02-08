using System;
using System.Windows.Forms;
using System.Media;

namespace SoundBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Crickets_Click(object sender, EventArgs e)
        {
            SoundPlayer cricketSound = new SoundPlayer(@"..\..\Sounds\Chatwheel_cricket.wav");
            cricketSound.Play();
        }

        private void Frog_Click(object sender, EventArgs e)
        {
            SoundPlayer frogSound = new SoundPlayer(@"..\..\Sounds\Chatwheel_frog.wav");
            frogSound.Play();
        }

        private void Disastah_Click(object sender, EventArgs e)
        {
            SoundPlayer disastahSound = new SoundPlayer(@"..\..\Sounds\Chatwheel_disastah.wav");
            disastahSound.Play();
        }

        private void CryBaby_Click(object sender, EventArgs e)
        {
            SoundPlayer cryBabySound = new SoundPlayer(@"..\..\Sounds\Chatwheel_crybaby.wav");
            cryBabySound.Play();
        }

        private void Patience_Click(object sender, EventArgs e)
        {
            SoundPlayer patienceSound = new SoundPlayer(@"..\..\Sounds\Chatwheel_patience.wav");
            patienceSound.Play();
        }

        private void Brutal_Click(object sender, EventArgs e)
        {
            SoundPlayer brutalSound = new SoundPlayer(@"..\..\Sounds\Chatwheel_brutal.wav");
            brutalSound.Play();
        }

        private void Ehto_Click(object sender, EventArgs e)
        {
            SoundPlayer ehtoSound = new SoundPlayer(@"..\..\Sounds\Chatwheel_ehto_g_g.wav");
            ehtoSound.Play();
        }

        private void AllDead_Click(object sender, EventArgs e)
        {
            SoundPlayer allDeadSound = new SoundPlayer(@"..\..\Sounds\Chatwheel_all_dead.wav");
            allDeadSound.Play();
        }
    }
}
