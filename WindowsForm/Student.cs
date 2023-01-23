using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm
{
    [Serializable]
    public class Student
    {
        public int StdId { get; set; }
        public string StdName { get; set; }
        public double Percentage { get; set; }
    }
}
