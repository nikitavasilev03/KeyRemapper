using HookCore.Models;
using KeyRemapper.Dialogs;
using KeyRemapperCore;
using System;
using System.Windows.Forms;

namespace KeyRemapper
{
    public partial class MainForm : Form
    {
        private readonly RulesController controller;
        private readonly KeysMap keysMap;
        public MainForm()
        {
            InitializeComponent();
            keysMap = new KeysMap();

            controller = new RulesController(
                new ProfilesLoader()
                {
                    Folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KeyRemapper\",
                    FileName = "ProfilesData.data"
                },
                new KeySender(keysMap)
                );
            if (controller.IsListening)
            {
                btnStartKeyListen.Enabled = false;
                btnStopKeyListen.Enabled = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Добавляем профиля 
            foreach (var profile in controller.Manager.Profiles)
                toolStripComboBoxProfiles.Items.Add(profile);
            toolStripComboBoxProfiles.SelectedItem = controller.Manager.CurrentProfile;
            AddProfileRules(controller.Profile);
        }

        private void AddProfileRules(Profile profile)
        {
            foreach (var rule in profile.RulesMap)
                lbRules.Items.Add(rule);
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            RuleManagerDialog dialog = new RuleManagerDialog(keysMap);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                var rule = controller.AddRule(dialog.PressKey, dialog.SendKey);
                if (rule != null)
                {
                    lbRules.Items.Add(rule);
                }
                //Правило блокирующее нажатую клавишу
                rule = controller.AddRule(dialog.PressKey, Key.None);
                if (rule != null)
                {
                    lbRules.Items.Add(rule);
                }
                //Правило блокирующее заменяющую клавишу
                rule = controller.AddRule(dialog.SendKey, Key.None);
                if (rule != null)
                {
                    lbRules.Items.Add(rule);
                }
            }
        }

        private void btnRemoveRule_Click(object sender, EventArgs e)
        {
            if (lbRules.SelectedItem is KeysRule item && controller.RemoveRule(item))
            {
                lbRules.Items.Remove(item);
            }
        }

        private void btnStartKeyListen_Click(object sender, EventArgs e)
        {
            controller.StartKeyListen();
            btnStartKeyListen.Enabled = false;
            btnStopKeyListen.Enabled = true;
        }

        private void btnStopKeyListen_Click(object sender, EventArgs e)
        {
            controller.StopKeyListen();
            btnStartKeyListen.Enabled = true;
            btnStopKeyListen.Enabled = false;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void toolStripMenuICloseWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            notifyIcon1.Visible = true;
        }

        private void toolStripMenuIExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuIOptions_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuIAbout_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuIProfileCreate_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuIProfileEditCurrent_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuIProfileRemoveCurrent_Click(object sender, EventArgs e)
        {

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.SaveChange();
        }
    }
}
