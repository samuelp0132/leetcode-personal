
var result = BalancedStringSplit("RLRRRLLRLL");
Console.WriteLine(result);

int BalancedStringSplit(string s)
{
    ushort balance = 0, count = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == 'L')
        {
            balance++;
        }
        else
        {
            balance--;
        }

        if (balance == 0)
        {
            count++;
        }
    }

    return count;
}