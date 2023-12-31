﻿using System.Windows.Forms;

namespace Demo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Undo = new System.Windows.Forms.Button();
            this.Redo = new System.Windows.Forms.Button();
            this.nextpage = new System.Windows.Forms.Button();
            this.backpage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this._backgroundchat = new System.Windows.Forms.Panel();
            this._send = new System.Windows.Forms.Button();
            this._sendbox = new System.Windows.Forms.RichTextBox();
            this._boxchat = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.back_color = new System.Windows.Forms.Button();
            this.color_yellow = new System.Windows.Forms.Button();
            this.color_blue = new System.Windows.Forms.Button();
            this.color_red = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.back_pen = new System.Windows.Forms.Button();
            this.size_pen_3 = new System.Windows.Forms.Button();
            this.size_pen_2 = new System.Windows.Forms.Button();
            this.size_pen_1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.back_polygons = new System.Windows.Forms.Button();
            this._triangle = new System.Windows.Forms.Button();
            this._retangle = new System.Windows.Forms.Button();
            this._circle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.back_eraser = new System.Windows.Forms.Button();
            this.size_eraser_3 = new System.Windows.Forms.Button();
            this.size_eraser_2 = new System.Windows.Forms.Button();
            this.size_eraser_1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this._text = new System.Windows.Forms.Button();
            this._Color = new System.Windows.Forms.Button();
            this.Polygons = new System.Windows.Forms.Button();
            this.Eraser = new System.Windows.Forms.Button();
            this.Pen = new System.Windows.Forms.Button();
            this._chat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this._backgroundchat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.shareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.versionToolStripMenuItem.Text = "Contact Us";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.contactUsToolStripMenuItem.Text = "Version";
            // 
            // shareToolStripMenuItem
            // 
            this.shareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asEditorToolStripMenuItem,
            this.asViewerToolStripMenuItem});
            this.shareToolStripMenuItem.Name = "shareToolStripMenuItem";
            this.shareToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.shareToolStripMenuItem.Text = "Share";
            // 
            // asEditorToolStripMenuItem
            // 
            this.asEditorToolStripMenuItem.Name = "asEditorToolStripMenuItem";
            this.asEditorToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.asEditorToolStripMenuItem.Text = "As Editor";
            // 
            // asViewerToolStripMenuItem
            // 
            this.asViewerToolStripMenuItem.Name = "asViewerToolStripMenuItem";
            this.asViewerToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.asViewerToolStripMenuItem.Text = "As Viewer";
            // 
            // Undo
            // 
            this.Undo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Undo.BackgroundImage")));
            this.Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Undo.Location = new System.Drawing.Point(23, 113);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(30, 30);
            this.Undo.TabIndex = 1;
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Redo
            // 
            this.Redo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Redo.BackgroundImage")));
            this.Redo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Redo.Location = new System.Drawing.Point(64, 113);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(30, 30);
            this.Redo.TabIndex = 2;
            this.Redo.UseVisualStyleBackColor = true;
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            // 
            // nextpage
            // 
            this.nextpage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextpage.Location = new System.Drawing.Point(600, 550);
            this.nextpage.Name = "nextpage";
            this.nextpage.Size = new System.Drawing.Size(50, 20);
            this.nextpage.TabIndex = 3;
            this.nextpage.Text = ">";
            this.nextpage.UseVisualStyleBackColor = true;
            this.nextpage.Click += new System.EventHandler(this.nextpage_Click);
            // 
            // backpage
            // 
            this.backpage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backpage.Location = new System.Drawing.Point(550, 550);
            this.backpage.Name = "backpage";
            this.backpage.Size = new System.Drawing.Size(50, 20);
            this.backpage.TabIndex = 4;
            this.backpage.Text = "<";
            this.backpage.UseVisualStyleBackColor = true;
            this.backpage.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "(*.pdf)|*.pdf";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "(*.pdf)|*.pdf";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this._backgroundchat);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(100, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 510);
            this.panel1.TabIndex = 5;
            // 
            // _backgroundchat
            // 
            this._backgroundchat.BackColor = System.Drawing.Color.IndianRed;
            this._backgroundchat.Controls.Add(this._send);
            this._backgroundchat.Controls.Add(this._sendbox);
            this._backgroundchat.Controls.Add(this._boxchat);
            this._backgroundchat.Location = new System.Drawing.Point(350, 130);
            this._backgroundchat.Name = "_backgroundchat";
            this._backgroundchat.Size = new System.Drawing.Size(339, 229);
            this._backgroundchat.TabIndex = 1;
            // 
            // _send
            // 
            this._send.Location = new System.Drawing.Point(249, 188);
            this._send.Name = "_send";
            this._send.Size = new System.Drawing.Size(75, 23);
            this._send.TabIndex = 2;
            this._send.Text = "Send";
            this._send.UseVisualStyleBackColor = true;
            // 
            // _sendbox
            // 
            this._sendbox.Location = new System.Drawing.Point(3, 175);
            this._sendbox.Name = "_sendbox";
            this._sendbox.Size = new System.Drawing.Size(240, 50);
            this._sendbox.TabIndex = 1;
            this._sendbox.Text = "";
            // 
            // _boxchat
            // 
            this._boxchat.HideSelection = false;
            this._boxchat.Location = new System.Drawing.Point(3, 3);
            this._boxchat.Name = "_boxchat";
            this._boxchat.Size = new System.Drawing.Size(333, 166);
            this._boxchat.TabIndex = 0;
            this._boxchat.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 510);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Controls.Add(this.back_color);
            this.panel6.Controls.Add(this.color_yellow);
            this.panel6.Controls.Add(this.color_blue);
            this.panel6.Controls.Add(this.color_red);
            this.panel6.Location = new System.Drawing.Point(1120, 389);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(60, 210);
            this.panel6.TabIndex = 6;
            this.panel6.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(15, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // back_color
            // 
            this.back_color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_color.BackgroundImage")));
            this.back_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_color.Location = new System.Drawing.Point(15, 170);
            this.back_color.Name = "back_color";
            this.back_color.Size = new System.Drawing.Size(30, 30);
            this.back_color.TabIndex = 3;
            this.back_color.UseVisualStyleBackColor = true;
            this.back_color.Click += new System.EventHandler(this.back_color_Click);
            // 
            // color_yellow
            // 
            this.color_yellow.BackColor = System.Drawing.Color.Yellow;
            this.color_yellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.color_yellow.Location = new System.Drawing.Point(15, 130);
            this.color_yellow.Name = "color_yellow";
            this.color_yellow.Size = new System.Drawing.Size(30, 30);
            this.color_yellow.TabIndex = 2;
            this.color_yellow.UseVisualStyleBackColor = false;
            this.color_yellow.Click += new System.EventHandler(this.color_yellow_Click);
            // 
            // color_blue
            // 
            this.color_blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.color_blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.color_blue.Location = new System.Drawing.Point(15, 90);
            this.color_blue.Name = "color_blue";
            this.color_blue.Size = new System.Drawing.Size(30, 30);
            this.color_blue.TabIndex = 1;
            this.color_blue.UseVisualStyleBackColor = false;
            this.color_blue.Click += new System.EventHandler(this.color_blue_Click);
            // 
            // color_red
            // 
            this.color_red.BackColor = System.Drawing.Color.Red;
            this.color_red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.color_red.Location = new System.Drawing.Point(15, 50);
            this.color_red.Name = "color_red";
            this.color_red.Size = new System.Drawing.Size(30, 30);
            this.color_red.TabIndex = 0;
            this.color_red.UseVisualStyleBackColor = false;
            this.color_red.Click += new System.EventHandler(this.color_red_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.back_pen);
            this.panel5.Controls.Add(this.size_pen_3);
            this.panel5.Controls.Add(this.size_pen_2);
            this.panel5.Controls.Add(this.size_pen_1);
            this.panel5.Location = new System.Drawing.Point(1120, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 210);
            this.panel5.TabIndex = 5;
            this.panel5.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(15, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // back_pen
            // 
            this.back_pen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_pen.BackgroundImage")));
            this.back_pen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_pen.Location = new System.Drawing.Point(15, 170);
            this.back_pen.Name = "back_pen";
            this.back_pen.Size = new System.Drawing.Size(30, 30);
            this.back_pen.TabIndex = 3;
            this.back_pen.UseVisualStyleBackColor = true;
            this.back_pen.Click += new System.EventHandler(this.back_pen_Click);
            // 
            // size_pen_3
            // 
            this.size_pen_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("size_pen_3.BackgroundImage")));
            this.size_pen_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.size_pen_3.Location = new System.Drawing.Point(15, 130);
            this.size_pen_3.Name = "size_pen_3";
            this.size_pen_3.Size = new System.Drawing.Size(30, 30);
            this.size_pen_3.TabIndex = 2;
            this.size_pen_3.UseVisualStyleBackColor = true;
            this.size_pen_3.Click += new System.EventHandler(this.size_pen_3_Click);
            // 
            // size_pen_2
            // 
            this.size_pen_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("size_pen_2.BackgroundImage")));
            this.size_pen_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.size_pen_2.Location = new System.Drawing.Point(15, 90);
            this.size_pen_2.Name = "size_pen_2";
            this.size_pen_2.Size = new System.Drawing.Size(30, 30);
            this.size_pen_2.TabIndex = 1;
            this.size_pen_2.UseVisualStyleBackColor = true;
            this.size_pen_2.Click += new System.EventHandler(this.size_pen_2_Click);
            // 
            // size_pen_1
            // 
            this.size_pen_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("size_pen_1.BackgroundImage")));
            this.size_pen_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.size_pen_1.Location = new System.Drawing.Point(15, 50);
            this.size_pen_1.Name = "size_pen_1";
            this.size_pen_1.Size = new System.Drawing.Size(30, 30);
            this.size_pen_1.TabIndex = 0;
            this.size_pen_1.UseVisualStyleBackColor = true;
            this.size_pen_1.Click += new System.EventHandler(this.size_pen_1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.back_polygons);
            this.panel4.Controls.Add(this._triangle);
            this.panel4.Controls.Add(this._retangle);
            this.panel4.Controls.Add(this._circle);
            this.panel4.Location = new System.Drawing.Point(1120, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 210);
            this.panel4.TabIndex = 5;
            this.panel4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(15, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // back_polygons
            // 
            this.back_polygons.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_polygons.BackgroundImage")));
            this.back_polygons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_polygons.Location = new System.Drawing.Point(15, 170);
            this.back_polygons.Name = "back_polygons";
            this.back_polygons.Size = new System.Drawing.Size(30, 30);
            this.back_polygons.TabIndex = 3;
            this.back_polygons.UseVisualStyleBackColor = true;
            this.back_polygons.Click += new System.EventHandler(this.button1_Click);
            // 
            // _triangle
            // 
            this._triangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_triangle.BackgroundImage")));
            this._triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._triangle.Location = new System.Drawing.Point(15, 130);
            this._triangle.Name = "_triangle";
            this._triangle.Size = new System.Drawing.Size(30, 30);
            this._triangle.TabIndex = 2;
            this._triangle.UseVisualStyleBackColor = true;
            this._triangle.Click += new System.EventHandler(this._polygons_Click);
            // 
            // _retangle
            // 
            this._retangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_retangle.BackgroundImage")));
            this._retangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._retangle.Location = new System.Drawing.Point(15, 90);
            this._retangle.Name = "_retangle";
            this._retangle.Size = new System.Drawing.Size(30, 30);
            this._retangle.TabIndex = 1;
            this._retangle.UseVisualStyleBackColor = true;
            this._retangle.Click += new System.EventHandler(this._retangle_Click);
            // 
            // _circle
            // 
            this._circle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_circle.BackgroundImage")));
            this._circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._circle.Location = new System.Drawing.Point(15, 50);
            this._circle.Name = "_circle";
            this._circle.Size = new System.Drawing.Size(30, 30);
            this._circle.TabIndex = 0;
            this._circle.UseVisualStyleBackColor = true;
            this._circle.Click += new System.EventHandler(this._circle_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.back_eraser);
            this.panel3.Controls.Add(this.size_eraser_3);
            this.panel3.Controls.Add(this.size_eraser_2);
            this.panel3.Controls.Add(this.size_eraser_1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 210);
            this.panel3.TabIndex = 1;
            this.panel3.Visible = false;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(15, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // back_eraser
            // 
            this.back_eraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_eraser.BackgroundImage")));
            this.back_eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_eraser.Location = new System.Drawing.Point(15, 170);
            this.back_eraser.Name = "back_eraser";
            this.back_eraser.Size = new System.Drawing.Size(30, 30);
            this.back_eraser.TabIndex = 3;
            this.back_eraser.UseVisualStyleBackColor = true;
            this.back_eraser.Click += new System.EventHandler(this.back_eraser_Click);
            // 
            // size_eraser_3
            // 
            this.size_eraser_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("size_eraser_3.BackgroundImage")));
            this.size_eraser_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.size_eraser_3.Location = new System.Drawing.Point(15, 130);
            this.size_eraser_3.Name = "size_eraser_3";
            this.size_eraser_3.Size = new System.Drawing.Size(30, 30);
            this.size_eraser_3.TabIndex = 2;
            this.size_eraser_3.UseVisualStyleBackColor = true;
            this.size_eraser_3.Click += new System.EventHandler(this.size_eraser_3_Click);
            // 
            // size_eraser_2
            // 
            this.size_eraser_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("size_eraser_2.BackgroundImage")));
            this.size_eraser_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.size_eraser_2.Location = new System.Drawing.Point(15, 90);
            this.size_eraser_2.Name = "size_eraser_2";
            this.size_eraser_2.Size = new System.Drawing.Size(30, 30);
            this.size_eraser_2.TabIndex = 1;
            this.size_eraser_2.UseVisualStyleBackColor = true;
            this.size_eraser_2.Click += new System.EventHandler(this.size_eraser_2_Click);
            // 
            // size_eraser_1
            // 
            this.size_eraser_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("size_eraser_1.BackgroundImage")));
            this.size_eraser_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.size_eraser_1.Location = new System.Drawing.Point(15, 50);
            this.size_eraser_1.Name = "size_eraser_1";
            this.size_eraser_1.Size = new System.Drawing.Size(30, 30);
            this.size_eraser_1.TabIndex = 0;
            this.size_eraser_1.UseVisualStyleBackColor = true;
            this.size_eraser_1.Click += new System.EventHandler(this.size_eraser_1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this._text);
            this.panel2.Controls.Add(this._Color);
            this.panel2.Controls.Add(this.Polygons);
            this.panel2.Controls.Add(this.Eraser);
            this.panel2.Controls.Add(this.Pen);
            this.panel2.Location = new System.Drawing.Point(1120, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 210);
            this.panel2.TabIndex = 7;
            // 
            // _text
            // 
            this._text.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_text.BackgroundImage")));
            this._text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._text.Location = new System.Drawing.Point(15, 170);
            this._text.Name = "_text";
            this._text.Size = new System.Drawing.Size(30, 30);
            this._text.TabIndex = 4;
            this._text.UseVisualStyleBackColor = true;
            // 
            // _Color
            // 
            this._Color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_Color.BackgroundImage")));
            this._Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._Color.Location = new System.Drawing.Point(15, 130);
            this._Color.Name = "_Color";
            this._Color.Size = new System.Drawing.Size(30, 30);
            this._Color.TabIndex = 3;
            this._Color.UseVisualStyleBackColor = true;
            this._Color.Click += new System.EventHandler(this._Color_Click);
            // 
            // Polygons
            // 
            this.Polygons.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Polygons.BackgroundImage")));
            this.Polygons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Polygons.Location = new System.Drawing.Point(15, 90);
            this.Polygons.Name = "Polygons";
            this.Polygons.Size = new System.Drawing.Size(30, 30);
            this.Polygons.TabIndex = 2;
            this.Polygons.UseVisualStyleBackColor = true;
            this.Polygons.Click += new System.EventHandler(this.Polygons_Click);
            // 
            // Eraser
            // 
            this.Eraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eraser.BackgroundImage")));
            this.Eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eraser.Cursor = System.Windows.Forms.Cursors.Default;
            this.Eraser.Location = new System.Drawing.Point(15, 50);
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(30, 30);
            this.Eraser.TabIndex = 1;
            this.Eraser.UseVisualStyleBackColor = true;
            this.Eraser.Click += new System.EventHandler(this.Eraser_Click);
            // 
            // Pen
            // 
            this.Pen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pen.BackgroundImage")));
            this.Pen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pen.Location = new System.Drawing.Point(15, 10);
            this.Pen.Name = "Pen";
            this.Pen.Size = new System.Drawing.Size(30, 30);
            this.Pen.TabIndex = 0;
            this.Pen.UseVisualStyleBackColor = true;
            this.Pen.Click += new System.EventHandler(this.Pen_Click);
            // 
            // _chat
            // 
            this._chat.Location = new System.Drawing.Point(1105, 39);
            this._chat.Name = "_chat";
            this._chat.Size = new System.Drawing.Size(75, 23);
            this._chat.TabIndex = 8;
            this._chat.Text = "Chat";
            this._chat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this._chat);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backpage);
            this.Controls.Add(this.nextpage);
            this.Controls.Add(this.Redo);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this._backgroundchat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asViewerToolStripMenuItem;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Redo;
        private System.Windows.Forms.Button nextpage;
        private System.Windows.Forms.Button backpage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Pen;
        private System.Windows.Forms.Button _text;
        private System.Windows.Forms.Button _Color;
        private System.Windows.Forms.Button Polygons;
        private System.Windows.Forms.Button Eraser;
        private Panel panel3;
        private Button back_eraser;
        private Button size_eraser_3;
        private Button size_eraser_2;
        private Button size_eraser_1;
        private PictureBox pictureBox2;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Button back_polygons;
        private Button _triangle;
        private Button _retangle;
        private Button _circle;
        private Panel panel5;
        private PictureBox pictureBox4;
        private Button back_pen;
        private Button size_pen_3;
        private Button size_pen_2;
        private Button size_pen_1;
        private Panel panel6;
        private PictureBox pictureBox5;
        private Button back_color;
        private Button color_yellow;
        private Button color_blue;
        private Button color_red;
        private Panel _backgroundchat;
        private Button _send;
        private RichTextBox _sendbox;
        private ListView _boxchat;
        private Button _chat;
    }
}

