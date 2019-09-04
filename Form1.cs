using System;
using System.Linq;
using System.Windows.Forms;

namespace BoxOffice
{
    /// <summary>
    /// The purpose of this form is to keep track of the number of attendees coming into the venue
    /// to see each band, and to add up the total attendence for the night. 
    /// </summary>
    public partial class Form1 : Form
    {
        //index number used through out the program to match corresponding controls
        public int i = 0;

        /// <summary>
        /// default constructor 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #region Static Button Methods
        //These Methods provide functionality to the "Add Band" and "Remove Band buttons"


        /// <summary>
        /// Adds all the controls needed to keep track of attendees coming to see a band
        /// </summary>
        public void AddBandBTN_Click(object sender, EventArgs e)
        {
            //increment the index number
            i++;

            CreateBandNameTextBox();
            CreateSub1Button();
            CreatCountTextBox();
            CreateAdd1Button();
        }

        /// <summary>
        /// Removes all the controls needed to keep track of attendees coming to see a band
        /// </summary>
        private void RemoveBandBTN_Click(object sender, EventArgs e)
        {
            //check to prevent out of range error
            if (flowLayoutPanel1.Controls.Count < 4)
                return;

            //remove the 4 most recently created elements, becuase there are 4 elements for each band
            for (int j = 0; j < 4; j++)
            {
                flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
            }
            //decrement index
            i--;

            //calculate and display total attendence 
            TotalCountLabel.Text = Total();
        }
        #endregion

        #region Dynamic Button Methods
        // These Methods provide functionality to the "-1" and "+1" buttons


        /// <summary>
        /// subtracts 1 from the number of attendees for a band
        /// </summary>
        private void Sub1_click(object sender, EventArgs e)
        {
            //create new button variable, and assign the button that called the function to the new varialble
            Button Btn = (Button)sender;
            //subtract 1 from the corresponding count 
            AddOrSubtract(Btn);
        }

        /// <summary>
        /// subtracts 1 from the number of attendees for a band
        /// </summary>
        private void Add1_click(object sender, EventArgs e)
        {
            //create new button variable, and assign the button that called the function to the new varialble
            Button Btn = (Button)sender;
            //add 1 to the corresponding count
            AddOrSubtract(Btn);
        }
        #endregion

        #region "Add Band" Helper Methods
        //These methods are called by the AddBandBTN_Click method


        private void CreateBandNameTextBox()
        {
            //create a textbox for the user to enter the name of a band
            TextBox BandName = new TextBox();

            //add the index number to the end of the textbox name
            BandName.Name = $"BandName { i }";

            //set properties for the textbox
            BandName.Text = "Enter Band Name";
            BandName.Width = 156;
            Padding margin = BandName.Margin;
            margin.Right = 119;
            BandName.Margin = margin;

            //add textbox to the GUI via flowlayoutpanel
            flowLayoutPanel1.Controls.Add(BandName);
        }

        private void CreateSub1Button()
        {
            //create a button to decrement the count of attendees for a band
            Button Sub1 = new Button();

            //add the index number to the end of the name
            Sub1.Name = $"Sub1_ { i }";

            //set properties
            Sub1.Text = "-1";
            Sub1.Width = 50;

            //call function when clicked
            Sub1.Click += new EventHandler(Sub1_click);

            //add to the GUI via flowlayoutpanel
            flowLayoutPanel1.Controls.Add(Sub1);
        }

        private void CreatCountTextBox()
        {
            //create a textbox for the count of attendees for a band
            TextBox Count = new TextBox();

            //add the index number to the end of the name
            Count.Name = $"Count { i }";

            //set properties
            Count.Text = "0";
            Count.Width = 30;
            Count.TextAlign = HorizontalAlignment.Center;

            //add to the GUI via flowlayoutpanel
            flowLayoutPanel1.Controls.Add(Count);
        }

        private void CreateAdd1Button()
        {
            //create button to increment the count of attendees for a band 
            Button Add1 = new Button();

            //add the index number to the end of the name
            Add1.Name = $"Add1_ { i }";

            // set properties
            Add1.Text = "+1";
            Add1.Width = 50;

            //call function when clicked
            Add1.Click += new EventHandler(Add1_click);

            //add to the GUI via flowlayoutpanel
            flowLayoutPanel1.Controls.Add(Add1);
        }
        #endregion

        #region Other Helper Methods
        // the AddOrSubtract, Total, and InputCheck Methods called by other methods can be found here 


        /// <summary>
        /// Adds or Subtracts from the corresponding count, depending on which button was clicked
        /// </summary>
        /// <param name="Btn"></param>
        private void AddOrSubtract(Button Btn)
        {
            //use the index number attatched to the button name to find the corresponding 'count' textbox. 
            TextBox Count = (TextBox)flowLayoutPanel1.Controls.Find($"Count { Btn.Name[Btn.Name.Length - 1] }", false).FirstOrDefault();
            //if there is invalid input in the count box, reset the value and notify the user
            if (InputCheck(Count) == false)
                return;
            //checks to see if the button clicked was the subtract button
            if (Btn.Text == "-1")
            {
                //prevent the count from becoming negative
                if (int.Parse(Count.Text) == 0)
                    return;
                //convert the count text from string to int, subtract 1, then convert back to string
                Count.Text = (int.Parse(Count.Text) - 1).ToString();
            }
            //if it's not the subtract button calling the function, it must be the add button
            else
            {
                //convert the count text from string to int, add 1, then convert back to string
                Count.Text = (int.Parse(Count.Text) + 1).ToString();
            }

            //calculate and display total attendence 
            TotalCountLabel.Text = Total();
        }


        /// <summary>
        /// //calculate the total attendence 
        /// </summary>
        /// <returns>total attendance</returns>
        private string Total()
        {
            //initialize totalcount
            int TotalCount = 0;

            //iterate thru every "Count" textbox
            for (int j = 1; j <= i; j++)
            {
                //use int j to find "count" textbox with the matching index attached to its name
                TextBox PartialCount = (TextBox)flowLayoutPanel1.Controls.Find($"Count { j }", false).FirstOrDefault();
                //if there is invalid input in the count box, reset the value and notify the user
                InputCheck(PartialCount);
                //convert the text in the count box to an int
                int PartialCountInt = int.Parse(PartialCount.Text);
                //add the count of each bands attenddees to the total count
                TotalCount += PartialCountInt;
            }
            //convert to string and return message "Total count: ..."
            return $"Total count: { TotalCount.ToString()} ";
        }

        /// <summary>
        /// if there is invalid input in the count box, reset the value and notify the user
        /// returns true if input is valid, and false if input is not valid
        /// </summary>
        /// <param name="TB">The TextBox to be checked</param>
        private bool InputCheck(TextBox TB)
        {
            try
            {
                int.Parse(TB.Text);
            }
            catch
            {
                MessageBox.Show($"*NOTICE* '{TB.Text}' is not valid input. When you click 'OK', this count will be reset to its last valid value");
                TB.Undo();
                return false;
            }
            return true;
        }
        #endregion
    }


}
