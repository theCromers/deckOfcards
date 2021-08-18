using System;

namespace Cromer_Kayla_hw3_pt1
{
    enum TenOrdinals
    {
        first = 1, //1
        second, third, fourth, fifth, sixth, seventh, eigth, ninth, tenth,


    }
    class Program
    {

        static void Main(string[] args)
        {
            TenOrdinals amendmentOrdinal = TenOrdinals.first | TenOrdinals.second | TenOrdinals.third | TenOrdinals.fourth | TenOrdinals.fifth
              | TenOrdinals.sixth | TenOrdinals.seventh | TenOrdinals.eigth | TenOrdinals.ninth | TenOrdinals.tenth;
            Console.WriteLine(amendmentOrdinal);


        }

    }
    class Rights
    {

        public struct hwStruct
        { }
        string bill()
        {
            string[,] billOrights;
            {
                { "Freedom of religion, speech, press, assembly, and petition, ", "Right to keep and bear arms in order to maintain a well regulated militia,",
                 "No Quartering of soldiers,","Freedom from unreasonable searches and seizures,", "Right to due process of law, freedom from self-incrimination, double jeopardy,",
                 "Rights of the accused persons, e.g. right to a speedy and public trial,", "Right of trial by jury in civil cases,", "Freedom from excessive bail, cruel, and unusual punishments,",      
                 "Other rights of the people", "Powers reserved to the states,"};
            }
        TenOrdinals ordinal;

        static string[,] rightsArr = new string[1, 10]
        {
                { "first ", "second ", "third ", "fourth ", "fifth ","sixth ", "seventh ","eighth","ninth ","tenth" }
        };
        }
}

