using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class ChefMaster : Form
    {

        private MaitreHotel MH;
        private CommisSalle CS;
        private ChefRang CR_1, CR_2, CR_3, CR_4;
        private Serveur SR_1, SR_2, SR_3, SR_4;

        private Table Table_4_Rang1_1, Table_4_Rang1_2, Table_4_Rang1_3, Table_4_Rang1_4;
        private Table[] TB_Rang1;
        private Rang Rang1;
        private Table Table_4_Rang_2_1, Table_4_Rang_2_2, Table_4_Rang_2_3, Table_4_Rang_2_4;
        private Table[] TB_Rang2;
        private Rang Rang2;

        private Carre Carre1 ;

        private Table Table_8_Rang3_1, Table_4_Rang3_2, Table_8_Rang3_3;
        private Table[] TB_Rang3;
        private Rang Rang3;
        private Table Table_4_Rang_4_1, Table_8_Rang_4_2, Table_4_Rang_4_3;
        private Table[] TB_Rang4;
        private Rang Rang4;

        private Carre Carre2;

        private Salle Salle;
        private PresentoireSalle Presentoire;

        private int Chiffre;

        private String[] CMD;

        private Clients Groupe_test;

        private Table Table_test;



        public ChefMaster()
        {

            //Instanciation personnelle

            MH = MaitreHotel.GetInstance("Maitre", "Hotel");
            CS = CommisSalle.GetInstance("Commis", "Salle");

            CR_1 = new ChefRang("CR", "1");
            CR_2 = new ChefRang("CR", "2");
            CR_3 = new ChefRang("CR", "3");
            CR_4 = new ChefRang("CR", "4");

            SR_1 = new Serveur("SR", "1");
            SR_2 = new Serveur("SR", "2");
            SR_3 = new Serveur("SR", "3");
            SR_4 = new Serveur("SR", "4");

            //Instanciation Salle

            TB_Rang1 = new Table[4];
            TB_Rang1[0] = Table_4_Rang1_1 = new Table(4, 0, 1);
            TB_Rang1[1] = Table_4_Rang1_2 = new Table(4, 0, 2);
            TB_Rang1[2] = Table_4_Rang1_3 = new Table(4, 0, 3);
            TB_Rang1[3] = Table_4_Rang1_4 = new Table(4, 0, 4);
            Rang1 = new Rang(SR_1, CR_1, TB_Rang1);

            TB_Rang2 = new Table[4];
            TB_Rang2[0] = Table_4_Rang_2_1 = new Table(4, 0, 5);
            TB_Rang2[1] = Table_4_Rang_2_2 = new Table(4, 0, 6);
            TB_Rang2[2] = Table_4_Rang_2_3 = new Table(4, 0, 7);
            TB_Rang2[3] = Table_4_Rang_2_4 = new Table(4, 0, 8);
            Rang2 = new Rang(SR_2, CR_2, TB_Rang2);

            Carre1 = new Carre(Rang1, Rang2);

            TB_Rang3 = new Table[3];
            TB_Rang3[0] = Table_8_Rang3_1 = new Table(8, 0, 9);
            TB_Rang3[1] = Table_4_Rang3_2 = new Table(4, 0, 10);
            TB_Rang3[2] = Table_8_Rang3_3 = new Table(8, 0, 11);
            Rang3 = new Rang(SR_3, CR_3, TB_Rang3);

            TB_Rang4 = new Table[3];
            TB_Rang4[0] = Table_4_Rang_4_1 = new Table(4, 0, 12);
            TB_Rang4[1] = Table_8_Rang_4_2 = new Table(8, 0, 13);
            TB_Rang4[2] = Table_4_Rang_4_3 = new Table(4, 0, 14);
            Rang4 = new Rang(SR_3, CR_3, TB_Rang3);

            Carre2 = new Carre(Rang3, Rang4);

            Presentoire = new PresentoireSalle();
            Salle = Salle.GetInstance(Carre1, Carre2, MH, CS, Presentoire);

            Chiffre = 0;



            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MH.AttribueTable();


        }
        private void Service (Boolean MatinMidi)
        {
            //
        }

        private void commencer(object sender, EventArgs e)
        {
            timer2.Start();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void  Arreter_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void SelectDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectDay.SelectedItem == "Midi")
            {
                Seconde.Text = "0";
                Minutes.Text = "0";
                Heures.Text = "12";
                Jour.Text = "0";
            }
            if (SelectDay.SelectedItem == "Soir")
            {
                Seconde.Text = "0";
                Minutes.Text = "0";
                Heures.Text = "19";
                Jour.Text = "0";
            }
        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            int secondInt = Convert.ToInt32(Seconde.Text);
            if (secondInt < 59)
            {
                Seconde.Text = Convert.ToString(secondInt + 1);
            }
            else
            {
                Seconde.Text = "0";
                int minuteInt = Convert.ToInt32(Minutes.Text);
                if (minuteInt < 59)
                {
                    Minutes.Text = Convert.ToString(minuteInt + 1);
                }
                else
                {
                    Minutes.Text = "0";
                    int hourInt = Convert.ToInt32(Heures.Text);
                    if (hourInt < 23)
                    {
                        Heures.Text = Convert.ToString(hourInt + 1);
                    }
                    else
                    {
                        Heures.Text = "0";
                        int dayInt = Convert.ToInt32(Jour.Text);
                        if (dayInt < 7)
                        {
                            Jour.Text = Convert.ToString(dayInt + 1);
                        }
                        else
                        {
                            Jour.Text = "0";
                        }
                    }
                }
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            string nbr_client;
            nbr_client = textBox1.Text;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            timer2.Interval = trackBar2.Value;
        }

        private void ArriveCli_Click(object sender, EventArgs e)
        {
           
            //Instanciation Groupe Clients

            CMD = new String[ this.comboBox9.SelectedIndex ];

            for(int i =0; i< this.comboBox9.SelectedIndex ; i++)
            {
                switch (i)
                {
                    case 0:
                        CMD[0] = this.comboBox2.SelectedText;
                        break;
                    case 1:
                        CMD[1] = this.comboBox3.SelectedText;
                        break;
                    case 2:
                        CMD[2] = this.comboBox4.SelectedText;
                        break;
                    case 3:
                        CMD[3] = this.comboBox5.SelectedText;
                        break;
                    case 4:
                        CMD[4] = this.comboBox6.SelectedText;
                        break;
                    case 5:
                        CMD[5] = this.comboBox7.SelectedText;
                        break;
                    default:
                        break;
                   
                }
            }
            //CMD[0] = "Pates";
            //CMD[1] = "Pizza";
            Groupe_test = new Clients(this.comboBox9.SelectedIndex+1, false, this.comboBox8.SelectedText, CMD);

            //Acceuill, Attribution, placement clients & prise de commande
            //Apport eau et pains

            //deplacer groupe cli vers MH
            //this.ClientIMG.Location = new Point(111,360);


            Table_test = MH.AttribueTable(Salle, Groupe_test, false);
            
            MAJ_Client_Table(Table_test);




            this.button2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Groupe_test.
            if(Table_test.GetId() <5)
            {
                SR_1.Debarasse(Table_test);
                foreach (string S in CMD)
                {
                    Chiffre += SR_4.Addition();
                }
            }
            else if(Table_test.GetId() < 9)
            {
                SR_2.Debarasse(Table_test);
                foreach (string S in CMD)
                {
                    Chiffre += SR_4.Addition();
                }
            }
            else if(Table_test.GetId() < 12)
            {
                SR_3.Debarasse(Table_test);
                foreach (string S in CMD)
                {
                    Chiffre += SR_4.Addition();
                }
            }
            else
            {
                SR_4.Debarasse(Table_test);
                foreach (string S in CMD)
                {
                    Chiffre += SR_4.Addition();
                }
            }

            this.label10.Text = Chiffre.ToString() + "€";



        }



        private void MAJ_Client_Table (Table Test)
        {
            switch(Test.GetId())
            {
                case 1:
                    this.ClientIMG.Location = new Point(304, 482);
                    this.NBpers_Tab1.Text = Groupe_test.GetNBClients().ToString();
                    this.PainEau_Tab1.ForeColor = System.Drawing.Color.Green;
                    break;
                case 2:
                    this.ClientIMG.Location = new Point(428, 468);
                    this.NBpers_Tab2.Text = Groupe_test.GetNBClients().ToString();
                    this.PainEau_Tab2.ForeColor = System.Drawing.Color.Green;
                    break;
                case 3:
                    this.ClientIMG.Location = new Point(567, 468);
                    this.NBpers_Tab3.Text = Groupe_test.GetNBClients().ToString();
                    this.PainEau_Tab3.ForeColor = System.Drawing.Color.Green;
                    break;
                case 4:
                    this.ClientIMG.Location = new Point(693, 437);
                    this.NBpers_Tab4.Text = Groupe_test.GetNBClients().ToString();
                    this.PainEau_Tab4.ForeColor = System.Drawing.Color.Green;
                    break;
                case 5:
                    this.ClientIMG.Location = new Point(304, 642);
                    this.NBpers_Tab2_1.Text = Groupe_test.GetNBClients().ToString();
                    this.PainEau_Tab2_1.ForeColor = System.Drawing.Color.Green;
                    break;
                case 6:
                    this.ClientIMG.Location = new Point(437, 575);
                    this.NBpers_Tab2_2.Text = Groupe_test.GetNBClients().ToString();
                    this.PainEau_Tab2_2.ForeColor = System.Drawing.Color.Green;
                    break;
                case 7:
                    this.ClientIMG.Location = new Point(565, 641);
                    this.NBpers_Tab2_3.Text = Groupe_test.GetNBClients().ToString();
                    this.PainEau_Tab2_3.ForeColor = System.Drawing.Color.Green;
                    break;
                case 8:
                    this.ClientIMG.Location = new Point(685, 575);
                    this.NBpers_Tab2_4.Text = Groupe_test.GetNBClients().ToString();
                    this.PainEau_Tab2_4.ForeColor = System.Drawing.Color.Green;
                    break;
                case 9:
                    this.ClientIMG.Location = new Point(846, 446);
                    this.NBpers_Tab3_1.Text = Groupe_test.GetNBClients().ToString();
                    this.PainEau_Tab3_1.ForeColor = System.Drawing.Color.Green;
                    break;
                case 10:
                    this.ClientIMG.Location = new Point(839, 638);
                    this.NBpers_Tab3_2.Text = Groupe_test.GetNBClients().ToString();
                    this.PainEau_Tab3_2.ForeColor = System.Drawing.Color.Green;
                    break;
                case 11:
                    this.ClientIMG.Location = new Point(991, 584);
                    this.NBpers_Tab3_3.Text = Groupe_test.GetNBClients().ToString();
                    this.PainEau_Tab3_3.ForeColor = System.Drawing.Color.Green;
                    break;
                case 12:
                    this.ClientIMG.Location = new Point(1139, 638);
                    this.NBpers_Tab4_1.Text = Groupe_test.GetNBClients().ToString();
                    this.PainEau_Tab4_1.ForeColor = System.Drawing.Color.Green;
                    break;
                case 13:
                    this.ClientIMG.Location = new Point(304, 482);
                    this.NBpers_Tab4_2.Text = Groupe_test.GetNBClients().ToString();
                    this.PainEau_Tab1.ForeColor = System.Drawing.Color.Green;
                    break;
                case 14:
                    this.ClientIMG.Location = new Point(304, 482);
                    this.NBpers_Tab4_3.Text = Groupe_test.GetNBClients().ToString();
                    this.PainEau_Tab4_3.ForeColor = System.Drawing.Color.Green;
                    break;

                
            }
        }


        
        private void Plat_pret_Click(object sender, EventArgs e)
        {
            //Service 


            //SR_1.AmenerSale();

            Groupe_test.SetServi(true);
            this.ClientMnge_Tab_1.Text = "Servi";
            this.ClientMnge_Tab_1.ForeColor = System.Drawing.Color.Green;

            //demmarrer un timer en fn humeur
            //Barre de progression ?
            //lorsque fin timer

            //SR_1.Debarrasse (Table)
        }
    }
}
