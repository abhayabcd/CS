using System;
class Jegged
{
    static void Main()
    {
        int[][] j = new int[4][];

        j[0] = new int[4];
        j[1] = new int[1];
        j[2] = new int[3];
        j[3] = new int[2];

        j[0][0] =10;
        j[0][1] =20;
        j[0][2] =30;
        j[0][3] =40;
        j[1][0] =50;
        j[2][0] =60;
        j[2][1] =70;
        j[2][2] =80;
        j[3][0] =90;
        j[3][1] =100;

        for (int i = 0; i < j.Length; i++)
        {
            for (int k = 0; k < j[i].Length; k++)
            {
                Console.WriteLine(j[i][k]);
            }
        }
    }
}