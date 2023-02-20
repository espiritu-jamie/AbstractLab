using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLab
{
    /// <summary>
    /// Abstract Lab
    /// </summary>
    /// <remarks>Author: Jamie Marie Espiritu </remarks>
    /// <remarks>Date: Feb 18, 2023</remarks>
    internal class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
    }
}
