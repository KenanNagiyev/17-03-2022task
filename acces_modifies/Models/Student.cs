using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;

namespace acces_modifies.Models
{
    public class Student:Person
    {
        public void Semi()
        {
            Age = 15;
            Person a = new Person();
            
        }
    }
}
