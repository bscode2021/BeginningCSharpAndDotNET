using Ch11Ex03;

Primes primesFrom2to100 = new Primes(2, 1000);
foreach (long i in primesFrom2to100)
{
    Console.WriteLine($"{i} ");
}