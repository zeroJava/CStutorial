using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Nullables
{
    public class NullableEx1
    {
        /*
         * Value types can not hold null values.
         * 
         * Inorder to allow value type to hold
         * null, we have to wrap the value-da-
         * ta-type with a nullable constrauct.
         * 
         * */

        /*
         * Nullable does'nt actulally hold a
         * null value.
         * */

        private void NullableEample()
        {
            /*
             * To allow a struct value to hold a null
             * value, we use a struct called nullabe<>.
             * 
             * e.g.
             * int?
             * nullable<int>
             * */

            int? nullValue = 10;
            Nullable<int> nullValue2 = new Nullable<int>(10); // this is how it wrutten behind the scene

            /*
             * The nullable struct has two properties,
             * which is the Value and HasValue.
             * 
             * If we're try retrieving a value, when
             * the the hasvalue is false, it will
             * throw an invalidoperatrion exception.
             * 
             * I.e. 
             * 
             * int? number = null; // is actutally nullable<int>();
             * number.value.tostrong();
             * 
             * The above code will throw a invalidoperation
             * and not nullpoint exception.
             * */

            /*
             * We won't get a null exception because,
             * nullable doesn't actuall hold a null
             * value, instead it holds some sort of
             * default value, which pretends to be null.
             * */
        }

        public void OperatorLifting()
        {
            /*
             * The nullable<> type does Not have its
             * own version of the '==', '<' and '>'
             * operators.
             * 
             * Instead, it uses the operators of the
             * type parameter value that it was assigned.
             * 
             * This is know as Operator Lifting.
             * */

            int? num1 = 450;
            int? num2 = 500;

            bool resul = num1 == num2;

            /*
             * The '==' operator that is used i from the
             * int data type.
             * */
        }
    }
}
