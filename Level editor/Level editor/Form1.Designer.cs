namespace Level_editor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.floorView = new System.Windows.Forms.ListView();
            this.roomView = new System.Windows.Forms.ListView();
            this.itemView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.characterView = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.doorView = new System.Windows.Forms.ListView();
            this.btnAddFloor = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnAddCharacter = new System.Windows.Forms.Button();
            this.btnAddDoor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // floorView
            // 
            this.floorView.BackColor = System.Drawing.Color.White;
            this.floorView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorView.HideSelection = false;
            this.floorView.Location = new System.Drawing.Point(452, 12);
            this.floorView.MultiSelect = false;
            this.floorView.Name = "floorView";
            this.floorView.Size = new System.Drawing.Size(286, 184);
            this.floorView.TabIndex = 0;
            this.floorView.UseCompatibleStateImageBehavior = false;
            this.floorView.View = System.Windows.Forms.View.List;
            this.floorView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // roomView
            // 
            this.roomView.HideSelection = false;
            this.roomView.Location = new System.Drawing.Point(452, 270);
            this.roomView.MultiSelect = false;
            this.roomView.Name = "roomView";
            this.roomView.Size = new System.Drawing.Size(286, 184);
            this.roomView.TabIndex = 2;
            this.roomView.UseCompatibleStateImageBehavior = false;
            this.roomView.View = System.Windows.Forms.View.List;
            this.roomView.SelectedIndexChanged += new System.EventHandler(this.roomView_SelectedIndexChanged);
            // 
            // itemView
            // 
            this.itemView.HideSelection = false;
            this.itemView.Location = new System.Drawing.Point(61, 609);
            this.itemView.MultiSelect = false;
            this.itemView.Name = "itemView";
            this.itemView.Size = new System.Drawing.Size(286, 184);
            this.itemView.TabIndex = 3;
            this.itemView.UseCompatibleStateImageBehavior = false;
            this.itemView.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Floors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Characters";
            // 
            // characterView
            // 
            this.characterView.HideSelection = false;
            this.characterView.Location = new System.Drawing.Point(452, 609);
            this.characterView.MultiSelect = false;
            this.characterView.Name = "characterView";
            this.characterView.Size = new System.Drawing.Size(286, 184);
            this.characterView.TabIndex = 7;
            this.characterView.UseCompatibleStateImageBehavior = false;
            this.characterView.View = System.Windows.Forms.View.List;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rooms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(961, 577);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Doors";
            // 
            // doorView
            // 
            this.doorView.HideSelection = false;
            this.doorView.Location = new System.Drawing.Point(843, 609);
            this.doorView.MultiSelect = false;
            this.doorView.Name = "doorView";
            this.doorView.Size = new System.Drawing.Size(286, 184);
            this.doorView.TabIndex = 9;
            this.doorView.UseCompatibleStateImageBehavior = false;
            this.doorView.View = System.Windows.Forms.View.List;
            // 
            // btnAddFloor
            // 
            this.btnAddFloor.Location = new System.Drawing.Point(559, 202);
            this.btnAddFloor.Name = "btnAddFloor";
            this.btnAddFloor.Size = new System.Drawing.Size(75, 23);
            this.btnAddFloor.TabIndex = 12;
            this.btnAddFloor.Text = "Add Floor";
            this.btnAddFloor.UseVisualStyleBackColor = true;
            this.btnAddFloor.Click += new System.EventHandler(this.btnAddFloor_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(559, 460);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoom.TabIndex = 13;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(159, 799);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 14;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnAddCharacter
            // 
            this.btnAddCharacter.Location = new System.Drawing.Point(550, 799);
            this.btnAddCharacter.Name = "btnAddCharacter";
            this.btnAddCharacter.Size = new System.Drawing.Size(93, 23);
            this.btnAddCharacter.TabIndex = 15;
            this.btnAddCharacter.Text = "Add Character";
            this.btnAddCharacter.UseVisualStyleBackColor = true;
            this.btnAddCharacter.Click += new System.EventHandler(this.btnAddCharacter_Click);
            // 
            // btnAddDoor
            // 
            this.btnAddDoor.Location = new System.Drawing.Point(946, 799);
            this.btnAddDoor.Name = "btnAddDoor";
            this.btnAddDoor.Size = new System.Drawing.Size(75, 23);
            this.btnAddDoor.TabIndex = 16;
            this.btnAddDoor.Text = "Add Door";
            this.btnAddDoor.UseVisualStyleBackColor = true;
            this.btnAddDoor.Click += new System.EventHandler(this.btnAddDoor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 857);
            this.Controls.Add(this.btnAddDoor);
            this.Controls.Add(this.btnAddCharacter);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.btnAddFloor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.doorView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.characterView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemView);
            this.Controls.Add(this.roomView);
            this.Controls.Add(this.floorView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Level editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView floorView;
        private System.Windows.Forms.ListView roomView;
        private System.Windows.Forms.ListView itemView;
        private System.Windows.Forms.ListView characterView;
        private System.Windows.Forms.ListView doorView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddFloor;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnAddCharacter;
        private System.Windows.Forms.Button btnAddDoor;
    }
}

