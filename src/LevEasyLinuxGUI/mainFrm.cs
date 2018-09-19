using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LevEasyLinuxGUI
{
    public partial class mainFrm : Form
    {
        private static readonly string VNC_PASSWORD_HINT = "Mật khẩu VNC cần ít hơn 8 kí tự chữ hoặc số";
        private static readonly string MAIN_FORM_TITLE = "Lev Easy Linux GUI by https://lowendviet.com|";
        private static readonly string VERSION = Assembly.GetEntryAssembly().GetName().Version.ToString();

        private static readonly string ERR_PLINK_NOT_FOUND = @"Ứng dụng cần plink để kết nối tới VPS. Nếu bạn chưa có, hãy tải plink tại
                https://the.earth.li/~sgtatham/putty/latest/w32/plink.exe và đặt vào cùng thư mục với tool này!";
        private static readonly string ERR_PUTTYGEN_NOT_FOUND = @"Bạn đang sử dụng file key định dạng PEM. Với định dạng này, ứng dụng cần puttygen để sử dụng key.
                Nếu bạn chưa có, hãy tải puttygen tại https://the.earth.li/~sgtatham/putty/latest/w32/puttygen.exe và đặt vào cùng thư mục với tool này!";
        private static readonly string ERR_EMPTY_FIELD = " không được bỏ trống!";

        private static readonly string SCRIPT_URL = "https://raw.githubusercontent.com/chieunhatnang/easyLinuxGUI/master/Scripts/easylinuxgui.sh";
        private static readonly string SCRIPT_NAME = "easylinuxgui.sh";

        public mainFrm()
        {
            InitializeComponent();
            txtVNCPassword.GotFocus += new System.EventHandler(txtVNCPassword_Focus);
            txtVNCPassword.LostFocus += new System.EventHandler(txtVNCPassword_LostFocus);
            txtVNCPassword.Text = VNC_PASSWORD_HINT;

            this.Text = MAIN_FORM_TITLE + VERSION;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void rdPass_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPass.Checked)
            {
                txtVPSPassword.Enabled = true;
                txtVPSKeyPath.Enabled = false;
                btnKeyBrowse.Enabled = false;
            }
            else
            {
                txtVPSPassword.Enabled = false;
                txtVPSKeyPath.Enabled = true;
                btnKeyBrowse.Enabled = true;
            }
        }

        private void btnKeyBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Linux key file (*.pem)|*.pem|Putty key file (*.ppk)|*.ppk";
            dlg.FilterIndex = 1;
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtVPSKeyPath.Text = dlg.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: IO error. Original error: " + ex.Message);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //Check lib
                if (!File.Exists(@"plink.exe"))
                {
                    MessageBox.Show(ERR_PLINK_NOT_FOUND, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Check input
                foreach (Control c in new Control[] { txtIP, txtVPSUsername, txtVPSKeyPath, txtVPSPassword, txtVNCPassword })
                {
                    if (c.Enabled && (string.IsNullOrEmpty(c.Text) || c.Text == VNC_PASSWORD_HINT))
                    {
                        MessageBox.Show(c.Text + ERR_EMPTY_FIELD, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        c.Focus();
                        return;
                    }
                }

                string ip = txtIP.Text.Trim();
                string vncPassword = txtVNCPassword.Text.Trim();

                string command = ip + " -P 22 " + " -l " + txtVPSUsername.Text.Trim() + " ";

                if (rdPass.Checked)
                {
                    command += " -pw " + txtVPSPassword.Text.Trim();
                }
                if (rdKey.Checked)
                {
                    if (Path.GetExtension(txtVPSKeyPath.Text) == ".pem")
                    {
                        string convertedKeyPath = Path.GetDirectoryName(txtVPSKeyPath.Text) + "\\" + Path.GetFileNameWithoutExtension(txtVPSKeyPath.Text) + ".ppk";
                        var keyLines = File.ReadAllLines(txtVPSKeyPath.Text);
                        var keyBytes = System.Convert.FromBase64String(string.Join("", keyLines.Skip(1).Take(keyLines.Length - 2)));
                        var puttyKey = RSAConverter.FromDERPrivateKey(keyBytes).ToPuttyPrivateKey();
                        File.WriteAllText(convertedKeyPath, puttyKey);

                        command += " -i " + convertedKeyPath.Trim();
                    }
                    if(Path.GetExtension(txtVPSKeyPath.Text) == ".ppk")
                    {
                        command += " -i " + txtVPSKeyPath.Text.Trim();
                    }
                }


                command += " \\\"\\\"wget " + SCRIPT_URL + " -O " + SCRIPT_NAME + " && chmod 777 " + SCRIPT_NAME + " && ./" + SCRIPT_NAME + " "
                        + vncPassword + " " + getParam(chkFF.Checked) + " " + getParam(chkChrome.Checked) + " " + getParam(chkWine.Checked) + "\\\"\\\"";

                // Auto accept host key
                //command = "/c echo y | plink.exe " + command + " && read";
                Thread t = new Thread(() =>
                {
                    CMDWrapper.runExternalExe(@"plink.exe", command);
                    MessageBox.Show("Hoàn thành cài đặt! Bạn hãy sử dụng VNCViewer để kết nối tới địa chỉ: " + ip + ":5901, password: "
                        + vncPassword + ". Have a nice day!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                });

                t.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "More detail: >>>" + Environment.NewLine + ex.ToString(), 
                    "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtVNCPassword_Focus(object sender, EventArgs e)
        {
            if (txtVNCPassword.Text == VNC_PASSWORD_HINT)
            {
                txtVNCPassword.Text = "";
            }
        }

        private void txtVNCPassword_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVNCPassword.Text))
            {
                txtVNCPassword.Text = VNC_PASSWORD_HINT;
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(((LinkLabel)sender).Text);
        }

        private string getParam(bool c)
        {
            if (c)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
    }
}
