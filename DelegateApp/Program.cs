using System;
using System.Linq;

namespace DelegateApp
{
    public delegate string strMyDel(string str);
    class Program
    {
        static void Main(string[] args)
        {
            TestDelegate testDelegate = new TestDelegate();
            //using generic delegates
            Func<string, string> myTestDelegateSpace = testDelegate.Space;
            Func<string, string> myTestDelegateReverse = testDelegate.Reverse;
            string spacedString =  myTestDelegateSpace("CodebitsAcademy");
            string reversedSting = myTestDelegateReverse("CodebitsAcademy");
            Console.WriteLine(spacedString);
            Console.WriteLine(reversedSting);
            //using Non-genric delegates
            strMyDel strMySpace = testDelegate.Space;
            strMyDel strMyReverse = testDelegate.Reverse;
           string nameSpaced = strMySpace.Invoke("abayomi");
            string nameReversed = strMyReverse.Invoke("abayomi");

            Console.WriteLine(nameSpaced);
            Console.WriteLine(nameReversed);

        }


        class TestDelegate
        {
            public string Space(string name)
            {
                string strResult = String.Join(" ", name.Reverse());
                string newSpace = "";
                for(int i = strResult.Length-1; i >= 0; i--)
                {
                    newSpace += strResult[i];
                }
                return newSpace;
            }

            public string Reverse(string name)
            {
                char[] charArray = name.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
              
            }
        }
    }
}
