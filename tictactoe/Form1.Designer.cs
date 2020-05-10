namespace tictactoe
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.R1C2 = new System.Windows.Forms.Button();
            this.R1C1 = new System.Windows.Forms.Button();
            this.R1C3 = new System.Windows.Forms.Button();
            this.R2C2 = new System.Windows.Forms.Button();
            this.R2C3 = new System.Windows.Forms.Button();
            this.R2C1 = new System.Windows.Forms.Button();
            this.R3C1 = new System.Windows.Forms.Button();
            this.R3C2 = new System.Windows.Forms.Button();
            this.R3C3 = new System.Windows.Forms.Button();
            this.NewGameBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(233, 28);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutBtn,
            this.NewGameBtn,
            this.ExitButton});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuItem2.Text = "Help";
            // 
            // AboutBtn
            // 
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(224, 26);
            this.AboutBtn.Text = "About";
            this.AboutBtn.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(224, 26);
            this.ExitButton.Text = "Exit";
            this.ExitButton.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem6.Text = "About";
            // 
            // R1C2
            // 
            this.R1C2.Location = new System.Drawing.Point(90, 45);
            this.R1C2.Name = "R1C2";
            this.R1C2.Size = new System.Drawing.Size(59, 58);
            this.R1C2.TabIndex = 1;
            this.R1C2.UseVisualStyleBackColor = true;
            this.R1C2.Click += new System.EventHandler(this.button_click);
            // 
            // R1C1
            // 
            this.R1C1.Location = new System.Drawing.Point(25, 45);
            this.R1C1.Name = "R1C1";
            this.R1C1.Size = new System.Drawing.Size(59, 58);
            this.R1C1.TabIndex = 2;
            this.R1C1.UseVisualStyleBackColor = true;
            this.R1C1.Click += new System.EventHandler(this.button_click);
            // 
            // R1C3
            // 
            this.R1C3.Location = new System.Drawing.Point(155, 45);
            this.R1C3.Name = "R1C3";
            this.R1C3.Size = new System.Drawing.Size(59, 58);
            this.R1C3.TabIndex = 3;
            this.R1C3.UseVisualStyleBackColor = true;
            this.R1C3.Click += new System.EventHandler(this.button_click);
            // 
            // R2C2
            // 
            this.R2C2.Location = new System.Drawing.Point(90, 109);
            this.R2C2.Name = "R2C2";
            this.R2C2.Size = new System.Drawing.Size(59, 58);
            this.R2C2.TabIndex = 4;
            this.R2C2.UseVisualStyleBackColor = true;
            this.R2C2.Click += new System.EventHandler(this.button_click);
            // 
            // R2C3
            // 
            this.R2C3.Location = new System.Drawing.Point(155, 109);
            this.R2C3.Name = "R2C3";
            this.R2C3.Size = new System.Drawing.Size(59, 58);
            this.R2C3.TabIndex = 5;
            this.R2C3.UseVisualStyleBackColor = true;
            this.R2C3.Click += new System.EventHandler(this.button_click);
            // 
            // R2C1
            // 
            this.R2C1.Location = new System.Drawing.Point(25, 109);
            this.R2C1.Name = "R2C1";
            this.R2C1.Size = new System.Drawing.Size(59, 58);
            this.R2C1.TabIndex = 6;
            this.R2C1.UseVisualStyleBackColor = true;
            this.R2C1.Click += new System.EventHandler(this.button_click);
            // 
            // R3C1
            // 
            this.R3C1.Location = new System.Drawing.Point(25, 173);
            this.R3C1.Name = "R3C1";
            this.R3C1.Size = new System.Drawing.Size(59, 58);
            this.R3C1.TabIndex = 7;
            this.R3C1.UseVisualStyleBackColor = true;
            this.R3C1.Click += new System.EventHandler(this.button_click);
            // 
            // R3C2
            // 
            this.R3C2.Location = new System.Drawing.Point(90, 173);
            this.R3C2.Name = "R3C2";
            this.R3C2.Size = new System.Drawing.Size(59, 58);
            this.R3C2.TabIndex = 8;
            this.R3C2.UseVisualStyleBackColor = true;
            this.R3C2.Click += new System.EventHandler(this.button_click);
            // 
            // R3C3
            // 
            this.R3C3.Location = new System.Drawing.Point(155, 173);
            this.R3C3.Name = "R3C3";
            this.R3C3.Size = new System.Drawing.Size(59, 58);
            this.R3C3.TabIndex = 9;
            this.R3C3.UseVisualStyleBackColor = true;
            this.R3C3.Click += new System.EventHandler(this.button_click);
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(224, 26);
            this.NewGameBtn.Text = "New Game";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(233, 253);
            this.Controls.Add(this.R3C3);
            this.Controls.Add(this.R3C2);
            this.Controls.Add(this.R3C1);
            this.Controls.Add(this.R2C1);
            this.Controls.Add(this.R2C3);
            this.Controls.Add(this.R2C2);
            this.Controls.Add(this.R1C3);
            this.Controls.Add(this.R1C1);
            this.Controls.Add(this.R1C2);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip2;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AboutBtn;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Button R1C2;
        private System.Windows.Forms.Button R1C1;
        private System.Windows.Forms.Button R1C3;
        private System.Windows.Forms.Button R2C2;
        private System.Windows.Forms.Button R2C3;
        private System.Windows.Forms.Button R2C1;
        private System.Windows.Forms.Button R3C1;
        private System.Windows.Forms.Button R3C2;
        private System.Windows.Forms.Button R3C3;
        private System.Windows.Forms.ToolStripMenuItem NewGameBtn;
    }
}

