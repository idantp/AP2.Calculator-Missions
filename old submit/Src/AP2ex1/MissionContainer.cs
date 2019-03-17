/*
 * Author: Idan Twito
 * ID: 311125249
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    //points to arithmetic methods.
    public delegate double FuncsDelegate(double num);

    public class FunctionsContainer
    {
        //each key is a function description and it's value is it's implementation. 
        private Dictionary<string, FuncsDelegate> funcsDictionary;

        public FunctionsContainer(){
            this.funcsDictionary = new Dictionary<string, FuncsDelegate>();
        }
        //Indexer - each index is a string and the value is an arithmetic method
        public FuncsDelegate this [string funcIndex]{
            get {
                //returns the matching implementation to the arithmetic method name
                if (funcsDictionary.ContainsKey(funcIndex)) {
                    return funcsDictionary[funcIndex];
                }
                //if such does not exist - create a new one that returns the same value
                else
                {
                    funcsDictionary[funcIndex] = val => val;
                    return funcsDictionary[funcIndex];
                }
               
            }
            set { funcsDictionary[funcIndex] = value; }
        }
        //reutrns all the arithmetic method names
        public ICollection<string> getAllMissions() { return this.funcsDictionary.Keys; }
    }
}
