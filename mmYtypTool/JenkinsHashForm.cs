using System;
using System.Windows.Forms;
using CodeWalker.GameFiles;

namespace mmYtypTool
{
    public partial class JenkinsHashForm : Form
    {
        public JenkinsHashForm()
        {
            InitializeComponent();
        }

        private void textToHashTb_TextChanged(object sender, EventArgs e)
        {
            textToHashOutTb.Text = JenkHash.GenHash(textToHashTb.Text.ToLowerInvariant()).ToString();
        }

        private void hashToTextTb_TextChanged(object sender, EventArgs e)
        {
            uint hash;
            try
            {
                hash = uint.Parse(hashToTextTb.Text);
            }
            catch
            {
                try
                {
                    hash = (uint)int.Parse(hashToTextTb.Text);
                }
                catch
                {
                    hash = 0;
                }
            }

            string g = JenkIndex.TryGetString(hash);

            hashToTextOutTb.Text = string.IsNullOrEmpty(g) ? "Not found" : g;
        }
    }
}
