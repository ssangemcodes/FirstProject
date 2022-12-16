using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExtended
{
    public interface IStudent //interfaces are basically contracts. They do not have any impelmentation. When a class implements
                            // an interface it has to implement the methods of the in interface
    {
        void AddAddress(string address);

        string GetGrades();
    }
}
