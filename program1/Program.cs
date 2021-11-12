int sumN(int N)
{
    int sum = 0;
    for (int i = 3; i <= N; i += 3) { sum += i; }
    for (int i = 5; i <= N; i += 5) { if (i % 3 != 0) { sum += i; } }
    return sum;
}

Console.WriteLine(sumN(1000 - 1));

// int bruteFsumN(int N, int divA, int divB = 1)
// {
//     int sum = 0;
//     for (int i = divA; i <= N; i += divA) { sum += i; }
//     if (divB > 1)
//     {
//         for (int i = divB; i <= N; i += divB) { if (i % divA != 0) { sum += i; } }
//     }
//     return sum;
// }

// int sumNOpt(int N, int divA, int divB)
// {
//     int a = divA * divB;
//     int ba = 0;
//     int b2 = 0;
//     int c = 0;
//     int cb = 0;
//     int cc = 0;
//     ba = bruteFsumN(a, divA, divB);
//     b2 = bruteFsumN(2 * a, divA, divB);
//     c = N / a;
//     cb = b2 - 2 * ba;
//     cc = bruteFsumN(c - 1, 1);
//     //Console.WriteLine(a + " " + ba + " " + b2 + " " + c + " " + cb + " " + cc );
//     return c * ba + cc * cb;
// }
// for (int K = 15; K < 999; K += 15)
// {
//     Console.Write(bruteFsumN(K, 3, 5) + "   ");
//     Console.WriteLine(sumNOpt(K, 3, 5));
// }