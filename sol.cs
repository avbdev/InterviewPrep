using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
/*
* Given a sequence of values, find the kth most frequent value.
*
* Example: Given [1,3,1,2,1,5,7,3], the 2nd most frequent value is 3.
*/
/* 
{ InputNumber : count }
*/

// 


// {
// 1 : 1,
// 2 : 2,
// }

// [1,2,2] ==> k=2 ==> o/p -> 1
// [1] ==> k = 2 ==> o/p -> throw an error.
// []
// Iterate over the array and kee

/*
  {
    1 : {}
  }
*/




// class Solution
// {
//     static void Main(string[] args)
//     {

//         int[] c = new int[] { 1, 2, 2 };
//         var a = GetKthFrequent(c, 2);
//         Console.WriteLine($"{a[0]}");

//     }

//     public static List<int> GetKthFrequent(int[] arr, int k)
//     {

//         var freqCounter = new Dictionary<int, int>();
//         var counterOccurrencesDict = new Dictionary<int, HashSet<int>>();

//         // Insert values and its count to the dictionary
//         foreach (int ele in arr)
//         {
//             if (freqCounter.ContainsKey(ele)) freqCounter[ele]++;
//             else freqCounter[ele] = 1;
//         }


//         // Dict --> {frq: HashSet<inputOccurences>}
//         // We need an ele which is kth largest freq.
//         // {frq: [inputOccurences] }
//         // {3 : {1,2}, 2: {4,5,6}, 8:{32}}

//         foreach (var kvp in freqCounter)
//         {
//             // value = key[set] = actual freq.
//             if (counterOccurrencesDict.ContainsKey(kvp.Value))
//                 counterOccurrencesDict[kvp.Value].Add(kvp.Key);
//             else
//             {
//                 counterOccurrencesDict[kvp.Value] = new HashSet<int>();
//                 counterOccurrencesDict[kvp.Value].Add(kvp.Key);
//             }
//         }

//         var keys = counterOccurrencesDict.Keys.ToArray();

//         Array.Sort(keys);

//         var selectedKey = keys[k];
//         // Sort the keys in the dictionary

//         return counterOccurrencesDict[selectedKey].ToList();

//     }

// }



