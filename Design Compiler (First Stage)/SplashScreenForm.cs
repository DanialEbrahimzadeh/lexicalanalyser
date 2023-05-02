using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Compiler__First_Stage_
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
            SplashScreenForm_Preparation();
        }

        private void SplashScreenForm_Preparation()
        {
            try
            {
                //this.BackColor = Color.FromArgb(29, 29, 29);
                LoadingPictureBox.Image = Image.FromFile("..\\..\\images\\loading.gif");
                FirstLogoPictureBox.Image = Image.FromFile("..\\..\\images\\firstlogo.png");
                this.BackgroundImage = Image.FromFile("..\\..\\images\\back1.png");
            }
            catch { }
        }

        //Use timer class
        Timer tmr;
        private void SplashScreenForm_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            //set time interval 15 sec
            tmr.Interval = 7000;
            //starts the timer
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            //after 3 sec stop the timer
            tmr.Stop();
            //display mainform
            Form1 myMainForm = new Form1();
            myMainForm.Show();
            //hide this form
            this.Hide();
        }
    }
}
