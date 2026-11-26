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

   /// <summary>
  /// GetGroupOfAnagramUsingFreqApproach
  /// T.C : O(n.k) It is better than sort one because we removed sort complexity
  /// </summary>
  /// <param name="listOfWords"></param>
  /// <returns></returns>
  public static List<List<string>> GetGroupOfAnagramUsingFreqApproach(List<string> listOfWords)
  {
      var anagramDict = new Dictionary<string, List<string>>();

      foreach(var word in listOfWords)
      {
          var freq = new int[26];

          for(var c in word)
          {
              freq[c - 'a']++; // as every chars are stores in ascii. - 'a' will help to get value with 0-25 index

          }
          var key = string.Join('#', freq);

          if(!anagramDict.TryGetValue(key, out var group))
          {
              group = new List<string>();
              anagramDict[key] = group;
          }
          group.Add(word);

      }

      return new List<List<string>>(anagramDict.Values);
  }
    }
}
