using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.StudentClass
{
    public class PropertyChangedEventArgs : EventArgs
    {
        public PropertyChangedEventArgs(string propName , dynamic oldValue , dynamic newValue)
        {
            this.PropName = propName;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        public string  PropName { get; set; }
        public dynamic OldValue { get; set; }
        public dynamic NewValue { get; set; }
    }
}
