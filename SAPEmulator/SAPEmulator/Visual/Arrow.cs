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
    public partial class Arrow : UserControl
    {

        public enum Direction
        {
            Left,
            Right
        }
        Graphics gra;
        private bool State;
        private bool OldState;

        [Category("Appearance"), Description("The length of the arrow leg (excluding the cap)"), Editor("ArrowLength", typeof(int))]
        public int ArrowLength { get; set; }

        [Category("Appearance"), Description("The number to appear in the cap of the arrow"), Editor("CapNumber", typeof(char))]
        public char CapNumber { get; set; }

        [Category("Appearance"), Description("The color of the border when the arrow is highlighted"), Editor("OnColorBorder", typeof(Color))]
        public Color OnColorBorder { get; set; }


        [Category("Appearance"), Description("The color of the border when the arrow is not highlighted"), Editor("OffColorBorder", typeof(Color))]
        public Color OffColorBorder { get; set; }


        [Category("Appearance"), Description("The fill color when the arrow is highlighted"), Editor("OnColorFill", typeof(Color))]
        public Color OnColorFill { get; set; }


        [Category("Appearance"), Description("The fill color when the arrow is not highlighted"), Editor("OffColorFill", typeof(Color))]
        public Color OffColorFill { get; set; }


        [Category("Appearance"), Description("The direction of the arrow"), Editor("ArrowDirection", typeof(Direction))]
        public Direction ArrowDirection { get; set; }
        public Arrow()
        {
            InitializeComponent();
            OnColorBorder = Color.FromArgb(220, 220, 220);
            OffColorBorder = Color.FromArgb(220, 220, 220);
            OnColorFill = Color.FromArgb(234, 234, 234);
            OffColorFill = Color.FromArgb(234, 234, 234);
            gra = CreateGraphics();
            CapNumber = '8';
            State = false;
            OldState = false;
            ArrowLength = 54;
            ArrowDirection = Direction.Right;

        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            DrawArrow(false);
            Size = new Size(ArrowLength + 19, 19);
        }
        private void DrawArrow(bool On)
        {
            int xOffset = 0;
            int yOffset = 5;
            using (Pen p = new Pen(On ? OnColorBorder : OffColorBorder))
            using (GraphicsPath ArrowPath = new GraphicsPath())
            {

                if (ArrowDirection == Direction.Right)
                {
                    ArrowPath.AddLine(new Point(0 + xOffset, 0 + yOffset), new Point(ArrowLength + xOffset, 0 + yOffset));
                    ArrowPath.AddLine(new Point(ArrowLength + xOffset, 0 + yOffset), new Point(ArrowLength + xOffset, -5 + yOffset));
                    ArrowPath.AddLine(new Point(ArrowLength + xOffset, -5 + yOffset), new Point(ArrowLength + xOffset + 19, 4 + yOffset));
                    ArrowPath.AddLine(new Point(ArrowLength + xOffset + 19, 4 + yOffset), new Point(ArrowLength + xOffset, 13 + yOffset));
                    ArrowPath.AddLine(new Point(ArrowLength + xOffset, 13 + yOffset), new Point(ArrowLength + xOffset, 8 + yOffset));
                    ArrowPath.AddLine(new Point(ArrowLength + xOffset, 8 + yOffset), new Point(0 + xOffset, 8 + yOffset));

                    gra.FillPath(new SolidBrush(On ? OnColorFill : OffColorFill), ArrowPath);
                    gra.DrawPath(p, ArrowPath);
                    gra.DrawString(CapNumber.ToString(), new Font("Arial", 8), new SolidBrush(Color.FromArgb(127, 127, 127)), ArrowLength+ xOffset, yOffset-3, new StringFormat());
                }
                else
                {
                    ArrowPath.AddLine(new Point(0 + xOffset, 4 + yOffset), new Point(19 + xOffset, -5 + yOffset));
                    ArrowPath.AddLine(new Point(19 + xOffset, -5 + yOffset), new Point(19 + xOffset, 0 + yOffset));
                    ArrowPath.AddLine(new Point(19 + xOffset, 0 + yOffset), new Point(19+ ArrowLength + xOffset, 0 + yOffset));
                    ArrowPath.AddLine(new Point(19 + ArrowLength + xOffset, 8 + yOffset), new Point(19 + xOffset, 8 + yOffset));
                    ArrowPath.AddLine(new Point(19 + xOffset, 8 + yOffset), new Point(19 + xOffset, 13 + yOffset));
                    ArrowPath.AddLine(new Point(19 + xOffset, 13 + yOffset), new Point(0 + xOffset, 4 + yOffset));

                    gra.FillPath(new SolidBrush(On ? OnColorFill : OffColorFill), ArrowPath);
                    gra.DrawPath(p, ArrowPath);
                    gra.DrawString(CapNumber.ToString(), new Font("Arial", 8), new SolidBrush(Color.FromArgb(127, 127, 127)), 9+xOffset, yOffset-2, new StringFormat());
                }

            }
        }
        public void ChangeState(bool val)
        {
            State = val;
            if (State != OldState) DrawArrow(State); //only change when state is not equal to previous state /reduce overhead            
            OldState = State;
        }
    }
}
