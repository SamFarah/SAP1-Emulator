using System.Collections.Generic;
using System.Linq;
namespace SAP1Modules
{
    public class Bus
    {
        /*
             A bus can have (theoretically) an infinite number of devices (registers) 
             connected to it. Its job is to transfer data from one device to another.
             depending on the devices control signals

             +-----------------------------------------------+
             |                       .                       |
             |                      / \                      |
             |                     /   \                     |
             |                     |   |                     |
             |  +---------+        |BUS|        +---------+  |
             |  |   REG   | <====> |   | <====> |   REG   |  |   
             |  +---------+        |   |        +---------+  |
             |                     |   |                     |
             |  +---------+        |   |        +---------+  |
             |  |   REG   | <====> |   | <====> |   REG   |  |     
             |  +---------+        |   |        +---------+  |
             |       .             |   |             .       |    
             |       .             |BUS|             .       |    
             |       .             |   |             .       |
             |  +---------+        |   |        +---------+  |      
             |  |   REG   | <====> |   | <====> |   REG   |  |      
             |  +---------+        |   |        +---------+  |               
             |                     |   |                     |    
             |  +---------+        |   |        +---------+  | 
             |  |   REG   | <====> |   | <====> |   REG   |  |
             |  +---------+        |BUS|        +---------+  |
             |                     |   |                     |
             |                     \   /                     |
             |                      \ /                      |
             |                       '                       |
             +-----------------------------------------------+   
        */

        //Connected Devices as shown in the figure above
        public List<Register> Devices;

        //"Data" reflects the "enabled" device's data.
        //Note that it is not "stored" anywhere, since the bus is not a device with memory, it's a read only property
        public byte Data
        {
            get
            {
                //As long as the control logic doesnt "Enable" more than one device on the bus then the 
                //output sum will be the value of the one enabled device
                //if more than one device is enabled at once. the Bus value will be "unpredictable"
                return (byte)Devices.Sum(x => x.GetData());
            }
        }

        //Constructor
        public Bus(List<Register> devices)
        {
            //Connect the devices to the bus
            Devices = devices;
        }

        //Writes whatever data that is "on the bus" into any device that has "load" control signal active.
        public void UpdateDevices()
        {
            byte dataOnBus = Data; //Store in local variable to prevent reading devices multiple times.        
            Devices.ForEach(x => x.SetData(dataOnBus)); //If a device's "Load" signal is active then it will take that value, otherwise it will ignore it
        }

        //Reset everything connected to the BUS 
        //Technically this is not a functionality of a Bus. but it is convenient to reset all connected devices at once.
        public void Reset() { Devices.ForEach(x => x.Reset()); }
    }
}
