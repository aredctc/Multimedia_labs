namespace OpenGLCSharp
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
            this.OpenGLControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.Start_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenGLControl
            // 
            this.OpenGLControl.AccumBits = ((byte)(0));
            this.OpenGLControl.AutoCheckErrors = false;
            this.OpenGLControl.AutoFinish = false;
            this.OpenGLControl.AutoMakeCurrent = true;
            this.OpenGLControl.AutoSwapBuffers = true;
            this.OpenGLControl.BackColor = System.Drawing.Color.White;
            this.OpenGLControl.ColorBits = ((byte)(32));
            this.OpenGLControl.DepthBits = ((byte)(16));
            this.OpenGLControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenGLControl.ForeColor = System.Drawing.Color.White;
            this.OpenGLControl.Location = new System.Drawing.Point(0, 0);
            this.OpenGLControl.Name = "OpenGLControl";
            this.OpenGLControl.Size = new System.Drawing.Size(784, 561);
            this.OpenGLControl.StencilBits = ((byte)(0));
            this.OpenGLControl.TabIndex = 0;
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(6, 19);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(101, 23);
            this.Start_Button.TabIndex = 1;
            this.Start_Button.Text = "Почати рух";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.Start_Button);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(659, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дії";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OpenGLControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Lab5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl OpenGLControl;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

