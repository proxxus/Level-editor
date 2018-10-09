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
        ObjectType typeToAdd;

        public NewMemberDialog(Form1 aParent, ObjectType aTypeToAdd)
        {
            parent = aParent;
            typeToAdd = aTypeToAdd;
            InitializeComponent();
        }

        private void NewMemberDialog_Load(object sender, EventArgs e)
        {
            switch (typeToAdd)
            {
                case ObjectType.Floor:
                    ShowFloorForm();
                    break;
                case ObjectType.Room:
                    ShowRoomForm();
                    break;
                case ObjectType.Item:
                    ShowItemForm();
                    break;
                case ObjectType.Character:
                    ShowCharacterForm();
                    break;
                case ObjectType.Doors:
                    ShowDoorForm();
                    break;
                default:
                    throw new NullReferenceException();
            }
        }

        private void ShowFloorForm()
        {
            this.Text = "Add New Floor";
            label6.Location = new Point((this.Width / 2) - (label6.Width / 2));
            label6.Show();
            label6.Text = "Name of Floor";
            textBox1.Show();
        }

        private void ShowRoomForm()
        {
        }

        private void ShowItemForm()
        {

        }

        private void ShowCharacterForm()
        {

        }

        private void ShowDoorForm()
        {

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            switch (typeToAdd)
            {
                case ObjectType.Floor:
                    if (((!String.IsNullOrWhiteSpace(label6.Text)) && textBox1.Text.Count() > 3) && !parent.FloorDictionary.Keys.Contains(textBox1.Text))
                    {
                        label6.ForeColor = Color.Black;
                        parent.FloorDictionary.Add(textBox1.Text, new Form1.Floor());
                        parent.UpdateView(parent);
                        this.Close();
                    }
                    else
                    {
                        label6.ForeColor = Color.Red;
                        MessageBox.Show("Name must be 4 or more letters and can't have the same name as another floor");
                    }
                    break;
                case ObjectType.Room:
                    break;
                case ObjectType.Item:
                    break;
                case ObjectType.Character:
                    break;
                case ObjectType.Doors:
                    break;
                default:
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
