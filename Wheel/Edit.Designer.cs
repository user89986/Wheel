namespace Wheel
{
    partial class Edit
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
            this.Password = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Delte = new System.Windows.Forms.PictureBox();
            this.Registration = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Delte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Registration)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(18, 105);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(300, 20);
            this.Password.TabIndex = 0;
            this.Password.UseSystemPasswordChar = true;
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(18, 61);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(300, 20);
            this.User.TabIndex = 1;
            this.User.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.User_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Номер телефона*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Пароль*";
            // 
            // Delte
            // 
            this.Delte.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Delte.BackgroundImage = global::Wheel.Properties.Resources.delete;
            this.Delte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delte.Location = new System.Drawing.Point(172, 131);
            this.Delte.Name = "Delte";
            this.Delte.Size = new System.Drawing.Size(150, 27);
            this.Delte.TabIndex = 3;
            this.Delte.TabStop = false;
            this.Delte.Click += new System.EventHandler(this.Delte_Click);
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Registration.BackgroundImage = global::Wheel.Properties.Resources.edit;
            this.Registration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registration.Location = new System.Drawing.Point(12, 131);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(148, 27);
            this.Registration.TabIndex = 2;
            this.Registration.TabStop = false;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(96, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Администратор";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(334, 170);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delte);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Edit";
            this.Text = "Сhanging the data";
            ((System.ComponentModel.ISupportInitialize)(this.Delte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Registration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.PictureBox Registration;
        private System.Windows.Forms.PictureBox Delte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}