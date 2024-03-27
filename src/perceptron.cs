using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_3642_Assignment__3
{
    internal class Perceptron
    {
        bool[] inputNodes;
        public double[] weights;
        double learningRate = 0.01;
        int epochs = 1000;
        //Creates varables
        public Perceptron(int numOfInputs)
        {
            Random random = new Random();
            double[] weights = new double[numOfInputs + 1];
            for (int i = 0; i < numOfInputs; i++)
            {
                weights[i] = (Math.Round(random.NextDouble(), 2) - .5);
            }
            //Initilzes weights to random values from -.5 to .5
            weights[weights.Length - 1] = -.5;
            //Sets the bias to a value of -.5
            this.weights = weights;
        }

        public bool GetOutputNode(bool[] inputNodes)
        {
            SetInputNodes(inputNodes);
            double totalWeight = SetOutputNode();
            //Gets the sum of all the weights with given bit array
            if (totalWeight > 0)
            {
                return true;
                //if totalweight is positive return true
            }
            else
            {
                return false;
                //else return false
            }
        }

        private void SetInputNodes(bool[] inputNodes)
        {
            this.inputNodes = new bool[inputNodes.Length + 1];
            for (int i = 0; i < inputNodes.Length; i++)
            {
                this.inputNodes[i] = inputNodes[i];
            }
            this.inputNodes[this.inputNodes.Length - 1] = true;
            //Sets the input nodes to a given input array
        }

        private double SetOutputNode() 
        {
            double totalWeight = 0;
            for(int i = 0; i < inputNodes.Length; i++) 
            { 
                if (inputNodes[i])
                {
                    totalWeight += weights[i];
                }
            }
            totalWeight += weights[weights.Length - 1];
            return totalWeight;
            //gets the total weight of the current input array
        }

        public void SetLearningRate(double x)
        {
            learningRate = x;
            //learning rate setter
        }

        public void SetEpochs(int x)
        {
            epochs = x;
            //epochs rate setter
        }

        private int BoolToInt(bool value)
        {
            //converts boolean to integer
            if (value)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void TrainPerceptron(bool[][] inputData, bool[] solutions)
        {
            for (int cycle = 0; cycle < epochs; cycle++)
            {
                //Runs once per epoch
                for (int i = 0; i < inputData.Length; i++)
                {
                    //iterates though each input set and compares it to desired solution
                    if (GetOutputNode(inputData[i]) != solutions[i])
                    {
                        int solutionInt = BoolToInt(solutions[i]);
                        int outputInt = BoolToInt(GetOutputNode(inputData[i]));
                        double error = solutionInt - outputInt;
                        //Calculate if error is positive or negative error
                        for (int j = 0; j < 4; j++)
                        {
                            if (inputData[i][j])
                            {
                                solutionInt = 1;
                            }
                            else
                            {
                                solutionInt = 0;
                            }
                            weights[j] += learningRate * error * solutionInt;
                            //updates weight based off of learning rate, error, and if the bit was true or not
                        }
                    }
                }
            }
        }
    }
}
