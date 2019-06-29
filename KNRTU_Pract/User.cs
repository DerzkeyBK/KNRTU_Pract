using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNRTU_Pract
{
    public class User
    {
        string _Name { get; set; }

        string _Surname { get; set; }

        string _Patr { get; set; }

        string _GroupNumber { get; set; }

        public User(string Name, string Surname, string Patr, string GroupNumber)
        {
            _Name = Name;
            _Surname = Surname;
            _Patr = Patr;
            _GroupNumber = GroupNumber;
        }
    }
}
