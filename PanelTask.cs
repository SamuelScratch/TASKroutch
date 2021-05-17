using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;

namespace TASKetch
{
    public class PanelTask : System.Windows.Forms.Panel
    {

        private string nameTask;
        private string description;
        public int PanNum;
        public static int OldPanNum = -1;
        public static int PanSelected = -1;
        public Label labName;
        public Label labDescription;
        public int done = 0;
        public Color couleur;

        private bool mousedown = false;
        private int p_Y;

        public PanelTask(string newNameTask, string newDescription,int taskCount,Color newCouleur, int newDone = 0)
        {
            nameTask = newNameTask;
            description = newDescription;
            PanNum = taskCount;
            done = newDone;
            couleur = newCouleur;

            //int LocCount = (64 * taskCount) - taskCount;
            this.Size = new System.Drawing.Size(200,64);
            //this.Location = new System.Drawing.Point(0, LocCount);
            this.Dock = DockStyle.Top;
            labName = new Label();
            labName.Font = new System.Drawing.Font(labName.Font.FontFamily, 12);
            labDescription = new Label();
            
            labName.Text = newNameTask;
            labDescription.Text = newDescription;
            labName.Location = new System.Drawing.Point(4, 0);
            labDescription.Location = new System.Drawing.Point(4,32);
            labName.Size = new System.Drawing.Size(184, 24);
            labDescription.Size = new System.Drawing.Size(184, 16);
            
            this.Controls.Add(labDescription);
            this.Controls.Add(labName);
            this.BorderStyle = BorderStyle.None;
            this.BackColor = couleur;


            this.Click += new System.EventHandler(this.LabOnClick);
            labName.Click += new System.EventHandler(this.LabOnClick);
            labDescription.Click += new System.EventHandler(this.LabOnClick);

            if (done == 1)
            {
                labName.Font = new System.Drawing.Font(labName.Font.FontFamily, 12, System.Drawing.FontStyle.Strikeout);
                labDescription.Font = new System.Drawing.Font(labDescription.Font.FontFamily, 9, System.Drawing.FontStyle.Strikeout);
            }
        }

       /* public void PanOnClick(object sender, EventArgs e)
        {
            PanelTask.PanSelected = PanNum;
            Program.newForm.RefreshList();
        }*/

        public void LabOnClick(object sender, EventArgs e)
        {
            this.Focus();
            PanelTask.OldPanNum = PanelTask.PanSelected;
            PanelTask.PanSelected = PanNum;
            Program.newForm.RefreshList();
        }
        public void TextBarreDebarre()
        {
            if(done == 1)
            {
                labName.Font = new System.Drawing.Font(labName.Font.FontFamily, 12, System.Drawing.FontStyle.Strikeout);
                labDescription.Font = new System.Drawing.Font(labDescription.Font.FontFamily, 9, System.Drawing.FontStyle.Strikeout);
            }
            else
            {
                labName.Font = new System.Drawing.Font(labName.Font.FontFamily, 12);
                labDescription.Font = new System.Drawing.Font(labDescription.Font.FontFamily, 9);
            }
        }
        public void rafraichir()
        {
            this.BackColor = couleur;
            this.labName.Text = nameTask;
            this.labDescription.Text = description;
        }
    }
}
