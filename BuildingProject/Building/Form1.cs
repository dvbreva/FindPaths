using Building.BuildingUtils;
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

            sr.Close();
        }


    }
}

