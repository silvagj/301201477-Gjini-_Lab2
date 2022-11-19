using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301201477__Gjini__Lab2
{
    public partial class NotificationManager : Form
    {
        public NotificationManager()
        {
            InitializeComponent();
        }

        private void NotificationManager_Load(object sender, EventArgs e)
        {

        }

        private void btnManageSubscription_Click(object sender, EventArgs e)
        {
            ManageNotificationSubscription mainForm = new ManageNotificationSubscription();
            this.Hide(); 
            mainForm.ShowDialog(); 
            this.Close();
        }

        private void btnPublishNotification_Click(object sender, EventArgs e)
        {
            PublishNotification mainForm = new PublishNotification();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
