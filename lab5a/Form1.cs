//system libraries

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



/*

 

 @ author Utsavkumar M Patel , Student Number : 000820474 ,
 
 This program was created on the th November 11th December 2020.
 The primary goal of this program is to make a windows form application of the drop in the bucket which make use of 
 the graphical interface , Graphics object , Timer , Trackbar control and ColorDialog control.

 (Statement of the authorships) : 
 I, Utsavkumar M Patel , Student Number 000820474 , certify that this material is my original work.
 And No other person's work has been used without due acknowledgement.


*/

//namespace lab5a
namespace lab5a
{
    
    /// <summary>
    /// DrawForm  Class
    /// </summary>
    public partial class DrawForm : Form
    {
        
        // local variable initilization
        private int starter = 1;
        
        //setting bucketfull condition to false...
        bool bucketIsFull = false;
        
        //Color of water set to lightblue
        Color color = Color.LightBlue; 
       
        /// <summary>
        /// DrawForm Class inialization.
        /// </summary>
        
        public DrawForm()
        {
           
            InitializeComponent();

            //set trackbar value to 0.
            TrackBar.Value = 0;

            base.Paint += DrawBucketContainer;  
            
        }

        
     
        /// <summary>
        /// Color button Click method..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            //initialize the colordialog ...
            ColorDialog clgb = new ColorDialog();

            //Show color option of DialogBox Result..
            if (clgb.ShowDialog() == DialogResult.OK)
                  color = clgb.Color;     

        }


        /// <summary>
        /// This method is used to display waterfill.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void dropWaterFill(object sender, EventArgs e)
        {

            // SolidBrush object created 
            SolidBrush b = new SolidBrush(color);

            //Graphics object created...
            Graphics g = CreateGraphics();
            
            // Using Graphics Fill Rectangle bucket...
            g.FillRectangle(b, 81, 201, 15, 201 - starter);


            if (this.starter >= 100)
            {
                //Check if bucket is full or not ...
                bucketIsFull = true;
                //Disable the ClockTimer...
                ClockTimer.Enabled = false;
                g.FillRectangle(new SolidBrush(BackColor), 81, 201, 15, 201);
                //Set Trackbar value to 0
                TrackBar.Value = 0;
                this.starter = 0;
            }

            g.FillRectangle(b, 86, 400 - this.starter, 200, 1);

            this.starter = starter + 1;

        }

        /// <summary>
        /// DrawBucketContainer Method to DrawBucket Object,,...
        /// </summary>
        /// <param name="a"></param>
        /// <param name="paintEvent"></param>
        private void DrawBucketContainer(object a, PaintEventArgs paintEvent)
        {

            //Create graphics object using paintEvent Graphics...
            Graphics grapics = paintEvent.Graphics;

            //Draw line 1 of container via pen object
            grapics.DrawLine(new Pen(Color.Gray), 82, 288, 82, 398);

            //Draw line 2 of container via pen object
            grapics.DrawLine(new Pen(Color.Gray), 82, 398, 283, 398);
            
            //Draw line 3 of container via pen object
            grapics.DrawLine(new Pen(Color.Gray), 283, 398, 283, 288);



        }






        private void CloseButton_Click(object sender, EventArgs e)
        {
           
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {

            var speed = (TrackBar.Maximum - TrackBar.Value) * 10;

            if (TrackBar.Value == 10)  //prevent 0 speed when max value
            {
                speed = (int)(0.5 * 10);
            }

            Graphics graphics = CreateGraphics();

            if (TrackBar.Value == 0)
            {
                ClockTimer.Enabled = false;

            }

            else
            {

                if (bucketIsFull == false)
                {
                    ClockTimer.Interval = speed;
                    ClockTimer.Enabled = true;
                }

                else
                {
                    bucketIsFull = false;
                    graphics.FillRectangle(new SolidBrush(BackColor), 86, 285, 199, 140);
                    graphics.FillRectangle(new SolidBrush(BackColor), 86, 200, 15, 86);
                    ClockTimer.Interval = speed;
                    ClockTimer.Enabled = true;
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }



        }
    }
