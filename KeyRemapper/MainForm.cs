using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using KeyHookCore;

namespace KeyRemapper
{
    public partial class MainForm : Form
    {
        public KeyboardKeyHook KeyboardHook { get; set; }
        public Dictionary<Keys, Keys> RulesMap { get; set; } = new Dictionary<Keys, Keys>();
        private readonly KeysMap KeysMap = new KeysMap();
        private KeysPair currentRule;

        public MainForm()
        {
            InitializeComponent();

            KeyboardHook = new KeyboardKeyHook();
            KeyboardHook.KeyPress += KeyboardHookOnKeyPress;
            KeyboardHook.ManageHook += ManageHook;
        }


        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }

        private HookResult ManageHook(Keys key)
        {
            if (currentRule != null && currentRule.KeyPress == key)
            {
                currentRule = null;
                return HookResult.NoRelease;
            }
            return HookResult.Release;
        }

        private void KeyboardHookOnKeyPress(KeyEventArgs args)
        {
            Keys key = args.KeyCode;
            if (currentRule == null && RulesMap.Keys.Contains(key))
            {
                currentRule = new KeysPair(key, RulesMap[key]);
                string message = KeysMap[RulesMap[key]];
                SendKeys.Send(message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopKeyListen();
        }

        public void StartKeyListen()
        {
            if (KeyboardHook != null && !KeyboardHook.Hooked)
                KeyboardHook.Hook();
        }

        public void StopKeyListen()
        {
            if (KeyboardHook != null && KeyboardHook.Hooked)
                KeyboardHook.Unhook();
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            RuleManagerDialog dialog = new RuleManagerDialog(KeysMap);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                var currentKey = dialog.CurrentKey;
                var changeKey = dialog.ChangeKey;

                if (currentKey != changeKey)
                {
                    if (changeKey != Keys.None)
                        RulesMap.Add(currentKey, Keys.None);
                    RulesMap.Add(changeKey, currentKey);
                    RefreshListBox();
                }
            }
        }

        private void btnRemoveRule_Click(object sender, EventArgs e)
        {
            int index = lbRules.SelectedIndex;
            if (index >= 0)
            {
                var item = RulesMap.ElementAt(index);
                RulesMap.Remove(item.Key);
                RefreshListBox();
            }
        }

        public void RefreshListBox()
        {
            lbRules.Items.Clear();
            foreach (var item in RulesMap)
                lbRules.Items.Add($"{item.Value} -> {item.Key}");
        }

        private void btnStartKeyListen_Click(object sender, EventArgs e)
        {
            StartKeyListen();
            btnStartKeyListen.Enabled = false;
            btnStopKeyListen.Enabled = true;
        }

        private void btnStopKeyListen_Click(object sender, EventArgs e)
        {
            StopKeyListen();
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
    }
}
