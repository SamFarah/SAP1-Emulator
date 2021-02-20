using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace SAP1Emulator.AppCode.Visual
{
    public partial class LED : UserControl
    {
        internal LEDDisplay Control = null;
        [Category("Appearance"),
        Description("The LED colour"),
        Editor("LEDColor", typeof(Color))]
        public Color LEDColor { get; set; }

        Graphics gra;
        Rectangle Rect;
        private bool State;
        private bool OldState;
        private const int len = 10;


        public LED()
        {
            InitializeComponent();
            gra = CreateGraphics();
            Rect = new Rectangle(0, 0, len, len);
            State = false;
            OldState = false;
            LEDColor = Color.Red;

        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Size = new Size(len + 1, len + 1);
            PaintLED();
        }
      
        private void PaintLED()
        {
            SolidBrush redBrush = new SolidBrush(State ? LEDColor:Color.White);
            gra.FillEllipse(redBrush, Rect);
            gra.DrawEllipse(new Pen(Color.Black), Rect);
        }

        public void ChangeState(bool val)
        {
            State = val;
            if (State != OldState) PaintLED(); //only change when state is not equal to previous state /reduce overhead            
            OldState = State;
        }
    }

    internal class LEDConverter : TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destType)
        {
            if (destType == typeof(InstanceDescriptor)) return true;
            return base.CanConvertTo(context, destType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destType)
        {
            if (destType == typeof(InstanceDescriptor))
            {
                System.Reflection.ConstructorInfo ci = typeof(LED).GetConstructor(Type.EmptyTypes);
                return new InstanceDescriptor(ci, null, false);
            }
            return base.ConvertTo(context, culture, value, destType);
        }
    }

    public class LEDCollection : CollectionBase
    {
        private LEDDisplay Control;
        internal LEDCollection(LEDDisplay Control)
        {
            this.Control = Control;
        }

        public LED this[int Index]
        {
            get
            {
                if (List.Count - 1 < Index) return null;
                return (LED)List[Index];
            }
        }

        public bool Contains(LED Led) { return List.Contains(Led); }

        public int Add(LED Led)
        {
            int i;

            i = List.Add(Led);
            Led.Control = Control;
            Control.RefreshLayout();

            return i;
        }

        public void Remove(LED Led)
        {
            List.Remove(Led);
            Led.Control = null;
            Control.RefreshLayout();
        }
    }

}
