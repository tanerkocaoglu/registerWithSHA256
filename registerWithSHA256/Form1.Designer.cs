namespace registerWithSHA256
{
	partial class RegisterSHA256
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
			this.Btn_Register = new System.Windows.Forms.Button();
			this.Txt_Name = new System.Windows.Forms.TextBox();
			this.Txt_Surname = new System.Windows.Forms.TextBox();
			this.Txt_Mail = new System.Windows.Forms.TextBox();
			this.Txt_Password = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Btn_Register
			// 
			this.Btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Btn_Register.Location = new System.Drawing.Point(117, 123);
			this.Btn_Register.Name = "Btn_Register";
			this.Btn_Register.Size = new System.Drawing.Size(100, 30);
			this.Btn_Register.TabIndex = 0;
			this.Btn_Register.Text = "Register";
			this.Btn_Register.UseVisualStyleBackColor = true;
			this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
			// 
			// Txt_Name
			// 
			this.Txt_Name.Location = new System.Drawing.Point(117, 11);
			this.Txt_Name.Name = "Txt_Name";
			this.Txt_Name.Size = new System.Drawing.Size(100, 22);
			this.Txt_Name.TabIndex = 1;
			// 
			// Txt_Surname
			// 
			this.Txt_Surname.Location = new System.Drawing.Point(117, 39);
			this.Txt_Surname.Name = "Txt_Surname";
			this.Txt_Surname.Size = new System.Drawing.Size(100, 22);
			this.Txt_Surname.TabIndex = 1;
			// 
			// Txt_Mail
			// 
			this.Txt_Mail.Location = new System.Drawing.Point(117, 67);
			this.Txt_Mail.Name = "Txt_Mail";
			this.Txt_Mail.Size = new System.Drawing.Size(100, 22);
			this.Txt_Mail.TabIndex = 1;
			// 
			// Txt_Password
			// 
			this.Txt_Password.Location = new System.Drawing.Point(117, 95);
			this.Txt_Password.Name = "Txt_Password";
			this.Txt_Password.Size = new System.Drawing.Size(100, 22);
			this.Txt_Password.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(15, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Name :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(15, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Surname :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(15, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "E-Mail :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(15, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Password :";
			// 
			// RegisterSHA256
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(241, 169);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Txt_Password);
			this.Controls.Add(this.Txt_Mail);
			this.Controls.Add(this.Txt_Surname);
			this.Controls.Add(this.Txt_Name);
			this.Controls.Add(this.Btn_Register);
			this.Name = "RegisterSHA256";
			this.Text = "Register SHA256";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Btn_Register;
		private System.Windows.Forms.TextBox Txt_Name;
		private System.Windows.Forms.TextBox Txt_Surname;
		private System.Windows.Forms.TextBox Txt_Mail;
		private System.Windows.Forms.TextBox Txt_Password;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

