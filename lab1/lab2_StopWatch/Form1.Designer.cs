namespace lab2_StopWatch
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
            this.openGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAnimation = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGlControl
            // 
            this.openGlControl.AccumBits = ((byte)(0));
            this.openGlControl.AutoCheckErrors = false;
            this.openGlControl.AutoFinish = false;
            this.openGlControl.AutoMakeCurrent = true;
            this.openGlControl.AutoSwapBuffers = true;
            this.openGlControl.BackColor = System.Drawing.Color.Black;
            this.openGlControl.ColorBits = ((byte)(32));
            this.openGlControl.DepthBits = ((byte)(16));
            this.openGlControl.Location = new System.Drawing.Point(2, 5);
            this.openGlControl.Name = "openGlControl";
            this.openGlControl.Size = new System.Drawing.Size(430, 250);
            this.openGlControl.StencilBits = ((byte)(0));
            this.openGlControl.TabIndex = 0;
            // 
            // Btn_Start
            // 
            this.Btn_Start.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Start.Location = new System.Drawing.Point(438, 5);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(107, 30);
            this.Btn_Start.TabIndex = 2;
            this.Btn_Start.Text = "Старт";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Stop.Location = new System.Drawing.Point(438, 41);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(107, 30);
            this.Btn_Stop.TabIndex = 3;
            this.Btn_Stop.Text = "Стоп";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "10",
            "50",
            "100",
            "500",
            "1000",
            "2500",
            "5000"});
            this.comboBox1.Location = new System.Drawing.Point(-1, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 23);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(438, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 65);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Інтервал оновлення";
            // 
            // checkBoxAnimation
            // 
            this.checkBoxAnimation.AutoSize = true;
            this.checkBoxAnimation.Location = new System.Drawing.Point(438, 158);
            this.checkBoxAnimation.Name = "checkBoxAnimation";
            this.checkBoxAnimation.Size = new System.Drawing.Size(69, 17);
            this.checkBoxAnimation.TabIndex = 8;
            this.checkBoxAnimation.Text = "Анімація";
            this.checkBoxAnimation.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(549, 259);
            this.Controls.Add(this.checkBoxAnimation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.openGlControl);
            this.Name = "Form1";
            this.Text = "StopWatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl openGlControl;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxAnimation;
    }
}

