﻿namespace WinFormToutEmbal
{
    partial class frmToutEmbal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToutEmbal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrêterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.continuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBoxA = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBoxB = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBoxC = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblProdA = new System.Windows.Forms.Label();
            this.lblProdB = new System.Windows.Forms.Label();
            this.lblProdC = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pageC = new System.Windows.Forms.TabPage();
            this.pageB = new System.Windows.Forms.TabPage();
            this.pageA = new System.Windows.Forms.TabPage();
            this.tabBox = new System.Windows.Forms.TabControl();
            this.progressBarProdA = new System.Windows.Forms.ProgressBar();
            this.progressBarProdB = new System.Windows.Forms.ProgressBar();
            this.progressBarProdC = new System.Windows.Forms.ProgressBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.prodcutionTraffic1 = new WinFormToutEmbal.UserControlTool.ProdcutionTraffic();
            this.prodcutionTraffic2 = new WinFormToutEmbal.UserControlTool.ProdcutionTraffic();
            this.prodcutionTraffic3 = new WinFormToutEmbal.UserControlTool.ProdcutionTraffic();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.productionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolStripMenuItem,
            this.arrêterToolStripMenuItem,
            this.continuerToolStripMenuItem});
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem,
            this.cToolStripMenuItem});
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StartToolStripMenuItem.Tag = "start";
            this.StartToolStripMenuItem.Text = "Démarrer";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aToolStripMenuItem.Text = "A";
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bToolStripMenuItem.Text = "B";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem.Text = "C";
            // 
            // arrêterToolStripMenuItem
            // 
            this.arrêterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem1,
            this.bToolStripMenuItem1,
            this.cToolStripMenuItem1});
            this.arrêterToolStripMenuItem.Name = "arrêterToolStripMenuItem";
            this.arrêterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arrêterToolStripMenuItem.Tag = "stop";
            this.arrêterToolStripMenuItem.Text = "Arrêter";
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aToolStripMenuItem1.Text = "A";
            // 
            // bToolStripMenuItem1
            // 
            this.bToolStripMenuItem1.Name = "bToolStripMenuItem1";
            this.bToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bToolStripMenuItem1.Text = "B";
            // 
            // cToolStripMenuItem1
            // 
            this.cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            this.cToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem1.Text = "C";
            // 
            // continuerToolStripMenuItem
            // 
            this.continuerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem2,
            this.bToolStripMenuItem2,
            this.cToolStripMenuItem2});
            this.continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
            this.continuerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.continuerToolStripMenuItem.Tag = "pause";
            this.continuerToolStripMenuItem.Text = "continuer";
            // 
            // aToolStripMenuItem2
            // 
            this.aToolStripMenuItem2.Name = "aToolStripMenuItem2";
            this.aToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.aToolStripMenuItem2.Text = "A";
            // 
            // bToolStripMenuItem2
            // 
            this.bToolStripMenuItem2.Name = "bToolStripMenuItem2";
            this.bToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.bToolStripMenuItem2.Text = "B";
            // 
            // cToolStripMenuItem2
            // 
            this.cToolStripMenuItem2.Name = "cToolStripMenuItem2";
            this.cToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem2.Text = "C";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBoxA,
            this.statusBoxB,
            this.statusBoxC,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(607, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBoxA
            // 
            this.statusBoxA.Name = "statusBoxA";
            this.statusBoxA.Size = new System.Drawing.Size(57, 17);
            this.statusBoxA.Text = "Caisse A :";
            // 
            // statusBoxB
            // 
            this.statusBoxB.Name = "statusBoxB";
            this.statusBoxB.Size = new System.Drawing.Size(56, 17);
            this.statusBoxB.Text = "Caisse B :";
            // 
            // statusBoxC
            // 
            this.statusBoxC.Name = "statusBoxC";
            this.statusBoxC.Size = new System.Drawing.Size(57, 17);
            this.statusBoxC.Text = "Caisse C :";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel4.Text = "Date Time Here";
            // 
            // lblProdA
            // 
            this.lblProdA.AutoSize = true;
            this.lblProdA.Location = new System.Drawing.Point(119, 296);
            this.lblProdA.Name = "lblProdA";
            this.lblProdA.Size = new System.Drawing.Size(77, 15);
            this.lblProdA.TabIndex = 6;
            this.lblProdA.Text = "Production A";
            // 
            // lblProdB
            // 
            this.lblProdB.AutoSize = true;
            this.lblProdB.Location = new System.Drawing.Point(119, 343);
            this.lblProdB.Name = "lblProdB";
            this.lblProdB.Size = new System.Drawing.Size(76, 15);
            this.lblProdB.TabIndex = 7;
            this.lblProdB.Text = "Production B";
            // 
            // lblProdC
            // 
            this.lblProdC.AutoSize = true;
            this.lblProdC.Location = new System.Drawing.Point(119, 390);
            this.lblProdC.Name = "lblProdC";
            this.lblProdC.Size = new System.Drawing.Size(77, 15);
            this.lblProdC.TabIndex = 8;
            this.lblProdC.Text = "Production C";
            // 
            // pageC
            // 
            this.pageC.Location = new System.Drawing.Point(4, 24);
            this.pageC.Name = "pageC";
            this.pageC.Padding = new System.Windows.Forms.Padding(3);
            this.pageC.Size = new System.Drawing.Size(537, 158);
            this.pageC.TabIndex = 2;
            this.pageC.Text = "Caisse C";
            this.pageC.UseVisualStyleBackColor = true;
            // 
            // pageB
            // 
            this.pageB.Location = new System.Drawing.Point(4, 24);
            this.pageB.Name = "pageB";
            this.pageB.Padding = new System.Windows.Forms.Padding(3);
            this.pageB.Size = new System.Drawing.Size(537, 158);
            this.pageB.TabIndex = 1;
            this.pageB.Text = "Caisse B";
            this.pageB.UseVisualStyleBackColor = true;
            // 
            // pageA
            // 
            this.pageA.Location = new System.Drawing.Point(4, 24);
            this.pageA.Name = "pageA";
            this.pageA.Padding = new System.Windows.Forms.Padding(3);
            this.pageA.Size = new System.Drawing.Size(537, 158);
            this.pageA.TabIndex = 0;
            this.pageA.Text = "Caisse A";
            this.pageA.UseVisualStyleBackColor = true;
            // 
            // tabBox
            // 
            this.tabBox.Controls.Add(this.pageA);
            this.tabBox.Controls.Add(this.pageB);
            this.tabBox.Controls.Add(this.pageC);
            this.tabBox.Location = new System.Drawing.Point(27, 39);
            this.tabBox.Name = "tabBox";
            this.tabBox.SelectedIndex = 0;
            this.tabBox.Size = new System.Drawing.Size(545, 186);
            this.tabBox.TabIndex = 9;
            // 
            // progressBarProdA
            // 
            this.progressBarProdA.Location = new System.Drawing.Point(228, 275);
            this.progressBarProdA.Name = "progressBarProdA";
            this.progressBarProdA.Size = new System.Drawing.Size(233, 36);
            this.progressBarProdA.TabIndex = 10;
            // 
            // progressBarProdB
            // 
            this.progressBarProdB.Location = new System.Drawing.Point(228, 322);
            this.progressBarProdB.Name = "progressBarProdB";
            this.progressBarProdB.Size = new System.Drawing.Size(233, 36);
            this.progressBarProdB.TabIndex = 11;
            // 
            // progressBarProdC
            // 
            this.progressBarProdC.Location = new System.Drawing.Point(228, 369);
            this.progressBarProdC.Name = "progressBarProdC";
            this.progressBarProdC.Size = new System.Drawing.Size(233, 36);
            this.progressBarProdC.TabIndex = 12;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "green.png");
            this.imageList1.Images.SetKeyName(1, "red.png");
            this.imageList1.Images.SetKeyName(2, "orange.png");
            // 
            // prodcutionTraffic1
            // 
            this.prodcutionTraffic1.Location = new System.Drawing.Point(467, 275);
            this.prodcutionTraffic1.Name = "prodcutionTraffic1";
            this.prodcutionTraffic1.Size = new System.Drawing.Size(101, 36);
            this.prodcutionTraffic1.TabIndex = 13;
            // 
            // prodcutionTraffic2
            // 
            this.prodcutionTraffic2.Location = new System.Drawing.Point(468, 324);
            this.prodcutionTraffic2.Name = "prodcutionTraffic2";
            this.prodcutionTraffic2.Size = new System.Drawing.Size(100, 34);
            this.prodcutionTraffic2.TabIndex = 14;
            // 
            // prodcutionTraffic3
            // 
            this.prodcutionTraffic3.Location = new System.Drawing.Point(468, 371);
            this.prodcutionTraffic3.Name = "prodcutionTraffic3";
            this.prodcutionTraffic3.Size = new System.Drawing.Size(100, 34);
            this.prodcutionTraffic3.TabIndex = 15;
            // 
            // frmToutEmbal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.prodcutionTraffic3);
            this.Controls.Add(this.prodcutionTraffic2);
            this.Controls.Add(this.prodcutionTraffic1);
            this.Controls.Add(this.progressBarProdC);
            this.Controls.Add(this.progressBarProdB);
            this.Controls.Add(this.progressBarProdA);
            this.Controls.Add(this.tabBox);
            this.Controls.Add(this.lblProdC);
            this.Controls.Add(this.lblProdB);
            this.Controls.Add(this.lblProdA);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmToutEmbal";
            this.Text = "ToutEmbal";
            this.Load += new System.EventHandler(this.frmToutEmbal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem productionToolStripMenuItem;
        private ToolStripMenuItem StartToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem bToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem arrêterToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem1;
        private ToolStripMenuItem bToolStripMenuItem1;
        private ToolStripMenuItem cToolStripMenuItem1;
        private ToolStripMenuItem continuerToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem2;
        private ToolStripMenuItem bToolStripMenuItem2;
        private ToolStripMenuItem cToolStripMenuItem2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusBoxA;
        private ToolStripStatusLabel statusBoxB;
        private ToolStripStatusLabel statusBoxC;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private Label lblProdA;
        private Label lblProdB;
        private Label lblProdC;
        private System.Windows.Forms.Timer timer1;
        private TabPage pageC;
        private UserControlTool.ViewBoxUserControl viewBoxManager3;
        private TabPage pageB;
        private UserControlTool.ViewBoxUserControl viewBoxManager2;
        private TabPage pageA;
        private TabControl tabBox;
        private ProgressBar progressBarProdA;
        private ProgressBar progressBarProdB;
        private ProgressBar progressBarProdC;
        private ImageList imageList1;
        private UserControlTool.ProdcutionTraffic prodcutionTraffic1;
        private UserControlTool.ProdcutionTraffic prodcutionTraffic2;
        private UserControlTool.ProdcutionTraffic prodcutionTraffic3;
    }
}