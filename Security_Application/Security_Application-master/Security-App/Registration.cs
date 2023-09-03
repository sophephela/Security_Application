using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace Security_App
{
    public partial class Registration : Form
    {
        SqlConnection con = new SqlConnection("Data Source=sqlserver.dynamicdna.co.za;Initial Catalog=Security-App-Innocent;User ID=BBD;Password=123");
        public Registration()
        {
            InitializeComponent();
        }

        private void registerB_Click(object sender, EventArgs e)

        {
            if (otp.ToString().Equals(otpT.Text))
            {
                try
                {
                    con.Open();

                    SqlCommand com = new SqlCommand("INSERT INTO Customer VALUES('" + fnameT.Text + "','" + emailT.Text + "','" + passwordT.Text + "')", con);

                    try
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Congratulations you have ragistered");
                        fnameT.Clear();
                        emailT.Clear();
                        passwordT.Clear();
                        otpT.Clear();

                        fnameT.Focus();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Failed to register, please contact the system admin");
                    }
                    con.Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("Failed to connect the the database");
                }
            }
            else
            MessageBox.Show("Incorrect PIN");

        }
        int otp;

        private void sendB_Click(object sender, EventArgs e)
        {
            if (fnameT.Text.Length > 0 && emailT.Text.Length > 0 && passwordT.Text.Length > 0)
            {
                Random r = new Random();
                otp = r.Next(1000, 10000);

                sendEmail();
            }
            else
                MessageBox.Show("All fields are required");
        }

        private void sendEmail()
        {
            try
            {

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("cv@gmail.com");
                msg.To.Add(emailT.Text);
                msg.Subject = "Important mail: OTP";
                msg.Body = "Hi, " + fnameT.Text + "\n\nOTP: " + otp;

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "cv@gmail.com";
                ntcd.Password = "ymcfqogatxcpjtrj";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                MessageBox.Show("Your Mail is sent");

            }
            catch (Exception)
            {

                MessageBox.Show("Failed to send an email");
            }
        }
    }
}
