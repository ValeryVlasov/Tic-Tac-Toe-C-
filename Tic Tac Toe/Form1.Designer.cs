namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button4 = new Button();
            button7 = new Button();
            button10 = new Button();
            button8 = new Button();
            button5 = new Button();
            button2 = new Button();
            button9 = new Button();
            button6 = new Button();
            button3 = new Button();
            CPUTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 0;
            label1.Text = "Player Wins: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(350, 9);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 1;
            label2.Text = "CPU Wins: ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(68, 53);
            button1.Name = "button1";
            button1.Size = new Size(120, 120);
            button1.TabIndex = 2;
            button1.Text = "GGGG";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PlayerClickButton;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Lime;
            button4.Location = new Point(68, 179);
            button4.Name = "button4";
            button4.Size = new Size(120, 120);
            button4.TabIndex = 5;
            button4.Text = "GGGG";
            button4.UseVisualStyleBackColor = true;
            button4.Click += PlayerClickButton;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.Lime;
            button7.Location = new Point(68, 305);
            button7.Name = "button7";
            button7.Size = new Size(120, 120);
            button7.TabIndex = 8;
            button7.Text = "GGGG";
            button7.UseVisualStyleBackColor = true;
            button7.Click += PlayerClickButton;
            // 
            // button10
            // 
            button10.Location = new Point(182, 438);
            button10.Name = "button10";
            button10.Size = new Size(143, 31);
            button10.TabIndex = 11;
            button10.Text = "Restart Game";
            button10.UseVisualStyleBackColor = true;
            button10.Click += RestartGame;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.Lime;
            button8.Location = new Point(194, 305);
            button8.Name = "button8";
            button8.Size = new Size(120, 120);
            button8.TabIndex = 14;
            button8.Text = "GGGG";
            button8.UseVisualStyleBackColor = true;
            button8.Click += PlayerClickButton;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Lime;
            button5.Location = new Point(194, 179);
            button5.Name = "button5";
            button5.Size = new Size(120, 120);
            button5.TabIndex = 13;
            button5.Text = "GGGG";
            button5.UseVisualStyleBackColor = true;
            button5.Click += PlayerClickButton;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Lime;
            button2.Location = new Point(194, 53);
            button2.Name = "button2";
            button2.Size = new Size(120, 120);
            button2.TabIndex = 12;
            button2.Text = "GGGG";
            button2.UseVisualStyleBackColor = true;
            button2.Click += PlayerClickButton;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.Lime;
            button9.Location = new Point(320, 305);
            button9.Name = "button9";
            button9.Size = new Size(120, 120);
            button9.TabIndex = 17;
            button9.Text = "GGGG";
            button9.UseVisualStyleBackColor = true;
            button9.Click += PlayerClickButton;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Lime;
            button6.Location = new Point(320, 179);
            button6.Name = "button6";
            button6.Size = new Size(120, 120);
            button6.TabIndex = 16;
            button6.Text = "GGGG";
            button6.UseVisualStyleBackColor = true;
            button6.Click += PlayerClickButton;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Lime;
            button3.Location = new Point(320, 53);
            button3.Name = "button3";
            button3.Size = new Size(120, 120);
            button3.TabIndex = 15;
            button3.Text = "GGGG";
            button3.UseVisualStyleBackColor = true;
            button3.Click += PlayerClickButton;
            // 
            // CPUTimer
            // 
            CPUTimer.Interval = 1000;
            CPUTimer.Tick += CPUMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 481);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tic Tac Toe Win Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button4;
        private Button button7;
        private Button button10;
        private Button button8;
        private Button button5;
        private Button button2;
        private Button button9;
        private Button button6;
        private Button button3;
        private System.Windows.Forms.Timer CPUTimer;
    }
}