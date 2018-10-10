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
    public partial class GetDimensions : Form
    {
        dynamic workingStructure;

        public GetDimensions(ref dynamic aWorkingStructure)
        {
            workingStructure = aWorkingStructure;
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (VerifyTextBoxArray(new TextBox[] { textBoxXPos, textBoxYPos, textBoxWidth, textBoxHeight }))
            {
                workingStructure.myX = textBoxXPos.Text;
                workingStructure.myY = textBoxYPos.Text;
                workingStructure.myWidth = textBoxWidth.Text;
                workingStructure.myHeight = textBoxHeight.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid input in one or more fields!\nPlease correct and try again.");
            }
        }

        private bool VerifyTextBoxArray(TextBox[] someTextBoxes)
        {
            bool isValid = true;
            char[] allowedCharacters = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < someTextBoxes.Length; i++)
            {
                foreach (char anAllowedCharacter in someTextBoxes[i].Text)
                {
                    someTextBoxes[i].ForeColor = Color.Red;

                    if (!allowedCharacters.Contains(anAllowedCharacter))
                    {
                        someTextBoxes[i].ForeColor = Color.Red;
                        isValid = false;
                    }
                }
            }
            return isValid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
