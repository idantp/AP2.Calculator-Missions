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
    public class SingleMission : IMission
    {
        //points to an arithmetic method
        private FuncsDelegate funcsDelegate;
        private string name;
        private string type;

        public SingleMission(FuncsDelegate funcsDelegateArg,string nameArg)
        {
            this.funcsDelegate = funcsDelegateArg;
            this.name = nameArg;
            this.type = "Single";
        }

        public string Name { get { return this.name; } }

        public string Type { get { return this.type; } }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            //calculates the result of the arithmetic method
            double result = this.funcsDelegate(value);
            //calls all the methods that are registered to OnCalculate event.
            OnCalculate?.Invoke(this, result);
            return result;
        }
    }
}