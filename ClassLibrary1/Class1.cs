namespace ClassLibrary1
{
    public class Class1
    {
         public int lenghthelper(string word)
        {
            if (word == null)
                throw new ArgumentNullException("Please enter value");

            return word.Length;
        }
    }
}