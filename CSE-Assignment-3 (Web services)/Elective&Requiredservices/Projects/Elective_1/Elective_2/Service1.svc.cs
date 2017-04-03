using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Elective_2
{
   
    public class Service1 : IService1
    {
        public double bindingEnergy(Int32 A_, Int32 Z_) {
            // declare the coefficents 

            // Volume term 
            double a_v = 15.56;

            // surface area term
            double a_s = 17.23;

            // coulomb potential   
            double a_c = 0.697;

            //Asymmetry term
            double a_a = 93.14 / 4;

            //Pairing term
            double a_p = 12;

            // Delta (depends on if the nuclus is even-even, odd- odd or even-odd,       
            double delta = 0;       



            double  A = A_;   // Get the mhe mass number A
            double Z = Z_;    // Get the atomic number Z (number of protons) 
            double N = A - Z; // Calc the number of neutrons 



            // Calculate the delta value 

            if (Z % 2 == 0 && N % 2 == 0)                       // if nuclus has an even number of protons and neutrons
                delta = (-1) * a_p * System.Math.Pow(A, -0.5);
            else if (Z % 2 != 0 && N % 2 == 0)                  // if nuclus has an odd number of protons and neutrons
                delta = a_p * System.Math.Pow(A, -0.5);
            else                                                // if even number of protons and odd neutrons OR odd protons and even neutrons 
                delta = 0;


            //cal the binding energy based on the based on the Liquid Drop Model

            double bindingEnergy = a_v*A - a_s*Math.Pow(A,(2/3)) - a_c*Z*(Z-1)/(Math.Pow(A,(1/3))) - a_a* Math.Pow((N - Z), 2)/A + delta;

            return bindingEnergy;
        }
    }
}
