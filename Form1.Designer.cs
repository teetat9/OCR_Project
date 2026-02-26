namespace OCR_Project
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
            splitContainer1 = new SplitContainer();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            imageBox1 = new Emgu.CV.UI.ImageBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(35, 35, 40);
            splitContainer1.Panel1.Controls.Add(textBox3);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(35, 35, 40);
            splitContainer1.Panel2.Controls.Add(imageBox1);
            splitContainer1.Size = new Size(1115, 626);
            splitContainer1.SplitterDistance = 411;
            splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Swis721 Blk BT", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(28, 521);
            button1.Name = "button1";
            button1.Size = new Size(362, 78);
            button1.TabIndex = 0;
            button1.Text = "DETECT OCR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Font = new Font("Swis721 Blk BT", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(51, 420);
            button2.Name = "button2";
            button2.Size = new Size(304, 78);
            button2.TabIndex = 1;
            button2.Text = "LOAD IMAGE";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(51, 39);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 338);
            textBox1.TabIndex = 2;
            // 
            // imageBox1
            // 
            imageBox1.Dock = DockStyle.Fill;
            imageBox1.Location = new Point(0, 0);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(700, 626);
            imageBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox1.TabIndex = 2;
            imageBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(35, 35, 40);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Swis721 BlkCn BT", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.InactiveBorder;
            textBox2.Location = new Point(3, 603);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 20);
            textBox2.TabIndex = 3;
            textBox2.Text = "Speed Process Time:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(35, 35, 40);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Swis721 BlkCn BT", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.InactiveBorder;
            textBox3.Location = new Point(51, 13);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(284, 20);
            textBox3.TabIndex = 4;
            textBox3.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 626);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "OCR";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imageBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private TextBox textBox3;
    }
}
