﻿namespace Speiseplan
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvVorspeise = new System.Windows.Forms.ListView();
            this.columnIDVorspeise = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVorspeise = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvHauptspeise = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvNachspeise = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvVorspeise
            // 
            this.lvVorspeise.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIDVorspeise,
            this.columnVorspeise});
            this.lvVorspeise.HideSelection = false;
            this.lvVorspeise.Location = new System.Drawing.Point(45, 85);
            this.lvVorspeise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvVorspeise.Name = "lvVorspeise";
            this.lvVorspeise.Size = new System.Drawing.Size(359, 522);
            this.lvVorspeise.TabIndex = 0;
            this.lvVorspeise.UseCompatibleStateImageBehavior = false;
            this.lvVorspeise.View = System.Windows.Forms.View.Details;
            // 
            // columnIDVorspeise
            // 
            this.columnIDVorspeise.Text = "ID";
            // 
            // columnVorspeise
            // 
            this.columnVorspeise.Text = "Vorspeise";
            this.columnVorspeise.Width = 200;
            // 
            // lvHauptspeise
            // 
            this.lvHauptspeise.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvHauptspeise.HideSelection = false;
            this.lvHauptspeise.Location = new System.Drawing.Point(439, 85);
            this.lvHauptspeise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvHauptspeise.Name = "lvHauptspeise";
            this.lvHauptspeise.Size = new System.Drawing.Size(367, 522);
            this.lvHauptspeise.TabIndex = 1;
            this.lvHauptspeise.UseCompatibleStateImageBehavior = false;
            this.lvHauptspeise.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hauptspeise";
            this.columnHeader4.Width = 200;
            // 
            // lvNachspeise
            // 
            this.lvNachspeise.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.lvNachspeise.HideSelection = false;
            this.lvNachspeise.Location = new System.Drawing.Point(844, 85);
            this.lvNachspeise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvNachspeise.Name = "lvNachspeise";
            this.lvNachspeise.Size = new System.Drawing.Size(364, 522);
            this.lvNachspeise.TabIndex = 2;
            this.lvNachspeise.UseCompatibleStateImageBehavior = false;
            this.lvNachspeise.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Nachspeise";
            this.columnHeader10.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vorspeise";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(555, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hauptspeise";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(959, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nachspeise";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anlegenToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.löschenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1295, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // anlegenToolStripMenuItem
            // 
            this.anlegenToolStripMenuItem.Name = "anlegenToolStripMenuItem";
            this.anlegenToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.anlegenToolStripMenuItem.Text = "Anlegen";
            this.anlegenToolStripMenuItem.Click += new System.EventHandler(this.anlegenToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            this.bearbeitenToolStripMenuItem.Click += new System.EventHandler(this.bearbeitenToolStripMenuItem_Click);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.löschenToolStripMenuItem.Text = "Löschen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 750);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvNachspeise);
            this.Controls.Add(this.lvHauptspeise);
            this.Controls.Add(this.lvVorspeise);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnIDVorspeise;
        private System.Windows.Forms.ColumnHeader columnVorspeise;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anlegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        internal System.Windows.Forms.ListView lvVorspeise;
        internal System.Windows.Forms.ListView lvHauptspeise;
        internal System.Windows.Forms.ListView lvNachspeise;
    }
}

