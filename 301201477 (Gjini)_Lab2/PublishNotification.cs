using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301201477__Gjini__Lab2
{
    public partial class PublishNotification : Form
    {
        public PublishNotification()
        {
            InitializeComponent();
        }

        private void lblContent_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
           listSubscribers.Visible = true;
            lblContent.Visible = true;
            var notifications = new List<string>();
            bool exists = false;
            if(Collections.EmailNotifications !=null)
            {
                notifications.AddRange(Collections.EmailNotifications);
                exists = true;
            }
            
            if (Collections.MobileNotifications != null)
            {
                notifications.AddRange(Collections.MobileNotifications);
                exists = true;
            }
                
         if(exists==true && ( Collections.MobileNotifications.Count >0 || Collections.EmailNotifications.Count >0))
            {
                listSubscribers.DataSource = notifications;
                MessageBox.Show("Successfully Published");
            }
            else
            {
                MessageBox.Show("There are no subscribers");
            }
           
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Collections.CanPublish = (Collections.MobileNotifications != null && Collections.MobileNotifications.Count > 0) ||
           (Collections.MobileNotifications != null && Collections.MobileNotifications.Count > 0) ? true : false;
            // render main page
            NotificationManager mainForm = new NotificationManager();
            this.Hide(); //Hide the Old Form
            mainForm.ShowDialog(); //Show the New Form
            this.Close();
        }

        private void listSubscribers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
