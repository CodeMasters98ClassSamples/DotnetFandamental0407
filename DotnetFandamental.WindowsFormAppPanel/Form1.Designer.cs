namespace DotnetFandamental.WindowsFormAppPanel
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
            userNameLabel = new Label();
            userNameTextBox = new TextBox();
            loginButton = new Button();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            dayOfWeekLabel = new Label();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(12, 10);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(60, 15);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Username";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(78, 7);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(195, 23);
            userNameTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(12, 93);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(261, 38);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += button1_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(78, 47);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(195, 23);
            passwordTextBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(12, 50);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // dayOfWeekLabel
            // 
            dayOfWeekLabel.AutoSize = true;
            dayOfWeekLabel.Location = new Point(12, 141);
            dayOfWeekLabel.Name = "dayOfWeekLabel";
            dayOfWeekLabel.Size = new Size(55, 15);
            dayOfWeekLabel.TabIndex = 5;
            dayOfWeekLabel.Text = "روز هفته: ";
            dayOfWeekLabel.Click += dayOfWeekLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 165);
            Controls.Add(dayOfWeekLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(loginButton);
            Controls.Add(userNameTextBox);
            Controls.Add(userNameLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLabel;
        private TextBox userNameTextBox;
        private Button loginButton;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Label dayOfWeekLabel;
    }
}
