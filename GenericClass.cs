using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_10
{
    public class GenericClass<T,Y> 
    {
        private T _var;

        public T Var
        {
            get { return _var; }
            set { _var = value; }
        }
        private Y _var1;

        public Y Var1
        {
            get { return _var1; }
            set { _var1 = value; }
        }


        public  void Metod()
        {
            Console.WriteLine(_var+_var1);
        }

        public GenericClass(T var, Y var1)
        {
            Var = var;
            Var1 = var1;
        }
    }
}
