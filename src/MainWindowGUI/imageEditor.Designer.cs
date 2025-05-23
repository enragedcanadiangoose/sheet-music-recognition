﻿

namespace MainWindowGUI
{
    partial class imageEditor
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
            image = new PictureBox();
            label1 = new Label();
            topCropValue = new TextBox();
            label2 = new Label();
            rotationScrollBar = new HScrollBar();
            brightScrollBar = new HScrollBar();
            label3 = new Label();
            hScrollBar3 = new HScrollBar();
            label4 = new Label();
            saveButton = new Button();
            label5 = new Label();
            bottomCropValue = new TextBox();
            label6 = new Label();
            rightCropValue = new TextBox();
            label7 = new Label();
            leftCropValue = new TextBox();
            label8 = new Label();
            rotationAngle = new TextBox();
            rotateLeftButton = new Button();
            rotateRightButton = new Button();
            brightnessValue = new TextBox();
            contrastValue = new TextBox();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            SuspendLayout();
            // 
            // image
            // 
            image.Location = new Point(130, 12);
            image.Name = "image";
            image.Size = new Size(561, 645);
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.TabIndex = 0;
            image.TabStop = false;
            image.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 20F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 35);
            label1.TabIndex = 1;
            label1.Text = "Crop";
            // 
            // topCropValue
            // 
            topCropValue.Location = new Point(55, 47);
            topCropValue.Name = "topCropValue";
            topCropValue.Size = new Size(69, 23);
            topCropValue.TabIndex = 2;
            topCropValue.Text = "0";
            topCropValue.TextChanged += topCropValue_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 20F);
            label2.Location = new Point(12, 164);
            label2.Name = "label2";
            label2.Size = new Size(98, 35);
            label2.TabIndex = 4;
            label2.Text = "Rotate";
            // 
            // rotationScrollBar
            // 
            rotationScrollBar.LargeChange = 1;
            rotationScrollBar.Location = new Point(12, 199);
            rotationScrollBar.Maximum = 180;
            rotationScrollBar.Minimum = -180;
            rotationScrollBar.Name = "rotationScrollBar";
            rotationScrollBar.Size = new Size(100, 17);
            rotationScrollBar.TabIndex = 5;
            rotationScrollBar.Scroll += hScrollBar1_Scroll;
            // 
            // brightScrollBar
            // 
            brightScrollBar.LargeChange = 1;
            brightScrollBar.Location = new Point(12, 278);
            brightScrollBar.Minimum = -100;
            brightScrollBar.Name = "brightScrollBar";
            brightScrollBar.Size = new Size(100, 17);
            brightScrollBar.TabIndex = 7;
            brightScrollBar.Scroll += hScrollBar2_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 20F);
            label3.Location = new Point(12, 243);
            label3.Name = "label3";
            label3.Size = new Size(91, 35);
            label3.TabIndex = 6;
            label3.Text = "Bright";
            // 
            // hScrollBar3
            // 
            hScrollBar3.LargeChange = 1;
            hScrollBar3.Location = new Point(12, 359);
            hScrollBar3.Name = "hScrollBar3";
            hScrollBar3.Size = new Size(100, 17);
            hScrollBar3.TabIndex = 9;
            hScrollBar3.Value = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 20F);
            label4.Location = new Point(12, 324);
            label4.Name = "label4";
            label4.Size = new Size(74, 35);
            label4.TabIndex = 8;
            label4.Text = "Cont";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(11, 610);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(113, 47);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 50);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 13;
            label5.Text = "Top";
            // 
            // bottomCropValue
            // 
            bottomCropValue.Location = new Point(55, 76);
            bottomCropValue.Name = "bottomCropValue";
            bottomCropValue.Size = new Size(69, 23);
            bottomCropValue.TabIndex = 14;
            bottomCropValue.Text = "0";
            bottomCropValue.TextChanged += bottomCropValue_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 79);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 15;
            label6.Text = "Bottom";
            // 
            // rightCropValue
            // 
            rightCropValue.Location = new Point(55, 134);
            rightCropValue.Name = "rightCropValue";
            rightCropValue.Size = new Size(69, 23);
            rightCropValue.TabIndex = 18;
            rightCropValue.Text = "0";
            rightCropValue.TextChanged += rightCropValue_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 137);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 19;
            label7.Text = "Right";
            // 
            // leftCropValue
            // 
            leftCropValue.Location = new Point(55, 105);
            leftCropValue.Name = "leftCropValue";
            leftCropValue.Size = new Size(69, 23);
            leftCropValue.TabIndex = 16;
            leftCropValue.Text = "0";
            leftCropValue.TextChanged += leftCropValue_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(2, 108);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 17;
            label8.Text = "Left";
            // 
            // rotationAngle
            // 
            rotationAngle.Location = new Point(12, 217);
            rotationAngle.Name = "rotationAngle";
            rotationAngle.Size = new Size(69, 23);
            rotationAngle.TabIndex = 20;
            rotationAngle.Text = "0";
            rotationAngle.TextChanged += rotationAngle_TextChanged;
            // 
            // rotateLeftButton
            // 
            rotateLeftButton.ForeColor = SystemColors.ControlText;
            rotateLeftButton.Image = Properties.Resources.imageres_5344_1__Custom_;
            rotateLeftButton.Location = new Point(83, 216);
            rotateLeftButton.Name = "rotateLeftButton";
            rotateLeftButton.Size = new Size(20, 23);
            rotateLeftButton.TabIndex = 21;
            rotateLeftButton.UseVisualStyleBackColor = true;
            rotateLeftButton.Click += rotateLeftButton_Click;
            // 
            // rotateRightButton
            // 
            rotateRightButton.Image = Properties.Resources.imageres_5345_1__Custom_;
            rotateRightButton.Location = new Point(104, 216);
            rotateRightButton.Name = "rotateRightButton";
            rotateRightButton.Size = new Size(20, 23);
            rotateRightButton.TabIndex = 22;
            rotateRightButton.UseVisualStyleBackColor = true;
            rotateRightButton.Click += rotateRightButton_Click;
            // 
            // brightnessValue
            // 
            brightnessValue.Location = new Point(12, 298);
            brightnessValue.Name = "brightnessValue";
            brightnessValue.Size = new Size(69, 23);
            brightnessValue.TabIndex = 23;
            brightnessValue.Text = "0";
            brightnessValue.TextChanged += brightnessValue_TextChanged;
            // 
            // contrastValue
            // 
            contrastValue.Location = new Point(12, 379);
            contrastValue.Name = "contrastValue";
            contrastValue.Size = new Size(69, 23);
            contrastValue.TabIndex = 24;
            contrastValue.Text = "0";
            // 
            // imageEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 669);
            ControlBox = false;
            Controls.Add(contrastValue);
            Controls.Add(brightnessValue);
            Controls.Add(rotateRightButton);
            Controls.Add(rotateLeftButton);
            Controls.Add(rotationAngle);
            Controls.Add(rightCropValue);
            Controls.Add(label7);
            Controls.Add(leftCropValue);
            Controls.Add(label8);
            Controls.Add(bottomCropValue);
            Controls.Add(label6);
            Controls.Add(topCropValue);
            Controls.Add(label5);
            Controls.Add(saveButton);
            Controls.Add(hScrollBar3);
            Controls.Add(label4);
            Controls.Add(brightScrollBar);
            Controls.Add(label3);
            Controls.Add(rotationScrollBar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(image);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "imageEditor";
            ShowInTaskbar = false;
            Text = "imageEditor";
            Load += imageEditor_Load;
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private void customInit()
        {
            image.Image = Image.FromFile(Program.app.inputPath);
        }

        #endregion

        private PictureBox image;
        private Label label1;
        private TextBox topCropValue;
        private Label label2;
        private HScrollBar rotationScrollBar;
        private HScrollBar brightScrollBar;
        private Label label3;
        private HScrollBar hScrollBar3;
        private Label label4;
        private Button saveButton;
        private Label label5;
        private TextBox bottomCropValue;
        private Label label6;
        private TextBox rightCropValue;
        private Label label7;
        private TextBox leftCropValue;
        private Label label8;
        private TextBox rotationAngle;
        private Button rotateLeftButton;
        private Button rotateRightButton;
        private TextBox brightnessValue;
        private TextBox contrastValue;
    }
}