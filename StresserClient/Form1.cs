using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace StresserClient
{
    public partial class StresserClient : Form
    {
        private Client client;
        int threads = 500;
        public StresserClient()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopupNotifier startup = new PopupNotifier();
            startup.TitleText = "StresserClient Loaded";
            startup.ContentText = "StresserClient is ready to use";
            startup.Popup();
        }

        private void IP_TextChanged(object sender, EventArgs e)
        {

        }

        private void Attack_Click(object sender, EventArgs e)
        {
            client = new Client(IP.Text, (int)long.Parse(Port.Text));
            client.Attack(threads);

            PopupNotifier attackConfirmation = new PopupNotifier();
            attackConfirmation.TitleText = "Attack Confirmation";
            attackConfirmation.ContentText = $"Your attack on {IP.Text} at {Port.Text} has started";
            attackConfirmation.Popup();

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            client.Stop();
            PopupNotifier stoppageConfirmation = new PopupNotifier();
            stoppageConfirmation.TitleText = "Attack Cancellation Confirmation";
            stoppageConfirmation.ContentText = $"Your attack on {IP.Text} at {Port.Text} has been stopped";
            stoppageConfirmation.Popup();        
        }

        private void ThreadCount_TextChanged(object sender, EventArgs e)
        {
            if (ThreadCount.Text != "")
            {
                threads = int.Parse(ThreadCount.Text);
            }
        }
    }
}
