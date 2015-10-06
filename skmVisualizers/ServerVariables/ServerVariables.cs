using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace HexStringVisualizer
{
    [Serializable]
    public class HexStringVisualizer
    {
        public HexStringVisualizer(string str)
        {
            _str = str;
        }

        private String _str;

        public String NamesAndValues
        {
            get { return _str; }
            set { _str = value; }
        }
    }
}
