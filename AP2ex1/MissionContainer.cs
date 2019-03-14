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
            get { return  funcsDictionary[funcIndex]; }
            set { funcsDictionary[funcIndex] = value; }
        }
    }
}
