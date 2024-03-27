namespace CS_3642_Assignment__3
{
    public partial class BlockImageForm : Form
    {
        Label[] labelArray = new Label[4];
        bool[] dark = new bool[4];
        Perceptron perceptron;
        public BlockImageForm()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                Label label = new Label();
                label.Text = " ";
                label.BackColor = Color.White;
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Size = new Size(100, 100);
                label.Location = new Point(300 + (110 * (i % 2)), 100 + (110 * (i / 2)));
                label.Click += onLabelClick;
                labelArray[i] = label;
                dark[i] = false;
                Controls.Add(label);
                //Creates each of the 4 clickable labels
            }
            perceptron = new Perceptron(4);
            //Creates new perceptron with 4 input nodes
            WeightLabel1.Text = "Weight 1: " + perceptron.weights[0].ToString("0.00");
            WeightLabel2.Text = "Weight 2: " + perceptron.weights[1].ToString("0.00");
            WeightLabel3.Text = "Weight 3: " + perceptron.weights[2].ToString("0.00");
            WeightLabel4.Text = "Weight 4: " + perceptron.weights[3].ToString("0.00");
            BiasLabel.Text = "Bias: " + perceptron.weights[4].ToString("0.00");
            //Set the weight labels and bias label to display the default weights / bias
        }

        private void onLabelClick(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            int index = 0;
            for (int i = 0; i < labelArray.Length; i++)
            {
                if (labelArray[i] == label)
                {
                    index = i;
                }
                //Finds the index of the clicked label
            }
            if (label.BackColor == Color.White)
            {
                label.BackColor = Color.Black;
                dark[index] = true;
                //if the label was white convert it to black and set bool in dark array to true
            }
            else if (label.BackColor == Color.Black)
            {
                label.BackColor = Color.White;
                dark[index] = false;
                //if the label was black convert it to white and set bool in dark array to false
            }
            setBrightDarkLabel();
            //Sets the label to display bright or dark based off of changes
        }

        private void setBrightDarkLabel()
        {
            if (perceptron.GetOutputNode(dark))
            {
                BrightDarkLabel.Text = "Dark";
            }
            else
            {
                BrightDarkLabel.Text = "Bright";
            }
            //Sets the text of the label based off of results from perceptron
        }

        private void TrainPerceptronButton_Click(object sender, EventArgs e)
        {
            int[][] trainingDataInt = {
                new[] { 1, 0, 1, 0 },
                new[] { 0, 1, 1, 0 },
                new[] { 1, 1, 1, 0 },
                new[] { 1, 0, 0, 1 },
                new[] { 0, 1, 0, 1 },
                new[] { 1, 1, 0, 1 },
                new[] { 1, 0, 1, 1 },
                new[] { 0, 1, 1, 1 },
            };
            bool[] desiredOutput = { false, false, true, false, false, true, true, true };
            bool[][] trainingData = new bool[trainingDataInt.Length][];
            //Creates the training set and desired output
            for (int y = 0; y < trainingDataInt.Length; y++)
            {
                trainingData[y] = new bool[4];
                for (int x = 0; x < 4; x++)
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
            //Converts the integer training data to boolean

            perceptron.TrainPerceptron(trainingData, desiredOutput);
            //Calls the TrainPerceptron method in the perceptron
            WeightLabel1.Text = "Weight 1: " + perceptron.weights[0].ToString("0.00");
            WeightLabel2.Text = "Weight 2: " + perceptron.weights[1].ToString("0.00");
            WeightLabel3.Text = "Weight 3: " + perceptron.weights[2].ToString("0.00");
            WeightLabel4.Text = "Weight 4: " + perceptron.weights[3].ToString("0.00");
            BiasLabel.Text = "Bias: " + perceptron.weights[4].ToString("0.00");
            setBrightDarkLabel();
            //Updates the weight labels and the bright/dark label
        }
    }
}