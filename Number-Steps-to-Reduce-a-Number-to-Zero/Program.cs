int NumberOfSteps(int num) {
    ushort stepsCount = 0;
    for (var i = 0; num > 0 ; i++)
    {
        if (num % 2 == 0)
        {
            num /= 2;
            stepsCount++;
        }
        else
        {
            num -= 1;
            stepsCount++;
        }
    }
    return stepsCount;
}