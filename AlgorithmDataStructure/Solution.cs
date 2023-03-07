global using AlgorithmDataStructure;
using System;

namespace AlgorithmDataStructure
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
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

        //public bool IsSubsequence(string s, string t)
        //{
        //    string initialvalue = s;
        //    string result = "";

        //    foreach( char a in t)
        //    {
        //        if ( s !=  "" && s[0] == a)
        //        {
        //            result += s[0];
        //            s = s.Remove(0, 1);
        //        }
        //    }

        //    return result == initialvalue;
        //}

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 is null) return list2;
            if (list2 is null) return list1;

            ListNode list3 = new ListNode();

            while( list1 is not null && list2 is not null)
            {
                if( list1.val < list2.val)
                {
                    list3.val = list1.val;
                    list1 = list1.next;
                    list3.next = MergeTwoLists();
                }
                if (list1.val > list2.val)
                {
                    list3.val = list2.val;
                    list2 = list2.next;
                    list3.next = MergeTwoLists();
                }
            }
        }
    }
}

