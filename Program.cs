


using DataStructureAlgo;
using DataStructureAlgo.WindowSlidingAlgo;



//var longestSubstringWithNoRepition = LongestSubstring.GetLongestSubstringWithoutRepeating("pwwkew");
//Console.WriteLine($"Max substring length with no repition is {longestSubstringWithNoRepition}");

//var indicesOfTwoSum = TwoSum.SolveTwoSumProblem([5], 5);
//Console.WriteLine($"Result of Two Sum Problem: {string.Join(",", indicesOfTwoSum)}");

var groupOfAnagrams = GroupAnagrans.GetGroupOfAnagrams(new List<string> { "eat", "tea", "ant", "tan", "ate" });

groupOfAnagrams.ForEach(g => Console.WriteLine($"[{string.Join(", ", g)}]"));
