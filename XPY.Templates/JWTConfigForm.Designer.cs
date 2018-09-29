﻿namespace XPY.Templates {
    partial class JWTConfigForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Issuer = new System.Windows.Forms.TextBox();
            this.Audience = new System.Windows.Forms.TextBox();
            this.SecureKey = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issuer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Audience:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "SecureKey:";
            // 
            // Issuer
            // 
            this.Issuer.Location = new System.Drawing.Point(76, 6);
            this.Issuer.Name = "Issuer";
            this.Issuer.Size = new System.Drawing.Size(203, 22);
            this.Issuer.TabIndex = 3;
            this.Issuer.Text = "unknow";
            // 
            // Audience
            // 
            this.Audience.Location = new System.Drawing.Point(76, 34);
            this.Audience.Name = "Audience";
            this.Audience.Size = new System.Drawing.Size(203, 22);
            this.Audience.TabIndex = 4;
            this.Audience.Text = "unknow";
            // 
            // SecureKey
            // 
            this.SecureKey.Location = new System.Drawing.Point(76, 62);
            this.SecureKey.Name = "SecureKey";
            this.SecureKey.Size = new System.Drawing.Size(203, 22);
            this.SecureKey.TabIndex = 5;
            this.SecureKey.Text = "unknow";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(204, 90);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // JWTConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 122);
            this.ControlBox = false;
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.SecureKey);
            this.Controls.Add(this.Audience);
            this.Controls.Add(this.Issuer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JWTConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JWT Configuration";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.JWTConfigForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OKButton;
        internal System.Windows.Forms.TextBox Issuer;
        internal System.Windows.Forms.TextBox Audience;
        internal System.Windows.Forms.TextBox SecureKey;
    }
}