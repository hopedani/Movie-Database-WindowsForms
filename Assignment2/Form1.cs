/*
 Course: Web Servies Using .NET and C#
 Assignment: Assignment 2
 Author: Daniel Hope
 Date: Feb.21, 2018
 Description: A windows form for entering movie information into a record that will be placed in a database (MovieDB).
              Includes fucntionality to Add, Update and Delete records in the database.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        //declare variables for reuse throughout the program
        SqlConnection con;
        SqlCommand cmd;
        BindingSource bs;
        DialogResult result;
        public Form1()
        {
            InitializeComponent(); 

            //initialize connection to the database(MovieDB)
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MovieDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            //initialize ToolTips for all data entry fields and buttons to give user vital information on how to 
            //fill out and use the form
            tipISBN.SetToolTip(mtbISBN, "This is a required field.  You must enter a number here.");
            tipMovieID.SetToolTip(nudMovieID, "This is a required field.  You must select a number.\n" +
                "Warning! Be sure to double check this value when using the Update or Delete buttons below.");
            tipMovieName.SetToolTip(txtMovieName, "Optional field. Enter the movie title here (max 50 characters)");
            tipDate.SetToolTip(dtpReleaseDate, "Choose a release date from this calendar (default is set to current day)");
            tipLocation.SetToolTip(lbLocation, "Optional field. Choose if movie was made in Canada or Internationally");
            tipGenre.SetToolTip(lbGenre, "Optional field. Choose the genre of the movie you want to Add or Update");
            tipRating.SetToolTip(nudRating, "Give the movie a rating from 1 to 5 Stars!. Default is 1 Star.");
            tipDuration.SetToolTip(mtbDuration, "Required field.  Enter the length of the movie in minutes." +
                "\nDefault is zero.");
            tipPrice.SetToolTip(mtbPrice, "Required field.  Enter price of the movie from .01 cent to $99.99." +
                "\n Default is zero.");
            tipAdd.SetToolTip(btnAdd, "Click to add a record to the database.");
            tipUpdate.SetToolTip(btnUpdate, "Click to update a record in the database to the current values listed in the " +
                "fields to the left.\n" +
                "Warning! The record to be updated is determined by the value in Movie ID at the top of the page.");
            tipDelete.SetToolTip(btnDelete, "Click to delete a record from the database." +
                "\nWarning! the record to be deleted is determined by in Movie ID at the top of the page.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //try to open connection to database and fill dataGridView object with contents
            try
            {
                cmd = new SqlCommand("Select * from Movie", con); //assign sql command for filling dataGridView object
                con.Open();

                //bind sql results to dataGridView object
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    bs = new BindingSource();
                    bs.DataSource = rdr;
                    dataGridView1.DataSource = bs; 
                }       
            }
            catch (SqlException ex)
            {

            }
            con.Close();
        }

        //event handler for Add button, includes sql command to add user info to database and error handling
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //create sql command, open connection to database
                cmd = new SqlCommand("Select * FROM Movie WHERE Movie_id = (@MovieID)", con);
                con.Open();
                cmd.Parameters.AddWithValue("MovieID", nudMovieID.Value);
                SqlDataReader tempReader = cmd.ExecuteReader();

                //check if record already exists (based on MovieID number)
                if (tempReader.HasRows)
                {
                    MessageBox.Show("The Movie ID you selected is already in use!\nPlease choose a different Movie ID.", 
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tempReader.Close();
                    throw new Exception();  //throw exception and catch it to exit method
                }
            }
            catch (SqlException) { }
            catch (Exception) { }
            finally { con.Close(); }
           
            try
            {
                //after checking for unused MovieID, add user defined fields to database
                cmd = new SqlCommand("INSERT INTO Movie values (@MovieID, @MovieName, @ISBN, @ReleaseDate, @Location, @Genre, @Rating, @Duration, @Price)", con);
                con.Open();

                //prevent sql injection with the following:
                cmd.Parameters.AddWithValue("MovieID", nudMovieID.Value);
                cmd.Parameters.AddWithValue("MovieName", txtMovieName.Text);
                cmd.Parameters.AddWithValue("ISBN", Int64.Parse(mtbISBN.Text));
                cmd.Parameters.AddWithValue("ReleaseDate", dtpReleaseDate.Value.ToString());
                cmd.Parameters.AddWithValue("Location", lbLocation.Text);
                cmd.Parameters.AddWithValue("Genre", lbGenre.Text);
                cmd.Parameters.AddWithValue("Rating", nudRating.Value);
                cmd.Parameters.AddWithValue("Duration", Int32.Parse(mtbDuration.Text));
                cmd.Parameters.AddWithValue("Price", float.Parse(mtbPrice.Text));
                
                //check if any rows have been affected by sql command
                int x = cmd.ExecuteNonQuery();

                if (x > 0)
                {
                    MessageBox.Show("Movie added successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Something went wrong, movie not added to database.\nPlease try again.", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // refresh the database view
                cmd = new SqlCommand("Select * from Movie", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                bs = new BindingSource();
                bs.DataSource = rdr;
                dataGridView1.DataSource = bs;
                //reset fields on form
                ClearInfo();
            }
            catch (SqlException ex)
            {

            }
            
            con.Close();
        }

        //event handler for Update button, includes sql command to update info in database and error handling
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //check for a valid MovieID (a MovieID that is currently in the database to update)
                cmd = new SqlCommand("Select * FROM Movie WHERE Movie_id = (@MovieID)", con);
                con.Open();
                cmd.Parameters.AddWithValue("MovieID", nudMovieID.Value);
                SqlDataReader tempReader = cmd.ExecuteReader(); 

                //check if sql command returns any rows from database that have user selected MovieID
                if (!tempReader.HasRows)
                {
                    MessageBox.Show("The Movie ID you selected is not assigned to any movie!" +
                        "\nPlease choose a different Movie ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tempReader.Close();
                    throw new Exception();  //throw exception and catch it to exit method
                }
            }
            catch (SqlException){ }
            catch (Exception){ }
            finally
            {
                con.Close();
            }

            try
            {
                //if database contains a valid MovieID to update, continue with updating database
                cmd = new SqlCommand("UPDATE Movie SET Movie_Name = (@MovieName), ISBN_Number = (@ISBN), Release_Date = (@ReleaseDate)," +
                    "Location = (@Location), Genre = (@Genre), Rating = (@Rating), Duration = (@Duration), Price = (@Price) WHERE Movie_id = (@MovieID)", con);
                con.Open();

                //prevent sql injection with the following:
                cmd.Parameters.AddWithValue("MovieID", nudMovieID.Value);
                cmd.Parameters.AddWithValue("MovieName", txtMovieName.Text);
                cmd.Parameters.AddWithValue("ISBN", Int64.Parse(mtbISBN.Text));
                cmd.Parameters.AddWithValue("ReleaseDate", dtpReleaseDate.Value.ToString());
                cmd.Parameters.AddWithValue("Location", lbLocation.Text);
                cmd.Parameters.AddWithValue("Genre", lbGenre.Text);
                cmd.Parameters.AddWithValue("Rating", nudRating.Value);
                cmd.Parameters.AddWithValue("Duration", Int32.Parse(mtbDuration.Text));
                cmd.Parameters.AddWithValue("Price", float.Parse(mtbPrice.Text));

                //check that database record has been updated
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Movie was updated successfully!", "Success!",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Update failed, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // refresh the database view
                cmd = new SqlCommand("Select * from Movie", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                bs = new BindingSource();
                bs.DataSource = rdr;
                dataGridView1.DataSource = bs;
                ClearInfo();  //reset data fields on form
            }
            catch (SqlException ex) { }

            con.Close();
        }

        //event handler for Delete button, includes sql command to delete record in database and error handling
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //create sql command, open connection to database
                cmd = new SqlCommand("Select * FROM Movie WHERE Movie_id = (@MovieID)", con);
                con.Open();
                cmd.Parameters.AddWithValue("MovieID", nudMovieID.Value);
                SqlDataReader tempReader = cmd.ExecuteReader();

                //check that the user defined MovieID exists in database, if not let user know
                if (!tempReader.HasRows)
                {
                    MessageBox.Show("The Movie ID you selected is not assigned to any movie!" +
                        "\nPlease choose a different Movie ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tempReader.Close();
                    throw new Exception(); //throw and catch exception to exit method
                }

            }
            catch (SqlException) { }
            catch (Exception) { }
            finally
            {
                con.Close();
            }

            //if user selected MovieID exists in database, prompt user with secondary question to ensure button was not
            //accidently clicked
            result = MessageBox.Show("Are you sure you want to delete this movie record?", 
                "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                //if database contains a valid MovieID to delete and user confirms deletion with MessageBox
                //continue with deleting record from database
                con.Open();
                cmd = new SqlCommand("DELETE FROM Movie WHERE Movie_id = (@MovieID)", con);
                cmd.Parameters.AddWithValue("MovieID", nudMovieID.Text);

                //check that deletion occurred and prompt user of results
                int x = cmd.ExecuteNonQuery();

                if (x > 0)
                {
                    MessageBox.Show("Movie deleted successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Unable to delete Movie, please try again.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // refresh the database view
                cmd = new SqlCommand("Select * from Movie", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                bs = new BindingSource();
                bs.DataSource = rdr;
                dataGridView1.DataSource = bs;
                ClearInfo(); //reset fields on form
            }
            catch (SqlException ex)
            {

            }
            con.Close();
        }

        
        private void mtbISBN_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEntry(mtbISBN.Text, out errorMsg))
            {
                //cancels the event to be corrected
                e.Cancel = true;
                //Cancel the event and select the text to be correct
                mtbISBN.Select(0, mtbISBN.Text.Length);
                //Set the ErrorProvider error with the text to display
                this.errorProvider1.SetError(mtbISBN, errorMsg);
            }
            if (e.Cancel == false)
                this.errorProvider1.Clear();
        }

        private void mtbISBN_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(mtbISBN, "");
        }

        private void mtbDuration_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEntry(mtbDuration.Text, out errorMsg))
            {
                //cancels the event to be corrected
                e.Cancel = true;
                //Cancel the event and select the text to be correct
                mtbDuration.Select(0, mtbDuration.Text.Length);
                //Set the ErrorProvider error with the text to display
                this.errorProvider2.SetError(mtbDuration, errorMsg);
            }
            if (e.Cancel == false)
                this.errorProvider2.Clear();
        }

        private void mtbDuration_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(mtbDuration, "");
        }

        private void mtbPrice_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEntry(mtbPrice.Text, out errorMsg))
            {
                //cancels the event to be corrected
                e.Cancel = true;
                //Cancel the event and select the text to be correct
                mtbPrice.Select(0, mtbPrice.Text.Length);
                //Set the ErrorProvider error with the text to display
                this.errorProvider3.SetError(mtbPrice, errorMsg);
            }
            if (e.Cancel == false)
                this.errorProvider3.Clear();
        }

        private void mtbPrice_Validated(object sender, EventArgs e)
        {
            errorProvider3.SetError(mtbPrice, "");
        }

        //method for checking if required fields are empty
        public bool ValidEntry(string mtbField, out string errorMessage)
        {
            //check if field is empty
            if (mtbField.Length == 0)
            {
                errorMessage = "You must provide a numeric entry in this field.";
                return false;
            }
            else
            { 
                errorMessage = "";
                return true;
            }
            
        }

        //method for resetting form fields
        public void ClearInfo() {
            txtMovieName.Text = "";
            mtbISBN.Text = "0000000000000";
            mtbDuration.Text = "000";
            mtbPrice.Text = "0000";
        }
    }
}
