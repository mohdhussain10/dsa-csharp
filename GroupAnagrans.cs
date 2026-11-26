namespace DataStructureAlgo
{
    public static class GroupAnagrans
    {
        /// <summary>
        /// GetGroupOfAnagrams
        /// TC: O(n.klogk). Because of sorting every words
        /// </summary>
        /// <param name="listOfWords"></param>
        /// <returns></returns>
        public static List<List<string>> GetGroupOfAnagrams(List<string> listOfWords)
        {
            var anagramDict = new Dictionary<string, List<string>>();

            foreach(var words in listOfWords)
            {
                var chars = words.ToCharArray();

                chars.Sort();

                var key = new String(chars);

                if(!anagramDict.TryGetValue(key, out var groups))
                {
                    groups = new List<string>();
                    anagramDict[key] = groups;
                }
                groups.Add(words);
            }

            return new List<List<string>>(anagramDict.Values);




        }
    }
}
