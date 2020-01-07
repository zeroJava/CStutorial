using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Dynamics
{
    public class DynamicsEx1
    {
        /*
         * C# is a statically typed language, meaning
         * that the type of the variable is know by the
         * compiler at compile-time.
         * 
         * Also, once the variable has been assigned a
         * type, it cannot changed.
         * 
         * */

        /*
         * Static-type.
         * 
         * As mentioned, due to the fact that C# is
         * a statically typed programming language,
         * the compiler analyses the code, looking
         * for a match, and when can't find a method
         * that belongs to the type, then the compi-
         * ler will throw an error.
         * */

        public void ExecuteDynamicExample()
        {
            try
            {
                /*
                 * In C#, we have a function that tells
                 * the compiler to ignore all members for
                 * this variable, and wait until run-time
                 * to bind.
                 * 
                 * This is know a Dynamic-Binding, which
                 * is activated by using the dynamic
                 * keyword.
                 * */

                dynamic dynamic1 = new InnerDynamicEx1();

                /*
                 * Below the line of code will be ignored
                 * by the compiler, when compiled.
                 * 
                 * Instead, the compiler will wait during
                 * runtime to see if the GetMeAString
                 * existing, and return the value.
                 * */
                int number = dynamic1.GetMeANumber();
                string str = dynamic1.GetMeAString();
            }
            catch (RuntimeBinderException dynamicBindingException)
            {
                Console.WriteLine(string.Format("Error when using dynamic.\n{0}", dynamicBindingException.Message));
            }
        }

        public void ExecuteRuntimeBinderExceptionExample()
        {
            try
            {
                dynamic dynamic1 = new InnerDynamicEx1();
                int number = dynamic1.GetMeANumber();
                string str = dynamic1.GetMeAString();
            }
            catch (RuntimeBinderException dynamicBindingException)
            {
                /*
                 * If during run-time, the dynamic run-
                 * time-language (DLR) cannot find any
                 * of the members specified in the code,
                 * it will throw an exception.
                 * 
                 * The exception that is thrown, is the
                 * RuntimeBinderException. 
                 * 
                 * The exception is similar to compiler
                 * error we normally ecounter when there's
                 * no matching method or property.
                 * */
                Console.WriteLine(string.Format("Error when using dynamic.\n{0}", dynamicBindingException.Message));
            }
        }

        public void ExecuteCustomDynamicExample()
        {

        }

        protected class InnerDynamicEx1
        {
            public int GetNumber { get; set; } = 10;

            public int GetMeANumber()
            {
                return 5 * 5;
            }
        }

        // https://android.jlelse.eu/magic-lies-here-statically-typed-vs-dynamically-typed-languages-d151c7f95e2b
    }
}