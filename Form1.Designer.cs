
namespace Mysql8Connection
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
			this.buttonTestConnectionNative = new System.Windows.Forms.Button();
			this.textBoxConnectionString = new System.Windows.Forms.TextBox();
			this.textBoxMessage = new System.Windows.Forms.TextBox();
			this.buttonTestConnectionSHA2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonTestConnectionNative
			// 
			this.buttonTestConnectionNative.Location = new System.Drawing.Point(12, 130);
			this.buttonTestConnectionNative.Name = "buttonTestConnectionNative";
			this.buttonTestConnectionNative.Size = new System.Drawing.Size(219, 28);
			this.buttonTestConnectionNative.TabIndex = 0;
			this.buttonTestConnectionNative.Text = "Test mysql_native_password";
			this.buttonTestConnectionNative.UseVisualStyleBackColor = true;
			this.buttonTestConnectionNative.Click += new System.EventHandler(this.buttonTestConnectionNative_Click);
			// 
			// textBoxConnectionString
			// 
			this.textBoxConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxConnectionString.Location = new System.Drawing.Point(12, 12);
			this.textBoxConnectionString.Multiline = true;
			this.textBoxConnectionString.Name = "textBoxConnectionString";
			this.textBoxConnectionString.Size = new System.Drawing.Size(776, 110);
			this.textBoxConnectionString.TabIndex = 1;
			this.textBoxConnectionString.Text = "server=localhost;User Id=root;password=PAss12#$;port=3308;database=mytestdb;";
			// 
			// textBoxMessage
			// 
			this.textBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMessage.Location = new System.Drawing.Point(237, 128);
			this.textBoxMessage.Multiline = true;
			this.textBoxMessage.Name = "textBoxMessage";
			this.textBoxMessage.Size = new System.Drawing.Size(551, 66);
			this.textBoxMessage.TabIndex = 3;
			// 
			// buttonTestConnectionSHA2
			// 
			this.buttonTestConnectionSHA2.Location = new System.Drawing.Point(12, 164);
			this.buttonTestConnectionSHA2.Name = "buttonTestConnectionSHA2";
			this.buttonTestConnectionSHA2.Size = new System.Drawing.Size(219, 28);
			this.buttonTestConnectionSHA2.TabIndex = 4;
			this.buttonTestConnectionSHA2.Text = "Test caching_sha2_password";
			this.buttonTestConnectionSHA2.UseVisualStyleBackColor = true;
			this.buttonTestConnectionSHA2.Click += new System.EventHandler(this.buttonTestConnectionSHA2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 207);
			this.Controls.Add(this.buttonTestConnectionSHA2);
			this.Controls.Add(this.textBoxMessage);
			this.Controls.Add(this.textBoxConnectionString);
			this.Controls.Add(this.buttonTestConnectionNative);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "MySQL Connecion Test";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonTestConnectionNative;
		private System.Windows.Forms.TextBox textBoxConnectionString;
		private System.Windows.Forms.TextBox textBoxMessage;
		private System.Windows.Forms.Button buttonTestConnectionSHA2;
	}
}

