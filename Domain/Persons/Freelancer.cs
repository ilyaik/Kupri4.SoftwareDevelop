﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kupri4.SoftwareDevelop.Domain.Persons
{
    public class Freelancer : Person
    {
        public Freelancer(string firstName, string lastName) 
            : base(firstName, lastName, Settings.Employee.Status) { }

        public override decimal GetSalaryOnPeriod(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
