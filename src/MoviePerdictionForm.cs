using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_3642_Assignment__3
{
    public partial class MoviePerdictionForm : Form
    {
        CheckBox[] checkBoxArray;
        Label[] labelArray;
        Perceptron perceptron;
        public MoviePerdictionForm()
        {
            InitializeComponent();
            int y = 25;
            int x = 50;
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(96, 128);
            AddImages(imageList);
            //Creates a new imageList and add movie poster to the list
            checkBoxArray = new CheckBox[imageList.Images.Count];
            labelArray = new Label[imageList.Images.Count];
            //Creates array's to keep track of the checkBox's and their associated labels
            perceptron = new Perceptron(checkBoxArray.Length);
            perceptron.SetEpochs(100000);
            //Creates new perceptron with a set  epochs of 100000
            for (int i = 0; i < imageList.Images.Count; i++)
            {
                if (i == 6)
                {
                    y = 25;
                    x += 350;
                    //If the row is full start a new row
                }
                CheckBox checkBox = new CheckBox();
                checkBox.Size = new Size(150, 128);
                checkBox.Text = "";
                checkBox.Image = imageList.Images[i];
                checkBox.CheckedChanged += CheckRecommened;
                checkBox.Location = new Point(x, y);
                checkBoxArray[i] = checkBox;
                Controls.Add(checkBox);
                //Creates and add a checkbox with movie poster

                Label label = new Label();
                label.Text = "Weight: " + perceptron.weights[i].ToString("0.00");
                label.Location = new Point(x + checkBox.Width, y + 60);
                labelArray[i] = label;
                Controls.Add(label);
                //Creates the weight label assiocted with the movie
                y += 150;
            }
            Size = new Size(1200, y + 50);
            AddRecommendation();
            //Change the size of the form and calls AddRecommendation method
        }

        private void CheckRecommened(Object sender, EventArgs e)
        {
            bool[] bitArray = GetBitArray();
            //Gets the bitArray from checked checkboxes
            if (perceptron.GetOutputNode(bitArray))
            {
                label.Text = "Would Recommend";
            }
            else
            {
                label.Text = "Wouldn't Recommend";
            }
            //Updates the label based off of perceptron output
        }

        private bool[] GetBitArray()
        {
            bool[] bitArray = new bool[checkBoxArray.Length];
            for (int i = 0; i < bitArray.Length; i++)
            {
                if (checkBoxArray[i].Checked)
                {
                    bitArray[i] = true;
                }
                else
                {
                    bitArray[i] = false;
                }
            }
            return bitArray;
            //Makes and returns a bitArray repesenting which checkedboxs are checked
        }

        private void AddImages(ImageList imageList)
        {
            imageList.Images.Add(Image.FromFile("Movie Poster\\21 Jump Street.jpg"));
            imageList.Images.Add(Image.FromFile("Movie Poster\\Avatar.jpg"));
            imageList.Images.Add(Image.FromFile("Movie Poster\\Blade Runner.jpg"));
            imageList.Images.Add(Image.FromFile("Movie Poster\\Dark Knight.jpg"));
            imageList.Images.Add(Image.FromFile("Movie Poster\\Frozen.jpg"));
            imageList.Images.Add(Image.FromFile("Movie Poster\\Halloween.jpg"));
            imageList.Images.Add(Image.FromFile("Movie Poster\\Jaws.jpg"));
            imageList.Images.Add(Image.FromFile("Movie Poster\\Jurassicic Park.jpg"));
            imageList.Images.Add(Image.FromFile("Movie Poster\\Lord of the Rings.jpg"));
            imageList.Images.Add(Image.FromFile("Movie Poster\\Monster's Inc.jpg"));
            imageList.Images.Add(Image.FromFile("Movie Poster\\The Martian.jpg"));
            imageList.Images.Add(Image.FromFile("Movie Poster\\Titanic.jpg"));
            //Adds images to the image list from files
        }

        private void AddRecommendation()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(256, 384);
            pictureBox.Image = Image.FromFile("Movie Poster\\The Matrix.jpg");
            pictureBox.Location = new Point(800, (this.Height / 2) - (pictureBox.Height / 2));
            Controls.Add(pictureBox);
            //Add the pictire box with the recommened movie

            label.Location = new Point(800, (pictureBox.Location.Y + (pictureBox.Height + 50)));
            label.Text = "Wouldn't Recommend";
            //Move the label to be under the picture box

            TrainButton.Location = new Point(800 + (pictureBox.Width / 2 - TrainButton.Width / 2), label.Location.Y + 50);
            //Move the train button to be under the picture box
        }

        private void SetWeightLabels()
        {
            for (int i = 0; i < labelArray.Length; i++)
            {
                labelArray[i].Text = "Weight: " + perceptron.weights[i].ToString("0.00");
            }
            //Updates the weight label with new values
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            int[][] trainingDataInt = {
                new[] { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new[] { 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0 },
                new[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                new[] { 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0 },
                new[] { 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0 },
                new[] { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                new[] { 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0 },
                new[] { 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                new[] { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
                new[] { 1, 0, 0, 0, 1, 1, 1, 1, 0, 1, 0, 1 },
                new[] { 0, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                new[] { 0, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0 },
                new[] { 1, 0, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1 },
                new[] { 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
                new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                new[] { 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
                new[] { 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1, 1 },
                new[] { 1, 1, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0 },
                new[] { 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1 },
                new[] { 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 1 },
                new[] { 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1 },
                new[] { 0, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1 },
                new[] { 1, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 1 },
                new[] { 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 1 },
                new[] { 0, 1, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0 },
                new[] { 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                new[] { 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                new[] { 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1 },
                new[] { 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1 },
                new[] { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new[] { 1, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0 },
                new[] { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                new[] { 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0 },
                new[] { 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0 },
                new[] { 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1 },
                new[] { 1, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 1 },
                new[] { 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
                new[] { 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1 },
                new[] { 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1 },
                new[] { 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0 }
            };
            bool[] desiredOutput = {
                true,
                false,
                false,
                false,
                true,
                true,
                true,
                false,
                true,
                false,
                false,
                false,
                true,
                false,
                true,
                true,
                false,
                true,
                false,
                true,
                true,
                true,
                false,
                true,
                false,
                false,
                false,
                true,
                false,
                false,
                false,
                false,
                true,
                false,
                false,
                false,
                true,
                false,
                false,
                false,
                true
            };
            //Creates a bunch of training data
            bool[][] trainingData = new bool[trainingDataInt.Length][];
            for (int y = 0; y < trainingDataInt.Length; y++)
            {
                trainingData[y] = new bool[12];
                for (int x = 0; x < 12; x++)
                {
                    if (trainingDataInt[y][x] == 1)
                    {
                        trainingData[y][x] = true;
                    }
                    else
                    {
                        trainingData[y][x] = false;
                    }
                }
            }
            //Converts int training data to boolean
            perceptron.TrainPerceptron(trainingData, desiredOutput);
            SetWeightLabels();
            //Calls the TrainPerceptron method and updates the weightLabels
        }
    }
}