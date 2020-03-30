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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxTest2 = new UI_Library.Code.Adaptator.TextBoxImputable();
            this.textBoxTest1 = new UI_Library.Code.Adaptator.TextBoxImputable();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFileName = new UI_Library.Code.Adaptator.TextBoxImputable();
            this.label3 = new System.Windows.Forms.Label();
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
            this.subfileSubnewObjectToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.subfileSubnewObjectToolStripMenuItem.Text = "Object";
            this.subfileSubnewObjectToolStripMenuItem.Click += new System.EventHandler(this.subfileSubnewObjectToolStripMenuItem_Click);
            // 
            // subfileSubnewSimulationToolStripMenuItem
            // 
            this.subfileSubnewSimulationToolStripMenuItem.Name = "subfileSubnewSimulationToolStripMenuItem";
            this.subfileSubnewSimulationToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
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
            this.subfileSubopenObjectToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.subfileSubopenObjectToolStripMenuItem.Text = "Object";
            this.subfileSubopenObjectToolStripMenuItem.Click += new System.EventHandler(this.subfileSubopenObjectToolStripMenuItem_Click);
            // 
            // subfileSubopenSimulationToolStripMenuItem
            // 
            this.subfileSubopenSimulationToolStripMenuItem.Name = "subfileSubopenSimulationToolStripMenuItem";
            this.subfileSubopenSimulationToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
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
            this.subrunSimulationToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.subrunSimulationToolStripMenuItem.Text = "Simulation";
            this.subrunSimulationToolStripMenuItem.Click += new System.EventHandler(this.subrunSimulationToolStripMenuItem_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(64, 215);
            this.buttonTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(203, 101);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = "test Création Image";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 101);
            this.button1.TabIndex = 3;
            this.button1.Text = "Test déformation 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 101);
            this.button2.TabIndex = 4;
            this.button2.Text = "Test déformation 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxTest2
            // 
            this.textBoxTest2.BackColor = System.Drawing.Color.White;
            this.textBoxTest2.Location = new System.Drawing.Point(381, 183);
            this.textBoxTest2.Name = "textBoxTest2";
            this.textBoxTest2.Size = new System.Drawing.Size(126, 26);
            this.textBoxTest2.TabIndex = 5;
            this.textBoxTest2.Text = "-5e-8";
            // 
            // textBoxTest1
            // 
            this.textBoxTest1.Location = new System.Drawing.Point(647, 183);
            this.textBoxTest1.Name = "textBoxTest1";
            this.textBoxTest1.Size = new System.Drawing.Size(148, 26);
            this.textBoxTest1.TabIndex = 6;
            this.textBoxTest1.Text = "-5e-8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Strenght en N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Strenght en N";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(64, 183);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(203, 26);
            this.textBoxFileName.TabIndex = 9;
            this.textBoxFileName.Text = "myImg.png";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "FileName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTest1);
            this.Controls.Add(this.textBoxTest2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        UI_Library.Code.Adaptator.TextBoxImputable textBoxTest2;
        UI_Library.Code.Adaptator.TextBoxImputable textBoxTest1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        UI_Library.Code.Adaptator.TextBoxImputable textBoxFileName;
        private System.Windows.Forms.Label label3;
    }
}

