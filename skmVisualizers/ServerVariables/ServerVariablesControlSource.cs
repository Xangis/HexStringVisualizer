using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Specialized;
using System.Web.UI;
using System.IO;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HexStringVisualizer
{
    public class HexStringControlSource : VisualizerObjectSource
    {
        // Render the control and return its markup
        public override void GetData(object target, System.IO.Stream outgoingData)
        {
            if (target != null && target is string)
            {
                string s = (string)target;

                // Dump the contents from Request.ServerVariables to
                // a local NameValueCollection b/c Request.ServerVariables
                // is NOT serializable...
                // Serialize nvc to the outgoingData Stream
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(outgoingData, s);
            }
        }
    }
}
