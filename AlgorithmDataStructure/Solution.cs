global using AlgorithmDataStructure;
using System;

namespace AlgorithmDataStructure
{
    public class Solution
    {
        //public TreeNode InvertTree(TreeNode root)
        //{
        //    if (root is null) return root;

        //}

        //public int PivotIndex(int[] nums)
        //{
        //    int LeftSum = 0;
        //    int RightSum = nums.Sum();
        //    for (int s = 0; s < nums.Length; s++)
        //    {
        //        RightSum -= nums[s];
        //        Console.WriteLine(LeftSum);
        //        Console.WriteLine(RightSum);
        //        Console.WriteLine(" ");
        //        if (LeftSum == RightSum)
        //        {
        //            return s;
        //            Console.ReadLine();
        //        }
        //        LeftSum += nums[s];
        //    }
        //    return -1;
        //    Console.ReadLine();
        //}

        //public bool IsIsomorphic(string s, string t)
        //{
        //    if (s.Length != t.Length) return false;
        //    char[] s_array = s.ToCharArray();
        //    char[] t_array = t.ToCharArray();

        //    Dictionary<char, char> hashmap_s = new Dictionary<char, char>();
        //    Dictionary<char, char> hashmap_t = new Dictionary<char, char>();

        //    for (int i = 0; i < t.Length; i++)
        //        {
        //        if (hashmap_s.ContainsKey(s_array[i]))
        //        {
        //            if (hashmap_s[s_array[i]] != t_array[i]) return false;
        //        }
        //        else
        //        {
        //            hashmap_s.Add(s_array[i], t_array[i]);
        //            if (hashmap.ContainsValue(t_array[i])) return false;
        //        }
        //    }
        //    return true;
        //}
    }
}

