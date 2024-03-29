﻿using Building.BuildingUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Building
{
    public partial class Form1 : Form
    {
        public BuildingBuilder Builder = new BuildingBuilder();


        public Form1()
        {
            InitializeComponent();
        }



        private void fileImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog import = new OpenFileDialog();
            import.ShowDialog();
            FileTextBox.Text = import.FileName;
        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(FileTextBox.Text);
            String path;

            List<string[]> RoomsList = new List<string[]>();
            List<string[]> LinksList = new List<string[]>();

            listBox1.Items.Clear();
            checkedListBoxFrom.Items.Clear();
            checkedListBoxTo.Items.Clear();

            while ((path = sr.ReadLine()) != null)
            {
                // remove the ; char and replace the spaces with no space :D
                path = path.Trim(';');
                path = path.Replace(" ", "");

                // split the path by commas and assign it to pathDetails array
                string[] pathDetails = path.Split(',');

                // check if the third element is a number, if true we have a room 
                //                                         if false we have a link
                if (int.TryParse(pathDetails[2], out int val))
                {
                    RoomsList.Add(pathDetails);
                }
                else
                {
                    LinksList.Add(pathDetails);
                }
            }

            foreach(var item in RoomsList)
            {
                Room room = new Room(item[0], int.Parse(item[1]), int.Parse(item[2]), int.Parse(item[3]), item[4]);
                Builder.Floor.AddRoom(room);
                checkedListBoxFrom.Items.Add(room.Name);
                checkedListBoxTo.Items.Add(room.Name);
            }

            foreach(var item in LinksList)
            {
                Link link = new Link(item[1], item[2], int.Parse(item[3]), (item[4].ToString().Contains("yes")) ? true : false);
                Room room = new Room();
                Builder.Floor.Rooms.TryGetValue(item[0], out room);

                if(room != null && !room.Links.Contains(link))
                {
                    room.Links.Add(link);
                }

                listBox1.Items.Add($"From: {room.Name} > To: {link.To} / Type: {link.LinkType} / Cost: {link.Cost}");

                // a check for bidirectional rooms 
                // 
                if(link.Bidirectional == true)
                {
                    Room anotherRoom = new Room();
                    foreach(var r in Builder.Floor.Rooms)
                    {
                        if(r.Key == link.To)
                        {
                            Link LinkToFrom = new Link(room.Name, link.LinkType, link.Cost, link.Bidirectional);

                            if (!r.Value.Links.Contains(LinkToFrom) && LinkToFrom.To != r.Key)
                                r.Value.Links.Add(LinkToFrom);

                            listBox1.Items.Add($"From: {r.Value.Name} > To: {room.Name} / Type: {LinkToFrom.LinkType} / Cost: {LinkToFrom.Cost}");
                        }
                    }
                }
            }

            sr.Close();
        }

        // buttons for algorithms 
        private void button1stAlgorithm_Click(object sender, EventArgs e)
        { 
            string from = checkedListBoxFrom.SelectedItem.ToString();
            string to = checkedListBoxTo.SelectedItem.ToString();
            richTextBox1.Text = Builder.NoStairsPath(from, to);
            richTextBox2.Text = Builder.Result;
        }

        private void button2ndAlgorithm_Click(object sender, EventArgs e)
        {
            string from = checkedListBoxFrom.SelectedItem.ToString();
            string to = checkedListBoxTo.SelectedItem.ToString();
            richTextBox1.Text = Builder.FindPathWithLeastSteps(from, to);
            richTextBox2.Text = Builder.Result;
        }

        private void button3rdAlgorithm_Click(object sender, EventArgs e)
        {
            string from = checkedListBoxFrom.SelectedItem.ToString();
            string to = checkedListBoxTo.SelectedItem.ToString();
            richTextBox1.Text = Builder.NoStairsPath(from, to);
            if(Builder.Result == $"No path without stairs from {from} to {to} found.\nTry another way.")
            {
                Builder.Result = "";
                richTextBox1.Text = Builder.FindPathWithLift(from, to);
            }
            richTextBox2.Text = Builder.Result;

        }

        private void clearButton_Click(object sender, EventArgs e)
        { 
            checkedListBoxFrom.SetItemChecked(checkedListBoxFrom.SelectedIndex,false);
            checkedListBoxFrom.SelectedItem = null;
            checkedListBoxTo.SetItemChecked(checkedListBoxTo.SelectedIndex, false);
            checkedListBoxTo.SelectedItem = null;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            Builder.Result = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

