using System;
using System.Text;
using System.Windows.Forms;

namespace GetUserName {
    public partial class Form1 : Form {
        public Form1() => InitializeComponent();

        private void btnGetUserName_Click(object sender, EventArgs e) {
            var builder = new StringBuilder(100);
            var size = 100u;
            WinAPIClass.GetUserNameEx((int)WinAPIClass.NameFormat.NameSamCompatible, builder, ref size);
            lblGetUserName.Text = string.Format("Имя пользователя: {0}", builder.ToString());
        }
    }
}
