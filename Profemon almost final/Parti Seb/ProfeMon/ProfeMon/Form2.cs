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
    public partial class Form2 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Personnages personnages1;
        public Personnages personnages2;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            form3 = new Form3(this);
            player.SoundLocation = @".\Music_battle.wav";
            //player.SoundLocation = @"C:\Users\Dr.Kreijger\Documents\Cours\Bloc 1\Programmation pratique\Q2\ProféMonV2\Profemon almost final\Parti Seb\ProfeMon\ProfeMon\Resources\Music_battle.wav";
        }



        public int tom;
        public int pluquet;
        public int gosseye;
        public int wilfart;
        public int vdh;
        public int bivort;
        public int chot;
        public readonly Form1 form1;
        public bool J1turn = true;
        public bool J2turn = false;
        public int StunCounterJ1=0;
        public int StunCounterJ2 = 0;
        Form3 form3;



        public void Form2_Load(object sender, EventArgs e)
        {
            
            EnableJ1();
            DisableJ2();

            if (tom == 1)
            {
                label1.Text = "TOM";
                this.Prof1.Image = ProfeMon.Properties.Resources.T1;
            }
            else if (pluquet == 1)
            {
                label1.Text = "Pluquet";
                this.Prof1.Image = ProfeMon.Properties.Resources.P2;
            }
            else if (wilfart == 1)
            {
                label1.Text = "Wilfart";
                this.Prof1.Image = ProfeMon.Properties.Resources.W1;
            }
            else if (chot == 1)
            {
                label1.Text = "Chot";
                this.Prof1.Image = ProfeMon.Properties.Resources.C1;
            }
            else if (vdh == 1)
            {
                label1.Text = "VDH";
                this.Prof1.Image = ProfeMon.Properties.Resources.V1;
            }
            else if (gosseye == 1)
            {
                label1.Text = "Gosseye";
                this.Prof1.Image = ProfeMon.Properties.Resources.G1;
            }
            else if (bivort == 1)
            {
                label1.Text = "Bivort";
                this.Prof1.Image = ProfeMon.Properties.Resources.B1;
            }

            BarDeVie1.Maximum = 100;
            BarDeVie1.Minimum = 0;
            BarDeVie1.Value = 100;

            
            if (form1.click == 2)
            {
                if (tom == 2)
                {
                    label2.Text = "TOM";
                    this.Prof2.Image = ProfeMon.Properties.Resources.T1;
                }
                else if (pluquet == 2)
                {
                    label2.Text = "Pluquet";
                    this.Prof2.Image = ProfeMon.Properties.Resources.P2;
                }
                else if (wilfart == 2)
                {
                    label2.Text = "Wilfart";
                    this.Prof2.Image = ProfeMon.Properties.Resources.W1;
                }
                else if (chot == 2)
                {
                    label2.Text = "Chot";
                    this.Prof2.Image = ProfeMon.Properties.Resources.C1;
                }
                else if (vdh == 2)
                {
                    label2.Text = "VDH";
                    this.Prof2.Image = ProfeMon.Properties.Resources.V1;
                }
                else if (gosseye == 2)
                {
                    label2.Text = "Gosseye";
                    this.Prof2.Image = ProfeMon.Properties.Resources.G1;
                }
                else if (bivort == 2)
                {
                    label2.Text = "Bivort";
                    this.Prof2.Image = ProfeMon.Properties.Resources.B1;
                }
                player.PlayLooping();
            }
            BarDeVie2.Maximum = 100;
            BarDeVie2.Minimum = 0;
            BarDeVie2.Value = 100;
            
        }


        private void Attaque_Click(object sender, EventArgs e) //Attaque normale du joueur 1
        {
            Attack();
            NextTurn();
        }

        private void AttaqueG1_Click(object sender, EventArgs e) //Grosse attaque du joueur 1
        {
            BigAttack();
            NextTurn();
        }

        private void Defense_Click(object sender, EventArgs e) //Active la garde du joueur 1
        {
            personnages1.Guard();
            NextTurn();
        }

        private void Spécial_Click(object sender, EventArgs e) //Permet d'étourdir le joueur 2
        {
            if (personnages2.IsGuarding == false) //Si le joueur2 est en garde, il n'est pas étourdi
            {
                personnages2.Stunned();
                StunCounterJ2 = StunCounterJ2 + 2; //Compteur pour l'étourdissement du joueur2, l'étourdissement dure 2 tours
                StunCase();
            }
            else
            {
                NextTurn();
            }
        }

        private void Attaque2_Click(object sender, EventArgs e) //Attaque normale du joueur 2
        {
            Attack();
            NextTurn();
        }

        private void AttaqueG2_Click(object sender, EventArgs e) //Grosse attaque du joueur 2
        {
            BigAttack();
            NextTurn();
        }

        private void Defense2_Click(object sender, EventArgs e) //Active la garde du joueur 2
        {
            personnages2.Guard();
            NextTurn();
        }

        private void Spécial2_Click(object sender, EventArgs e) //Permet d'étourdir le joueur 1
        {
            if (personnages1.IsGuarding == false) //Si le joueur1 est en garde, il n'est pas étourdi
            {
                personnages1.Stunned();
                StunCounterJ1 = StunCounterJ1 + 2; //Compteur pour l'étourdissement du joueur1, l'étourdissement dure 2 tours
                StunCase();
            }else
            {
                NextTurn();
            }
            
            
        }

        public void Gagner() //Vérifie si quelqu'un a gagné (à éditer pour la version finale)
        {
            if (personnages1.IsDead || personnages2.IsDead)
            {
                player.Stop();
                Hide();
                form3.Show();
                form3.Form3_Load(null, null);
            }
        }

        public void NextTurn() //Passe au tour suivant
        {
            
            if (personnages1.IsStunned == true)
            {
                StunCounterJ1 = StunCounterJ1 - 1; //On réduit le compteur d'étourdissement du J1
            }
            if (personnages2.IsStunned == true)
            {
                StunCounterJ2 = StunCounterJ2 - 1; //On réduit le compteur d'étourdissement du J1
            }
            if (J1turn == true && StunCounterJ2 == 0) //On passe au tour du J2 si il n'est pas étourdi
            {
                DisableJ1();
                EnableJ2();
                personnages2.IsStunned = false;
            }
            else if(J2turn == true && StunCounterJ1 == 0) //On passe au tour du J1 si il n'est pas étourdi
            {
                DisableJ2();
                EnableJ1();
                personnages1.IsStunned = false;
            }
            ShieldIcon();
            StunIcon();
            Gagner();
        }

        public void DisableJ1() //Désactive le joueur1
        {
            Attaque.Enabled = false;
            AttaqueG1.Enabled = false;
            Defense.Enabled = false;
            Spécial.Enabled = false;
            J1turn = false;
        }
        public void EnableJ1() //Active le joueur1
        {
            Attaque.Enabled = true;
            AttaqueG1.Enabled = true;
            Defense.Enabled = true;
            Spécial.Enabled = true;
            J1turn = true;
        }

        public void DisableJ2() //Désactive le joueur2
        {
            Attaque2.Enabled = false;
            AttaqueG2.Enabled = false;
            Defense2.Enabled = false;
            Spécial2.Enabled = false;
            J2turn = false;
        }

        public void EnableJ2() //Active le joueur2
        {
            Attaque2.Enabled = true;
            AttaqueG2.Enabled = true;
            Defense2.Enabled = true;
            Spécial2.Enabled = true;
            J2turn = true;
        }

        public void DisableGuardJ1() //Désactive la garde du joueur1
        {
            personnages1.IsGuarding = false;
            
        }

        public void DisableGuardJ2() //Désactive la garde du joueur2
        {
            personnages2.IsGuarding = false;
        }

        public void StunCase() //Vérifie si un joueur est étourdi ou non
        {
            if (personnages1.IsStunned == true)
            {
                DisableJ1();
                EnableJ2();
            }
            if (personnages2.IsStunned == true)
            {
                DisableJ2();
                EnableJ1();
            }
            StunIcon();
        }

        public void CheckHealthBar() //Vérifie si la bar de vie tombe sous 0 afin d'éviter un crash
        {
            if (BarDeVie1.Value - 20 < 0 || BarDeVie1.Value - 15 < 0 || BarDeVie1.Value - 10 < 0 || BarDeVie1.Value - 5 < 0)
            {
                BarDeVie1.Value = 0;
                personnages1.PV = 0;
                personnages1.Dead();
            }
            if (BarDeVie2.Value - 20 < 0 || BarDeVie2.Value - 15 < 0 || BarDeVie2.Value - 10 < 0 || BarDeVie2.Value - 5 < 0)
            {
                BarDeVie2.Value = 0;
                personnages2.PV = 0;
                personnages2.Dead();
            }
        }

        public void Attack() //Attaque normale
        {
            CheckHealthBar();
            if (BarDeVie1.Value == 0 || BarDeVie2.Value == 0) //On vérifie si quelqu'un a gagné
            {
                return;
            }else if(J1turn==true)
            {
                if (personnages2.IsGuarding == false)
                {
                    BarDeVie2.Value = BarDeVie2.Value - 10;
                    personnages2.ReceiveSimpleAttack();
                }
                else
                {
                    BarDeVie2.Value = BarDeVie2.Value - 5; //Dégats réduits si le joueur 2 est en garde
                    personnages2.ReceiveSimpleAttack();
                }
            }
            else if (J2turn == true)
            {
                if (personnages1.IsGuarding == false)
                {
                    BarDeVie1.Value = BarDeVie1.Value - 10;
                    personnages1.ReceiveSimpleAttack();
                }
                else
                {
                    BarDeVie1.Value = BarDeVie1.Value - 5; //Dégats réduits si le joueur 1 est en garde
                    personnages1.ReceiveSimpleAttack();
                }
            }
        }

        public void BigAttack() //Grosse attaque
        {
            CheckHealthBar();
            if (BarDeVie1.Value == 0 || BarDeVie2.Value == 0) //On vérifie si quelqu'un a gagné
            {
                Gagner();
            }
            else if (J1turn == true)
            {
                if (personnages2.IsGuarding == false)
                {
                    BarDeVie2.Value = BarDeVie2.Value - 20;
                    personnages2.ReceiveBigAttack();
                }
                else
                {
                    BarDeVie2.Value = BarDeVie2.Value - 15; //Dégats réduits si le joueur 2 est en garde
                    personnages2.ReceiveBigAttack();
                    DisableGuardJ2();                       //Désactive la garde du joueur 2  
                }
            }
            else if (J2turn == true)
            {
                if (personnages1.IsGuarding == false)
                {
                    BarDeVie1.Value = BarDeVie1.Value - 20;
                    personnages1.ReceiveBigAttack();
                }
                else
                {
                    BarDeVie1.Value = BarDeVie1.Value - 15; //Dégats réduits si le joueur 1 est en garde
                    personnages1.ReceiveBigAttack();
                    DisableGuardJ1();                       //Désactive la garde du joueur 1
                }
            }
        }


        public void ShieldIcon()
        {
            if (personnages1.IsGuarding == true)
            {
                ShieldJ1.Show();
            }else if(personnages1.IsGuarding==false)
            {
                ShieldJ1.Hide();
            }

            if (personnages2.IsGuarding == true)
            {
                ShieldJ2.Show();
            }else if (personnages2.IsGuarding == false)
            {
                ShieldJ2.Hide();
            }
        }

        public void StunIcon()
        {
            if (personnages1.IsStunned == true)
            {
                StunJ1.Show();
            }
            else if (personnages1.IsStunned == false)
            {
                StunJ1.Hide();
            }

            if (personnages2.IsStunned == true)
            {
                StunJ2.Show();
            }
            else if (personnages2.IsStunned == false)
            {
                StunJ2.Hide();
            }
        }

    }
}
