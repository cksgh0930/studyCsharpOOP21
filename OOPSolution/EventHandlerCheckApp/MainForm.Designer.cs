
namespace EventHandlerCheckApp
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTuserID = new System.Windows.Forms.TextBox();
            this.TXTuserpassword = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // TXTuserID
            // 
            this.TXTuserID.Location = new System.Drawing.Point(111, 16);
            this.TXTuserID.Name = "TXTuserID";
            this.TXTuserID.Size = new System.Drawing.Size(229, 27);
            this.TXTuserID.TabIndex = 2;
            // 
            // TXTuserpassword
            // 
            this.TXTuserpassword.Location = new System.Drawing.Point(111, 61);
            this.TXTuserpassword.Name = "TXTuserpassword";
            this.TXTuserpassword.Size = new System.Drawing.Size(229, 27);
            this.TXTuserpassword.TabIndex = 2;
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(355, 56);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(85, 37);
            this.loginbutton.TabIndex = 3;
            this.loginbutton.Text = "로그인";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.TXTuserpassword);
            this.Controls.Add(this.TXTuserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Tag = "이벤트 확인 앱";
            this.Text = "이벤트 확인 앱";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTuserID;
        private System.Windows.Forms.TextBox TXTuserpassword;
        private System.Windows.Forms.Button loginbutton;
    }
}

