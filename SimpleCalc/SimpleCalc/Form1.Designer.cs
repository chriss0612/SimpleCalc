namespace SimpelCalc
{
    partial class Font
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rad = new System.Windows.Forms.ToolStripMenuItem();
            this.deg = new System.Windows.Forms.ToolStripMenuItem();
            this.grad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.northToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sCIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.to0sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyTo0 = new System.Windows.Forms.ToolStripMenuItem();
            this.convertErrorTo0 = new System.Windows.Forms.ToolStripMenuItem();
            this.logBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.strD = new System.Windows.Forms.Button();
            this.textD = new System.Windows.Forms.TextBox();
            this.strC = new System.Windows.Forms.Button();
            this.textC = new System.Windows.Forms.TextBox();
            this.strB = new System.Windows.Forms.Button();
            this.textB = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.decpoints = new System.Windows.Forms.TrackBar();
            this.label0 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.labelDecPoints = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.strA = new System.Windows.Forms.Button();
            this.textA = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.mainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decpoints)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.to0sToolStripMenuItem,
            this.logBaseToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(249, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip2";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rad,
            this.deg,
            this.grad,
            this.toolStripSeparator1,
            this.northToolStripMenuItem,
            this.sCIToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // rad
            // 
            this.rad.Checked = true;
            this.rad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rad.Name = "rad";
            this.rad.Size = new System.Drawing.Size(114, 22);
            this.rad.Text = "Rad";
            this.rad.Click += new System.EventHandler(this.rad_Click);
            // 
            // deg
            // 
            this.deg.Name = "deg";
            this.deg.Size = new System.Drawing.Size(114, 22);
            this.deg.Text = "Deg";
            this.deg.Click += new System.EventHandler(this.deg_Click);
            // 
            // grad
            // 
            this.grad.Name = "grad";
            this.grad.Size = new System.Drawing.Size(114, 22);
            this.grad.Text = "Grad";
            this.grad.Click += new System.EventHandler(this.grad_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // northToolStripMenuItem
            // 
            this.northToolStripMenuItem.Checked = true;
            this.northToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.northToolStripMenuItem.Name = "northToolStripMenuItem";
            this.northToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.northToolStripMenuItem.Text = "Normal";
            this.northToolStripMenuItem.Click += new System.EventHandler(this.northToolStripMenuItem_Click);
            // 
            // sCIToolStripMenuItem
            // 
            this.sCIToolStripMenuItem.Name = "sCIToolStripMenuItem";
            this.sCIToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.sCIToolStripMenuItem.Text = "SCI";
            this.sCIToolStripMenuItem.Click += new System.EventHandler(this.sCIToolStripMenuItem_Click);
            // 
            // to0sToolStripMenuItem
            // 
            this.to0sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emptyTo0,
            this.convertErrorTo0});
            this.to0sToolStripMenuItem.Name = "to0sToolStripMenuItem";
            this.to0sToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.to0sToolStripMenuItem.Text = "To0\'s";
            // 
            // emptyTo0
            // 
            this.emptyTo0.Name = "emptyTo0";
            this.emptyTo0.Size = new System.Drawing.Size(167, 22);
            this.emptyTo0.Text = "Empty to 0";
            this.emptyTo0.Click += new System.EventHandler(this.emptyTo0_Click);
            // 
            // convertErrorTo0
            // 
            this.convertErrorTo0.Name = "convertErrorTo0";
            this.convertErrorTo0.Size = new System.Drawing.Size(167, 22);
            this.convertErrorTo0.Text = "Convert error to 0";
            this.convertErrorTo0.Click += new System.EventHandler(this.convertErrorTo0_Click);
            // 
            // logBaseToolStripMenuItem
            // 
            this.logBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eToolStripMenuItem,
            this.toolStripComboBox1});
            this.logBaseToolStripMenuItem.Name = "logBaseToolStripMenuItem";
            this.logBaseToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.logBaseToolStripMenuItem.Text = "LogBase";
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Checked = true;
            this.eToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.eToolStripMenuItem.Text = "e";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 3;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayoutPanel.Controls.Add(this.strD, 0, 7);
            this.mainLayoutPanel.Controls.Add(this.textD, 0, 7);
            this.mainLayoutPanel.Controls.Add(this.strC, 0, 6);
            this.mainLayoutPanel.Controls.Add(this.textC, 0, 6);
            this.mainLayoutPanel.Controls.Add(this.strB, 0, 5);
            this.mainLayoutPanel.Controls.Add(this.textB, 0, 5);
            this.mainLayoutPanel.Controls.Add(this.output, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.decpoints, 0, 3);
            this.mainLayoutPanel.Controls.Add(this.label0, 0, 2);
            this.mainLayoutPanel.Controls.Add(this.label28, 2, 2);
            this.mainLayoutPanel.Controls.Add(this.labelDecPoints, 1, 2);
            this.mainLayoutPanel.Controls.Add(this.input, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.strA, 0, 4);
            this.mainLayoutPanel.Controls.Add(this.textA, 1, 4);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 8;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(249, 222);
            this.mainLayoutPanel.TabIndex = 8;
            // 
            // strD
            // 
            this.strD.Location = new System.Drawing.Point(3, 195);
            this.strD.Name = "strD";
            this.strD.Size = new System.Drawing.Size(44, 23);
            this.strD.TabIndex = 39;
            this.strD.Text = "D";
            this.strD.UseVisualStyleBackColor = true;
            this.strD.Click += new System.EventHandler(this.strD_Click);
            // 
            // textD
            // 
            this.textD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLayoutPanel.SetColumnSpan(this.textD, 2);
            this.textD.Location = new System.Drawing.Point(52, 197);
            this.textD.Margin = new System.Windows.Forms.Padding(2);
            this.textD.Name = "textD";
            this.textD.ReadOnly = true;
            this.textD.Size = new System.Drawing.Size(195, 20);
            this.textD.TabIndex = 40;
            // 
            // strC
            // 
            this.strC.Location = new System.Drawing.Point(3, 165);
            this.strC.Name = "strC";
            this.strC.Size = new System.Drawing.Size(44, 23);
            this.strC.TabIndex = 37;
            this.strC.Text = "C";
            this.strC.UseVisualStyleBackColor = true;
            this.strC.Click += new System.EventHandler(this.strC_Click);
            // 
            // textC
            // 
            this.textC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLayoutPanel.SetColumnSpan(this.textC, 2);
            this.textC.Location = new System.Drawing.Point(52, 167);
            this.textC.Margin = new System.Windows.Forms.Padding(2);
            this.textC.Name = "textC";
            this.textC.ReadOnly = true;
            this.textC.Size = new System.Drawing.Size(195, 20);
            this.textC.TabIndex = 38;
            // 
            // strB
            // 
            this.strB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.strB.Location = new System.Drawing.Point(3, 135);
            this.strB.Name = "strB";
            this.strB.Size = new System.Drawing.Size(44, 24);
            this.strB.TabIndex = 35;
            this.strB.Text = "B";
            this.strB.UseVisualStyleBackColor = true;
            this.strB.Click += new System.EventHandler(this.strB_Click);
            // 
            // textB
            // 
            this.textB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLayoutPanel.SetColumnSpan(this.textB, 2);
            this.textB.Location = new System.Drawing.Point(52, 137);
            this.textB.Margin = new System.Windows.Forms.Padding(2);
            this.textB.Name = "textB";
            this.textB.ReadOnly = true;
            this.textB.Size = new System.Drawing.Size(195, 20);
            this.textB.TabIndex = 36;
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLayoutPanel.SetColumnSpan(this.output, 3);
            this.output.Location = new System.Drawing.Point(2, 30);
            this.output.Margin = new System.Windows.Forms.Padding(2);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(245, 20);
            this.output.TabIndex = 32;
            // 
            // decpoints
            // 
            this.mainLayoutPanel.SetColumnSpan(this.decpoints, 3);
            this.decpoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decpoints.LargeChange = 4;
            this.decpoints.Location = new System.Drawing.Point(2, 72);
            this.decpoints.Margin = new System.Windows.Forms.Padding(2);
            this.decpoints.Maximum = 28;
            this.decpoints.Minimum = 1;
            this.decpoints.Name = "decpoints";
            this.decpoints.Size = new System.Drawing.Size(245, 28);
            this.decpoints.TabIndex = 28;
            this.decpoints.Value = 3;
            this.decpoints.Scroll += new System.EventHandler(this.decpoints_Scroll);
            // 
            // label0
            // 
            this.label0.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(2, 55);
            this.label0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(13, 13);
            this.label0.TabIndex = 29;
            this.label0.Text = "1";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(228, 55);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(19, 13);
            this.label28.TabIndex = 30;
            this.label28.Text = "28";
            // 
            // labelDecPoints
            // 
            this.labelDecPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDecPoints.AutoSize = true;
            this.labelDecPoints.Location = new System.Drawing.Point(73, 55);
            this.labelDecPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDecPoints.Name = "labelDecPoints";
            this.labelDecPoints.Size = new System.Drawing.Size(103, 13);
            this.labelDecPoints.TabIndex = 31;
            this.labelDecPoints.Text = "Significant Places: 2";
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLayoutPanel.SetColumnSpan(this.input, 3);
            this.input.Location = new System.Drawing.Point(2, 3);
            this.input.Margin = new System.Windows.Forms.Padding(2);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(245, 20);
            this.input.TabIndex = 1;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // strA
            // 
            this.strA.Location = new System.Drawing.Point(3, 105);
            this.strA.Name = "strA";
            this.strA.Size = new System.Drawing.Size(44, 23);
            this.strA.TabIndex = 33;
            this.strA.Text = "A";
            this.strA.UseVisualStyleBackColor = true;
            this.strA.Click += new System.EventHandler(this.strA_Click);
            // 
            // textA
            // 
            this.textA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLayoutPanel.SetColumnSpan(this.textA, 2);
            this.textA.Location = new System.Drawing.Point(52, 107);
            this.textA.Margin = new System.Windows.Forms.Padding(2);
            this.textA.Name = "textA";
            this.textA.ReadOnly = true;
            this.textA.Size = new System.Drawing.Size(195, 20);
            this.textA.TabIndex = 34;
            // 
            // Font
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 246);
            this.Controls.Add(this.mainLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(754, 414);
            this.MinimumSize = new System.Drawing.Size(229, 170);
            this.Name = "Font";
            this.Text = "Simple Calc";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decpoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rad;
        private System.Windows.Forms.ToolStripMenuItem deg;
        private System.Windows.Forms.ToolStripMenuItem grad;
        private System.Windows.Forms.ToolStripMenuItem to0sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyTo0;
        private System.Windows.Forms.ToolStripMenuItem convertErrorTo0;
        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TrackBar decpoints;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label labelDecPoints;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.ToolStripMenuItem logBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem northToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sCIToolStripMenuItem;
        private System.Windows.Forms.Button strA;
        private System.Windows.Forms.Button strD;
        private System.Windows.Forms.TextBox textD;
        private System.Windows.Forms.Button strC;
        private System.Windows.Forms.TextBox textC;
        private System.Windows.Forms.Button strB;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox textA;
    }
}

