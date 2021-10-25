using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mmYtypTool
{
    public partial class EnterNameForm : Form
    {
        Delegate _action;
        public EnterNameForm(Delegate action)
        {
            InitializeComponent();
            _action = action;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            _action.DynamicInvoke(enterNameTb.Text);
            submitBtn.Text = "";
            this.Close();
        }
    }
}
