//public class ListNode
//{
//      public int val;
//      public ListNode next;
//      public ListNode(int val=0, ListNode next=null)
//      {
//          this.val = val;
//          this.next = next;
//      }
// }

//public class Solution
//{
//    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
//    {
//        if (list1 is null) return list2;
//        if (list2 is null) return list1;

//        ListNode list3 = new ListNode();

//        while( list1 != null && list2 != null)
//        {
//            if (list1.val < list2.val)
//                    {
//                        list3.val = list1.val;
//                        list1 = list1.next;
//                        list3.next = MergeTwoLists(list1, list2);
//                    }
//                    if (list2.val < list2.val)
//                    {
//                        list3.val = list2.val;
//                        list2 = list2.next;
//                        list3.next =MergeTwoLists(list2, list1);
//                    }
//        }


//        if (list1 is null) list3 = list1;
//        if (list2 is null) list3 = list2;

//        return list3;
//    }
//}

//public class Solution
//{
//    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
//    {
//        if (list1 is null) return list2;
//        if (list2 is null) return list1;

//        if (list1.val < list2.val)
//        {
//            list1.next = MergeTwoLists(list1.next, list2);
//            return list1;
//        }
//        else
//        {
//            list2.next = MergeTwoLists(list2.next, list1);
//            return list2;
//        }
//    }
//}

//public class ListNode
//{
//        public int val;
//        public ListNode next;
//        public ListNode(int val = 0, ListNode next = null)
//    {
//        this.val = val;
//        this.next = next;
//             }
// }

//public class Solution
//{
//    public ListNode DeleteDuplicates(ListNode head)
//    {
//        while (head != null)
//        {
//            ListNode tmp = head;
//            if (tmp.val == head.val)
//            {
//                head = head.next;
//                tmp = null;
//            }
//            else
//            {
//                head = head.next;
//            }
//        }
//    }
//}

///////////sInvert Binary Tree


//public class Solution
//{
//    public TreeNode InvertTree(TreeNode root)
//    {
//        if (root != null)
//        {
//            var temp = root.left;
//            root.left = InvertTree(root.right);
//            root.right = InvertTree(temp);
//        }

//        return root;
//    }
//}

//using System;
//using System.Linq;
//using System.IO;
//using System.Collections.Generic;

//namespace test
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //1000 600 250 100
//            //2
//            //10:25 1500
//            //23:40 2001

//            List<int> timecheck = new List<int>
//            {
//                22,23,
//            };


//            int[] inputs = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//            int A = inputs[0];
//            int B = inputs[1];
//            int C = inputs[2];
//            int D = inputs[3];

//            int result = 0;

//            int times = int.Parse(Console.ReadLine());
//            for (int s = 0; s < times; s++)
//            {
//                string[] timeAndDistance = Console.ReadLine().Split(' ');
//                int[] time = timeAndDistance[0].Split(":").Select(int.Parse).ToArray();
//                int Distance = int.Parse(timeAndDistance[1]);
//                if (A + C > Distance)
//                {
//                    result = result + B;
//                    continue;
//                }
//                else
//                {
//                    int multiplication = (Distance - A) / C;
//                    result = result + B + D * multiplication;
//                }


//                if (timecheck.Contains(time[0]))
//                {
//                    double a = 1.2;
//                    a = result * 1.2;
//                    result = (int)a;
//                }
//            }

//            Console.WriteLine(result);
//        }
//    }
//}

////724 Find Pivot Index

//wrong

//int[] input = new int[6] { 1, 7, 3, 6, 5, 6 };
//int LeftSum = 0;
//int RightSum = 0;
//int[] leftSum_Array = new int[6];
//int[] RightSum_Array = new int[6];
//for ( int s = 0; s < input.Length; s++)
//{
//    LeftSum = +input[s];
//    leftSum_Array[s] = LeftSum;
//    RightSum = +input[input.Length - s];
//    RightSum_Array[s] = RightSum;
//}

//for( int i = 0; i < input.Length; i++)
//{
//    for( int j = 0; j < input.Length; j++)
//    {
//        if(leftSum_Array[i] == RightSum_Array[j])
//        {

//        }
//    }
//}

//correct

//int[] num = new int[6] { 1, 7, 3, 6, 5, 6 };
//int LeftSum = 0;
//int RightSum = 0;
//for (int s = 0; s < num.Length; s++)
//{
//    RightSum = num.Sum() - num[s] - LeftSum;
//    if( LeftSum == RightSum)
//    {

//    }
//    LeftSum = +num[s];
//}

//Solution solution = new Solution();
//Console.WriteLine(solution.PivotIndex(num));

//226.Invert Binary Tree
//int[] nums;
//int[] output = new int[nums.Length];
//output[0] = nums[0];
//for (int s = 1; s <  nums.Length; s++)
//{
//    output[s] = output[s - 1] + nums[s];
//}