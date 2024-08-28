namespace InjectionSimulator
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
            btn_login = new Button();
            txt_username = new TextBox();
            txt_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label_query = new Label();
            label_status = new Label();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 13F);
            btn_login.Location = new Point(56, 230);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(146, 56);
            btn_login.TabIndex = 0;
            btn_login.Text = "Logga in";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(148, 64);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(176, 23);
            txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(148, 123);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(176, 23);
            txt_password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(47, 61);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(47, 123);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // label_query
            // 
            label_query.AutoSize = true;
            label_query.Font = new Font("Segoe UI", 13F);
            label_query.Location = new Point(56, 184);
            label_query.Name = "label_query";
            label_query.Size = new Size(90, 25);
            label_query.TabIndex = 5;
            label_query.Text = "Sql Query";
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Font = new Font("Segoe UI", 13F);
            label_status.Location = new Point(56, 308);
            label_status.Name = "label_status";
            label_status.Size = new Size(133, 25);
            label_status.TabIndex = 6;
            label_status.Text = "Du är utloggad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_status);
            Controls.Add(label_query);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(btn_login);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label1;
        private Label label2;
        private Label label_query;
        private Label label_status;
    }
}
