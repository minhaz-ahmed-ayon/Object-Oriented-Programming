﻿namespace Railway
{
    partial class trainmasterlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trainmasterlogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textuser = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.checkBoxshow = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Train Master";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(464, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(464, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Agency FB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(509, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Agency FB", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(499, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Create or remove an Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(469, 137);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(225, 22);
            this.textuser.TabIndex = 5;
            this.textuser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(469, 203);
            this.textpass.Name = "textpass";
            this.textpass.PasswordChar = '*';
            this.textpass.Size = new System.Drawing.Size(225, 22);
            this.textpass.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReset.Font = new System.Drawing.Font("Agency FB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(509, 320);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(164, 40);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Agency FB", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(499, 421);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(190, 27);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Back to Home Page";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // checkBoxshow
            // 
            this.checkBoxshow.AutoSize = true;
            this.checkBoxshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxshow.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxshow.Location = new System.Drawing.Point(620, 231);
            this.checkBoxshow.Name = "checkBoxshow";
            this.checkBoxshow.Size = new System.Drawing.Size(117, 27);
            this.checkBoxshow.TabIndex = 9;
            this.checkBoxshow.Text = "Show Password";
            this.checkBoxshow.UseVisualStyleBackColor = true;
            this.checkBoxshow.CheckedChanged += new System.EventHandler(this.checkBoxshow_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1, -31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 559);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // trainmasterlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 479);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxshow);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "trainmasterlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "trainmasterlogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.CheckBox checkBoxshow;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}