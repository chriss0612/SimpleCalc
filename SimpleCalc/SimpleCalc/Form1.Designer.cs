namespace SimpelCalc
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rad = new System.Windows.Forms.ToolStripMenuItem();
            this.deg = new System.Windows.Forms.ToolStripMenuItem();
            this.grad = new System.Windows.Forms.ToolStripMenuItem();
            this.to0sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyTo0 = new System.Windows.Forms.ToolStripMenuItem();
            this.convertErrorTo0 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.output = new System.Windows.Forms.TextBox();
            this.decpoints = new System.Windows.Forms.TrackBar();
            this.label0 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.labelDecPoints = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
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
            this.to0sToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(332, 28);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip2";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rad,
            this.deg,
            this.grad});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // rad
            // 
            this.rad.Checked = true;
            this.rad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rad.Name = "rad";
            this.rad.Size = new System.Drawing.Size(181, 26);
            this.rad.Text = "Rad";
            this.rad.Click += new System.EventHandler(this.rad_Click);
            // 
            // deg
            // 
            this.deg.Name = "deg";
            this.deg.Size = new System.Drawing.Size(181, 26);
            this.deg.Text = "Deg";
            this.deg.Click += new System.EventHandler(this.deg_Click);
            // 
            // grad
            // 
            this.grad.Name = "grad";
            this.grad.Size = new System.Drawing.Size(181, 26);
            this.grad.Text = "Grad";
            this.grad.Click += new System.EventHandler(this.grad_Click);
            // 
            // to0sToolStripMenuItem
            // 
            this.to0sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emptyTo0,
            this.convertErrorTo0});
            this.to0sToolStripMenuItem.Name = "to0sToolStripMenuItem";
            this.to0sToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.to0sToolStripMenuItem.Text = "To0\'s";
            // 
            // emptyTo0
            // 
            this.emptyTo0.Name = "emptyTo0";
            this.emptyTo0.Size = new System.Drawing.Size(201, 26);
            this.emptyTo0.Text = "Empty to 0";
            this.emptyTo0.Click += new System.EventHandler(this.emptyTo0_Click);
            // 
            // convertErrorTo0
            // 
            this.convertErrorTo0.Name = "convertErrorTo0";
            this.convertErrorTo0.Size = new System.Drawing.Size(201, 26);
            this.convertErrorTo0.Text = "Convert error to 0";
            this.convertErrorTo0.Click += new System.EventHandler(this.convertErrorTo0_Click);
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 3;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayoutPanel.Controls.Add(this.output, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.decpoints, 0, 3);
            this.mainLayoutPanel.Controls.Add(this.label0, 0, 2);
            this.mainLayoutPanel.Controls.Add(this.label28, 2, 2);
            this.mainLayoutPanel.Controls.Add(this.labelDecPoints, 1, 2);
            this.mainLayoutPanel.Controls.Add(this.input, 0, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 28);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 4;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(332, 125);
            this.mainLayoutPanel.TabIndex = 8;
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLayoutPanel.SetColumnSpan(this.output, 3);
            this.output.Location = new System.Drawing.Point(3, 37);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(326, 22);
            this.output.TabIndex = 32;
            // 
            // decpoints
            // 
            this.mainLayoutPanel.SetColumnSpan(this.decpoints, 3);
            this.decpoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decpoints.LargeChange = 1;
            this.decpoints.Location = new System.Drawing.Point(3, 87);
            this.decpoints.Maximum = 28;
            this.decpoints.Name = "decpoints";
            this.decpoints.Size = new System.Drawing.Size(326, 35);
            this.decpoints.TabIndex = 28;
            this.decpoints.Value = 2;
            this.decpoints.Scroll += new System.EventHandler(this.decpoints_Scroll);
            // 
            // label0
            // 
            this.label0.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(3, 65);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(16, 17);
            this.label0.TabIndex = 29;
            this.label0.Text = "0";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(305, 65);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(24, 17);
            this.label28.TabIndex = 30;
            this.label28.Text = "28";
            // 
            // labelDecPoints
            // 
            this.labelDecPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDecPoints.AutoSize = true;
            this.labelDecPoints.Location = new System.Drawing.Point(109, 65);
            this.labelDecPoints.Name = "labelDecPoints";
            this.labelDecPoints.Size = new System.Drawing.Size(114, 17);
            this.labelDecPoints.TabIndex = 31;
            this.labelDecPoints.Text = "decimal points: 2";
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLayoutPanel.SetColumnSpan(this.input, 3);
            this.input.Location = new System.Drawing.Point(3, 5);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(326, 22);
            this.input.TabIndex = 1;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 153);
            this.Controls.Add(this.mainLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Form1";
            this.Text = "Simple Calc";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

