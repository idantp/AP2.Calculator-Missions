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

        public string Name => this.name;

        public string Type => this.type;

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            return this.funcsDelegate(value);
        }
    }
}
