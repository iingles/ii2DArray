using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ii2DArray
{

    public partial class MainPage : ContentPage
    {
        // Set constants for rows and columns and a variable for each
        const int MAX_ROW = 5;
        const int MAX_COL = 3;
        int row, column;

        // Set up our array
        decimal[,] prices = {   
            {450m, 450m, 450m, 450m},
            {425m, 425m, 425m, 425m},
            {400m, 400m, 400m, 400m},
            {375m, 375m, 375m, 375m},
            {375m, 375m, 375m, 375m},
            {350m, 350m, 350m, 350m}
        };

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Test entry conditions and display the result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDisplayPrice_Clicked(object sender, EventArgs e)
        {

            if (int.TryParse(EntryRow.Text, out int row) 
                && row >= 0 && row <= MAX_ROW
                &&int.TryParse(EntryColumn.Text, out int col)
                && col >= 0 && col <=MAX_COL
                )
            {
                LblResults.Text = prices[row, col].ToString("c");
            }
            else
            {
                DisplayAlert("Invalid Input", $"Row must be between 0 and {MAX_ROW}.  Column must be between 0 and {MAX_COL}", "close");
            }
        }

        private void BtnMaxRevenue_Clicked(object sender, EventArgs e)
        {
            decimal total = 0;

            for (int i = 0; i <= MAX_ROW; i++)
            {
                for (int j = 0; j <= MAX_COL; j++)
                {
                    total += prices[i, j];
                }
            }

            DisplayAlert("Total", $"Total revenue is: {total:c}", "Close");
        }
    }
}
