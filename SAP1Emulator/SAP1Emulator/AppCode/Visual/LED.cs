using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SAP1Emulator.AppCode.Visual
{
    public partial class LED : Panel
    {


        Panel onPanel, offPaenl;

        Graphics gra;
        bool State;
        bool OldState;
        Rectangle Rect;
        const int len = 10;
        public LED()
        {
            InitializeComponent();
            gra = CreateGraphics();
            Rect = new Rectangle(0, 0, len, len);
            State = false;
            OldState = false;
            // this.Controls.Add(Rect);

            //  pictureBox = new PictureBox();
            //  this.Controls.Add(pictureBox);


            
        }


        //[Category("Custom")]
        //[Browsable(true)]
        //[Description("Set path to image file")]
        //[Editor(typeof(System.Windows.Forms.Design.WindowsFormsComponentEditor),typeof(System.Drawing.Design.UITypeEditor))]


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Size = new Size(len + 1, len + 1);


            TurnOff();


            //Assembly assembly = Assembly.GetExecutingAssembly();
            //Stream stream = assembly.GetManifestResourceStream("SAP1Emulator.Images.LEDIcon.png");
            //Image img = new Bitmap(stream);
            //pictureBox.Image = img;
            //pictureBox.Size = img.Size;
        }

        private void TurnOn()
        {
            SolidBrush redBrush = new SolidBrush(Color.Red);
            gra.FillEllipse(redBrush, Rect);
            gra.DrawEllipse(new Pen(Color.Black), Rect);
        }
        private void TurnOff()
        {
            SolidBrush redBrush = new SolidBrush(Color.White);
            gra.FillEllipse(redBrush, Rect);
            gra.DrawEllipse(new Pen(Color.Black), Rect);
        }

        public void ChangeState(bool val)
        {
            State = val;

            if (State != OldState)
            {
                if (State) TurnOn();
                else TurnOff();


            }
            OldState = State;
        }

        public void SayHello()
        {
            MessageBox.Show("Hello", "MyComponent", MessageBoxButtons.OK);
        }

    }
}
