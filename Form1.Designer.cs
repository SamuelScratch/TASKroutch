
namespace TASKetch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BoutAjouterTache = new System.Windows.Forms.Button();
            this.BoutSupprimerTache = new System.Windows.Forms.Button();
            this.PageAjouterTache = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BoutAnnulerCreaTache = new System.Windows.Forms.Button();
            this.BoutValiderCreaTache = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BoxNomCreaTache = new System.Windows.Forms.TextBox();
            this.BoutCouleurCreaTache = new System.Windows.Forms.Button();
            this.PanDescCreaTache = new System.Windows.Forms.Panel();
            this.BoxDescCreaTache = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BoutModifierTache = new System.Windows.Forms.Button();
            this.BoutTerminerTache = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BoxDescription = new System.Windows.Forms.RichTextBox();
            this.LabNomTache = new System.Windows.Forms.Label();
            this.PanListTask = new System.Windows.Forms.Panel();
            this.PageContenuPrincipale = new System.Windows.Forms.TableLayoutPanel();
            this.BarRecherche = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BoutMonter = new System.Windows.Forms.Button();
            this.BoutDescendre = new System.Windows.Forms.Button();
            this.PageAjouterTache.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.PanDescCreaTache.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PageContenuPrincipale.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoutAjouterTache
            // 
            this.BoutAjouterTache.BackColor = System.Drawing.Color.White;
            this.BoutAjouterTache.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BoutAjouterTache.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoutAjouterTache.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoutAjouterTache.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoutAjouterTache.ForeColor = System.Drawing.Color.Black;
            this.BoutAjouterTache.Location = new System.Drawing.Point(0, 0);
            this.BoutAjouterTache.Margin = new System.Windows.Forms.Padding(0);
            this.BoutAjouterTache.Name = "BoutAjouterTache";
            this.BoutAjouterTache.Size = new System.Drawing.Size(194, 40);
            this.BoutAjouterTache.TabIndex = 2;
            this.BoutAjouterTache.Text = "Ajouter";
            this.BoutAjouterTache.UseVisualStyleBackColor = false;
            this.BoutAjouterTache.Click += new System.EventHandler(this.BoutAjouterTache_Click);
            // 
            // BoutSupprimerTache
            // 
            this.BoutSupprimerTache.BackColor = System.Drawing.Color.White;
            this.BoutSupprimerTache.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BoutSupprimerTache.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoutSupprimerTache.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoutSupprimerTache.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoutSupprimerTache.Location = new System.Drawing.Point(582, 0);
            this.BoutSupprimerTache.Margin = new System.Windows.Forms.Padding(0);
            this.BoutSupprimerTache.Name = "BoutSupprimerTache";
            this.BoutSupprimerTache.Size = new System.Drawing.Size(196, 40);
            this.BoutSupprimerTache.TabIndex = 3;
            this.BoutSupprimerTache.Text = "Supprimer";
            this.BoutSupprimerTache.UseVisualStyleBackColor = false;
            this.BoutSupprimerTache.Click += new System.EventHandler(this.BoutSupprimerTache_Click);
            // 
            // PageAjouterTache
            // 
            this.PageAjouterTache.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PageAjouterTache.Controls.Add(this.tableLayoutPanel3);
            this.PageAjouterTache.Controls.Add(this.tableLayoutPanel2);
            this.PageAjouterTache.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageAjouterTache.Location = new System.Drawing.Point(0, 0);
            this.PageAjouterTache.Name = "PageAjouterTache";
            this.PageAjouterTache.Size = new System.Drawing.Size(778, 576);
            this.PageAjouterTache.TabIndex = 4;
            this.PageAjouterTache.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BoutAnnulerCreaTache, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.BoutValiderCreaTache, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 536);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(778, 40);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // BoutAnnulerCreaTache
            // 
            this.BoutAnnulerCreaTache.BackColor = System.Drawing.Color.White;
            this.BoutAnnulerCreaTache.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BoutAnnulerCreaTache.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoutAnnulerCreaTache.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoutAnnulerCreaTache.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoutAnnulerCreaTache.Location = new System.Drawing.Point(389, 0);
            this.BoutAnnulerCreaTache.Margin = new System.Windows.Forms.Padding(0);
            this.BoutAnnulerCreaTache.Name = "BoutAnnulerCreaTache";
            this.BoutAnnulerCreaTache.Size = new System.Drawing.Size(389, 40);
            this.BoutAnnulerCreaTache.TabIndex = 5;
            this.BoutAnnulerCreaTache.Text = "Annuler";
            this.BoutAnnulerCreaTache.UseVisualStyleBackColor = false;
            this.BoutAnnulerCreaTache.Click += new System.EventHandler(this.BoutAnnulerCreaTache_Click);
            // 
            // BoutValiderCreaTache
            // 
            this.BoutValiderCreaTache.BackColor = System.Drawing.Color.White;
            this.BoutValiderCreaTache.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BoutValiderCreaTache.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoutValiderCreaTache.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoutValiderCreaTache.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoutValiderCreaTache.Location = new System.Drawing.Point(0, 0);
            this.BoutValiderCreaTache.Margin = new System.Windows.Forms.Padding(0);
            this.BoutValiderCreaTache.Name = "BoutValiderCreaTache";
            this.BoutValiderCreaTache.Size = new System.Drawing.Size(389, 40);
            this.BoutValiderCreaTache.TabIndex = 4;
            this.BoutValiderCreaTache.Text = "Valider";
            this.BoutValiderCreaTache.UseVisualStyleBackColor = false;
            this.BoutValiderCreaTache.Click += new System.EventHandler(this.BoutValiderCreaTache_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.BoxNomCreaTache, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BoutCouleurCreaTache, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.PanDescCreaTache, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 576);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // BoxNomCreaTache
            // 
            this.BoxNomCreaTache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxNomCreaTache.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxNomCreaTache.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoxNomCreaTache.Location = new System.Drawing.Point(197, 23);
            this.BoxNomCreaTache.Name = "BoxNomCreaTache";
            this.BoxNomCreaTache.Size = new System.Drawing.Size(421, 33);
            this.BoxNomCreaTache.TabIndex = 0;
            // 
            // BoutCouleurCreaTache
            // 
            this.BoutCouleurCreaTache.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoutCouleurCreaTache.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoutCouleurCreaTache.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoutCouleurCreaTache.Location = new System.Drawing.Point(197, 484);
            this.BoutCouleurCreaTache.Name = "BoutCouleurCreaTache";
            this.BoutCouleurCreaTache.Size = new System.Drawing.Size(421, 39);
            this.BoutCouleurCreaTache.TabIndex = 6;
            this.BoutCouleurCreaTache.Text = "Couleur";
            this.BoutCouleurCreaTache.UseVisualStyleBackColor = true;
            this.BoutCouleurCreaTache.Click += new System.EventHandler(this.BoutCouleurCreaTache_Click);
            // 
            // PanDescCreaTache
            // 
            this.PanDescCreaTache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanDescCreaTache.Controls.Add(this.BoxDescCreaTache);
            this.PanDescCreaTache.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanDescCreaTache.Location = new System.Drawing.Point(194, 139);
            this.PanDescCreaTache.Margin = new System.Windows.Forms.Padding(0);
            this.PanDescCreaTache.Name = "PanDescCreaTache";
            this.PanDescCreaTache.Size = new System.Drawing.Size(427, 322);
            this.PanDescCreaTache.TabIndex = 8;
            // 
            // BoxDescCreaTache
            // 
            this.BoxDescCreaTache.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxDescCreaTache.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxDescCreaTache.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoxDescCreaTache.Location = new System.Drawing.Point(0, 0);
            this.BoxDescCreaTache.Name = "BoxDescCreaTache";
            this.BoxDescCreaTache.Size = new System.Drawing.Size(425, 320);
            this.BoxDescCreaTache.TabIndex = 1;
            this.BoxDescCreaTache.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tâche à faire";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BoutModifierTache
            // 
            this.BoutModifierTache.BackColor = System.Drawing.Color.White;
            this.BoutModifierTache.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BoutModifierTache.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoutModifierTache.Enabled = false;
            this.BoutModifierTache.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoutModifierTache.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoutModifierTache.Location = new System.Drawing.Point(194, 0);
            this.BoutModifierTache.Margin = new System.Windows.Forms.Padding(0);
            this.BoutModifierTache.Name = "BoutModifierTache";
            this.BoutModifierTache.Size = new System.Drawing.Size(194, 40);
            this.BoutModifierTache.TabIndex = 5;
            this.BoutModifierTache.Text = "Modifier";
            this.BoutModifierTache.UseVisualStyleBackColor = false;
            this.BoutModifierTache.Click += new System.EventHandler(this.BoutModifierTache_Click);
            // 
            // BoutTerminerTache
            // 
            this.BoutTerminerTache.BackColor = System.Drawing.Color.White;
            this.BoutTerminerTache.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BoutTerminerTache.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoutTerminerTache.Enabled = false;
            this.BoutTerminerTache.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoutTerminerTache.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoutTerminerTache.Location = new System.Drawing.Point(388, 0);
            this.BoutTerminerTache.Margin = new System.Windows.Forms.Padding(0);
            this.BoutTerminerTache.Name = "BoutTerminerTache";
            this.BoutTerminerTache.Size = new System.Drawing.Size(194, 40);
            this.BoutTerminerTache.TabIndex = 6;
            this.BoutTerminerTache.Text = "Terminer";
            this.BoutTerminerTache.UseVisualStyleBackColor = false;
            this.BoutTerminerTache.Click += new System.EventHandler(this.BoutTerminerTache_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.White;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Image3.png");
            this.imageList1.Images.SetKeyName(1, "Image2.png");
            this.imageList1.Images.SetKeyName(2, "Image1.png");
            this.imageList1.Images.SetKeyName(3, "Image4.png");
            this.imageList1.Images.SetKeyName(4, "Image5.png");
            this.imageList1.Images.SetKeyName(5, "Image6.png");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.BoutAjouterTache, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BoutSupprimerTache, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BoutModifierTache, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BoutTerminerTache, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 576);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 40);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BoxDescription);
            this.panel1.Controls.Add(this.LabNomTache);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(305, 33);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.panel1.Size = new System.Drawing.Size(460, 505);
            this.panel1.TabIndex = 1;
            // 
            // BoxDescription
            // 
            this.BoxDescription.BackColor = System.Drawing.Color.White;
            this.BoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoxDescription.Location = new System.Drawing.Point(7, 114);
            this.BoxDescription.Name = "BoxDescription";
            this.BoxDescription.ReadOnly = true;
            this.BoxDescription.Size = new System.Drawing.Size(444, 389);
            this.BoxDescription.TabIndex = 1;
            this.BoxDescription.Text = "Rien de mieux qu\'une ToDo list pour bien s\'organiser :D";
            this.BoxDescription.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.BoxDescription_LinkClicked);
            // 
            // LabNomTache
            // 
            this.LabNomTache.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabNomTache.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabNomTache.Location = new System.Drawing.Point(7, 0);
            this.LabNomTache.Margin = new System.Windows.Forms.Padding(0);
            this.LabNomTache.Name = "LabNomTache";
            this.LabNomTache.Padding = new System.Windows.Forms.Padding(0, 5, 0, 20);
            this.LabNomTache.Size = new System.Drawing.Size(444, 114);
            this.LabNomTache.TabIndex = 0;
            this.LabNomTache.Text = "Bienvenue sur TASKetch";
            // 
            // PanListTask
            // 
            this.PanListTask.AutoScroll = true;
            this.PanListTask.BackColor = System.Drawing.Color.White;
            this.PanListTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanListTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanListTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanListTask.Location = new System.Drawing.Point(13, 33);
            this.PanListTask.Name = "PanListTask";
            this.PanListTask.Size = new System.Drawing.Size(266, 505);
            this.PanListTask.TabIndex = 0;
            // 
            // PageContenuPrincipale
            // 
            this.PageContenuPrincipale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PageContenuPrincipale.ColumnCount = 5;
            this.PageContenuPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.PageContenuPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.PageContenuPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PageContenuPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PageContenuPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.PageContenuPrincipale.Controls.Add(this.PanListTask, 1, 1);
            this.PageContenuPrincipale.Controls.Add(this.panel1, 3, 1);
            this.PageContenuPrincipale.Controls.Add(this.BarRecherche, 1, 0);
            this.PageContenuPrincipale.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.PageContenuPrincipale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageContenuPrincipale.Location = new System.Drawing.Point(0, 0);
            this.PageContenuPrincipale.Margin = new System.Windows.Forms.Padding(0);
            this.PageContenuPrincipale.Name = "PageContenuPrincipale";
            this.PageContenuPrincipale.RowCount = 3;
            this.PageContenuPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PageContenuPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PageContenuPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PageContenuPrincipale.Size = new System.Drawing.Size(778, 576);
            this.PageContenuPrincipale.TabIndex = 9;
            // 
            // BarRecherche
            // 
            this.BarRecherche.AutoCompleteCustomSource = null;
            this.BarRecherche.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.BarRecherche.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.BarRecherche.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.BarRecherche.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BarRecherche.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.BarRecherche.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.BarRecherche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BarRecherche.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BarRecherche.Image = null;
            this.BarRecherche.IsDerivedStyle = true;
            this.BarRecherche.Lines = null;
            this.BarRecherche.Location = new System.Drawing.Point(13, 3);
            this.BarRecherche.MaxLength = 32767;
            this.BarRecherche.Multiline = false;
            this.BarRecherche.Name = "BarRecherche";
            this.BarRecherche.ReadOnly = false;
            this.BarRecherche.Size = new System.Drawing.Size(266, 24);
            this.BarRecherche.Style = MetroSet_UI.Enums.Style.Light;
            this.BarRecherche.StyleManager = null;
            this.BarRecherche.TabIndex = 2;
            this.BarRecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BarRecherche.ThemeAuthor = "Narwin";
            this.BarRecherche.ThemeName = "MetroLite";
            this.BarRecherche.UseSystemPasswordChar = false;
            this.BarRecherche.WatermarkText = "rechercher";
            this.BarRecherche.TextChanged += new System.EventHandler(this.metroSetTextBox1_TextChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.BoutMonter, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BoutDescendre, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(13, 544);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(266, 29);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // BoutMonter
            // 
            this.BoutMonter.BackColor = System.Drawing.Color.White;
            this.BoutMonter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoutMonter.Enabled = false;
            this.BoutMonter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoutMonter.Location = new System.Drawing.Point(3, 3);
            this.BoutMonter.Name = "BoutMonter";
            this.BoutMonter.Size = new System.Drawing.Size(127, 23);
            this.BoutMonter.TabIndex = 0;
            this.BoutMonter.Text = "Monter";
            this.BoutMonter.UseVisualStyleBackColor = false;
            this.BoutMonter.Click += new System.EventHandler(this.BoutMonter_Click);
            // 
            // BoutDescendre
            // 
            this.BoutDescendre.BackColor = System.Drawing.Color.White;
            this.BoutDescendre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoutDescendre.Enabled = false;
            this.BoutDescendre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoutDescendre.Location = new System.Drawing.Point(136, 3);
            this.BoutDescendre.Name = "BoutDescendre";
            this.BoutDescendre.Size = new System.Drawing.Size(127, 23);
            this.BoutDescendre.TabIndex = 1;
            this.BoutDescendre.Text = "Descendre";
            this.BoutDescendre.UseVisualStyleBackColor = false;
            this.BoutDescendre.Click += new System.EventHandler(this.BoutDescendre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(778, 616);
            this.Controls.Add(this.PageAjouterTache);
            this.Controls.Add(this.PageContenuPrincipale);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TASKroutch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.PageAjouterTache.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.PanDescCreaTache.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PageContenuPrincipale.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BoutAjouterTache;
        private System.Windows.Forms.Button BoutSupprimerTache;
        private System.Windows.Forms.Panel PageAjouterTache;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxNomCreaTache;
        private System.Windows.Forms.RichTextBox BoxDescCreaTache;
        private System.Windows.Forms.Button BoutAnnulerCreaTache;
        private System.Windows.Forms.Button BoutValiderCreaTache;
        private System.Windows.Forms.Button BoutModifierTache;
        private System.Windows.Forms.Button BoutTerminerTache;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button BoutCouleurCreaTache;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel PanDescCreaTache;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox BoxDescription;
        private System.Windows.Forms.Label LabNomTache;
        private System.Windows.Forms.Panel PanListTask;
        private System.Windows.Forms.TableLayoutPanel PageContenuPrincipale;
        private MetroSet_UI.Controls.MetroSetTextBox BarRecherche;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button BoutMonter;
        private System.Windows.Forms.Button BoutDescendre;
    }
}

