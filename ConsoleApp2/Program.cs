double[] R = new double[25];
Random r = new Random();

for (int i = 0; i < R.Length; i++)
    R[i] = r.Next(-100, 100);

foreach (int i in R)
    Console.Write(i + " ");

for (int i = 0;i < R.Length; i++)
{
    if (R[i] < 0) R[i] = Math.Pow(R[i], 2);
    else if (R[i] > 0) R[i] = R[i] + 7;
    else R[i] = 0;
    Console.Write(R[i] + " ");
}