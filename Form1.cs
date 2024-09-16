using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mysql8Connection
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonTestConnectionNative_Click(object sender, EventArgs e)
		{
			MySql.Data.MySqlClient.MySqlConnection conn;

			try
			{
				conn = new MySql.Data.MySqlClient.MySqlConnection(textBoxConnectionString.Text);
				conn.Open();
				conn.Close();
				

				textBoxMessage.ForeColor = Color.Green;
				textBoxMessage.Text = "Connection Successful!!!";
			}
			catch (Exception ex)
			{
				textBoxMessage.ForeColor = Color.Red;
				textBoxMessage.Text = ex.Message;
			}
		}

		private void buttonTestConnectionSHA2_Click(object sender, EventArgs e)
		{
			MySql.Data.MySqlClient.MySqlConnection conn;

			try
			{
				conn = new MySql.Data.MySqlClient.MySqlConnection(textBoxConnectionString.Text+ "SslMode=Required;");
				conn.Open();
				conn.Close();


				textBoxMessage.ForeColor = Color.Green;
				textBoxMessage.Text = "Connection Successful!!!";
			}
			catch (Exception ex)
			{
				textBoxMessage.ForeColor = Color.Red;
				textBoxMessage.Text = ex.Message;
			}
		}
	}
}
