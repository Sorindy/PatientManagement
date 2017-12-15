namespace ProgressLingkar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar3 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar5 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar4 = new CircularProgressBar.CircularProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBar1.AnimationFunction")));
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.White;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(279, 233);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Purple;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.MediumOrchid;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.Size = new System.Drawing.Size(168, 167);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.White;
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "__";
            this.circularProgressBar1.TabIndex = 0;
            this.circularProgressBar1.Text = "10";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBar2.AnimationFunction")));
            this.circularProgressBar2.AnimationSpeed = 500;
            this.circularProgressBar2.BackColor = System.Drawing.Color.White;
            this.circularProgressBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar2.ForeColor = System.Drawing.Color.LawnGreen;
            this.circularProgressBar2.InnerColor = System.Drawing.Color.White;
            this.circularProgressBar2.InnerMargin = 2;
            this.circularProgressBar2.InnerWidth = -1;
            this.circularProgressBar2.Location = new System.Drawing.Point(12, 100);
            this.circularProgressBar2.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.Color.MidnightBlue;
            this.circularProgressBar2.OuterMargin = -25;
            this.circularProgressBar2.OuterWidth = 26;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.Chartreuse;
            this.circularProgressBar2.ProgressWidth = 25;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar2.Size = new System.Drawing.Size(230, 232);
            this.circularProgressBar2.StartAngle = 270;
            this.circularProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar2.SubscriptText = "";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.Lime;
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar2.SuperscriptText = "%";
            this.circularProgressBar2.TabIndex = 2;
            this.circularProgressBar2.Text = "26";
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar2.Value = 68;
            // 
            // circularProgressBar3
            // 
            this.circularProgressBar3.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBar3.AnimationFunction")));
            this.circularProgressBar3.AnimationSpeed = 500;
            this.circularProgressBar3.BackColor = System.Drawing.Color.White;
            this.circularProgressBar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar3.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar3.InnerMargin = 2;
            this.circularProgressBar3.InnerWidth = -1;
            this.circularProgressBar3.Location = new System.Drawing.Point(279, 32);
            this.circularProgressBar3.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar3.Name = "circularProgressBar3";
            this.circularProgressBar3.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar3.OuterMargin = -25;
            this.circularProgressBar3.OuterWidth = 26;
            this.circularProgressBar3.ProgressColor = System.Drawing.Color.Yellow;
            this.circularProgressBar3.ProgressWidth = 25;
            this.circularProgressBar3.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar3.Size = new System.Drawing.Size(168, 167);
            this.circularProgressBar3.StartAngle = 270;
            this.circularProgressBar3.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar3.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar3.SubscriptText = ".23";
            this.circularProgressBar3.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar3.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar3.SuperscriptText = "°C";
            this.circularProgressBar3.TabIndex = 3;
            this.circularProgressBar3.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar3.Value = 30;
            // 
            // circularProgressBar5
            // 
            this.circularProgressBar5.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBar5.AnimationFunction")));
            this.circularProgressBar5.AnimationSpeed = 500;
            this.circularProgressBar5.BackColor = System.Drawing.Color.White;
            this.circularProgressBar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar5.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar5.InnerMargin = 2;
            this.circularProgressBar5.InnerWidth = -1;
            this.circularProgressBar5.Location = new System.Drawing.Point(457, 233);
            this.circularProgressBar5.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar5.Name = "circularProgressBar5";
            this.circularProgressBar5.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.circularProgressBar5.OuterMargin = -25;
            this.circularProgressBar5.OuterWidth = 26;
            this.circularProgressBar5.ProgressColor = System.Drawing.Color.LightBlue;
            this.circularProgressBar5.ProgressWidth = 25;
            this.circularProgressBar5.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar5.Size = new System.Drawing.Size(168, 167);
            this.circularProgressBar5.StartAngle = 270;
            this.circularProgressBar5.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar5.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar5.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar5.SubscriptText = ".23";
            this.circularProgressBar5.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar5.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar5.SuperscriptText = "°C";
            this.circularProgressBar5.TabIndex = 5;
            this.circularProgressBar5.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar5.Value = 25;
            // 
            // circularProgressBar4
            // 
            this.circularProgressBar4.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBar4.AnimationFunction")));
            this.circularProgressBar4.AnimationSpeed = 500;
            this.circularProgressBar4.BackColor = System.Drawing.Color.White;
            this.circularProgressBar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar4.InnerColor = System.Drawing.Color.White;
            this.circularProgressBar4.InnerMargin = 2;
            this.circularProgressBar4.InnerWidth = -1;
            this.circularProgressBar4.Location = new System.Drawing.Point(457, 32);
            this.circularProgressBar4.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar4.Name = "circularProgressBar4";
            this.circularProgressBar4.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar4.OuterMargin = -25;
            this.circularProgressBar4.OuterWidth = 26;
            this.circularProgressBar4.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar4.ProgressWidth = 25;
            this.circularProgressBar4.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar4.Size = new System.Drawing.Size(168, 167);
            this.circularProgressBar4.StartAngle = 270;
            this.circularProgressBar4.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar4.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar4.SubscriptText = "°C";
            this.circularProgressBar4.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar4.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar4.SuperscriptText = "";
            this.circularProgressBar4.TabIndex = 6;
            this.circularProgressBar4.Text = "10";
            this.circularProgressBar4.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar4.Value = 15;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 446);
            this.Controls.Add(this.circularProgressBar4);
            this.Controls.Add(this.circularProgressBar5);
            this.Controls.Add(this.circularProgressBar3);
            this.Controls.Add(this.circularProgressBar2);
            this.Controls.Add(this.circularProgressBar1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private CircularProgressBar.CircularProgressBar circularProgressBar3;
        private CircularProgressBar.CircularProgressBar circularProgressBar5;
        private CircularProgressBar.CircularProgressBar circularProgressBar4;
        private System.Windows.Forms.Timer timer2;

    }
}

