﻿namespace UI_Library
{
    partial class createObject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butForm = new System.Windows.Forms.Button();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subfileNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.subfileSubnewSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.butMaterial = new System.Windows.Forms.Button();
            this.butMeasurement = new System.Windows.Forms.Button();
            this.butColor = new System.Windows.Forms.Button();
            this.cmBoxMaterial = new System.Windows.Forms.ComboBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butOk = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.txtBoxX = new UI_Library.Code.Adaptator.TextBoxImputable();
            this.txtBoxY = new UI_Library.Code.Adaptator.TextBoxImputable();
            this.txtBoxZ = new UI_Library.Code.Adaptator.TextBoxImputable();
            this.checkedListBoxPoints = new System.Windows.Forms.CheckedListBox();
            this.arrowDown = new System.Windows.Forms.Button();
            this.arrowUp = new System.Windows.Forms.Button();
            this.pctBoxShuriken = new System.Windows.Forms.PictureBox();
            this.pctBoxCercle = new System.Windows.Forms.PictureBox();
            this.pctBoxPentagone = new System.Windows.Forms.PictureBox();
            this.pctBoxHexagone = new System.Windows.Forms.PictureBox();
            this.pctBoxTriangle = new System.Windows.Forms.PictureBox();
            this.pctBoxCarre = new System.Windows.Forms.PictureBox();
            this.pctBoxCreate = new System.Windows.Forms.PictureBox();
            this.addButton = new System.Windows.Forms.Button();
            this.unChekButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxShuriken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCercle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPentagone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxHexagone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxTriangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCarre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCreate)).BeginInit();
            this.SuspendLayout();
            // 
            // butForm
            // 
            this.butForm.Location = new System.Drawing.Point(112, 163);
            this.butForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butForm.Name = "butForm";
            this.butForm.Size = new System.Drawing.Size(358, 132);
            this.butForm.TabIndex = 2;
            this.butForm.Text = "Form";
            this.butForm.UseVisualStyleBackColor = true;
            this.butForm.Click += new System.EventHandler(this.butForm_Click);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subfileNewToolStripMenuItem,
            this.openToolStripMenuItem,
            this.addToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fichierToolStripMenuItem.Text = "File";
            // 
            // subfileNewToolStripMenuItem
            // 
            this.subfileNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectToolStripMenuItem1,
            this.subfileSubnewSimulationToolStripMenuItem});
            this.subfileNewToolStripMenuItem.Name = "subfileNewToolStripMenuItem";
            this.subfileNewToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.subfileNewToolStripMenuItem.Text = "New";
            // 
            // objectToolStripMenuItem1
            // 
            this.objectToolStripMenuItem1.Name = "objectToolStripMenuItem1";
            this.objectToolStripMenuItem1.Size = new System.Drawing.Size(198, 34);
            this.objectToolStripMenuItem1.Text = "Object";
            // 
            // subfileSubnewSimulationToolStripMenuItem
            // 
            this.subfileSubnewSimulationToolStripMenuItem.Name = "subfileSubnewSimulationToolStripMenuItem";
            this.subfileSubnewSimulationToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.subfileSubnewSimulationToolStripMenuItem.Text = "Simulation";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editionToolStripMenuItem.Text = "Edit";
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.affichageToolStripMenuItem.Text = "View";
            // 
            // objectToolStripMenuItem
            // 
            this.objectToolStripMenuItem.Name = "objectToolStripMenuItem";
            this.objectToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.objectToolStripMenuItem.Text = "Object";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.affichageToolStripMenuItem,
            this.objectToolStripMenuItem,
            this.runToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2334, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // butMaterial
            // 
            this.butMaterial.Location = new System.Drawing.Point(112, 348);
            this.butMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butMaterial.Name = "butMaterial";
            this.butMaterial.Size = new System.Drawing.Size(358, 132);
            this.butMaterial.TabIndex = 3;
            this.butMaterial.Text = "Material";
            this.butMaterial.UseVisualStyleBackColor = true;
            this.butMaterial.Click += new System.EventHandler(this.butMaterial_Click);
            // 
            // butMeasurement
            // 
            this.butMeasurement.Location = new System.Drawing.Point(112, 532);
            this.butMeasurement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butMeasurement.Name = "butMeasurement";
            this.butMeasurement.Size = new System.Drawing.Size(358, 132);
            this.butMeasurement.TabIndex = 4;
            this.butMeasurement.Text = "Measurement";
            this.butMeasurement.UseVisualStyleBackColor = true;
            this.butMeasurement.Click += new System.EventHandler(this.butMeasurement_Click);
            // 
            // butColor
            // 
            this.butColor.Location = new System.Drawing.Point(112, 717);
            this.butColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butColor.Name = "butColor";
            this.butColor.Size = new System.Drawing.Size(358, 132);
            this.butColor.TabIndex = 5;
            this.butColor.Text = "Color";
            this.butColor.UseVisualStyleBackColor = true;
            // 
            // cmBoxMaterial
            // 
            this.cmBoxMaterial.Enabled = false;
            this.cmBoxMaterial.FormattingEnabled = true;
            this.cmBoxMaterial.Items.AddRange(new object[] {
            "Aluminium",
            "Or",
            "Diamand",
            "Fer",
            "Acier",
            "Inox"});
            this.cmBoxMaterial.Location = new System.Drawing.Point(1707, 165);
            this.cmBoxMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmBoxMaterial.Name = "cmBoxMaterial";
            this.cmBoxMaterial.Size = new System.Drawing.Size(456, 28);
            this.cmBoxMaterial.TabIndex = 12;
            this.cmBoxMaterial.Text = "Material";
            this.cmBoxMaterial.Visible = false;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(1954, 965);
            this.butCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(308, 60);
            this.butCancel.TabIndex = 13;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Visible = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(1623, 965);
            this.butOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(308, 60);
            this.butOk.TabIndex = 14;
            this.butOk.Text = "OK";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Visible = false;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(1708, 374);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(50, 33);
            this.lblX.TabIndex = 15;
            this.lblX.Text = "X :";
            this.lblX.Visible = false;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(1708, 451);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(51, 33);
            this.lblY.TabIndex = 16;
            this.lblY.Text = "Y :";
            this.lblY.Visible = false;
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZ.Location = new System.Drawing.Point(1708, 528);
            this.lblZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(49, 33);
            this.lblZ.TabIndex = 17;
            this.lblZ.Text = "Z :";
            this.lblZ.Visible = false;
            // 
            // txtBoxX
            // 
            this.txtBoxX.AccessibleDescription = "";
            this.txtBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxX.Location = new System.Drawing.Point(1768, 369);
            this.txtBoxX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxX.Name = "txtBoxX";
            this.txtBoxX.Size = new System.Drawing.Size(158, 40);
            this.txtBoxX.TabIndex = 18;
            this.txtBoxX.Tag = "";
            this.txtBoxX.Visible = false;
            // 
            // txtBoxY
            // 
            this.txtBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxY.Location = new System.Drawing.Point(1768, 446);
            this.txtBoxY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxY.Name = "txtBoxY";
            this.txtBoxY.Size = new System.Drawing.Size(158, 40);
            this.txtBoxY.TabIndex = 19;
            this.txtBoxY.Visible = false;
            // 
            // txtBoxZ
            // 
            this.txtBoxZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxZ.Location = new System.Drawing.Point(1770, 523);
            this.txtBoxZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxZ.Name = "txtBoxZ";
            this.txtBoxZ.Size = new System.Drawing.Size(158, 40);
            this.txtBoxZ.TabIndex = 20;
            this.txtBoxZ.Visible = false;
            // 
            // checkedListBoxPoints
            // 
            this.checkedListBoxPoints.FormattingEnabled = true;
            this.checkedListBoxPoints.Location = new System.Drawing.Point(1710, 642);
            this.checkedListBoxPoints.Name = "checkedListBoxPoints";
            this.checkedListBoxPoints.Size = new System.Drawing.Size(393, 280);
            this.checkedListBoxPoints.TabIndex = 21;
            this.checkedListBoxPoints.Visible = false;
            // 
            // arrowDown
            // 
            this.arrowDown.Image = global::UI_Library.Properties.Resources.Arrow_Down_Small;
            this.arrowDown.Location = new System.Drawing.Point(2119, 818);
            this.arrowDown.Name = "arrowDown";
            this.arrowDown.Size = new System.Drawing.Size(79, 104);
            this.arrowDown.TabIndex = 22;
            this.arrowDown.UseVisualStyleBackColor = true;
            this.arrowDown.Visible = false;
            this.arrowDown.Click += new System.EventHandler(this.arrowDown_Click);
            // 
            // arrowUp
            // 
            this.arrowUp.BackColor = System.Drawing.Color.Transparent;
            this.arrowUp.Image = global::UI_Library.Properties.Resources.Arrow_Up_Small;
            this.arrowUp.Location = new System.Drawing.Point(2119, 642);
            this.arrowUp.Name = "arrowUp";
            this.arrowUp.Size = new System.Drawing.Size(79, 93);
            this.arrowUp.TabIndex = 0;
            this.arrowUp.UseVisualStyleBackColor = false;
            this.arrowUp.Visible = false;
            this.arrowUp.Click += new System.EventHandler(this.arrowUp_Click);
            // 
            // pctBoxShuriken
            // 
            this.pctBoxShuriken.Enabled = false;
            this.pctBoxShuriken.Image = global::UI_Library.Properties.Resources.shuriken;
            this.pctBoxShuriken.Location = new System.Drawing.Point(1971, 686);
            this.pctBoxShuriken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctBoxShuriken.Name = "pctBoxShuriken";
            this.pctBoxShuriken.Size = new System.Drawing.Size(195, 200);
            this.pctBoxShuriken.TabIndex = 11;
            this.pctBoxShuriken.TabStop = false;
            this.pctBoxShuriken.Visible = false;
            this.pctBoxShuriken.Click += new System.EventHandler(this.pctBoxShuriken_Click_1);
            // 
            // pctBoxCercle
            // 
            this.pctBoxCercle.Enabled = false;
            this.pctBoxCercle.Image = global::UI_Library.Properties.Resources.cercle;
            this.pctBoxCercle.Location = new System.Drawing.Point(1706, 686);
            this.pctBoxCercle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctBoxCercle.Name = "pctBoxCercle";
            this.pctBoxCercle.Size = new System.Drawing.Size(195, 200);
            this.pctBoxCercle.TabIndex = 10;
            this.pctBoxCercle.TabStop = false;
            this.pctBoxCercle.Visible = false;
            this.pctBoxCercle.Click += new System.EventHandler(this.pctBoxCercle_Click_1);
            // 
            // pctBoxPentagone
            // 
            this.pctBoxPentagone.Enabled = false;
            this.pctBoxPentagone.Image = global::UI_Library.Properties.Resources.pentagone;
            this.pctBoxPentagone.Location = new System.Drawing.Point(1971, 425);
            this.pctBoxPentagone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctBoxPentagone.Name = "pctBoxPentagone";
            this.pctBoxPentagone.Size = new System.Drawing.Size(195, 200);
            this.pctBoxPentagone.TabIndex = 9;
            this.pctBoxPentagone.TabStop = false;
            this.pctBoxPentagone.Visible = false;
            this.pctBoxPentagone.Click += new System.EventHandler(this.pctBoxPentagone_Click_1);
            // 
            // pctBoxHexagone
            // 
            this.pctBoxHexagone.Enabled = false;
            this.pctBoxHexagone.Image = global::UI_Library.Properties.Resources.hexagone;
            this.pctBoxHexagone.Location = new System.Drawing.Point(1706, 425);
            this.pctBoxHexagone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctBoxHexagone.Name = "pctBoxHexagone";
            this.pctBoxHexagone.Size = new System.Drawing.Size(195, 200);
            this.pctBoxHexagone.TabIndex = 8;
            this.pctBoxHexagone.TabStop = false;
            this.pctBoxHexagone.Visible = false;
            this.pctBoxHexagone.Click += new System.EventHandler(this.pctBoxHexagone_Click_1);
            // 
            // pctBoxTriangle
            // 
            this.pctBoxTriangle.Enabled = false;
            this.pctBoxTriangle.Image = global::UI_Library.Properties.Resources.triangle;
            this.pctBoxTriangle.Location = new System.Drawing.Point(1971, 163);
            this.pctBoxTriangle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctBoxTriangle.Name = "pctBoxTriangle";
            this.pctBoxTriangle.Size = new System.Drawing.Size(195, 200);
            this.pctBoxTriangle.TabIndex = 7;
            this.pctBoxTriangle.TabStop = false;
            this.pctBoxTriangle.Visible = false;
            this.pctBoxTriangle.Click += new System.EventHandler(this.pctBoxTriangle_Click_1);
            // 
            // pctBoxCarre
            // 
            this.pctBoxCarre.Enabled = false;
            this.pctBoxCarre.Image = global::UI_Library.Properties.Resources.carré;
            this.pctBoxCarre.Location = new System.Drawing.Point(1706, 163);
            this.pctBoxCarre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctBoxCarre.Name = "pctBoxCarre";
            this.pctBoxCarre.Size = new System.Drawing.Size(195, 200);
            this.pctBoxCarre.TabIndex = 6;
            this.pctBoxCarre.TabStop = false;
            this.pctBoxCarre.Visible = false;
            this.pctBoxCarre.Click += new System.EventHandler(this.pctBoxCarre_Click);
            // 
            // pctBoxCreate
            // 
            this.pctBoxCreate.BackgroundImage = global::UI_Library.Properties.Resources.objet;
            this.pctBoxCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxCreate.Location = new System.Drawing.Point(634, 78);
            this.pctBoxCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctBoxCreate.Name = "pctBoxCreate";
            this.pctBoxCreate.Size = new System.Drawing.Size(900, 923);
            this.pctBoxCreate.TabIndex = 0;
            this.pctBoxCreate.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(2078, 438);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 64);
            this.addButton.TabIndex = 23;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // unChekButton
            // 
            this.unChekButton.Location = new System.Drawing.Point(2123, 755);
            this.unChekButton.Name = "unChekButton";
            this.unChekButton.Size = new System.Drawing.Size(138, 44);
            this.unChekButton.TabIndex = 24;
            this.unChekButton.Text = "UnCheck All";
            this.unChekButton.UseVisualStyleBackColor = true;
            this.unChekButton.Click += new System.EventHandler(this.unChekButton_Click);
            // 
            // createObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2334, 1043);
            this.Controls.Add(this.unChekButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.arrowDown);
            this.Controls.Add(this.arrowUp);
            this.Controls.Add(this.checkedListBoxPoints);
            this.Controls.Add(this.txtBoxZ);
            this.Controls.Add(this.txtBoxY);
            this.Controls.Add(this.txtBoxX);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.cmBoxMaterial);
            this.Controls.Add(this.pctBoxShuriken);
            this.Controls.Add(this.pctBoxCercle);
            this.Controls.Add(this.pctBoxPentagone);
            this.Controls.Add(this.pctBoxHexagone);
            this.Controls.Add(this.pctBoxTriangle);
            this.Controls.Add(this.pctBoxCarre);
            this.Controls.Add(this.butColor);
            this.Controls.Add(this.butMeasurement);
            this.Controls.Add(this.butMaterial);
            this.Controls.Add(this.butForm);
            this.Controls.Add(this.pctBoxCreate);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "createObject";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxShuriken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCercle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPentagone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxHexagone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxTriangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCarre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCreate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBoxCreate;
        private System.Windows.Forms.Button butForm;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subfileNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem subfileSubnewSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button butMaterial;
        private System.Windows.Forms.Button butMeasurement;
        private System.Windows.Forms.Button butColor;
        private System.Windows.Forms.PictureBox pctBoxCarre;
        private System.Windows.Forms.PictureBox pctBoxTriangle;
        private System.Windows.Forms.PictureBox pctBoxHexagone;
        private System.Windows.Forms.PictureBox pctBoxPentagone;
        private System.Windows.Forms.PictureBox pctBoxCercle;
        private System.Windows.Forms.PictureBox pctBoxShuriken;
        private System.Windows.Forms.ComboBox cmBoxMaterial;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
        private Code.Adaptator.TextBoxImputable txtBoxX;
        private Code.Adaptator.TextBoxImputable txtBoxY;
        private Code.Adaptator.TextBoxImputable txtBoxZ;
        private System.Windows.Forms.CheckedListBox checkedListBoxPoints;
        private System.Windows.Forms.Button arrowUp;
        private System.Windows.Forms.Button arrowDown;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button unChekButton;
    }
}