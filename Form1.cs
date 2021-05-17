using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using MetroSet_UI.Forms;

namespace TASKetch
{
    public partial class Form1 : Form
    {
        public static List<string> ListeTaches;
        public static List<PanelTask> ListePanneaux;
        private bool isModif = false;
        private bool mousedown;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
          /*  this.BoutQuitter.BackgroundImage = imageList1.Images[0];
            this.BoutReduire.BackgroundImage = imageList1.Images[1];
            this.BandeauFenetre.BackgroundImage = imageList1.Images[2];*/
            this.Icon = Icon.ExtractAssociatedIcon("LogoScratch.ico");
            
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            ListeTaches = new List<string>();
            ListePanneaux = new List<PanelTask>();
            StreamReader StreamFichier = null;
            try
            {
                StreamFichier = new StreamReader("Taches.txt");
                string ligne;
                int i = 0;

                ligne = StreamFichier.ReadToEnd();
                if(ligne != "")
                {
                    string[] ligneSplit = ligne.Split("§");
                    if(ligneSplit[0].Split(";").Count() == 4)
                    {
                        foreach (var j in ligneSplit)
                        {
                            ListeTaches.Add(j);
                            ListePanneaux.Add(new PanelTask(j.Split(";")[0], j.Split(";")[1], i, Color.FromArgb(Convert.ToInt32(j.Split(";")[2])), Int32.Parse(j.Split(";")[3])));
                            i++;
                        }
                    }
                    else if(ligneSplit[0].Split(";").Count() == 2)
                    {
                        foreach (var j in ligneSplit)
                        {
                            ListeTaches.Add(j);
                            ListePanneaux.Add(new PanelTask(j.Split(";")[0], j.Split(";")[1], i, Color.FromArgb(-1), 0));
                            i++;
                        }
                    }

                    i = 0;
                    foreach (var j in ListePanneaux)
                    {
                        PanListTask.Controls.Add(j);
                        i++;
                    }
                }
                else
                {
                    FileStream fichier = File.Create("Taches.txt");
                    fichier.Close();
                }
                StreamFichier.Close();
            }
            catch
            {
                try
                {
                    StreamFichier.Close();
                }
                catch
                {

                }
                FileStream fichier = File.Create("Taches.txt");
                fichier.Close();
            }
        }

        public void RefreshList()
        {

            for(int i = 0; i < ListePanneaux.Count; i++)
            {
                ListePanneaux[i].PanNum = i;
                if (PanelTask.PanSelected != -1) ListePanneaux[i].BorderStyle = BorderStyle.None;
            }

            if (PanelTask.PanSelected != -1)
            {
                BoutTerminerTache.Enabled = true;
                BoutModifierTache.Enabled = true;
                BoutMonter.Enabled = true;
                BoutDescendre.Enabled = true;

                if (PanelTask.OldPanNum != -1) ListePanneaux[PanelTask.OldPanNum].BorderStyle = BorderStyle.None;

                ListePanneaux[PanelTask.PanSelected].BorderStyle = BorderStyle.Fixed3D;
                LabNomTache.Text = ListePanneaux[PanelTask.PanSelected].labName.Text;
                BoxDescription.Text = ListePanneaux[PanelTask.PanSelected].labDescription.Text;
            }
            else
            {
                BoutTerminerTache.Enabled = false;
                BoutModifierTache.Enabled = false;
                BoutMonter.Enabled = false;
                BoutDescendre.Enabled = false;
            }
        }

        private void BoutAjouterTache_Click(object sender, EventArgs e)
        {
            PageAjouterTache.Show();
            tableLayoutPanel1.Hide();
            BoxNomCreaTache.Focus();
            if (isModif)
            {
                BoxNomCreaTache.Text = ListePanneaux[PanelTask.PanSelected].labName.Text;
                BoxDescCreaTache.Text = ListePanneaux[PanelTask.PanSelected].labDescription.Text;
                BoutCouleurCreaTache.BackColor = ListePanneaux[PanelTask.PanSelected].couleur;
            }
        }

        private void BoutAnnulerCreaTache_Click(object sender, EventArgs e)
        {
            PageAjouterTache.Hide();
            tableLayoutPanel1.Show();
            BoxNomCreaTache.Text = "";
            BoxDescCreaTache.Text = "";
            colorDialog1.Color = Color.White;
            BoutCouleurCreaTache.BackColor = colorDialog1.Color;
            isModif = false;
        }

        private void BoutValiderCreaTache_Click(object sender, EventArgs e)
        {
            if(BoxNomCreaTache.Text != "")
            {
                if (BoxDescCreaTache.Text == "") BoxDescCreaTache.Text = " ";

                if (isModif)
                {
                    
                    ListePanneaux[PanelTask.PanSelected].labName.Text = BoxNomCreaTache.Text;
                    ListePanneaux[PanelTask.PanSelected].labDescription.Text = BoxDescCreaTache.Text;
                    ListePanneaux[PanelTask.PanSelected].couleur = BoutCouleurCreaTache.BackColor;
                    ListePanneaux[PanelTask.PanSelected].BackColor = BoutCouleurCreaTache.BackColor;
                }
                else
                {
                    //ListeTaches.Add(BoxNomCreaTache.Text + ";" + BoxDescCreaTache.Text);
                    ListePanneaux.Add(new PanelTask(BoxNomCreaTache.Text, BoxDescCreaTache.Text, ListePanneaux.Count, colorDialog1.Color, 0));
                    PanListTask.Controls.Add(ListePanneaux[ListePanneaux.Count - 1]);
                }

                RefreshList();

                PageAjouterTache.Hide();
                tableLayoutPanel1.Show();
                BoxNomCreaTache.Text = "";
                BoxDescCreaTache.Text = "";
                colorDialog1.Color = Color.White;
                BoutCouleurCreaTache.BackColor = colorDialog1.Color;
                isModif = false;
            }
        }

        private void BoutSupprimerTache_Click(object sender, EventArgs e)
        {
            if(PanelTask.PanSelected != -1)
            {
                PanListTask.Controls.RemoveAt(PanelTask.PanSelected);
                ListePanneaux.RemoveAt(PanelTask.PanSelected);
                
                PanelTask.PanSelected = -1;
                LabNomTache.Text = "";
                BoxDescription.Text = "";
                RefreshList();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            StreamWriter fichier = new StreamWriter("Taches.txt");
            if(ListePanneaux.Count > 0)
            {
                fichier.Write(ListePanneaux[0].labName.Text +";" + ListePanneaux[0].labDescription.Text + ";" + ListePanneaux[0].couleur.ToArgb() + ";" + ListePanneaux[0].done.ToString());
                for (int i = 1; i < ListePanneaux.Count; i++)
                {
                    fichier.Write("§");
                    fichier.Write(ListePanneaux[i].labName.Text + ";" + ListePanneaux[i].labDescription.Text + ";"+ ListePanneaux[i].couleur.ToArgb() + ";" + ListePanneaux[i].done.ToString());
                }
            }
            fichier.Close();
        }

        private void BoutModifierTache_Click(object sender, EventArgs e)
        {
            isModif = true;
            BoutAjouterTache_Click(this, null);
        }

        private void BoutTerminerTache_Click(object sender, EventArgs e)
        {
            if(ListePanneaux[PanelTask.PanSelected].done == 1)
            {
                ListePanneaux[PanelTask.PanSelected].done = 0;
            }
            else
            {
                ListePanneaux[PanelTask.PanSelected].done = 1;
            }
            ListePanneaux[PanelTask.PanSelected].TextBarreDebarre();
        }

        private void BoutCouleurCreaTache_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            BoutCouleurCreaTache.BackColor = colorDialog1.Color;
        }

        private void BandeauFenetre_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void BandeauFenetre_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int mousex = MousePosition.X - 300;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void BandeauFenetre_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void BoutReduire_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BoxDescription_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", e.LinkText);
        }

        private void BoutMonter_Click(object sender, EventArgs e)
        {
            if(PanelTask.PanSelected != ListePanneaux.Count-1)
            {
                PanelTask tmp = ListePanneaux[PanelTask.PanSelected];
                ListePanneaux[PanelTask.PanSelected] = ListePanneaux[PanelTask.PanSelected + 1];
                ListePanneaux[PanelTask.PanSelected + 1] = tmp;
                PanelTask.PanSelected++;

                PanListTask.Controls.Clear();
                foreach(var i in ListePanneaux)
                {
                    PanListTask.Controls.Add(i);
                }
                RefreshList();
            }
        }

        private void BoutDescendre_Click(object sender, EventArgs e)
        {
            if (PanelTask.PanSelected != 0)
            {
                PanelTask tmp = ListePanneaux[PanelTask.PanSelected];
                ListePanneaux[PanelTask.PanSelected] = ListePanneaux[PanelTask.PanSelected - 1];
                ListePanneaux[PanelTask.PanSelected - 1] = tmp;
                PanelTask.PanSelected--;

                PanListTask.Controls.Clear();
                foreach (var i in ListePanneaux)
                {
                    PanListTask.Controls.Add(i);
                }
                RefreshList();
            }
        }

        private void metroSetTextBox1_TextChanged(object sender, EventArgs e)
        {
            foreach(var i in ListePanneaux)
            {
                if (i.labName.Text.ToLower().Contains(BarRecherche.Text.ToLower()) || i.labDescription.Text.ToLower().Contains(BarRecherche.Text.ToLower()))
                {
                    i.Show();
                }
                else
                {
                    i.Hide();
                }
            }
        }
    }
}
