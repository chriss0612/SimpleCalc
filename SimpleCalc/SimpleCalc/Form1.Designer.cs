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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rad = new System.Windows.Forms.ToolStripMenuItem();
            this.deg = new System.Windows.Forms.ToolStripMenuItem();
            this.grad = new System.Windows.Forms.ToolStripMenuItem();
            this.to0sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyTo0 = new System.Windows.Forms.ToolStripMenuItem();
            this.convertErrorTo0 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.output = new System.Windows.Forms.TextBox();
            this.decpoints = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decpoints)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.to0sToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(332, 28);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
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
            this.rad.Size = new System.Drawing.Size(116, 26);
            this.rad.Text = "Rad";
            this.rad.Click += new System.EventHandler(this.rad_Click);
            // 
            // deg
            // 
            this.deg.Name = "deg";
            this.deg.Size = new System.Drawing.Size(116, 26);
            this.deg.Text = "Deg";
            this.deg.Click += new System.EventHandler(this.deg_Click);
            // 
            // grad
            // 
            this.grad.Name = "grad";
            this.grad.Size = new System.Drawing.Size(116, 26);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.output, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.decpoints, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.input, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 125);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.output, 3);
            this.output.Location = new System.Drawing.Point(3, 37);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(326, 22);
            this.output.TabIndex = 32;
            // 
            // decpoints
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.decpoints, 3);
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "28";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "decimal points: 2";
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.input, 3);
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
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip2);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Form1";
            this.Text = "Simple Calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decpoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rad;
        private System.Windows.Forms.ToolStripMenuItem deg;
        private System.Windows.Forms.ToolStripMenuItem grad;
        private System.Windows.Forms.ToolStripMenuItem to0sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyTo0;
        private System.Windows.Forms.ToolStripMenuItem convertErrorTo0;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TrackBar decpoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input;
    }
}

