
namespace _447Gibdd.Forms
{
    partial class AddUserForm
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
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.clear_text = new System.Windows.Forms.Button();
            this.bt_adduser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(12, 12);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(100, 20);
            this.tb_surname.TabIndex = 0;
            // 
            // tb_firstname
            // 
            this.tb_firstname.Location = new System.Drawing.Point(12, 38);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(100, 20);
            this.tb_firstname.TabIndex = 1;
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(12, 64);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(100, 20);
            this.tb_lastname.TabIndex = 2;
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(12, 90);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(100, 20);
            this.tb_login.TabIndex = 3;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(12, 116);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 4;
            // 
            // clear_text
            // 
            this.clear_text.Location = new System.Drawing.Point(13, 143);
            this.clear_text.Name = "clear_text";
            this.clear_text.Size = new System.Drawing.Size(75, 23);
            this.clear_text.TabIndex = 5;
            this.clear_text.Text = "Убрать текст";
            this.clear_text.UseVisualStyleBackColor = true;
            this.clear_text.Click += new System.EventHandler(this.clear_text_Click);
            // 
            // bt_adduser
            // 
            this.bt_adduser.Location = new System.Drawing.Point(12, 173);
            this.bt_adduser.Name = "bt_adduser";
            this.bt_adduser.Size = new System.Drawing.Size(75, 23);
            this.bt_adduser.TabIndex = 6;
            this.bt_adduser.Text = "Готово";
            this.bt_adduser.UseVisualStyleBackColor = true;
            this.bt_adduser.Click += new System.EventHandler(this.bt_adduser_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(126, 208);
            this.Controls.Add(this.bt_adduser);
            this.Controls.Add(this.clear_text);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_lastname);
            this.Controls.Add(this.tb_firstname);
            this.Controls.Add(this.tb_surname);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button clear_text;
        private System.Windows.Forms.Button bt_adduser;
    }
}