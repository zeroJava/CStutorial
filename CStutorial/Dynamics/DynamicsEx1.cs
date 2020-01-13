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

            /*
             * Note
             * 
             * Dynamic just delays it runtime, so
             * stuff that would happen in compiler
             * time would be moved to runtime.
             * */
            
            /* I.e.
             * 
             * void GetValue();
             * int num = GetValue();
             * 
             * */

            /*
             * Normally the error would happen at
             * compile-time, but dynamic just moves
             * it to run time.
             * */
        }

        public void ExecuteDynamicExampleTwo()
        {
            /*
             * In Dynamic-Type programming langauges,
             * it possible to assign a variable with
             * a value of another data-type.
             * 
             * E.g.
             * 
             * int v1 = 32;
             * v1 = "Hellow world";
             * 
             * This is not possible in Statically-
             * Type languages.
             * */

            /*
             * C# Dynamic allows you to do this.
             * */

            dynamic v1 = 32;
            Console.WriteLine(v1);

            v1 = "Hello world";
            Console.WriteLine(v1);
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

        public void DynamicCoversionExample()
        {
            /*
             * Dynamic types can be coverted to other
             * types implicitly.
             * */

            int number = 64;
            dynamic dynamicNumber = number;
            long longNumber = dynamicNumber;

            /*
             * This can only happen if the casting is
             * allowed normally.
             * */
        }

        public void DynamicExamplainedExample()
        {
            /*
             * Run-time figures out the binding by
             * either using the IDynamicMetaObject-
             * Provider interface or the run-time
             * searching for a pattern via language
             * binding.
             * */

            /*
             * Look at chatper 20 Albahari for more
             * info.
             * */

            /*
             * IDynamicMetaObjectProvider
             * 
             * Using the IDynamicMetaObjectProvider,
             * the class inheriting this interface
             * can define meaning of the operation
             * (Albahari).
             * */

            /*
             * Language binding
             * 
             * Language binding is used when there
             * is no object that uses IDynamicMeta-
             * ObjectProvider.
             * 
             * Instead it resorts finding a match-
             * ing signature in the code.
             * */
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