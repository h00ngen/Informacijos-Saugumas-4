
namespace IS_Pd4
{
    partial class LoggedIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.addPasswordButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.generatePasswordButton = new System.Windows.Forms.Button();
            this.ManagePasswordsButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sveiki atvykę,";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(311, 57);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(34, 16);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "user";
            // 
            // addPasswordButton
            // 
            this.addPasswordButton.Location = new System.Drawing.Point(207, 272);
            this.addPasswordButton.Name = "addPasswordButton";
            this.addPasswordButton.Size = new System.Drawing.Size(147, 39);
            this.addPasswordButton.TabIndex = 2;
            this.addPasswordButton.Text = "Pridėti slaptažodį";
            this.addPasswordButton.UseVisualStyleBackColor = true;
            this.addPasswordButton.Click += new System.EventHandler(this.addPasswordButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pavadinimas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Slaptažodis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Svetainė";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Komentaras";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(175, 90);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(285, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(175, 200);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(285, 20);
            this.passwordTextBox.TabIndex = 8;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(175, 125);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(285, 20);
            this.urlTextBox.TabIndex = 9;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(175, 162);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(285, 20);
            this.commentTextBox.TabIndex = 10;
            // 
            // generatePasswordButton
            // 
            this.generatePasswordButton.Location = new System.Drawing.Point(207, 227);
            this.generatePasswordButton.Name = "generatePasswordButton";
            this.generatePasswordButton.Size = new System.Drawing.Size(147, 39);
            this.generatePasswordButton.TabIndex = 11;
            this.generatePasswordButton.Text = "Sugeneruoti slaptažodį";
            this.generatePasswordButton.UseVisualStyleBackColor = true;
            this.generatePasswordButton.Click += new System.EventHandler(this.generatePasswordButton_Click);
            // 
            // ManagePasswordsButton
            // 
            this.ManagePasswordsButton.Location = new System.Drawing.Point(12, 317);
            this.ManagePasswordsButton.Name = "ManagePasswordsButton";
            this.ManagePasswordsButton.Size = new System.Drawing.Size(536, 45);
            this.ManagePasswordsButton.TabIndex = 18;
            this.ManagePasswordsButton.Text = "Peržiūrėti slaptažodžius";
            this.ManagePasswordsButton.UseVisualStyleBackColor = true;
            this.ManagePasswordsButton.Click += new System.EventHandler(this.ManagePasswordsButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(149, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "Slaptažodžio kūrimas";
            // 
            // LoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 371);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ManagePasswordsButton);
            this.Controls.Add(this.generatePasswordButton);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addPasswordButton);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.label1);
            this.Name = "LoggedIn";
            this.Text = "LogggedIn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoggedIn_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button addPasswordButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button generatePasswordButton;
        private System.Windows.Forms.Button ManagePasswordsButton;
        private System.Windows.Forms.Label label6;
    }
}