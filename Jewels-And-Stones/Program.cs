public class Solution {
    public int NumJewelsInStonesOne(string jewels, string stones)
    {
        char[] arrJewels = jewels.ToCharArray();
        char[] arrStones = stones.ToCharArray();
        int occurrency = 0;
        for (int i = 0; i < stones.Length; i++)
        {
            if (arrJewels[i] == arrStones[i])
                occurrency += 1;
        }

        return occurrency;
    }
    
    public int NumJewelsInStonesTwo(string jewels, string stones)
    {
        int occurrency = 0;
        for (int i = 0; i < stones.Length; i++)
        {
            if (jewels.IndexOf(stones[i]) != -1)
                occurrency += 1;
        }
        return occurrency;
    }
}