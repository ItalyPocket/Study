
// {
//     string RoleNameTell = "niko";
//     string RoleTakeAbout = "2";
//     string RoleSpeak = $"{RoleNameTell}说：{RoleTakeAbout}";
//     Console.WriteLine(RoleSpeak);
// }
// {
//     niko(9, 10);
// }
// int niko(int T1, int T2)
// {
//     Console.WriteLine(T1 + T2);
//     return T1 * T2;
// }
// {
//     int kimi = niko(10, 10);
//     string umi = miku("地道", kimi);
// }
// string miku(string RoleNameTell, int niko)
// {
//     Console.WriteLine($"{RoleNameTell}说：{niko}");
//     return "喵喵喵喵喵";
// }
// {
//     string umi = miku;
//     Console.WriteLine(umi);
// }
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


