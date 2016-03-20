using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericList
{
    [AttributeUsage(AttributeTargets.Struct
        | AttributeTargets.Class
        | AttributeTargets.Interface
        | AttributeTargets.Enum
        | AttributeTargets.Method)]


    public class VersionAttribute : Attribute
    {
        private int major;
        private int minor;

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public int Major
        {
            get { return this.major; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Major number should be positive or 0");
                }
                this.major = value;
            }
        }

        public int Minor
        {
            get { return this.minor; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Minor number should be positive or 0");
                }
                this.minor = value;
            }
        }

       

    }
}
