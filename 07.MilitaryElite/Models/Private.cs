﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(int id, string firstName, string secondName, decimal salary) 
            : base(id, firstName, secondName)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; }

        public override string ToString()
        {
            return $"{base.ToString()} Salary: {Math.Round(Salary,2):F2}";
        }
    }
}
