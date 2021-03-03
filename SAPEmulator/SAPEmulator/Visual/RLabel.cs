using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPEmulator.AppCode.Visual
{
    class RLabel : System.Windows.Forms.Label
    {
        private double rotationAngle;
        public RLabel()
        {
            rotationAngle = 0d;
            this.Size = new Size(105, 12);
            base.AutoSize = false;
            TopLine = false;
        }
        [Description("Rotation Angle"), Category("Appearance")]
        public double RotationAngle
        {
            get { return rotationAngle; }
            set { rotationAngle = value; this.Invalidate(); }
        }

        [Description("Put Line Top"), Category("Appearance")]
        public bool TopLine { get; set; }        

        protected override void OnPaint(PaintEventArgs e)
        {            
            this.AutoSize = false;
            Graphics graphics = e.Graphics;

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.Trimming = StringTrimming.None;

            Brush textBrush = new SolidBrush(this.ForeColor);

            //Getting the width and height of the text, which we are going to write
            float width = graphics.MeasureString(base.Text, this.Font).Width;
            float height = graphics.MeasureString(base.Text, this.Font).Height;

            //The radius is set to 0.9 of the width or height, b'cos not to
            //hide and part of the text at any stage
            float radius = 0f;
            if (ClientRectangle.Width < ClientRectangle.Height)
            {
                radius = ClientRectangle.Width * 0.9f / 2;
            }
            else
            {
                radius = ClientRectangle.Height * 0.9f / 2;
            }
            double angle = (rotationAngle / 180) * Math.PI;
            graphics.TranslateTransform(
                (ClientRectangle.Width + (float)(height * Math.Sin(angle)) - (float)(width * Math.Cos(angle))) / 2,
                (ClientRectangle.Height - (float)(height * Math.Cos(angle)) - (float)(width * Math.Sin(angle))) / 2);
            graphics.RotateTransform((float)rotationAngle);
            graphics.DrawString(base.Text, this.Font, textBrush, 0, 0);
            graphics.ResetTransform();

            if(TopLine)
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                          Color.Black, 0, ButtonBorderStyle.None,
                                          Color.Black,1, ButtonBorderStyle.Solid,
                                          Color.Black, 0, ButtonBorderStyle.None,
                                          Color.Black, 0, ButtonBorderStyle.None);
        }

    }
}
