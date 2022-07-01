namespace ShutdownTimer
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
            this.components = new System.ComponentModel.Container();
            this.LabelMinutes = new System.Windows.Forms.Label();
            this.LabelSeconds = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.ContextMenuStripStartButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LabelHours = new System.Windows.Forms.Label();
            this.ToolStripMenuItemIncrement = new System.Windows.Forms.ToolStripMenuItem();
            this.AUDSeconds = new ShutdownTimer.AdvancedUpDown();
            this.AUDMinutes = new ShutdownTimer.AdvancedUpDown();
            this.AUDHours = new ShutdownTimer.AdvancedUpDown();
            this.ContextMenuStripStartButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AUDSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AUDMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AUDHours)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelMinutes
            // 
            this.LabelMinutes.AutoSize = true;
            this.LabelMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMinutes.Location = new System.Drawing.Point(92, 6);
            this.LabelMinutes.Margin = new System.Windows.Forms.Padding(0);
            this.LabelMinutes.Name = "LabelMinutes";
            this.LabelMinutes.Size = new System.Drawing.Size(76, 24);
            this.LabelMinutes.TabIndex = 2;
            this.LabelMinutes.Text = "Minutes";
            this.LabelMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelSeconds
            // 
            this.LabelSeconds.AutoSize = true;
            this.LabelSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSeconds.Location = new System.Drawing.Point(171, 6);
            this.LabelSeconds.Margin = new System.Windows.Forms.Padding(0);
            this.LabelSeconds.Name = "LabelSeconds";
            this.LabelSeconds.Size = new System.Drawing.Size(85, 24);
            this.LabelSeconds.TabIndex = 3;
            this.LabelSeconds.Text = "Seconds";
            this.LabelSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnStart
            // 
            this.BtnStart.ContextMenuStrip = this.ContextMenuStripStartButton;
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(9, 78);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(240, 36);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // ContextMenuStripStartButton
            // 
            this.ContextMenuStripStartButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemIncrement});
            this.ContextMenuStripStartButton.Name = "contextMenuStrip1";
            this.ContextMenuStripStartButton.Size = new System.Drawing.Size(181, 48);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LabelHours
            // 
            this.LabelHours.AutoSize = true;
            this.LabelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHours.Location = new System.Drawing.Point(14, 6);
            this.LabelHours.Margin = new System.Windows.Forms.Padding(0);
            this.LabelHours.Name = "LabelHours";
            this.LabelHours.Size = new System.Drawing.Size(61, 24);
            this.LabelHours.TabIndex = 6;
            this.LabelHours.Text = "Hours";
            this.LabelHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToolStripMenuItemIncrement
            // 
            this.ToolStripMenuItemIncrement.Checked = true;
            this.ToolStripMenuItemIncrement.CheckOnClick = true;
            this.ToolStripMenuItemIncrement.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItemIncrement.Name = "ToolStripMenuItemIncrement";
            this.ToolStripMenuItemIncrement.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemIncrement.Text = "15 Increment";
            this.ToolStripMenuItemIncrement.CheckedChanged += new System.EventHandler(this.ToolStripMenuItemIncrement_CheckedChanged);
            // 
            // AUDSeconds
            // 
            this.AUDSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AUDSeconds.Location = new System.Drawing.Point(178, 33);
            this.AUDSeconds.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.AUDSeconds.Name = "AUDSeconds";
            this.AUDSeconds.Size = new System.Drawing.Size(70, 35);
            this.AUDSeconds.TabIndex = 9;
            this.AUDSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AUDMinutes
            // 
            this.AUDMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AUDMinutes.Location = new System.Drawing.Point(94, 33);
            this.AUDMinutes.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.AUDMinutes.Name = "AUDMinutes";
            this.AUDMinutes.Size = new System.Drawing.Size(70, 35);
            this.AUDMinutes.TabIndex = 8;
            this.AUDMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AUDHours
            // 
            this.AUDHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AUDHours.Location = new System.Drawing.Point(10, 33);
            this.AUDHours.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.AUDHours.Name = "AUDHours";
            this.AUDHours.Size = new System.Drawing.Size(70, 35);
            this.AUDHours.TabIndex = 7;
            this.AUDHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 121);
            this.Controls.Add(this.AUDSeconds);
            this.Controls.Add(this.AUDMinutes);
            this.Controls.Add(this.AUDHours);
            this.Controls.Add(this.LabelHours);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LabelSeconds);
            this.Controls.Add(this.LabelMinutes);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(274, 160);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(274, 160);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ShutdownTimer";
            this.ContextMenuStripStartButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AUDSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AUDMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AUDHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelMinutes;
        private System.Windows.Forms.Label LabelSeconds;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LabelHours;
        private AdvancedUpDown AUDHours;
        private AdvancedUpDown AUDMinutes;
        private AdvancedUpDown AUDSeconds;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripStartButton;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemIncrement;
    }
}

