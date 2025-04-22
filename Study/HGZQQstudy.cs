string stop = "go";
for (Console.WriteLine("请输入所需要计算的内容"); ; Console.WriteLine("请输入所需要计算的内容"))
{
    string WhatYouEntered = Console.ReadLine();
    if (WhatYouEntered == "stop")
    {
        stop = "stop";
        Console.WriteLine("程序已停止");
        break;
    }
    while (WhatYouEntered == null || WhatYouEntered.Trim() == "")
    {
        Console.WriteLine("你输入的内容为空，请重新输入");
        WhatYouEntered = Console.ReadLine();
    }
    int Howlong = WhatYouEntered.Length;
    int miduem = WhatYouEntered.IndexOf("+");
    if (miduem == -1)
    {
        miduem = WhatYouEntered.IndexOf("-");
        if (miduem == -1)
        {
            miduem = WhatYouEntered.IndexOf("*");
            if (miduem == -1)
            {
                miduem = WhatYouEntered.IndexOf("/");
                if (miduem == -1)
                {
                    Console.WriteLine("你输入的内容不符合计算要求，请重新输入");
                }
                else
                {
                    float sum = nuber1(miduem) / nuber2(miduem);
                    Console.WriteLine("计算结果为" + sum);
                }
            }
            else
            {
                float sum = nuber1(miduem) * nuber2(miduem);
                Console.WriteLine("计算结果为" + sum);
            }
        }
        else
        {
            float sum = nuber1(miduem) - nuber2(miduem);
            Console.WriteLine("计算结果为" + sum);
        }
    }
    else
    {
        float sum = nuber1(miduem) + nuber2(miduem);
        Console.WriteLine("计算结果为" + sum);
    }
    float nuber1(int miduem)
    {
        string nuber1 = WhatYouEntered.Substring(0, miduem);
        return float.Parse(nuber1);
    }
    float nuber2(int miduem)
    {
        string nuber2 = WhatYouEntered.Substring(miduem + 1, Howlong - miduem - 1);
        return float.Parse(nuber2);
    }
}
