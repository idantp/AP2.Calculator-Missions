using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private FuncsDelegate funcsDelegate;
        private string name;
        private string type;

        public ComposedMission(string nameArg)
        {
            this.name = nameArg;
            this.type = "Composed";
        }

        public string Name => this.name;

        public string Type => this.type;

        public event EventHandler<double> OnCalculate;

        public void Add(FuncsDelegate funcsDelegate) {
            

        }

        public double Calculate(double value)
        {

        }
    }
}
