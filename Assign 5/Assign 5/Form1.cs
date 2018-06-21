/***************************************************************
* Name: Zubaidah Alqaisi                                       *
* ZID: Z1786977                                                * 
* Course: CSCI 473 Section 2 Spring 2018                       *
* Assignment: Assign5                                          *
* Due Date: wednesday, Apr. 16.                                *
* Program goal: Create a small application dealing with        *
*               passwords to make it easier for the user to    *
*               remember the passwords of different websites.  *
***************************************************************/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Assign_5
{
    public partial class Form1 : Form
    {
        // declaring data memeber of the class
        private String s;   // string varaible for reading the text file using StreamReader
        private Boolean change = false;
        private int indexItem;
        private List<String> infoList = new List<String>(); 

        public Form1()
        {
            InitializeComponent();
        }

/********************************************************
 * Function: Form1_Load():                              *
 * Purpose:  This function is used to read the master   *
 *           password info stored in the setupFile text *
 *           file that is required for the paassword    *
 *           manager itself.                            *
 * Argument: object sender, EventArgs e                 *
 * Return: none void                                    *
 * *****************************************************/

        private void Form1_Load(object sender, EventArgs e)
        {
            indexItem = -1;  // setting the index to default value 
            // reading data from the text file for the password manager
            using (StreamReader sr = new StreamReader("setupFile.txt"))
            {
                // first read 
                s = sr.ReadLine();

            }

        } // end of Form1_Load ()

        /*******************************************************
        * Function: Submit_Click ()                            *
        * Purpose:This function reads the content of the "Info-*
        *         List text file when the correct master       *
        *        password is entered by the user. Then, it will*
        *       split the content which is website names, login*
        *       names, and the passwords by space and store it *
        *       in an array of strings. After spliting, it will*
        *      decrypt the passwords and print out the names of*
        *       the websites to the list box.                  *
        * Argument: object sender, EventArgs e                 *
        * Return: none void                                    *
        ********************************************************/

        private void Submit_Click(object sender, EventArgs e)
        {
            // if the master password entered by the user is correct
            if (passwordText.Text == Encryption(s))
            {
                using (StreamReader sr = new StreamReader("InfoList.txt"))
                {
                    String info;
                    // first read 
                    info = sr.ReadLine();

                    // if it is not end of file
                    while (info != null)
                    {
                        // spliting the content of the file by space
                        string[] splitInfo = info.Split(' ');
                        // concatinate the decrypted string with the encrypted password 
                        string decryptInfo = splitInfo[0] + " " + splitInfo[1] + " " + Encryption(splitInfo[2]);
                        // add the concatenated string to the list
                        infoList.Add(decryptInfo);
                        // second read
                        info = sr.ReadLine();
                    }
                    // looping through the list
                    foreach (String line in infoList)
                    {
                        // declaring array to store the each entry in the list
                        String[] fileInfo;
                        // split each line or entry by space
                        fileInfo = line.Split(' ');

                        output.Items.Add(fileInfo[0]);  // display only the website name 
                    }

                } // end of using streamReader 

                // activate the text field and the buttons if the master password entered is correct
                AddPssword.Enabled = true;
                Clear.Enabled = true;
                siteTextField.Enabled = true;
                loginTextField.Enabled = true;
                sitePassword.Enabled = true;

                // Empty the password text field after submitting the master password  
                passwordText.Text = String.Empty;

                // deactivate the submit button after entering the master password to avoid submitting the same info twice
                Submit.Enabled = false;

                // disable the password text field after entering one already
                passwordText.Enabled = false;
            }
            else
            {
                MessageBox.Show("The password you entered was incorrect.", "Incorrect Password");

                // Empty the password text field after submitting the wrong master password  
                passwordText.Text = String.Empty;
            }

        }// end of Submit_Click ()

/*************************************************
* Function: AddPssword_Click()                   *
* Purpose: This function adds the values entered *
*          by the user in the appropriate text   *
*         fields and add it to list. It will also*
*         display the website names only in the  *
*         list box.                              *
* Argument: object sender, EventArgs e           *
* Return: none void                              *
*************************************************/

        private void AddPssword_Click(object sender, EventArgs e)
        {
            if (Checker())
            {
                // preform changes
                change = true;
                // concatenate the values of the text fields into a string variable
                String line = siteTextField.Text + " " + loginTextField.Text + " " + sitePassword.Text;
                // add the variable to the list
                infoList.Add(line);
                // display the website names in the list box
                output.Items.Add(siteTextField.Text);
            }
            // empty the text fields after adding the info
            siteTextField.Text = "";
            loginTextField.Text = "";
            sitePassword.Text = String.Empty;

        } // end of AddPssword_Click()

/***********************************************
* Function: ModifyPassword_Click()             *
* Purpose: This function Modify the info assoc-*
*          iated of a specific website selected*
*          by the user from the list box.      *
* Argument: object sender, EventArgs           *
* Return: none void                            *
***********************************************/

        private void ModifyPassword_Click(object sender, EventArgs e)
        {
            if (Checker())
            {
                // allow to preform changes
                change = true;
                // modify the content associated with the name of the website selected from the list box
                infoList[indexItem] = siteTextField.Text + " " + loginTextField.Text + " " + sitePassword.Text;
                output.Items[indexItem] = siteTextField.Text;

                MessageBox.Show("The Info is modified sucessfully.");

                // empty the text fields after modifying the info
                siteTextField.Text = "";
                loginTextField.Text = "";
                sitePassword.Text = String.Empty;
            }

        }// end of ModifyPassword_Click()

/*************************************************
* Function: Output_SelectedIndexChanged()        *       
* Purpose:This function allows the user to select*
*         a website name that is displayed on the*
*         list box and perform some tasks such as*
*         modify or show the password associated *
*         with that website name.                *
* Argument: object sender, EventArgs             *
* Reutn: none void                               *
* ***********************************************/

        private void Output_SelectedIndexChanged(object sender, EventArgs e)
        {
            //declaring array of string 
            String[] infoArray;

            // select item from the text area 
            indexItem = output.SelectedIndex;
            // if there is an item selected 
            if (output.SelectedItem != null)
            {
                // spliting the info in the list and save it into array of string
                infoArray = infoList[indexItem].Split();
                // display the info after spliting in the appropriate text field 
                siteTextField.Text = infoArray[0];
                loginTextField.Text = infoArray[1];
                sitePassword.Text = infoArray[2];

                // enable the buttons if an item is selected from the list box
                DeletePassword.Enabled = true;
                ShowPassword.Enabled = true;
                ModifyPassword.Enabled = true;
            }
            else
            {
                // if no item is selected empty the text fields
                siteTextField.Text = "";
                loginTextField.Text = "";
                sitePassword.Text = String.Empty;

                // disable the buttons if no item is selected from the list box
                DeletePassword.Enabled = false;
                ModifyPassword.Enabled = false;
                ShowPassword.Enabled = false;
            }

        }// end of Output_SelectedIndexChanged()

/****************************************************
* Function: Checker()                               *
* Porpuse: Error checking function to check for     *
*         entering empty space and empty text field.*
* Argument: none                                    *
* Return: none void                                 *
* **************************************************/

        private Boolean Checker()
        {
            String site = siteTextField.Text;
            String login = loginTextField.Text;
            String password = sitePassword.Text;

            // if the text fiels are empty, prompt the user to enter a value
            if ( site == String.Empty || login == String.Empty || password == String.Empty )
            {
                MessageBox.Show("Please Enter a valid value in the text fields.", "Error Message");
                return false; 
            }
            // if the text fields contain empty spaces, prompt the user to emter a valid value
            if ( site.Contains(" ") || login.Contains(" ") || password.Contains(" ") )
            {
                MessageBox.Show("Please Enter a value with no spaces.", "Error Message");
                return false;
            }
            // checking that the passwords matching the password constraints
            if (!PasswordChecker(password) )
            {
                MessageBox.Show("Please enter the right password. Your password should be " +
                    "at least 8 characters long and should contain uppercase letters, lowercase letters and digits", "Incorrect Pawword Format");

                return false;
            }

            return true;

        }// end of Checker() 

/**************************************************
 * Function: DeletePassword_Click ()              *
 * Purpose: Delete specific content from the list *
 *         box when a user select it and delete it*
 *         from the file where it exists.         *
 * Argument: object sender, EventArgs e           *
 * Return: none void                              *
 * ***********************************************/

        private void DeletePassword_Click(object sender, EventArgs e)
        {
            // if there is an item selected from the list box
            if (indexItem != -1 )
            {
                // allow changes
                change = true;
                // remove the selected content from the list
                infoList.RemoveAt(indexItem);
                // remove the selected content from the list box as well
                output.Items.RemoveAt(indexItem);
            }
          
        }// end of DeletePassword_Click() 

/************************************************
* Function: ShowPassword_Click()                *
* Purpose: This function will show the value of *
*          the password of the selected item in *
*          the list box for a few seconds then  *
*          displayed back to stars.             *
* Argument: object sender, EventArgs e          *
* Return: none void                             *
*************************************************/

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            sitePassword.PasswordChar = '\0';  // set the password field to its value 
            Refresh();  // re draw the screen 
            // creating a timer for the password to show with 10 secs only
            Stopwatch timer = new Stopwatch();
            // start the timer 
            timer.Start();
            // specify the time period for the timer which is 3000 milliseconds 
            while (timer.ElapsedMilliseconds < 3000) ;
            // show the password as stars after the specified time period of the timer
            sitePassword.PasswordChar = '*';

        } // end of ShowPassword_Click()

/************************************************
* Function: Exit_Click()                        *
* Purpose: This function save changes made to   *
*      the infoList text file and add additional*
*      info added in the text fields by the user*
*     to the file as well efore exiting the form*
* Argument: object sender, EventArgs e          *
* Return: none void                             *
************************************************/

        private void Exit_Click(object sender, EventArgs e)
        {
            // if change is true then allow changes to the file
            if (change)
            {
                // using StreamWriter to write to the text file
                using (StreamWriter sw = new StreamWriter("InfoList.txt"))
                {
                    foreach (String info in infoList)
                    {
                        // split the login information by space
                        string[] infoArray = info.Split(' ');
                        // write the login in information to the file InfoList.txt with encrypted password 
                        sw.WriteLine(infoArray[0] + " " + infoArray[1] + " " + Encryption(infoArray[2]));
                    }
                }
            }
                Application.Exit();

        } // end of Exit_Click()

/**************************************************
* Function: Encryption ()                         *
* Purpose: This function is used to encrypt the   *
*          existing password fron the user.       *
* Argument: string password                       *
* Return:String, the encrypted version of password* 
* ************************************************/

        private string Encryption(string password)
        {
            // creating a string builder 
            StringBuilder word = new StringBuilder();
            // spliting the password passed by the user into characters
            foreach ( char character in password)
            {
                // encrypt the password and append it 
                word.Append((char)('\uFFFF' ^ character));
            }
            // return the new encrypted password 
            return word.ToString();

        }// end of Encryption()

/*************************************************
 * Function: PasswordChecker()                   *
 * Purpose: This function make sure that the     *
 *       password entered by the user is matching*
 *       the requirments which is 8 characters   *
 *       length and must contains upper case and *
 *       lower case as well as digits.           *
 * Argument: string password                     *
 * Return: bool length, upperCase, lowerCase,    *
 *         and digit.                            *
 ************************************************/

        private bool PasswordChecker(string password)
        {
            // boolean type of variables for checking
            Boolean length = false;
            Boolean upperCase = false;
            Boolean lowerCase = false;
            Boolean digit = false;
            // if the password length is longer or equal to 8 characters
            if (password.Length >= 8)
            {
                length = true;
                // split the password to chars and test each char
                foreach (char letter in password)
                {
                    // if it has upper case letters 
                    if (char.IsUpper(letter))
                    {
                        upperCase = true;
                    }
                    // if it has lower case letters 
                    if (char.IsLower(letter))
                    {
                        lowerCase = true;
                    }
                    // if it has digits 
                    if (char.IsDigit(letter))
                    {
                        digit = true;
                    }
                    // if it has all lower case, upper case, and digits then break outside of the loop
                    if ( upperCase && lowerCase && digit)
                    {
                        break;
                    }
                }
            }
               return length && upperCase && lowerCase && digit; 

        } // end of passwordChecker()

/**************************************************
 * Function: Clear_Click()                        *
 * Purpose: This function clears the text fields  *
 *          in the form upon clicking the clear   *
 *          button by the user.                   *
 * Argument: object sender, EventArgs e           *
 * Return: none void                              *
 *************************************************/

        private void Clear_Click(object sender, EventArgs e)
        {
            siteTextField.Text = String.Empty;
            loginTextField.Text = String.Empty;
            sitePassword.Text = String.Empty;

        } // end of Clear_Click()

    }// end of Form1 class

}// end of assign_5 namespace
