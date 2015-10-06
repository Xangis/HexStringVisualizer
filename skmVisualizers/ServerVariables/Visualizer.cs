using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System.IO;

[assembly: DebuggerVisualizer(
typeof(HexStringVisualizer.Visualizer),
typeof(HexStringVisualizer.HexStringControlSource),
    Target = typeof(string),
    Description = "Hex String Visualizer")]

namespace HexStringVisualizer
{
    public class Visualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            // Deserialize the Stream returned by GetData() into a string
            String vars = null;
            using (Stream dataStream = objectProvider.GetData())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                vars = formatter.Deserialize(dataStream) as String;
            }

            // Create the user interface form, passing in the NameValueCollection
            using (VisualizerForm displayForm = new VisualizerForm())
            {
                displayForm.Visualize(vars);
                windowService.ShowDialog(displayForm);
            }
        }
    }
}
