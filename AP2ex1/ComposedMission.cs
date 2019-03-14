using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private string name;
        private string type;
        private List<FuncsDelegate> funcsList;

        public ComposedMission(string nameArg)
        {
            this.name = nameArg;
            this.type = "Composed";
            funcsList = new List<FuncsDelegate>();
        }

        public string Name { get { return this.name; } }

        public string Type { get { return this.type; } }

        public event EventHandler<double> OnCalculate;

        public ComposedMission Add(FuncsDelegate funcsDelegateArg) {
            this.funcsList.Add(funcsDelegateArg);
            return this;
        }

        public double Calculate(double value)
        {
            foreach (FuncsDelegate func in funcsList){
               value = func(value);
            }
            OnCalculate?.Invoke(this, value);
            return value;
        }
    }
}
