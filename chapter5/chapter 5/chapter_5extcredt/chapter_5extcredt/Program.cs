using System;
using System.Collections.Generic;

namespace chapter_5extcredt
{
    class Program
    {
        static void Main(string[] args)
        {

			
			SortedList<int, string> sortedList1 = new SortedList<int, string>();
			sortedList1.Add(3, "Three");
			sortedList1.Add(4, "Six");
			sortedList1.Add(1, "Seven");
			sortedList1.Add(5, "Eight");
			sortedList1.Add(2, "Nine");

			
			Console.WriteLine("sortedList1 has " + sortedList1.Count + " items in the list");
			
			foreach (KeyValuePair<int, string> item in sortedList1)
			{
				
			}


			SortedList<string, int> sortedList2 = new SortedList<string, int>();
			sortedList2.Add("Six", 1);
			sortedList2.Add("Seven", 2);
			sortedList2.Add("Eight", 3);
			sortedList2.Add("Nine", 4);
			
			

			
			Console.WriteLine("sortedList2 has " + sortedList2.Count + " items in the list");

			
			for (int i = 0; i < sortedList2.Count; i++)
			{
				Console.WriteLine("key: {0}, value: {1}", sortedList2.Keys[i], sortedList2.Values[i]);
			}






		
			SortedList<double, int?> sortedList3 = new SortedList<double, int?>()
		{
				{1.2, null},
				{3.6, 400},
				{7.1, 701}
		};
			
			sortedList3.Add(1.5, 100);
			sortedList3.Add(3.5, 200);
			sortedList3.Add(2.4, 300);
			sortedList3.Add(2.3, null);
			sortedList3.Add(1.1, null);



			
			Console.WriteLine("sortedList3 has " + sortedList3.Count + " items in the list");

			
			foreach (KeyValuePair<double, int?> kvp in sortedList3)
			{
				Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

			}

		}
	}


}
    
