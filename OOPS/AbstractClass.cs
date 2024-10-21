using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.OOPS
{
    public abstract class AbstractClass
    {
        public abstract string MakeSound();
        public abstract string LegsCount();
        public virtual string Eat()
        {
            return "I eat food";
        }
    }

    public class Dog : AbstractClass
    {
        public override string LegsCount()
        {
            throw new NotImplementedException();
        }

        public override string MakeSound()
        {
            return "Bark";
        }
    }
}
