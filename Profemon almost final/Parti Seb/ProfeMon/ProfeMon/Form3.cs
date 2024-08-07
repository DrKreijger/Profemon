using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfeMon
{
    public partial class Form3 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public readonly Form2 form2;
        public readonly Form1 form1;

        public Form3(Form2 form2)
        {
            InitializeComponent();
            this.form2 = form2;
            this.form1 = form1;
            player.SoundLocation = @".\Music_win.wav";
            //player.SoundLocation = @"C:\Users\Dr.Kreijger\Documents\Cours\Bloc 1\Programmation pratique\Q2\ProféMonV2\Profemon almost final\Parti Seb\ProfeMon\ProfeMon\Resources\Music_win.wav";
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            player.Play();
            if (form2.personnages1.IsDead == true)
            {
                WinnerName.Text = form2.personnages2.Name;
                WinnerImage.Image = form2.Prof2.Image;
                
            }

            if (form2.personnages2.IsDead == true)
            {
                WinnerName.Text = form2.personnages1.Name;
                WinnerImage.Image = form2.Prof1.Image;
            }
            
        }
    }
}
