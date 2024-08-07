namespace ProfeMon
{
    public partial class Form1 : Form
    {
        public Personnages personnage1;
        public Personnages personnage2;
        public Tom tom = new Tom();
        public VDH vdh = new VDH();
        public Wilfart wilfart = new Wilfart();
        public Gosseye gosseye = new Gosseye();
        public Chot chot = new Chot();
        public Bivort bivort = new Bivort();
        public Pluquet pluquet = new Pluquet();
        Form3 form3;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
        }


        Form2 form2;
        bool joueur1 = true;
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        public int click = 0;

        
       
        public void VALIDER_Click(object sender, EventArgs e)
        {

            click++;
                
             if (joueur1 == true)
             {
                JOUEUR1.ForeColor = Color.Black;
                Joueur2.ForeColor = Color.Red;
                
             }

            if (click == 1)
            {
                if (Tom.Checked)
                {
                    Tom.Hide();
                    form2.tom = 1;
                    personnage1 = tom;
                    
                }
                else if (Pluquet.Checked)
                {
                    Pluquet.Hide();
                    form2.pluquet = 1;
                    personnage1 = pluquet;
                }
                else if (Wilfart.Checked)
                {
                    Wilfart.Hide();
                    form2.wilfart = 1;
                    personnage1 = wilfart;
                }
                else if (Gosseye.Checked)
                {
                    Gosseye.Hide();
                    form2.gosseye = 1;
                    personnage1 = gosseye;
                }
                else if (Bivort.Checked)
                {
                    Bivort.Hide();
                    form2.bivort = 1;
                    personnage1 = bivort;
                }
                else if (VDH.Checked)
                {
                    VDH.Hide();
                    form2.vdh = 1;
                    personnage1 = vdh;
                }
                else if (Chot.Checked)
                {
                    Chot.Hide();
                    form2.chot = 1;
                    personnage1 = chot;
                }
            }

            if (click == 2)
            {
                if (Tom.Checked && personnage1!=tom)
                {
                    Tom.Hide();
                    form2.tom = 2;
                    personnage2 = tom;
                }
                else if (Pluquet.Checked && personnage1!=pluquet)
                {
                    Pluquet.Hide();
                    form2.pluquet = 2;
                    personnage2 = pluquet;
                }
                else if (Wilfart.Checked && personnage1!=wilfart)
                {
                    Wilfart.Hide();
                    form2.wilfart = 2;
                    personnage2 = wilfart;
                }
                else if (Gosseye.Checked && personnage1!=gosseye)
                {
                    Gosseye.Hide();
                    form2.gosseye = 2;
                    personnage2 = gosseye;
                }
                else if (Bivort.Checked && personnage1!=bivort)
                {
                    Bivort.Hide();
                    form2.bivort = 2;
                    personnage2 = bivort;
                }
                else if (VDH.Checked && personnage1!=vdh)
                {
                    VDH.Hide();
                    form2.vdh = 2;
                    personnage2 = vdh;
                }
                else if (Chot.Checked && personnage1!=chot)
                {
                    Chot.Hide();
                    form2.chot = 2;
                    personnage2 = chot;
                }
                Joueur2.ForeColor = Color.Black;
                form2.personnages1 = personnage1;
                form2.personnages2 = personnage2;
                Hide();
                form2.Show();
            }

            form2.Form2_Load(null, null);
        }

        

        private void Joueur2_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tom_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Wilfart_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Gosseye_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Pluquet_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Chot_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void VDH_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}