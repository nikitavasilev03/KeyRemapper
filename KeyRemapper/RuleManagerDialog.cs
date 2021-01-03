using System;
using System.Linq;
using System.Windows.Forms;

namespace KeyRemapper
{
    public partial class RuleManagerDialog : Form
    {
        public Keys CurrentKey { get; set; }
        public Keys ChangeKey { get; set; }

        public RuleManagerDialog(KeysMap map)
        {
            InitializeComponent();

            cbCurrentKey.TabStop = false;
            cbChangeKey.TabStop = false;
            gbChange.TabStop = false;
            button1.TabStop = false;


            var keysMap = map.Map.Keys.ToList();
            foreach (var item in keysMap)
            {
                cbCurrentKey.Items.Add(item);
                cbChangeKey.Items.Add(item);
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
            CurrentKey = (Keys)cbCurrentKey.SelectedItem;
        }

        private void cbChangeKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeKey = (Keys) cbChangeKey.SelectedItem;
        }
    }
}
