using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace Level_editor
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Dictionary<string, Floor> floorDictionary = new Dictionary<string, Floor>();
        Floor currentFloor = new Floor();

        public Form1()
        {
            InitializeComponent();
        }

        #region Structs and Classes
        struct Item
        {
            Item(int anXValue, int aYValue, Bitmap anImage)
            {
                myX = anXValue;
                myY = aYValue;
                myImage = anImage;
            }

            public int myX, myY;
            public readonly Bitmap myImage;
        };

        struct Character
        {
            public Bitmap MyCharacterImage { get; set; }
        };

        struct Door
        {
            // I have no idea of how to define it, but I know we need some form of "Room-link" to define where a door leads to
            public int myX, myY;
        }

        class Room
        {
            public Dictionary<string, Item> items = new Dictionary<string, Item>();
            public Dictionary<string, Character> characters = new Dictionary<string, Character>();
            public Dictionary<string, Door> doors = new Dictionary<string, Door>();

            public Bitmap MyBackground { get; set; }
        };

        class Floor
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
                floorDictionary.TryGetValue(floorView.FocusedItem.Text, out currentFloor);
                textBox1.Text = floorView.FocusedItem.Text;
                ClearViews();
                UpdateView(ref roomView, currentFloor.myRooms.Keys.Select(x => new ListViewItem(x)).ToArray());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ListViewItem> listedFloors = new List<ListViewItem>();

            for (int index = 0; index < 3; index++)
            {
                listedFloors.Add(new ListViewItem("Floor " + (index + 1)));
                floorDictionary.Add("Floor " + (index + 1), new Floor());
            }

            for (int index = 0; index < 2; index++)
            {
                floorDictionary["Floor 1"].myRooms.Add("Room " + (index + 1), new Room());
            }

            for (int index = 0; index < 3; index++)
            {
                floorDictionary["Floor 1"].myRooms["Room 1"].items.Add("Item " + (index + 1), new Item());
                floorDictionary["Floor 1"].myRooms["Room 1"].characters.Add("Character " + (index + 1), new Character());
                floorDictionary["Floor 1"].myRooms["Room 1"].doors.Add("Door " + (index + 1), new Door());
            }

            floorView.Items.AddRange(listedFloors.ToArray());
            floorView.Update();

            listedFloors.Clear();
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
    }
}
