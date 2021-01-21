using System;
using System.Linq;
using System.Windows.Forms;
using HookCore.Models;
using KeyRemapperCore;

namespace KeyRemapper.Dialogs
{
    public partial class RuleManagerDialog : Form
    {
        public Key PressKey { get; set; }
        public Key SendKey { get; set; }

        public RuleManagerDialog(KeysMap map)
        {
            InitializeComponent();

            cbSendKey.TabStop = false;
            cbPressKey.TabStop = false;
            gbChange.TabStop = false;
            button1.TabStop = false;

            var keysMap = map.Map.Keys.ToList();
            foreach (var item in keysMap)
            {
                cbSendKey.Items.Add(item);
                cbPressKey.Items.Add(item);
            }
        }

        private void RuleManagerDialog_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cbCurrentKey_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void cbCurrentKey_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void cbCurrentKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            SendKey = (Key)cbSendKey.SelectedItem;
        }

        private void cbChangeKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            PressKey = (Key)cbPressKey.SelectedItem;
        }
    }
}
