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
        Func<int>[] buttonDelegate;
        dynamic workingStructure;

        public NewMemberDialog(Form1 aParent, ObjectType aTypeToAdd)
        {
            parent = aParent;
            typeToAdd = aTypeToAdd;
            buttonDelegate = new Func<int>[5];
            InitializeComponent();
        }

        private void NewMemberDialog_Load(object sender, EventArgs e)
        {
            
            switch (typeToAdd)
            {
                case ObjectType.Floor:
                    InitFloorForm();
                    break;
                case ObjectType.Room:
                    InitRoomForm();
                    break;
                case ObjectType.Item:
                    InitItemForm();
                    break;
                case ObjectType.Character:
                    InitCharacterForm();
                    break;
                case ObjectType.Door:
                    InitDoorForm();
                    break;
                default:
                    throw new NullReferenceException();
            }
        }

        private void InitFloorForm()
        {
            workingStructure = new Form1.Floor();
            this.Text = "Add New Floor";

            label6.Text = "Name of Floor";
            label6.Location = new Point((this.Width / 2) - (label6.Width / 2), label6.Location.Y);
            label6.Show();

            textBox1.Location = new Point((this.Width / 2) - (textBox1.Width / 2), textBox1.Location.Y);
            textBox1.Show();
        }

        private void InitRoomForm()
        {
            workingStructure = new Form1.Room();
            this.Text = "Add New Room";

            button1.Text = "Set Image";
            button1.Show();

            label1.Text = "Background Image";
            label1.Show();

            button2.Text = "Set BGM";
            button2.Show();

            label2.Text = "BGM (if any) for the room";
            label2.Show();

            label6.Text = "Name of Room";
            label6.Show();

            textBox1.Show();

            buttonDelegate[0] = () =>
            {
                OpenFileDialog getImage = new OpenFileDialog();
                getImage.Filter = "Image files (*.png|*.jpg|*.jpeg)";
                getImage.RestoreDirectory = true;

                if (getImage.ShowDialog() == DialogResult.OK)
                {
                    
                }
                return 0;
            };
        }

        private void InitItemForm()
        {

        }

        private void InitCharacterForm()
        {

        }

        private void InitDoorForm()
        {

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            switch (typeToAdd)
            {
                case ObjectType.Floor:
                    if (((!String.IsNullOrWhiteSpace(label6.Text)) && textBox1.Text.Count() > 2) && !parent.FloorDictionary.Keys.Contains(textBox1.Text))
                    {
                        label6.ForeColor = Color.Black;
                        parent.FloorDictionary.Add(textBox1.Text, workingStructure);
                        parent.UpdateView(ref parent.GetView(), parent.FloorDictionary.Keys.Select(x => new ListViewItem(x)).ToArray());
                        this.Close();
                    }
                    else
                    {
                        label6.ForeColor = Color.Red;
                        MessageBox.Show("Name must be atleast 3 letters and can't be named the same as another floor.");
                    }
                    break;
                case ObjectType.Room:
                    break;
                case ObjectType.Item:
                    break;
                case ObjectType.Character:
                    break;
                case ObjectType.Door:
                    break;
                default:
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonDelegate[0].Invoke();
        }
    }
}
