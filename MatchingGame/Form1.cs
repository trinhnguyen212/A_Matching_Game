﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        //Use this Random object to choose random icons fc
        Random random = new Random();

        //Each of these letters is an interesting icon
        //in the Webdings font,
        //and each icon appears twice in this list
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N",",",",","k","k","b","b","v","v","w","w","z","z"
        };
        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        /// <summary>
        /// Assign each icon from the list of icons to a random square
        /// </summary>
        private void AssignIconsToSquares ()
        {
            //The TableLayoutPanel has 16 labels,
            //
            foreach (Control control in tableLayoutPanel1.Controls) 
            {
                Label iconLabel = control as Label;
                if(iconLabel!=null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
        /// <summary>
        /// Every label's Click event is handled by this event handler
        /// </summary>
        /// <param name="sender">The label that was clicked</param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                //if the clicked label is black, the player clicked
                //an icon that is already been revealed --
                //ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                clickedLabel.ForeColor = Color.Black;
            }
        }
    }
}
