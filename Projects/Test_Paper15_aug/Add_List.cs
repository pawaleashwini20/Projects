using System;
using System.Collections.Generic;
using System.Text;
//4.	Given two LinkedList, we need to combine two LinkedList  in such a way that the combined
//a List has alternate elements of both. If one list has extra element, then these
//elements are appended at the end of the combined list.[1M]
//Input : list1 = {1, 2, 3, 4, 5, 6}
//List2 = { 11, 22, 33, 44}
//List3: { 1, 11, 2, 22, 3, 33, 4, 44, 5, 6}


namespace Projects.Test_Paper15_aug
{
    class Add_List
    {
        static void Main(string[] args)
        {
            List<int> ll = new List<int>();
            ll.Add(1);
            ll.Add(2);
            ll.Add(3);
            ll.Add(4);
            List<int> aa = new List<int>();
            ll.Add(11);
            ll.Add(22);
            ll.Add(33);
            ll.AddRange(aa);
            Console.WriteLine(String.Join(" ",ll));
        }
    }
}
