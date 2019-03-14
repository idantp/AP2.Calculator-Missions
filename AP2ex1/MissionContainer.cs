using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double FuncsDelegate(double num);

    public class FunctionsContainer
    {
        private Dictionary<string, FuncsDelegate> funcsDictionary;

        public FunctionsContainer()
        {
            this.funcsDictionary = new Dictionary<string, FuncsDelegate>();
        }

       public FuncsDelegate this [string funcIndex]
        {
            get {
                if (funcsDictionary.ContainsKey(funcIndex))
                {
                    return funcsDictionary[funcIndex];
                }
                else
                {
                    funcsDictionary[funcIndex] = val => val;
                    return funcsDictionary[funcIndex];
                }
               
            }
            set { funcsDictionary[funcIndex] = value; }
        }
        public ICollection<string> getAllMissions() { return this.funcsDictionary.Keys; }
    }
}
