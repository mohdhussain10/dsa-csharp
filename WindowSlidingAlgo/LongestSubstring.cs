namespace DataStructureAlgo.WindowSlidingAlgo
{
    public static class LongestSubstring
    {
        public static int GetLongestSubstringWithoutRepeating(string s)
        {
            if(string.IsNullOrEmpty(s)) return 0;

            var stringSpan = s.AsSpan();

            var maxWindow = 0;

            var visitedDict = new Dictionary<char, int>();

            var left = 0;

            //Sliding window alogorithm

            for(var right = 0; right < stringSpan.Length; right++)
            {
                var currentChar = stringSpan[right];

                if (visitedDict.ContainsKey(currentChar))
                {
                    visitedDict[currentChar] = right;
                    if(visitedDict[currentChar] >= left)
                        left = right;
                }
                else
                {
                    maxWindow = right - left + 1;
                    visitedDict[currentChar] = right;
                }
            }
            return maxWindow;
        }
    }
}
