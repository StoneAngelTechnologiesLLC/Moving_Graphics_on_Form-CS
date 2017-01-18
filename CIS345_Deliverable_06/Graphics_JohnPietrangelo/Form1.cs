//John Pietrangelo CIS345 Tues/Thurs 9am
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_JohnPietrangelo
{
    public partial class graphicsFrm : Form
    {
        // To initilize form variables.
        enum Position
        {
            Left,Right,Up,Down,Center
        }
        Position mugPosition = Position.Center;
        Bitmap myMug = new Bitmap("IntroPic.JPG");
        bool cDirection = true;
        bool sDirection = true;
        int cDrawPositionX = 3;
        int cDrawPositionY = 3;
        int cErasePositionX = 3;
        int cErasePositionY = 3;
        int sDrawPositionX = 3;
        int sDrawPositionY = 3;
        int sErasePositionX = 3;
        int sErasePositionY = 3;
        int mDrawPositionX = 285;
        int mDrawPositionY = 75;
        int mErasePositionX = 285;
        int mErasePositionY = 75;

        public graphicsFrm()
        {
            InitializeComponent();
        }

        //Timer Event used to sync & control Object movement
        private void MovementToThe_TickTockAndWeDontStop(object sender, EventArgs e)
        {
            //Create a graphics object to draw and erase using Blocks (Square) 
            Graphics c = CreateGraphics();
            c.FillEllipse(Brushes.Gold, new Rectangle(cDrawPositionX, cDrawPositionY, 50, 50));
            
            //Create a graphics object to draw and erase using Lines (Circle)
            Pen colorPen = new Pen(Color.Maroon, 5.5F);
            Graphics s = CreateGraphics();
            s.DrawRectangle(colorPen, new Rectangle(sDrawPositionX, sDrawPositionY, 50, 50));

            //Create a graphics object Image to display and erase using Bitmap (JPG)
            Graphics m = CreateGraphics();
            m.DrawImage(myMug, mDrawPositionX, mDrawPositionY);

            //Pauses display, to enhance Object motion 
            System.Threading.Thread.Sleep(50);

            //To Save shape position for next erase
            cErasePositionX = cDrawPositionX;
            cErasePositionY = cDrawPositionY;
            sErasePositionX = sDrawPositionX;
            sErasePositionY = sDrawPositionY;
            mErasePositionX = mDrawPositionX;
            mErasePositionY = mDrawPositionY;

            //Erases old Objects
            c.FillRectangle(Brushes.WhiteSmoke, new Rectangle(cErasePositionX, cErasePositionY, 50, 50));
            s.FillRectangle(Brushes.WhiteSmoke, new Rectangle(sErasePositionX-3, sErasePositionY-3, 60, 60));
            m.FillRectangle(Brushes.WhiteSmoke, new Rectangle(mErasePositionX, mErasePositionY, 210, 225));

            //Object movement, in pixels for each interval (Circle)
            if (cDirection == true)
            {
                cDrawPositionX += 12;
            }
            else
            {
                cDrawPositionX -= 12;
            }

            //Change direction of Object if it goes Right or Left (Circle)
            if (cDrawPositionX >= 730)
            {
                cDirection = false;
            }
            else if (cDrawPositionX <= 3)
            {
                cDirection = true;
            }

            //Object movement, in pixels for each interval (Square)
            if (sDirection == true)
            {
                sDrawPositionY += 2;
            }
            else
            {
                sDrawPositionY -= 2;
            }

            //Change direction of Object if it goes Up or Down (Square)
            if (sDrawPositionY >= 368)
            {
                sDirection = false;
            }
            else if (sDrawPositionY <= 3)
            {
                sDirection = true;
            }

            //Object movement, in pixels for each interval (JPG)
            if (mugPosition == Position.Right)
            {
                mDrawPositionX += 4;
            }
            else if (mugPosition == Position.Left)
            {
                mDrawPositionX -= 4;
            }
            else if (mugPosition == Position.Down)
            {
                mDrawPositionY += 4;
            }
            else if (mugPosition == Position.Up)
            {
                mDrawPositionY -= 4;
            }
            else if(mugPosition == Position.Center)
            {
                mDrawPositionX = mErasePositionX;
                mDrawPositionY = mErasePositionY;
            }
        }

        private void whichWayDidHeGoGeorge_ManDown(object sender, KeyEventArgs e)
        {
            //To asign Object movement direction via my personally chosen Keys, when pressed. 
            if (e.KeyCode == Keys.Left)
            {
                mugPosition = Position.Left;
            }
            else if (e.KeyCode == Keys.Right)
            {
                mugPosition = Position.Right;
            }
            else if (e.KeyCode == Keys.Down)
            {
                mugPosition = Position.Down;
            }
            else if (e.KeyCode == Keys.Up)
            {
                mugPosition = Position.Up;
            }
            else
            {
                mugPosition = Position.Center;
            }
        }
    }
}
