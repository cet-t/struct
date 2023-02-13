using System;
using System.Collections.Generic;

class structs
{
    struct Datas
    {
        public (float, float) playerPos;
        public string stage;

        public Datas((float, float) _pos, string _stage)
        {
            this.playerPos = _pos;
            this.stage = _stage;
        }
    }

    public static void Main()
    {
        Datas cet = new((123, 456), "Stage1");
        Console.WriteLine($"{cet.playerPos}, {cet.stage}");
    }
}
