using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Tibia_Timers
{
    public partial class Form1 : Form
    {
        int TimerNeck = 0;
        int TimerRing = 0;
        int GlobalTimmer = 0;
        int TimerPotion = 600;
        System.Windows.Forms.Timer countdownTimer = new Timer();
        bool potionCheck = false;
        bool ringCheck = false;
        bool neckCheck = false;
        int originalTimeNeck = 0;
        int originalTimeRing = 0;



        public Form1()
        {
            InitializeComponent();
            StopBtn.Enabled = false;
            // Configurar el Timer
            countdownTimer.Interval = 1000; // 1 segundo
            countdownTimer.Tick += CountdownTimer_Tick;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            NeckTextBox.Enabled = false;
            RingTextBox.Enabled = false;
            PotionCheckBox.Enabled = false;
            StopBtn.Enabled = true;
            StartBtn.Enabled = false;

            if (!PotionCheckBox.Checked && string.IsNullOrEmpty(NeckTextBox.Text) && string.IsNullOrEmpty(RingTextBox.Text))
            {
                TitleLabel.Text = "llene algun campo para iniciar";
            }
            else if (PotionCheckBox.Checked || !string.IsNullOrEmpty(NeckTextBox.Text) || !string.IsNullOrEmpty(RingTextBox.Text))
            {
                if (string.IsNullOrEmpty(NeckTextBox.Text))
                {
                    NeckTextBox.Text = "0";
                }
                if (string.IsNullOrEmpty(RingTextBox.Text))
                {
                    RingTextBox.Text = "0";
                }
                if (PotionCheckBox.Checked)
                {
                    GlobalTimmer = 600;
                }

                TimerNeck = int.Parse(NeckTextBox.Text) * 60;
                TimerRing = int.Parse(RingTextBox.Text) * 60;
                originalTimeNeck = TimerNeck;
                originalTimeRing = TimerRing;
                if (TimerNeck > TimerRing)
                {
                    GlobalTimmer = TimerNeck;
                }
                if (TimerRing > TimerNeck)
                {
                    GlobalTimmer = TimerRing;
                }

                // Configurar el ProgressBar
                NeckProgressBar.Maximum = TimerNeck;
                NeckProgressBar.Value = TimerNeck;
                RingProgressBar.Maximum = TimerRing;
                RingProgressBar.Value = TimerRing;
                if (PotionCheckBox.Checked)
                {
                    PotionProgressBar.Maximum = TimerPotion;
                    PotionProgressBar.Value = TimerPotion;
                }

                // Iniciar el Timer
                higesthTimer();
                countdownTimer.Start();
                TitleLabel.Text = @$"Tibia timer countdown: {GlobalTimmer}";
            }
        }

        private void CountdownTimer_Tick(object? sender, EventArgs e)
        {
            if (GlobalTimmer > 0)
            {
                GlobalTimmer--;

                if (TimerNeck > 0)
                {
                    TimerNeck--;
                    NeckProgressBar.Value = TimerNeck;
                    if (TimerNeck < 60 && !neckCheck)
                    {
                        Alert("MENOS DE 1 MINUTO", "Tibia timer NECK");
                        neckCheck = true;
                    }
                }
                if (TimerRing > 0)
                {
                    TimerRing--;
                    RingProgressBar.Value = TimerRing;
                    if (TimerRing < 60 && !ringCheck)
                    {
                        Alert("MENOS DE 1 MINUTO", "Tibia timer RING");
                        ringCheck = true;
                    }
                }
                if (PotionCheckBox.Checked && TimerPotion > 0)
                {
                    TimerPotion--;
                    PotionProgressBar.Value = TimerPotion;
                    if (TimerPotion < 60 && !potionCheck)
                    {
                        Alert("MENOS DE 1 MINUTO", "Tibia timer POTION");
                        potionCheck = true;
                    }
                }
                int timerLbael = GlobalTimmer;
                TitleLabel.Text = @$"Tibia timer countdown: {timerLbael}";
            }
            else
            {
                countdownTimer.Stop();
                TitleLabel.Text = "¡Tiempo terminado!";
            }
        }
        private void higesthTimer()
        {
            int[] timers = { TimerNeck, TimerRing, TimerPotion };
            int highestTimer = timers.Max();
            GlobalTimmer = highestTimer;
            //TitleLabel.Text = @$"Tibia timer countdown: {GlobalTimmer}";
        }

        private void Alert(string message, string Title)
        {
            notifyIcon1.BalloonTipTitle = Title;
            notifyIcon1.Text = message;
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.BalloonTipText = message;
            notifyIcon1.ShowBalloonTip(500);
            notifyIcon1.Visible = true;
        }

        private void RingResetTimmerButton_Click(object sender, EventArgs e)
        {
            TimerRing = originalTimeRing;
            RingProgressBar.Maximum = originalTimeRing;
            RingProgressBar.Value = originalTimeRing;
            ringCheck = false;
            higesthTimer();
        }

        private void NeckResetTimmerButton_Click(object sender, EventArgs e)
        {
            TimerNeck = originalTimeNeck;
            NeckProgressBar.Maximum = originalTimeNeck;
            NeckProgressBar.Value = originalTimeNeck;
            neckCheck = false;
            higesthTimer();
        }

        private void PotionResetTimmerButton_Click(object sender, EventArgs e)
        {
            TimerPotion = 600;
            PotionProgressBar.Maximum = TimerPotion;
            PotionProgressBar.Value = TimerPotion;
            potionCheck = false;
            higesthTimer();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            NeckTextBox.Enabled = true;
            RingTextBox.Enabled = true;
            PotionCheckBox.Enabled = true;
            StopBtn.Enabled = false;
            TimerNeck = 0;
            TimerRing = 0;
            GlobalTimmer = 0;
            potionCheck = false;
            neckCheck = false;
            ringCheck = false;
            StartBtn.Enabled = true;
            countdownTimer.Stop();
        }
    }
}
