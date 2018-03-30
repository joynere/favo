﻿using System.Drawing;
using System.Windows.Forms;
namespace Favo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextEditorBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.codelines = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.neuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labeloperations = new System.Windows.Forms.Label();
            this.labelOp = new System.Windows.Forms.Label();
            this.labelaccumulator = new System.Windows.Forms.Label();
            this.labelAcc = new System.Windows.Forms.Label();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextEditorBox
            // 
            this.TextEditorBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Lukas",
            "Max",
            "Jan",
            "Leon",
            "Nico"});
            this.TextEditorBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextEditorBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextEditorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.TextEditorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextEditorBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.TextEditorBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TextEditorBox.ForeColor = System.Drawing.Color.White;
            this.TextEditorBox.Location = new System.Drawing.Point(86, 5);
            this.TextEditorBox.Multiline = true;
            this.TextEditorBox.Name = "TextEditorBox";
            this.TextEditorBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextEditorBox.Size = new System.Drawing.Size(477, 343);
            this.TextEditorBox.TabIndex = 0;
            this.TextEditorBox.TextChanged += new System.EventHandler(this.TextEditorBoxTextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(105, 76);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.codelines);
            this.splitContainer1.Panel1.Controls.Add(this.TextEditorBox);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(990, 353);
            this.splitContainer1.SplitterDistance = 568;
            this.splitContainer1.TabIndex = 5;
            // 
            // codelines
            // 
            this.codelines.BackColor = System.Drawing.Color.YellowGreen;
            this.codelines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codelines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codelines.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.codelines.Location = new System.Drawing.Point(5, 5);
            this.codelines.Margin = new System.Windows.Forms.Padding(5);
            this.codelines.Multiline = true;
            this.codelines.Name = "codelines";
            this.codelines.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.codelines.Size = new System.Drawing.Size(81, 343);
            this.codelines.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(86)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(86)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.dataGridView2.Location = new System.Drawing.Point(5, 5);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.ShowCellToolTips = false;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.Size = new System.Drawing.Size(408, 343);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(86)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 24);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Favo.Properties.Resources.FavoIcon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(86)))), ((int)(((byte)(51)))));
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(1199, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(24, 24);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(86)))), ((int)(((byte)(51)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 612);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 5);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 588);
            this.panel3.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem1,
            this.öffnenToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveasToolStripMenuItem,
            this.toolStripMenuItem1,
            this.runToolStripMenuItem,
            this.imodeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(38, 588);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // neuToolStripMenuItem1
            // 
            this.neuToolStripMenuItem1.AutoToolTip = true;
            this.neuToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.neuToolStripMenuItem1.Image = global::Favo.Properties.Resources.NewFile_16x;
            this.neuToolStripMenuItem1.Name = "neuToolStripMenuItem1";
            this.neuToolStripMenuItem1.Size = new System.Drawing.Size(29, 20);
            this.neuToolStripMenuItem1.ToolTipText = "New File";
            this.neuToolStripMenuItem1.Click += new System.EventHandler(this.NewToolStripMenuItem1_Click);
            // 
            // öffnenToolStripMenuItem1
            // 
            this.öffnenToolStripMenuItem1.AutoToolTip = true;
            this.öffnenToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.öffnenToolStripMenuItem1.Image = global::Favo.Properties.Resources.ASX_Open_blue_16x;
            this.öffnenToolStripMenuItem1.Name = "öffnenToolStripMenuItem1";
            this.öffnenToolStripMenuItem1.Size = new System.Drawing.Size(29, 20);
            this.öffnenToolStripMenuItem1.ToolTipText = "Open File";
            this.öffnenToolStripMenuItem1.Click += new System.EventHandler(this.ÖffnenToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.AutoToolTip = true;
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Image = global::Favo.Properties.Resources.Save_16x;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(29, 20);
            this.saveToolStripMenuItem.ToolTipText = "Save File";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveasToolStripMenuItem
            // 
            this.saveasToolStripMenuItem.AutoToolTip = true;
            this.saveasToolStripMenuItem.Image = global::Favo.Properties.Resources.SaveAs_16x;
            this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
            this.saveasToolStripMenuItem.Size = new System.Drawing.Size(29, 20);
            this.saveasToolStripMenuItem.ToolTipText = "Save File As";
            this.saveasToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(29, 19);
            this.toolStripMenuItem1.Text = "---";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.AutoToolTip = true;
            this.runToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("runToolStripMenuItem.Image")));
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.runToolStripMenuItem.Size = new System.Drawing.Size(29, 20);
            this.runToolStripMenuItem.ToolTipText = "Run (F5)";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.RunToolStripMenuItemClick);
            // 
            // imodeToolStripMenuItem
            // 
            this.imodeToolStripMenuItem.AutoToolTip = true;
            this.imodeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imodeToolStripMenuItem.Image")));
            this.imodeToolStripMenuItem.Name = "imodeToolStripMenuItem";
            this.imodeToolStripMenuItem.Size = new System.Drawing.Size(29, 20);
            this.imodeToolStripMenuItem.ToolTipText = "Switch if-Mode";
            this.imodeToolStripMenuItem.Click += new System.EventHandler(this.ImodeToolStripMenuItemClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labeloperations);
            this.panel4.Controls.Add(this.labelOp);
            this.panel4.Controls.Add(this.labelaccumulator);
            this.panel4.Controls.Add(this.labelAcc);
            this.panel4.Controls.Add(this.ErrorBox);
            this.panel4.Location = new System.Drawing.Point(105, 438);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(989, 124);
            this.panel4.TabIndex = 8;
            // 
            // labeloperations
            // 
            this.labeloperations.AutoSize = true;
            this.labeloperations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeloperations.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labeloperations.ForeColor = System.Drawing.Color.White;
            this.labeloperations.Location = new System.Drawing.Point(888, 73);
            this.labeloperations.Name = "labeloperations";
            this.labeloperations.Size = new System.Drawing.Size(45, 21);
            this.labeloperations.TabIndex = 6;
            this.labeloperations.Text = "NULL";
            // 
            // labelOp
            // 
            this.labelOp.AutoSize = true;
            this.labelOp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelOp.ForeColor = System.Drawing.Color.White;
            this.labelOp.Location = new System.Drawing.Point(793, 73);
            this.labelOp.Name = "labelOp";
            this.labelOp.Size = new System.Drawing.Size(80, 19);
            this.labelOp.TabIndex = 5;
            this.labelOp.Text = "Operations:";
            // 
            // labelaccumulator
            // 
            this.labelaccumulator.AutoSize = true;
            this.labelaccumulator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelaccumulator.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelaccumulator.ForeColor = System.Drawing.Color.White;
            this.labelaccumulator.Location = new System.Drawing.Point(888, 33);
            this.labelaccumulator.Name = "labelaccumulator";
            this.labelaccumulator.Size = new System.Drawing.Size(45, 21);
            this.labelaccumulator.TabIndex = 2;
            this.labelaccumulator.Text = "NULL";
            // 
            // labelAcc
            // 
            this.labelAcc.AutoSize = true;
            this.labelAcc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelAcc.ForeColor = System.Drawing.Color.White;
            this.labelAcc.Location = new System.Drawing.Point(793, 33);
            this.labelAcc.Name = "labelAcc";
            this.labelAcc.Size = new System.Drawing.Size(89, 19);
            this.labelAcc.TabIndex = 1;
            this.labelAcc.Text = "Accumulator:";
            // 
            // ErrorBox
            // 
            this.ErrorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ErrorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ErrorBox.Cursor = System.Windows.Forms.Cursors.No;
            this.ErrorBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ErrorBox.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.ErrorBox.ForeColor = System.Drawing.Color.White;
            this.ErrorBox.Location = new System.Drawing.Point(5, 5);
            this.ErrorBox.Multiline = true;
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.ReadOnly = true;
            this.ErrorBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ErrorBox.Size = new System.Drawing.Size(771, 114);
            this.ErrorBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1223, 617);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Favo";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.ToolStripMenuItem imodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem1;

        #endregion

        private System.Windows.Forms.TextBox TextEditorBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Panel panel1;
        private Panel panel2;
        public SplitContainer splitContainer1;
        private Panel panel3;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView2;
        private Panel panel4;
        private TextBox ErrorBox;
        private Label labelaccumulator;
        private Label labelAcc;
        private Label labeloperations;
        private Label labelOp;
        private TextBox codelines;
    }
}

