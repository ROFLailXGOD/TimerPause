using System;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public partial class TimerPauseSettings : UserControl
    {
        public TimerPauseSettings()
        {
            InitializeComponent();
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            return parent;
        }

        private void lblGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ROFLailXGOD/TimerPause");
        }

        private void lblYouTube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/user/zazaza691");
        }

        private void lblTwitch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitch.tv/zazaza691");
        }
    }
}
