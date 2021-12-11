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
            this.NumMinutes = new System.Windows.Forms.NumericUpDown();
            this.NumSeconds = new System.Windows.Forms.NumericUpDown();
            this.LabelMinutes = new System.Windows.Forms.Label();
            this.LabelSeconds = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.NumHours = new System.Windows.Forms.NumericUpDown();
            this.LabelHours = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHours)).BeginInit();
            this.SuspendLayout();
            // 
            // NumMinutes
            // 
            this.NumMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumMinutes.Location = new System.Drawing.Point(108, 35);
            this.NumMinutes.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NumMinutes.Name = "NumMinutes";
            this.NumMinutes.Size = new System.Drawing.Size(86, 35);
            this.NumMinutes.TabIndex = 0;
            this.NumMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumSeconds
            // 
            this.NumSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumSeconds.Location = new System.Drawing.Point(208, 35);
            this.NumSeconds.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NumSeconds.Name = "NumSeconds";
            this.NumSeconds.Size = new System.Drawing.Size(86, 35);
            this.NumSeconds.TabIndex = 1;
            this.NumSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelMinutes
            // 
            this.LabelMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMinutes.Location = new System.Drawing.Point(108, 6);
            this.LabelMinutes.Margin = new System.Windows.Forms.Padding(0);
            this.LabelMinutes.Name = "LabelMinutes";
            this.LabelMinutes.Size = new System.Drawing.Size(86, 26);
            this.LabelMinutes.TabIndex = 2;
            this.LabelMinutes.Text = "Minutes";
            this.LabelMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelSeconds
            // 
            this.LabelSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSeconds.Location = new System.Drawing.Point(208, 6);
            this.LabelSeconds.Margin = new System.Windows.Forms.Padding(0);
            this.LabelSeconds.Name = "LabelSeconds";
            this.LabelSeconds.Size = new System.Drawing.Size(86, 26);
            this.LabelSeconds.TabIndex = 3;
            this.LabelSeconds.Text = "Seconds";
            this.LabelSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(9, 78);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(286, 36);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // NumHours
            // 
            this.NumHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumHours.Location = new System.Drawing.Point(10, 35);
            this.NumHours.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NumHours.Name = "NumHours";
            this.NumHours.Size = new System.Drawing.Size(86, 35);
            this.NumHours.TabIndex = 5;
            this.NumHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelHours
            // 
            this.LabelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHours.Location = new System.Drawing.Point(10, 6);
            this.LabelHours.Margin = new System.Windows.Forms.Padding(0);
            this.LabelHours.Name = "LabelHours";
            this.LabelHours.Size = new System.Drawing.Size(86, 26);
            this.LabelHours.TabIndex = 6;
            this.LabelHours.Text = "Hours";
            this.LabelHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 121);
            this.Controls.Add(this.LabelHours);
            this.Controls.Add(this.NumHours);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LabelSeconds);
            this.Controls.Add(this.LabelMinutes);
            this.Controls.Add(this.NumSeconds);
            this.Controls.Add(this.NumMinutes);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 160);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 160);
            this.Name = "Form1";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.NumMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumMinutes;
        private System.Windows.Forms.NumericUpDown NumSeconds;
        private System.Windows.Forms.Label LabelMinutes;
        private System.Windows.Forms.Label LabelSeconds;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.NumericUpDown NumHours;
        private System.Windows.Forms.Label LabelHours;
    }
}

