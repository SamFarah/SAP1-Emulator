using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace SAP1Emulator.AppCode.Visual
{
    [Designer(typeof(CollectionControlDesigner))]
    public partial class LEDDisplay : UserControl
    {
        private LEDCollection mLEDs;
        public LEDDisplay()
        {
            InitializeComponent();
            mLEDs = new LEDCollection(this);
        }
        [Category("Data"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public LEDCollection LEDs { get { return mLEDs; } }
        internal void RefreshLayout() { Invalidate(); }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            int i = 0;
            foreach (LED led in LEDs)
            {
                Controls.Add(led);
                led.Location = new Point(3 + (12 * i++), 3);
            }

            Size = new Size((LEDs.Count == 0 ? 12 : LEDs.Count * 12) + 6, 16);

            if (this.DesignMode) ControlPaint.DrawBorder(pe.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Dotted);
        }
        public void DisplayData(int Data)
        {
            for (int i = 0; i < LEDs.Count; i++)
                LEDs[LEDs.Count - 1 - i].ChangeState((Data & (1 << i)) > 0);

        }
    }
    internal class CollectionControlDesigner : ControlDesigner
    {
        private LEDDisplay MyControl;
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);            
            MyControl = (LEDDisplay)component;            
            IComponentChangeService c = (IComponentChangeService)GetService(typeof(IComponentChangeService));
            c.ComponentRemoving += new ComponentEventHandler(OnComponentRemoving);            
        }

        private void OnComponentRemoving(object sender, ComponentEventArgs e)
        {
            IComponentChangeService c = (IComponentChangeService)GetService(typeof(IComponentChangeService));
            LED Led;
            IDesignerHost h = (IDesignerHost)GetService(typeof(IDesignerHost));
            int i;

            // If the user is removing an LED
            if (e.Component is LED)
            {
                Led = (LED)e.Component;
                if (MyControl.LEDs.Contains(Led))
                {
                    c.OnComponentChanging(MyControl, null);
                    MyControl.LEDs.Remove(Led);
                    c.OnComponentChanged(MyControl, null, null, null);
                    return;
                }
            }

            // If the user is removing the control itself
            if (e.Component == MyControl)
            {
                for (i = MyControl.LEDs.Count - 1; i >= 0; i--)
                {
                    Led = MyControl.LEDs[i];
                    c.OnComponentChanging(MyControl, null);
                    MyControl.LEDs.Remove(Led);
                    h.DestroyComponent(Led);
                    c.OnComponentChanged(MyControl, null, null, null);
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            ISelectionService s = (ISelectionService)GetService(typeof(ISelectionService));
            IComponentChangeService c = (IComponentChangeService)GetService(typeof(IComponentChangeService));

            // Unhook events
            // s.SelectionChanged -= new EventHandler(OnSelectionChanged);
            c.ComponentRemoving -= new ComponentEventHandler(OnComponentRemoving);

            base.Dispose(disposing);
        }

        public override System.Collections.ICollection AssociatedComponents { get { return MyControl.LEDs; } }
        public override System.ComponentModel.Design.DesignerVerbCollection Verbs
        {
            get
            {
                DesignerVerbCollection v = new DesignerVerbCollection();

                // Verb to add buttons
                v.Add(new DesignerVerb("&Add LED", new EventHandler(OnAddLED)));
                v.Add(new DesignerVerb("&Remove LED", new EventHandler(OnRemoveLED)));
                return v;
            }
        }

        private void OnAddLED(object sender, System.EventArgs e)
        {
            LED Led;
            IDesignerHost h = (IDesignerHost)GetService(typeof(IDesignerHost));
            DesignerTransaction dt;
            IComponentChangeService c = (IComponentChangeService)GetService(typeof(IComponentChangeService));

            // Add a new LED to the collection
            dt = h.CreateTransaction("Add LED");
            Led = (LED)h.CreateComponent(typeof(LED));
            c.OnComponentChanging(MyControl, null);
            MyControl.LEDs.Add(Led);
            c.OnComponentChanged(MyControl, null, null, null);
            dt.Commit();
        }
        private void OnRemoveLED(object sender, System.EventArgs e)
        {
            LED Led;
            IDesignerHost h = (IDesignerHost)GetService(typeof(IDesignerHost));
            DesignerTransaction dt;
            IComponentChangeService c = (IComponentChangeService)GetService(typeof(IComponentChangeService));
            dt = h.CreateTransaction("Remove LED");
            Led = MyControl.LEDs[MyControl.LEDs.Count - 1];
            c.OnComponentChanging(MyControl, null);
            h.DestroyComponent(Led);
            c.OnComponentChanged(MyControl, null, null, null);
            dt.Commit();
        }
    }


}
