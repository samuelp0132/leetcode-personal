

var result = DecompressRLElist(new int[] {1,2,3,4});
foreach (var val in result)
{
      Console.WriteLine(val);
}

int[] DecompressRLElist(int[] nums)
{
      //var rightBound = nums[^1];
      //var leftBound = nums[^1] - nums[^1] + 1;
      //int[] firstList = new int[1];
      //firstList = new[] { leftBound * nums[leftBound] };
      int[] firstList, secondList = new int [nums.Length / 2];
      for (int i = 0; i < nums.Length; i++)
      {
          firstList = new[] {nums[2 * i * 1]};
          
      }
      
      return firstList;
}