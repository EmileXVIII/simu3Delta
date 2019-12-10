namespace UI_Library
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.barMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subfileNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subfileSubnewObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subfileSubnewSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subfileOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subfileSubopenObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subfileSubopenSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subrunSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonTest = new System.Windows.Forms.Button();
            this.but = new System.Windows.Forms.Label();
            this.barMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // barMenuStrip
            // 
            this.barMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.barMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.barMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.affichageToolStripMenuItem,
            this.projetToolStripMenuItem,
            this.runToolStripMenuItem});
            this.barMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.barMenuStrip.Name = "barMenuStrip";
            this.barMenuStrip.Size = new System.Drawing.Size(916, 33);
            this.barMenuStrip.TabIndex = 0;
            this.barMenuStrip.Text = "barMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subfileNewToolStripMenuItem,
            this.subfileOpenToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // subfileNewToolStripMenuItem
            // 
            this.subfileNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subfileSubnewObjectToolStripMenuItem,
            this.subfileSubnewSimulationToolStripMenuItem});
            this.subfileNewToolStripMenuItem.Name = "subfileNewToolStripMenuItem";
            this.subfileNewToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.subfileNewToolStripMenuItem.Text = "New";
            // 
            // subfileSubnewObjectToolStripMenuItem
            // 
            this.subfileSubnewObjectToolStripMenuItem.Name = "subfileSubnewObjectToolStripMenuItem";
            this.subfileSubnewObjectToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.subfileSubnewObjectToolStripMenuItem.Text = "Object";
            this.subfileSubnewObjectToolStripMenuItem.Click += new System.EventHandler(this.subfileSubnewObjectToolStripMenuItem_Click);
            // 
            // subfileSubnewSimulationToolStripMenuItem
            // 
            this.subfileSubnewSimulationToolStripMenuItem.Name = "subfileSubnewSimulationToolStripMenuItem";
            this.subfileSubnewSimulationToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.subfileSubnewSimulationToolStripMenuItem.Text = "Simulation";
            // 
            // subfileOpenToolStripMenuItem
            // 
            this.subfileOpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subfileSubopenObjectToolStripMenuItem,
            this.subfileSubopenSimulationToolStripMenuItem});
            this.subfileOpenToolStripMenuItem.Name = "subfileOpenToolStripMenuItem";
            this.subfileOpenToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.subfileOpenToolStripMenuItem.Text = "Open";
            // 
            // subfileSubopenObjectToolStripMenuItem
            // 
            this.subfileSubopenObjectToolStripMenuItem.Name = "subfileSubopenObjectToolStripMenuItem";
            this.subfileSubopenObjectToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.subfileSubopenObjectToolStripMenuItem.Text = "Object";
            this.subfileSubopenObjectToolStripMenuItem.Click += new System.EventHandler(this.subfileSubopenObjectToolStripMenuItem_Click);
            // 
            // subfileSubopenSimulationToolStripMenuItem
            // 
            this.subfileSubopenSimulationToolStripMenuItem.Name = "subfileSubopenSimulationToolStripMenuItem";
            this.subfileSubopenSimulationToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.subfileSubopenSimulationToolStripMenuItem.Text = "Simulation";
            this.subfileSubopenSimulationToolStripMenuItem.Click += new System.EventHandler(this.subfileSubopenSimulationToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // projetToolStripMenuItem
            // 
            this.projetToolStripMenuItem.Name = "projetToolStripMenuItem";
            this.projetToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.projetToolStripMenuItem.Text = "Projet";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subrunSimulationToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // subrunSimulationToolStripMenuItem
            // 
            this.subrunSimulationToolStripMenuItem.Name = "subrunSimulationToolStripMenuItem";
            this.subrunSimulationToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.subrunSimulationToolStripMenuItem.Text = "Simulation";
            this.subrunSimulationToolStripMenuItem.Click += new System.EventHandler(this.subrunSimulationToolStripMenuItem_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(222, 283);
            this.buttonTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(424, 166);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = "buttonTest";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // but
            // 
            this.but.AutoSize = true;
            this.but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but.Location = new System.Drawing.Point(0, 50);
            this.but.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(892, 87);
            this.but.TabIndex = 2;
            this.but.Text = "Bienvenue sur simu3Delta. \nCe projet a pour but la simulation 2D des deformations" +
    " dues à un choc. \nPour commencer utiliser le bouton test ci-dessous ou faites Fi" +
    "chier/Nouveau/Objet";
            this.but.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 692);
            this.Controls.Add(this.but);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.barMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.barMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.barMenuStrip.ResumeLayout(false);
            this.barMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip barMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projetToolStripMenuItem;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label but;
        private System.Windows.Forms.ToolStripMenuItem subfileNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subfileSubnewObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subfileSubnewSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subfileOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subfileSubopenObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subfileSubopenSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subrunSimulationToolStripMenuItem;
    }
}

