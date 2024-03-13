namespace WinForms_Controls
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
            email_txtbox = new TextBox();
            login_btn = new Button();
            userEmail_lbl = new Label();
            clickResult_lbl = new Label();
            SuspendLayout();
            // 
            // email_txtbox
            // 
            email_txtbox.Location = new Point(137, 23);
            email_txtbox.Name = "email_txtbox";
            email_txtbox.Size = new Size(375, 27);
            email_txtbox.TabIndex = 0;
            // 
            // login_btn
            // 
            login_btn.Location = new Point(137, 66);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(73, 29);
            login_btn.TabIndex = 1;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_click;
            // 
            // userEmail_lbl
            // 
            userEmail_lbl.AutoSize = true;
            userEmail_lbl.Location = new Point(28, 26);
            userEmail_lbl.Name = "userEmail_lbl";
            userEmail_lbl.Size = new Size(79, 20);
            userEmail_lbl.TabIndex = 2;
            userEmail_lbl.Text = "User Email";
            // 
            // clickResult_lbl
            // 
            clickResult_lbl.AutoSize = true;
            clickResult_lbl.Location = new Point(236, 75);
            clickResult_lbl.Name = "clickResult_lbl";
            clickResult_lbl.Size = new Size(0, 20);
            clickResult_lbl.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clickResult_lbl);
            Controls.Add(userEmail_lbl);
            Controls.Add(login_btn);
            Controls.Add(email_txtbox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox email_txtbox;
        private Button login_btn;
        private Label userEmail_lbl;
        private Label clickResult_lbl;
    }
}
