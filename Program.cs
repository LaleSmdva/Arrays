using System;

namespace Array___Object__Big_O_Notation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            int average,sumNums=0;
            int[] nums = {10,20,30,40};
            for(int i = 0; i < nums.Length; i++)
            {
                sumNums+=nums[i];
            }
            Console.WriteLine("Sum of this array is " +sumNums);
            average=sumNums/nums.Length;
            Console.WriteLine("Average is "+average);


            #endregion

            #region task2
               
             int countPositive=0, countNegative=0,countZero=0;
            int[] nums = {-5,-4,-3,0,6,7};
            for(int i=0;i<nums.Length;i++)
            {
                    if(nums[i]==0)
            {
                countZero++;
            }
                if(nums[i]>0)
                {
                    countPositive++;
                    
                }
                if(nums[i]<0)
                {
                    countNegative++;
                    
                }
              
            }
            Console.WriteLine("There are "+countPositive+" positive numbers in this array");
             Console.WriteLine("There are "+countNegative+" negative numbers in this array");
             Console.WriteLine("There is "+countZero+" neither positive nor negative number" );

            #endregion

            #region task3
                 int[] nums = {4,45,85,2,335,33};
            int maxNum=nums[0];
            for(int i=0;i<nums.Length;i++)
            {
                if(nums[i]>maxNum)
                {
                    maxNum=nums[i];
                    
                }
            }
            Console.WriteLine(maxNum+" is the greatest number");
            #endregion
        }
    }
}
