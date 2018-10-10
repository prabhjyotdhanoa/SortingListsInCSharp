using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectionSort
{
    public partial class MinMaxMedianModeSelectionSortForm : Form
    {
        // All your code should be placed within the class.

        #region Examples of Comments
        // This is a one-line comment

        /*
         * 
         * This is a multi-line comment.
         * 
         */
        #endregion

        #region Global Declarations, Initializations and Instantiations
        // Global variables and objects should be created at the top of the class.
        // If a variable or object is global to a class, any procedure in the class
        // can access and modify it.

        // Declaration: Associates a name with a data type or class
        // Initialization: Gives a variable its initial value
        // Instantiation: Creates an object and initializes it

        /*
         * The part of the following statement that lies to the left of the equals sign 
         * associates the name "numberList" with a list of "double" values. This is called 
         * a "declaration." The part that lies on the right creates the initially empty list. 
         * This is called an "instantiation."
         */
        private List<double> numberList = new List<double>();

        #endregion

        #region A Note on Object-Oriented Programming
        /*
         * In object-oriented programming, classes are the "blueprints" or "templates" for
         * making objects. Just as a cookie-cutter can be used to make any number of cookies,
         * a class can be used to make any number of objects. In Microsoft Visual Studio,
         * objects consist of properties, methods and events.
         * 
         * property-> A variable that belongs to an object, typically used to store
         *            information about a characteristic of the object
         * method  -> A procedure or function that belongs to an object. Methods are
         *            ACTIONS that can be performed by, to or for an object.
         * event   -> An event is a message sent by an object to signal the occurrence 
         *            of an action. Events are used to trigger the execution of code.
         * 
         * For example, the "Button" class is used to make buttons in Windows Forms
         * applications. 
         * 
         * Text    -> A property found within the Button class. It stores the text that is 
         *            displayed on the button.
         * Hide    -> A method found within the Button class. It is used to hide a button.
         * Click   -> An event found within the Button class. The "Click" event is is raised
         *            whenever the user clicks on a button.
         */
        #endregion

        #region Constructor Method
        // The following is called a "constructor method" for the form "SelectionSortForm."
        // Place within the constructor method any code that needs to be executed as 
        // soon as the form is created (i.e. loaded). 
        public MinMaxMedianModeSelectionSortForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            double number;
            bool isNumeric = Double.TryParse(numberTextBox.Text, out number);

            numberListBox.SelectedIndex = -1; //Remove any highlighting

            if (isNumeric) // This is equivalent to 'if (isnumeric == true)'
            {
                // Add the entered number to both the list and the list box
                numberList.Add(number);
                numberListBox.Items.Add(number);
            }
            else
            {
                MessageBox.Show("You may only enter numbers.", "Who was your kindergarten teacher?");
            }
            numberTextBox.SelectAll();
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            double min = minimum(numberList);
            int indexOfSmallest = indexOfMin(numberList);
            numberListBox.SetSelected(indexOfSmallest, true);
            outputBox.Text = "The minimum value in this list is " + min.ToString();

        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            double max = maximum(numberList);
            int indexOfLargest = indexOfMax(numberList);
            numberListBox.SetSelected(indexOfLargest, true);
            outputBox.Text = "The maximum value in this list is " + max.ToString();
        }
        private void MeanButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = "The mean value of this list is " + (average(numberList)).ToString();
        }


        private void MedianButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = "The median value of this list is " + (median(numberList)).ToString();
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (AscendingRadioButton.Checked == true)
            {
                List<double> newList = sortAscending(numberList);
                numberListBox.Items.Clear();

                //This loop adds values of sorted list back into ListBox
                for (int i = 0; i < newList.Count; i++)
                {
                    numberListBox.Items.Add(newList[i]);

                }

            }
            else if (DescendingRadioButton.Checked == true)
            {
                List<double> newList = sortDescending(numberList);
                numberListBox.Items.Clear();
                for (int i = 0; i < newList.Count; i++)
                {
                    numberListBox.Items.Add(newList[i]);

                }
            }
        }
        private void multiModeButton_Click(object sender, EventArgs e)
        {
            List <double> newList = multiMode(numberList);
            numberListBox.Items.Clear();
            for (int i = 0; i < newList.Count; i++)
            {
                numberListBox.Items.Add(newList[i]);
                numberListBox.SetSelected(i, true);
                
            }
            
        }

        private void ModeButton_Click(object sender, EventArgs e)
        {
          List <double> newList = multiMode(numberList);
            numberListBox.Items.Clear();
            for (int i = 0; i < newList.Count; i++)
            {
                numberListBox.Items.Add(newList[i]);
                numberListBox.SetSelected(i, true);
                
            }
        }

        private void ScrambleButton_Click(object sender, EventArgs e)
        {
            numberListBox.Items.Clear();
            numberList = scramble(numberList);

            for (int i = 0; i < numberList.Count; i++)
            {
                numberListBox.Items.Add(numberList[i]);

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            numberList.Clear();
            numberListBox.Items.Clear();
            outputBox.Text = "";
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            double searchedValue = double.Parse(numberTextBox.Text);

            int indexOfSearchedValue = searchList(searchedValue, numberList);

            numberList = sortAscending(numberList);
            numberListBox.Items.Clear();

            //This loop adds values of sorted list back into ListBox
            for (int i = 0; i < numberList.Count; i++)
            {
                numberListBox.Items.Add(numberList[i]);

            }

            if (indexOfSearchedValue == -1)
            {
                MessageBox.Show("We could not find that value");
            }
            else
            {
                numberListBox.SetSelected(indexOfSearchedValue, true);
            }



        }

        private void DevModeButton_Click(object sender, EventArgs e)
        {
            List<double> newList = devMode(numberList);
            numberListBox.Items.Clear();
            for (int i = 0; i < newList.Count; i++)
            {
                numberListBox.Items.Add(newList[i]);
                numberListBox.SetSelected(i, true);

            }
        }

        // Used to ensure that the focus stays on the text box when the button is clicked.
        // Otherwise, the button will have the focus.
        private void SubmitButton_MouseUp(object sender, MouseEventArgs e)
        {
            numberTextBox.SelectAll();
            numberTextBox.Focus();
        }

        #endregion

        #region Programmer-Defined Methods 
        private static int searchList(double keyValue, List<double> listOfNumbers)
        {
            List<double> copyList = new List<double>(listOfNumbers);
            /*
             * so i found a way for searching for zero by making the condition (middle > -1)
             * but i still have the problem of "skipping" numbers in my search
             * for ex: in a 10 digit list, if im searching for 4, the first middle will be 5, then 2, then 1, then 0
             * then the program repeats indefinitely
             *  in a 9 digit list:(0-8), the values that get skipped are 3 and 5
             * theres probably a pattern that can be found to check for these skipped indexes
             
             */

            /*one solution is to check if the new middles are even or odd, odd is self explantory, 
             * but for even, we need to find the median of the list, not the middle, 
             * so inat sense, we check 2 middles instead of one, and if not, we continue on
             */

            /*9/24/2018
             * So instead of just fiding middle, try finding the bototm and top of the function
             * then decrase bottom or top depending on  if key is smaller or larger than the middle
             */

            copyList = sortAscending(copyList);
            int middle = copyList.Count / 2;

            while (middle > 0)
            {
                if (copyList[middle] == keyValue)
                    return middle;

                else if (copyList[middle] < keyValue)
                {
                    middle = (copyList.Count + middle + 1) / 2; 
                }
                else if (copyList[middle] > keyValue)
                {
                    middle = (middle+1) / 2;

                }
            }
            return -1;
        }

        private static List<double> scramble(List<double> ListOfNumbers)
        {
            List<double> scrambledList = new List<double>();
            List<double> copyOfList = new List<double>(ListOfNumbers);

            Random randomNumber = new Random();
            for (int i = 0; i < ListOfNumbers.Count; i++)
            {
                int randomIndex = randomNumber.Next(0, copyOfList.Count);
                scrambledList.Add(copyOfList[randomIndex]);
                copyOfList.Remove(copyOfList[randomIndex]);
            }
            return scrambledList;
        }

        
        
        private static List<double> multiMode(List<double> listOfNumbers)
        {
            List<double> sortedList = sortAscending(listOfNumbers);
            List<double> valueList = new List<double>();
            List<double> frequencyList = new List<double>();

            int frequency = 1;
            double value = sortedList[0];

            for (int i = 1; i < sortedList.Count; i++)
            {
                if (sortedList[i] ==  sortedList[i-1])
                {
                    frequency = frequency + 1;
                }
                else
                {
                    valueList.Add(value);
                    frequencyList.Add(frequency);
                    frequency = 1;
                    value = sortedList[i];
                }

            }
            valueList.Add(value);
            frequencyList.Add(frequency);

            double largestVal = maximum(frequencyList); 
            List<double> finalList = new List<double>();
            for (int i = 0; i < valueList.Count; i++)
            {
                if (frequencyList[i] == largestVal)
                {
                    finalList.Add(valueList[i]);
                }
            }
            return finalList;


        }
        
        private static List<double> devMode(List<double> listOfNumbers)
        {
            // use a dictionary 
            Dictionary<double, int> dict = new Dictionary<double, int>();
            int frequency = 1;
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (dict.ContainsKey(listOfNumbers[i]) != true)
                {
                    dict.Add(listOfNumbers[i], frequency);
                }

                else if (dict.ContainsKey(listOfNumbers[i]) == true)
                {
                    frequency++;
                    dict[listOfNumbers[i]] = frequency;
                }
                frequency = 1;
            }
            
            int maximum = dict.Values.Max();

            List <double> modeList = new List<double>();

            foreach (var item in dict)
            {
                if (item.Value == maximum)
                {
                    modeList.Add(item.Key);
                }
            }
            return modeList;
        }

        private static List<double> mode(List<double> ListOfNumbers)
        {
            List<double> counterList = new List<double>();
            int counter = 0;

            for (int i = 0; i < ListOfNumbers.Count; i++)
            {
                counterList.Add(counter);
                for (int x = 0; x < ListOfNumbers.Count; x++)
                {
                    if (ListOfNumbers[i] == ListOfNumbers[x])
                    {
                        counterList[i] = (counterList[i] + 1);
                    }
                }
            }

            double largestVal = maximum(counterList);

            List<double> finalList = new List<double>();

            for (int i = 0; i < ListOfNumbers.Count; i++)
            {
                if (ListOfNumbers[i] == largestVal)
                {
                    finalList.Add(ListOfNumbers[i]);
                }
            }
            return finalList;
        }

        private static double median(List<double> List)
        {
            List = sortAscending(List);
            //checking if its even
            if (List.Count % 2 == 0)
            {
                int MiddleOfList = (List.Count / 2);
                double medianOfEvenList = (List[MiddleOfList] + List[MiddleOfList - 1]) / 2;
                return medianOfEvenList;
            }
            //checking if its odd
            else if (List.Count % 2 != 0)
            {
                int MiddleOfList = (List.Count - 1) / 2;
                double MedianOfOddList = List[MiddleOfList];
                return MedianOfOddList;
            }
            else
            {
                return double.NaN;
            }
        }

        private static List<double> sortAscending(List<double> List)
        {
            List<double> sortedList = new List<double>();
            List<double> copyOfList = new List<double>(List);
            for (int i = 0; i < List.Count; i++)
            {
                double small = minimum(copyOfList);
                sortedList.Add(small);
                copyOfList.Remove(small);
            }
            return sortedList;
        }

        private static List<double> sortDescending(List<double> List)
        {
            List<double> sortedList = new List<double>();
            List<double> copyOfList = new List<double>(List);
            int count = List.Count;
            for (int i = 0; i < count; i++)
            {
                double biggest = maximum(copyOfList);
                sortedList.Add(biggest);
                copyOfList.Remove(biggest);
            }
            List = sortedList;
            return List;
        }

        private static int indexOfMin(List<double> List)
        {
            int IndexOfMinimumValue = List.IndexOf(minimum(List));
            return IndexOfMinimumValue;
        }

        private static int indexOfMax(List<double> List)
        {
            int IndexOfMaximumValue = List.IndexOf(maximum(List));
            return IndexOfMaximumValue;
        }


        private static double minimum(List<double> numberList)
        {
            if (numberList.Count > 0)
            {
                double smallest = numberList[0];

                for (int i = 1; i < numberList.Count; i++)
                {
                    if (numberList[i] < smallest)
                    {
                        smallest = numberList[i];
                    }
                }
                return smallest;
            }

            else
            {
                return Double.NaN;
            }

        }

        private static double maximum(List<double> numberList)
        {
            if (numberList.Count > 0)
            {
                double largest = numberList[0];

                for (int i = 1; i < numberList.Count; i++)
                {
                    if (numberList[i] > largest)
                    {
                        largest = numberList[i];
                    }
                }
                return largest;
            }

            else
            {
                return Double.NaN;
            }

        }

        /// <summary>
        /// Finds the mean (average) value of a List of Numbers containing double values.
        /// </summary>

        private static double average(List<double> numberList)
        {
            if (numberList.Count > 0)
            {
                double sum = 0;

                for (int i = 0; i < numberList.Count; i++)
                {
                    sum = sum + numberList[i];
                }
                return sum / numberList.Count;
            }
            else
            {
                return double.NaN;
            }
        }

        #endregion

        private void MinMaxMedianModeSelectionSortForm_Load(object sender, EventArgs e)
        {

        }

    }// end of class
}// end of namespace
