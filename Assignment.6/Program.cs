namespace Assignment._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Question01
            /*a) The original value will not change because the struct is value type.
              b) The other value also will not change although the class is reference type 
                 because the string is immutable (when changing it ,it cerate another object).*/
            #endregion
            #region Question02
            /*a) -Anyone can assign these fields invalid or unexpected values directly.
                 -Cannot apply validation on the input.
                 -Any Changes on the original field must also be applied on the objects in Main
                  which makes it hard to maintenance.
              b) Private fields prevent anyone to access the fields and change it's value
                 and public property allow the validation on the input and set and get the values.*/
            #endregion
            #endregion
        }
    }
}
