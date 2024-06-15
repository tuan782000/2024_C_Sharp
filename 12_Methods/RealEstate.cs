using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _12_Methods
{
    public class RealEstate
    {
        public string Address {get; set;}
        public int Price {get; set;}
        public int SquareFootage {get; set;}

        public int CalculatePricePerSquareFootage() => Price / SquareFootage; // dùng lại thuộc tính Price và SquareFootage
        // public void CalculatePricePerSquareFootage (){
        //     Console.WriteLine(Price/SquareFootage);
        // }
    }
}