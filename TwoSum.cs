namespace DataStructureAlgo
{
    public static class TwoSum
    {
        public static List<int> SolveTwoSumProblem(int[] arr, int target)
        {


            if (!arr.Any()) return new List<int>();

            #region Pseudo Code
            // step1: Traverse array items and get the need
            //step2: Check if need is already available in dictionary.
            //Step3: if available, get the indice and return
            //step4: if not, insert in to visited and continue [2,3,1] 6 x+y+z = target
            #endregion

            var visitedMap = new Dictionary<int, int>();

            for (var i = 0; i < arr.Length; i++)
            {
                var need = target - arr[i];
                if (visitedMap.ContainsKey(need))
                {
                    var indiceOfNeedElement = visitedMap[need];
                    return new List<int> { indiceOfNeedElement, i };
                }
                else
                {
                    visitedMap[arr[i]] = i;

                }
            }
            return new List<int>();

        }

    }
}
