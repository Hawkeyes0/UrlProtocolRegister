using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace UrlProtocolRegister
{
    public partial class Form1 : Form
    {
        public string ProtocolName
        {
            set
            {
                tProtocol.Text = value;
                tProtocol.Enabled = false;
            }
        }

        public string Path
        {
            set
            {
                if (File.Exists(value))
                {
                    tPath.Text = value;
                    bBrowse.Enabled = false;
                }
            }
        }

        public bool UseParam
        {
            set
            {
                cbUseParam.Checked = value;
                cbUseParam.Enabled = false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            if (fdBrowse.ShowDialog() == DialogResult.OK)
            {
                tPath.Text = fdBrowse.FileName;
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            RegisteUrlProtocol(tProtocol.Text, tPath.Text, cbUseParam.Checked);
        }

        public void RegisteUrlProtocol(string protocolName, string path, bool useParam)
        {
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(protocolName, true);
            RegistryKey shell, open, command;
            string cmd;

            if (string.IsNullOrEmpty(protocolName))
            {
                MessageBox.Show("没有指定协议名称。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("没有选择关联的程序。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(path) || !path.Contains(".exe"))
            {
                MessageBox.Show("选择的关联程序不是可执行文件或不存在。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (key != null)
            {
                if (MessageBox.Show("协议名称：" + protocolName + " 已经存在。是否覆盖？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }
            else
            {
                key = Registry.ClassesRoot.CreateSubKey(protocolName);
                key.SetValue("", "Url:" + protocolName + " Protocol", RegistryValueKind.String);
                key.SetValue("URL Protocol", path, RegistryValueKind.String);

                key.CreateSubKey("DefaultIcon").SetValue("", path + ",1");

                shell = key.CreateSubKey("shell");
                open = shell.CreateSubKey("open");
                command = open.CreateSubKey("command");
                cmd = "\"" + path + "\"";
                if (useParam)
                    cmd += " \"%1\"";
                command.SetValue("", cmd);

                MessageBox.Show("协议 " + protocolName + " 注册完毕", "成功");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!tProtocol.Enabled && !bBrowse.Enabled && !cbUseParam.Enabled)
            {
                RegisteUrlProtocol(tProtocol.Text, tPath.Text, cbUseParam.Checked);
                Close();
            }
        }
    }
}
