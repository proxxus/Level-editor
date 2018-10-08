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
                    FloorForm();
                    break;
                case ObjectType.Room:
                    RoomForm();
                    break;
                case ObjectType.Item:
                    ItemForm();
                    break;
                case ObjectType.Character:
                    CharacterForm();
                    break;
                case ObjectType.Doors:
                    DoorForm();
                    break;
                default:
                    throw new NullReferenceException();
            }
        }

        private void FloorForm()
        {
            
        }

        private void RoomForm()
        {

        }

        private void ItemForm()
        {

        }

        private void CharacterForm()
        {

        }

        private void DoorForm()
        {

        }
    }
}
