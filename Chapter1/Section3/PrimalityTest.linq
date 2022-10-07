<Query Kind="Statements" />

IEnumerable<bool> PrimalityTest(IEnumerable<int> values)
{
	return values.AsParallel().Select(val => IsPrime(val));
}
bool IsPrime(int val)
{
	for (int i = 2; i < val; i++)
	{
		if (val % i == 0)
		{
			return false;
		}
	}
	return true;
}