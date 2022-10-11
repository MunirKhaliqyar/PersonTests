﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTests
{
    internal interface IComparable<Person>
    {
        public int CompareTo(Person person);
    }
}