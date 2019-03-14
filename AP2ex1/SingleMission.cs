using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private FuncsDelegate funcsDelegate;
        private string name;
        private string type;

        public SingleMission(FuncsDelegate funcsDelegate1,string name1)
        {
            this.funcsDelegate = funcsDelegate1;
            this.name = name1;
            this.type = "Single";
        }

        public string Name { get { return this.name; } }

        public string Type { get { return this.type; } }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            double result= this.funcsDelegate(value);
            OnCalculate?.Invoke(this, result);
            return result;
        }
    }
}