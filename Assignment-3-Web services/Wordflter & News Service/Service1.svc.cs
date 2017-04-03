using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WordFilterService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       
        public string wordFilter(string str)
        {
            
            string[] words = str.Split(null);
            string newString = "";

            for (int i = 0; i < words.Length; i++) 
            {
                if (words[i].Equals("a") || words[i].Equals("an")  || words[i].Equals("in") || words[i].Equals("on") || words[i].Equals("are") || words[i].Equals("am") || words[i].Equals("is") || words[i].Equals("the"))
                {
                    words[i] = "";
                }
                // Determine whether a tag begins the string.
                if (words[i].StartsWith("<"))
                {
                    // Find the closing tag.
                    int lastLocation = words[i].IndexOf(">");
                    // Remove the tag.
                    //if (lastLocation >= 0)
                    //{
                        words[i] = words[i].Substring(lastLocation + 1);

                    //    // Remove any additional starting tags.
                    //   // words[i] = ripStartTags(item);
                    //}
                }

                newString = newString + words[i] + " ";
            }

            return newString;
            
        }
    }
}
