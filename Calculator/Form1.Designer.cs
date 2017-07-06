namespace test_username
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
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(401, 41);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(124, 20);
            this.txt_user.TabIndex = 0;
            this.txt_user.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.Location = new System.Drawing.Point(263, 41);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(97, 24);
            this.lb_user.TabIndex = 1;
            this.lb_user.Text = "Username";
            // 
            // lb_pass
            // 
            this.lb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.Location = new System.Drawing.Point(263, 94);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(100, 23);
            this.lb_pass.TabIndex = 6;
            this.lb_pass.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(450, 155);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 254);
            this.label1.TabIndex = 10;
            this.label1.Text = "  LOGIN";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(401, 94);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(124, 20);
            this.txt_pass.TabIndex = 11;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(580, 272);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.txt_user);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pass;
    }
}

