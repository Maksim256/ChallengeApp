﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public abstract class Person 
    {

        

        public Person(string name)
        {
            this.Name = name;
        }

       
        public string Name { get; private set; }
        
    }
}
