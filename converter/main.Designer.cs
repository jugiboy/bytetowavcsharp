namespace converter
{
    partial class main
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtBytes = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rbCpp = new System.Windows.Forms.RadioButton();
            this.rbCSharp = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtBytes
            // 
            this.txtBytes.AllowDrop = true;
            this.txtBytes.Location = new System.Drawing.Point(12, 12);
            this.txtBytes.Multiline = true;
            this.txtBytes.Name = "txtBytes";
            this.txtBytes.Size = new System.Drawing.Size(313, 173);
            this.txtBytes.TabIndex = 1;
            this.txtBytes.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.txtBytes.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Play Sound";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbCpp
            // 
            this.rbCpp.AutoSize = true;
            this.rbCpp.Location = new System.Drawing.Point(331, 13);
            this.rbCpp.Name = "rbCpp";
            this.rbCpp.Size = new System.Drawing.Size(82, 17);
            this.rbCpp.TabIndex = 3;
            this.rbCpp.TabStop = true;
            this.rbCpp.Text = "Print as C++";
            this.rbCpp.UseVisualStyleBackColor = true;
            // 
            // rbCSharp
            // 
            this.rbCSharp.AutoSize = true;
            this.rbCSharp.Location = new System.Drawing.Point(331, 36);
            this.rbCSharp.Name = "rbCSharp";
            this.rbCSharp.Size = new System.Drawing.Size(77, 17);
            this.rbCSharp.TabIndex = 3;
            this.rbCSharp.TabStop = true;
            this.rbCSharp.Text = "Print as C#";
            this.rbCSharp.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 229);
            this.Controls.Add(this.rbCSharp);
            this.Controls.Add(this.rbCpp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBytes);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert bytes to WAV";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBytes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbCpp;
        private System.Windows.Forms.RadioButton rbCSharp;
    }
}

