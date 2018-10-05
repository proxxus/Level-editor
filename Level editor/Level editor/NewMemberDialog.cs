using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level_editor
{
    public partial class NewMemberDialog : System.Windows.Forms.Form
    {
        Form1 parent;
        string typeToAdd;

        public NewMemberDialog(Form1 aParent, string aTypeToAdd)
        {
            parent = aParent;
            typeToAdd = aTypeToAdd;
            InitializeComponent();
        }

        private void NewMemberDialog_Load(object sender, EventArgs e)
        {
            parent.FloorDictionary.Add("Simple Floor", new Form1.Floor());
        }
    }
}
