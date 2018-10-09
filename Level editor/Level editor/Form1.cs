using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace Level_editor
{
    // Reffering to level editor objects
    public enum ObjectType
    {
        Floor,
        Room,
        Item,
        Character,
        Doors
    };

    public partial class Form1 : System.Windows.Forms.Form
    {
        // Keeps track of our last marked floor and it's rooms, and their items, characters and doors.
        Floor currentFloor = new Floor();

        #region Properties
        public Dictionary<string, Floor> FloorDictionary { get; set; } = new Dictionary<string, Floor>();
        public Dictionary<string, Item> CurrentItems { get => (roomView.FocusedItem != null) ? currentFloor.myRooms[roomView.FocusedItem.Text].items : null; set => currentFloor.myRooms[roomView.FocusedItem.Text].items = value; }
        public Floor CurrentFloor { get => currentFloor; }
        public ListView FloorView { get; set; }
        public ListView FloorView { get; set; }
        public ListView FloorView { get; set; }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region Structs and Classes
        public struct Item
        {
            Item(int anXValue, int aYValue, int aWidth, int aHeight, Bitmap anImage)
            {
                myX = anXValue;
                myY = aYValue;
                myWidth = aWidth;
                myHeight = aHeight;
                myImage = anImage;
            }

            public int myX, myY, myWidth, myHeight;
            public Bitmap myImage;
        };

        public struct Character
        {
            public Bitmap MyCharacterImage { get; set; }
        };

        public struct Door
        {
            // I have no idea of how to define it, but I know we need some form of "Room-link" to define where a door leads to
            public int myX, myY;
        }

        public class Room
        {
            public Dictionary<string, Item> items = new Dictionary<string, Item>();
            public Dictionary<string, Character> characters = new Dictionary<string, Character>();
            public Dictionary<string, Door> doors = new Dictionary<string, Door>();

            public Bitmap MyBackground { get; set; }
        };

        public class Floor
        {
            public Dictionary<string, Room> myRooms = new Dictionary<string, Room>();
        };
        #endregion

        #region Utilities
        public void ClearViews()
        {
            roomView.Clear();
            itemView.Clear();
            characterView.Clear();
            doorView.Clear();
        }

        public void UpdateView(ref ListView aListView, ListViewItem[] aListOfItems)
        {
            aListView.Clear();
            aListView.Items.AddRange(aListOfItems);
        }
        #endregion

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (floorView.FocusedItem != null)
            {
                FloorDictionary.TryGetValue(floorView.FocusedItem.Text, out currentFloor);
                ClearViews();
                UpdateView(ref roomView, currentFloor.myRooms.Keys.Select(x => new ListViewItem(x)).ToArray());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void roomView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomView.FocusedItem != null)
            {
                UpdateView(ref itemView, currentFloor.myRooms[roomView.FocusedItem.Text].items.Keys.Select(x => new ListViewItem(x)).ToArray());
                UpdateView(ref characterView, currentFloor.myRooms[roomView.FocusedItem.Text].characters.Keys.Select(x => new ListViewItem(x)).ToArray());
                UpdateView(ref doorView, currentFloor.myRooms[roomView.FocusedItem.Text].doors.Keys.Select(x => new ListViewItem(x)).ToArray());
            }
        }

        private void btnAddFloor_Click(object sender, EventArgs e)
        {
            NewMemberDialog createItem = new NewMemberDialog(this, ObjectType.Floor);
            createItem.ShowDialog(this);
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            NewMemberDialog createItem = new NewMemberDialog(this, ObjectType.Floor);
            createItem.ShowDialog(this);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            NewMemberDialog createItem = new NewMemberDialog(this, ObjectType.Floor);
            createItem.ShowDialog(this);
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            NewMemberDialog createItem = new NewMemberDialog(this, ObjectType.Floor);
            createItem.ShowDialog(this);
        }

        private void btnAddDoor_Click(object sender, EventArgs e)
        {
            NewMemberDialog createItem = new NewMemberDialog(this, ObjectType.Floor);
            createItem.ShowDialog(this);
        }
    }
}
