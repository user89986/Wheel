namespace Wheel
{
    partial class Delete
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
            this.Name1 = new System.Windows.Forms.TextBox();
            this.NumberPhone = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Surname1 = new System.Windows.Forms.TextBox();
            this.Middlename1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumberPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(7, 49);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(300, 20);
            this.Name1.TabIndex = 0;
            // 
            // NumberPhone
            // 
            this.NumberPhone.BackgroundImage = global::Wheel.Properties.Resources.delete;
            this.NumberPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NumberPhone.Location = new System.Drawing.Point(7, 163);
            this.NumberPhone.Name = "NumberPhone";
            this.NumberPhone.Size = new System.Drawing.Size(300, 31);
            this.NumberPhone.TabIndex = 1;
            this.NumberPhone.TabStop = false;
            this.NumberPhone.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Имя*";
            // 
            // Surname1
            // 
            this.Surname1.Location = new System.Drawing.Point(7, 93);
            this.Surname1.Name = "Surname1";
            this.Surname1.Size = new System.Drawing.Size(300, 20);
            this.Surname1.TabIndex = 17;
            // 
            // Middlename1
            // 
            this.Middlename1.Location = new System.Drawing.Point(7, 137);
            this.Middlename1.Name = "Middlename1";
            this.Middlename1.Size = new System.Drawing.Size(300, 20);
            this.Middlename1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Фамилия*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Отчество*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(52, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Кого вы хотите удалить?";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(319, 204);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Middlename1);
            this.Controls.Add(this.Surname1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberPhone);
            this.Controls.Add(this.Name1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Delete";
            this.Text = "Delete";
            ((System.ComponentModel.ISupportInitialize)(this.NumberPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.PictureBox NumberPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Surname1;
        private System.Windows.Forms.TextBox Middlename1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}