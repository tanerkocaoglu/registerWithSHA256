using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace registerWithSHA256
{
	public partial class RegisterSHA256 : Form
	{
		public RegisterSHA256()
		{
			InitializeComponent();
		}

		readonly string sql = "Data Source=DESKTOP-I5I74Q7;Initial Catalog=registerWithSHA;Integrated Security=True";
		
		private void Btn_Register_Click(object sender, EventArgs e)
		{
			string hashedPassword = ComputeSha256Hash(Txt_Password.Text);
			using (var con = new SqlConnection(sql))
			{
				SqlCommand cmdRegister = new SqlCommand("insert into Tbl_Users(userName,userSurName,userMail,userPassword) " +
				"values(@userName,@userSurName,@userMail,@userPassword)", con);
				cmdRegister.Parameters.AddWithValue("@userName", Txt_Name.Text);
				cmdRegister.Parameters.AddWithValue("@userSurName", Txt_Surname.Text);
				cmdRegister.Parameters.AddWithValue("@userMail", Txt_Mail.Text);
				cmdRegister.Parameters.AddWithValue("@userPassword", hashedPassword);
				con.Open();
				cmdRegister.ExecuteNonQuery();
			}
		}
		public string ComputeSha256Hash(string rawData)
		{
			using (SHA256 sha256Hash = SHA256.Create())
			{
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
				StringBuilder builder = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
				{
					builder.Append(bytes[i].ToString("x2"));
				}
				return builder.ToString();
			}
		}
	}
}
