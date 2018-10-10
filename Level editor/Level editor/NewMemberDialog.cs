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

            //button2.Text = "Set BGM";
            //button2.Show();

            //label2.Text = "BGM (if any) for the room";
            //label2.Show();

            label6.Text = "Name of Room";
            label6.Show();

            textBox1.Show();

            // Definition of the function our buttons execute when pressed - button1
            buttonDelegate[0] = () =>
            {
                OpenFileDialog getImage = new OpenFileDialog();
                getImage.Filter = "Image files (*.png, *.jpg, *.jpeg) | *.png; *.jpg; *.jpeg";
                getImage.RestoreDirectory = true;
                getImage.CheckFileExists = true;
                getImage.CheckPathExists = true;

                if (getImage.ShowDialog() == DialogResult.OK)
                {
                    workingStructure.MyBackground = new Bitmap(getImage.FileName);
                }
                return 0;
            };
        }

        private void InitItemForm()
        {
            workingStructure = new Form1.Room();
            this.Text = "Add New Item";

            button1.Text = "Set Image";
            button1.Show();

            label1.Text = "Item Image";
            label1.Show();

            label6.Text = "Name of Item";
            label6.Show();

            label7.Text = "Item Description";
            label7.Show();

            textBox1.Show();
            descriptionBox.Show();

            // Definition of the function our buttons execute when pressed - button1
            buttonDelegate[0] = () =>
            {
                OpenFileDialog getImage = new OpenFileDialog();
                getImage.Filter = "Image files (*.png, *.jpg, *.jpeg) | *.png; *.jpg; *.jpeg";
                getImage.RestoreDirectory = true;
                getImage.CheckFileExists = true;
                getImage.CheckPathExists = true;

                if (getImage.ShowDialog() == DialogResult.OK)
                {
                    workingStructure.MyBackground = new Bitmap(getImage.FileName);
                }
                return 0;
            };

            // button2
            buttonDelegate[1] = () =>
            {
                GetDimensions dimensionDialog = new GetDimensions(ref workingStructure);
                dimensionDialog.Show();
                return 0;
            };
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

                    if (CheckNameField("Name must be atleast 3 letters and can't be named the same as another floor.", label6, textBox1, parent.FloorDictionary.Keys.ToArray()))
                    {
                        parent.FloorDictionary.Add(textBox1.Text, workingStructure);
                        parent.UpdateView(ref parent.GetView(typeToAdd), parent.FloorDictionary.Keys.Select(x => new ListViewItem(x)).ToArray());
                        this.Close();
                    }
                    break;
                case ObjectType.Room:
                    bool[] isValid = new bool[2];

                    isValid[0] = CheckNameField("Name must be atleast 3 letters and can't be named the same as another room on this floor.", label6, textBox1, parent.CurrentRooms.Keys.ToArray());
                    isValid[1] = IsValidImage(workingStructure.MyBackground, label1);

                    for (int index = 0; index < isValid.Length; index++)
                    {
                        if (!isValid[index])
                        { break; }

                        if (index == isValid.Length - 1)
                        {
                            parent.CurrentRooms.Add(textBox1.Text, workingStructure);
                            parent.UpdateView(ref parent.GetView(typeToAdd), parent.CurrentRooms.Keys.Select(x => new ListViewItem(x)).ToArray());
                            this.Close();
                        }
                    }
                    break;
                case ObjectType.Item:
                    //CheckNameField();
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

        private void button2_Click(object sender, EventArgs e)
        {
            buttonDelegate[1].Invoke();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonDelegate[2].Invoke();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonDelegate[3].Invoke();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonDelegate[4].Invoke();
        }

        private bool CheckNameField(string aHelpMessage, Label anInfoLabel, TextBox anInputTextBox, string[] aCollection)
        {
            if (((!String.IsNullOrWhiteSpace(anInfoLabel.Text)) && textBox1.Text.Count() > 2) && !aCollection.Contains(anInputTextBox.Text))
            {
                anInfoLabel.ForeColor = Color.Black;
                return true;
            }
            else
            {
                anInfoLabel.ForeColor = Color.Red;
                MessageBox.Show(aHelpMessage);
                return false;
            }
        }

        private bool IsValidImage(Bitmap anImageToCheck, Label anInfoLabel)
        {
            if (anImageToCheck == null)
            {
                anInfoLabel.ForeColor = Color.Red;
                MessageBox.Show("You must assign a valid image!");
                return false;
            }
            else
            {
                anInfoLabel.ForeColor = Color.Black;
                return true;
            }
        }
    }
}