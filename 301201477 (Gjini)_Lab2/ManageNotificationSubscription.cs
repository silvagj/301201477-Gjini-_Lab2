using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace _301201477__Gjini__Lab2
{
    public partial class ManageNotificationSubscription : Form
    {
        delegate int AddSub(string sub, int test, out string message);
        public ManageNotificationSubscription()
        {
            InitializeComponent();
            txtEmail.Enabled = false;
            txtSms.Enabled = false;

            txtSms.Text = "XXX-XXX-XXX";
            lblEmail.Visible = false;
            lblSms.Visible = false;
        }

        private void ManageNotificationSubscription_Load(object sender, EventArgs e)
        {

        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            string message = "Please check one of the options!";
            int test = 0;
            if (txtEmail.Text != null && chckEmail.Checked==true)
            {
                AddSub handler = emailSub;
                test=handler(txtEmail.Text, test, out message);
                
            }
            // check for mobile 
            if ((txtSms.Text != null) && txtSms.Text != "XXX-XXX-XXX" && chckSms.Checked == true)
            {
                AddSub handler = smsSub;
                test=handler(txtSms.Text, test, out message);
               

            }
            if (test == 2)
                MessageBox.Show("Email and Phone already Exist");
            // show a message after subcription
            else
            {
                MessageBox.Show(message);
                lblEmail.Visible = false;
                lblSms.Visible = false;
            }
                
        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            bool unsub = false;
            if (txtEmail.Text != null && chckEmail.Checked==true)
            {
                if (txtEmail.Text != null && Collections.EmailNotifications.Contains(txtEmail.Text))
                    Collections.EmailNotifications.Remove(txtEmail.Text);
                unsub = true;
            }
            // check phone to unsubscribe
           if (txtSms.Text != null && chckSms.Checked ==true)
            {
                if (txtSms.Text != null && Collections.MobileNotifications.Contains(txtSms.Text))
                    Collections.MobileNotifications.Remove(txtSms.Text);
                unsub = true;
            }
           if(unsub==true)
            {
                MessageBox.Show("Successfully UnSubscribed");
                lblEmail.Visible = false;
                lblSms.Visible = false;
            }
            else
            {
                MessageBox.Show("Subscriber doesn't exist!");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Collections.CanPublish = (Collections.MobileNotifications != null && Collections.MobileNotifications.Count > 0) ||
           (Collections.MobileNotifications != null && Collections.MobileNotifications.Count > 0) ? true : false;
            NotificationManager mainForm = new NotificationManager();
            this.Hide(); //Hide the Old Form
            mainForm.ShowDialog(); //Show the New Form
            this.Close();
        }

        private void chckEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (chckEmail.Checked == true)
                txtEmail.Enabled = true;
            else
                txtEmail.Enabled = false;
        }

        private void chckSms_CheckedChanged(object sender, EventArgs e)
        {
            if (chckSms.Checked == true)
                txtSms.Enabled = true;
            else
                txtSms.Enabled = false;

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Regex emailRegex = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
            if (emailRegex.IsMatch(txtEmail.Text))
            {
                lblEmail.Visible = false;
                btnSubscribe.Enabled = true;
                btnUnsubscribe.Enabled = true;
            }
            else
            {
                lblEmail.Visible = true;
                btnSubscribe.Enabled = false;
                btnUnsubscribe.Enabled = false;
            }
        }

        private void txtSms_TextChanged(object sender, EventArgs e)
        {
            Regex emailRegex = new Regex(@"\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})");
            // check if regex matches
            if (emailRegex.IsMatch(txtSms.Text))
            {
                lblSms.Visible = false;
                btnSubscribe.Enabled = true;
                btnUnsubscribe.Enabled = true;
            }
            else
            {
                lblSms.Visible = true;
                btnSubscribe.Enabled = false;
                btnUnsubscribe.Enabled = false;
            }
        }

        public static int emailSub(string email, int test, out string message)
        {
            message = "Successfully Subscribed";
            int t = test;
            if (Collections.EmailNotifications == null)
                Collections.EmailNotifications = new List<string>();
            if (!Collections.EmailNotifications.Contains(email) && email!="")
                Collections.EmailNotifications.Add(email);

            else
            {
                message = "Email Already Exists";
                t++;
            }
            return t;
        }
        public static int smsSub(string number,   int test, out  string message)
        {
            message = "Successfully Subscribed";
            int t = test;
            if (Collections.MobileNotifications == null)
                Collections.MobileNotifications = new List<string>();
            // apply check if the text is already in the list
            if (!Collections.MobileNotifications.Contains(number) && number !="")
            {
                Collections.MobileNotifications.Add(number);

            }
            else
            {
                message = "Phone Already Exists";
                t++;
            }
            return t;
        }

    }
}
