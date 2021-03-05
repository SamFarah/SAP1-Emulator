using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SAPEmulator.AppCode.Visual
{
    public partial class DoubleEndedArrow : UserControl
    {

        public enum Direction
        {
            None,
            Left,
            Right
        }
        Graphics gra;
        private Direction State;
        private Direction OldState;

        [Category("Appearance"), Description("The length of the arrow leg (excluding the cap)"), Editor("ArrowLength", typeof(int))]
        public int ArrowLength { get; set; }

        [Category("Appearance"), Description("The number to appear in the left cap of the arrow"), Editor("CapLNumber", typeof(char))]
        public char CapLNumber { get; set; }

        [Category("Appearance"), Description("The number to appear in the right cap of the arrow"), Editor("CapRNumber", typeof(char))]
        public char CapRNumber { get; set; }

        [Category("Appearance"), Description("The color of the border when the arrow pointing left is highlighted"), Editor("OnLColorBorder", typeof(Color))]
        public Color OnLColorBorder { get; set; }


        [Category("Appearance"), Description("The color of the border when the arrow pointing right is highlighted"), Editor("OnRColorBorder", typeof(Color))]
        public Color OnRColorBorder { get; set; }


        [Category("Appearance"), Description("The color of the border when the arrow pointing right is not highlighted"), Editor("OffColorBorder", typeof(Color))]
        public Color OffColorBorder { get; set; }


        [Category("Appearance"), Description("The fill color when the arrow pointing left is highlighted"), Editor("OnLColorFill", typeof(Color))]
        public Color OnLColorFill { get; set; }

        [Category("Appearance"), Description("The fill color when the arrow pointing right is highlighted"), Editor("OnRColorFill", typeof(Color))]
        public Color OnRColorFill { get; set; }

        [Category("Appearance"), Description("The fill color when the arrow pointing left is not highlighted"), Editor("OffColorFill", typeof(Color))]
        public Color OffColorFill { get; set; }



        [Category("Appearance"), Description("The direction of the arrow"), Editor("ArrowPointingDirection", typeof(Direction))]
        public Direction ArrowPointingDirection { get; set; }
        public DoubleEndedArrow()
        {
            InitializeComponent();

            OffColorBorder = Color.FromArgb(220, 220, 220);
            OffColorFill = Color.FromArgb(234, 234, 234);

            OnLColorBorder = Color.FromArgb(220, 220, 220);
            OnLColorFill = Color.FromArgb(234, 234, 234);

            OnRColorBorder = Color.FromArgb(220, 220, 220);
            OnRColorFill = Color.FromArgb(234, 234, 234);

            CapLNumber = '8';
            CapRNumber = '8';

            gra = CreateGraphics();
            State = Direction.None;
            OldState = Direction.None;
            ArrowLength = 54;
            ArrowPointingDirection = Direction.None;

        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            DrawArrow(Direction.None);
            Size = new Size(ArrowLength + 38, 19);
        }
        private void DrawArrow(Direction dire)
        {
            int xOffset = 19;
            int yOffset = 5;

            //Clear
            using (Pen p = new Pen(SystemColors.Control))
            using (GraphicsPath ArrowPath = new GraphicsPath())
            {
                Point[] Cover =
                    {
                        new Point(-19 + xOffset, 13 + yOffset),
                        new Point(ArrowLength +19+ xOffset, 13 + yOffset),
                        new Point(ArrowLength +19+ xOffset , -8 + yOffset),
                        new Point(-19 + xOffset, -8 + yOffset),
                    };
                ArrowPath.AddLines(Cover);
                gra.FillPath(new SolidBrush(SystemColors.Control), ArrowPath);
                gra.DrawPath(p, ArrowPath);
            }
            switch (dire)
            {
                case Direction.None:

                    using (Pen p = new Pen(OffColorBorder))
                    using (GraphicsPath ArrowPath = new GraphicsPath())
                    {
                        Point[] theArrow =
                            {
                                new Point(0 + xOffset, 0 + yOffset),
                                new Point(ArrowLength + xOffset, 0 + yOffset),
                                new Point(ArrowLength + xOffset, -5 + yOffset),
                                new Point(ArrowLength + xOffset + 19, 4 + yOffset),
                                new Point(ArrowLength + xOffset, 13 + yOffset),
                                new Point(ArrowLength + xOffset, 8 + yOffset ),
                                new Point(0 + xOffset, 8 + yOffset),
                                new Point(0 + xOffset, 13 + yOffset),
                                new Point(-19 + xOffset, 4 + yOffset),
                                new Point(0 + xOffset, -5+ yOffset),
                                new Point(0 + xOffset, 0 + yOffset),
                            };

                        ArrowPath.AddLines(theArrow);
                        gra.FillPath(new SolidBrush(OffColorFill), ArrowPath);
                        gra.DrawPath(p, ArrowPath);
                        gra.DrawString(CapRNumber.ToString(), new Font("Arial", 8), new SolidBrush(Color.FromArgb(127, 127, 127)), ArrowLength + xOffset, yOffset - 3, new StringFormat());
                        gra.DrawString(CapLNumber.ToString(), new Font("Arial", 8), new SolidBrush(Color.FromArgb(127, 127, 127)), -9 + xOffset, yOffset - 2, new StringFormat());
                    }
                    break;
                case Direction.Right:
                    using (Pen p = new Pen(OnRColorBorder))
                    using (GraphicsPath ArrowPath = new GraphicsPath())
                    {
                        Point[] rightArrow =
                            {
                                new Point(-19 + xOffset, 0 + yOffset),
                                new Point(ArrowLength + xOffset, 0 + yOffset),
                                new Point(ArrowLength + xOffset, -5 + yOffset),
                                new Point(ArrowLength + xOffset + 19, 4 + yOffset),
                                new Point(ArrowLength + xOffset, 13 + yOffset),
                                new Point(ArrowLength + xOffset, 8 + yOffset ),
                                new Point(-19 + xOffset, 8 + yOffset)
                            };
                        ArrowPath.AddLines(rightArrow);
                        gra.FillPath(new SolidBrush(OnRColorFill), ArrowPath);
                        gra.DrawPath(p, ArrowPath);
                        gra.DrawString(CapRNumber.ToString(), new Font("Arial", 8), new SolidBrush(Color.FromArgb(127, 127, 127)), ArrowLength + xOffset, yOffset - 3, new StringFormat());                       
                    }
                    break;
                case Direction.Left:
                    using (Pen p = new Pen(OnLColorBorder))
                    using (GraphicsPath ArrowPath = new GraphicsPath())
                    {
                        Point[] leftArrow =
                            {
                                new Point(ArrowLength+19 + xOffset, 8 + yOffset ),
                                new Point(0 + xOffset, 8 + yOffset),
                                new Point(0 + xOffset, 13 + yOffset),
                                new Point(-19 + xOffset, 4 + yOffset),
                                new Point(0 + xOffset, -5+ yOffset),
                                new Point(0 + xOffset, 0 + yOffset),
                                new Point(ArrowLength+19 + xOffset, 0 + yOffset),
                            };
                        ArrowPath.AddLines(leftArrow);
                        gra.FillPath(new SolidBrush(OnLColorFill), ArrowPath);
                        gra.DrawPath(p, ArrowPath);                        
                        gra.DrawString(CapLNumber.ToString(), new Font("Arial", 8), new SolidBrush(Color.FromArgb(127, 127, 127)), -9 + xOffset, yOffset - 2, new StringFormat());
                    }
                    break;
            }          
        }
        public void ChangeState(Direction dir)
        {
            State = dir;
            if (State != OldState) DrawArrow(dir); //only change when state is not equal to previous state /reduce overhead            
            OldState = State;
        }
    }
}
