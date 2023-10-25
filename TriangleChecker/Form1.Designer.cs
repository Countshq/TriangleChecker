namespace TriangleChecker
{
    partial class Checker
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
            button1 = new Button();
            SideA = new TextBox();
            SideB = new TextBox();
            SideC = new TextBox();
            result = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(183, 211);
            button1.Name = "button1";
            button1.Size = new Size(133, 44);
            button1.TabIndex = 0;
            button1.Text = "Проверка";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SideA
            // 
            SideA.BackColor = Color.FromArgb(255, 192, 128);
            SideA.Location = new Point(41, 75);
            SideA.Name = "SideA";
            SideA.Size = new Size(133, 23);
            SideA.TabIndex = 1;
            SideA.TextAlign = HorizontalAlignment.Center;
            // 
            // SideB
            // 
            SideB.BackColor = Color.FromArgb(255, 192, 128);
            SideB.Location = new Point(183, 75);
            SideB.Name = "SideB";
            SideB.Size = new Size(133, 23);
            SideB.TabIndex = 2;
            SideB.TabStop = false;
            SideB.TextAlign = HorizontalAlignment.Center;
            // 
            // SideC
            // 
            SideC.BackColor = Color.FromArgb(255, 192, 128);
            SideC.Location = new Point(322, 75);
            SideC.Name = "SideC";
            SideC.Size = new Size(133, 23);
            SideC.TabIndex = 3;
            SideC.TabStop = false;
            SideC.TextAlign = HorizontalAlignment.Center;
            // 
            // result
            // 
            result.BackColor = Color.FromArgb(255, 192, 128);
            result.Location = new Point(41, 142);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(414, 23);
            result.TabIndex = 4;
            result.TabStop = false;
            result.TextAlign = HorizontalAlignment.Center;
            // 
            // Checker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(516, 311);
            Controls.Add(result);
            Controls.Add(SideC);
            Controls.Add(SideB);
            Controls.Add(SideA);
            Controls.Add(button1);
            Name = "Checker";
            Text = "Checker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox SideA;
        private TextBox SideB;
        private TextBox SideC;
        private TextBox result;
    }
}