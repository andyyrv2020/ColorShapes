namespace ColorShapes
{
    partial class ColorShapes
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
            this.rectangleButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(12, 406);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(85, 25);
            this.rectangleButton.TabIndex = 0;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Location = new System.Drawing.Point(121, 406);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(85, 25);
            this.triangleButton.TabIndex = 1;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(231, 406);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(85, 25);
            this.circleButton.TabIndex = 2;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // ColorShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 482);
            this.ControlBox = false;
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.rectangleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorShapes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Random Color Shapes";
            this.Load += new System.EventHandler(this.ColorShapes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Button circleButton;
    }
}

