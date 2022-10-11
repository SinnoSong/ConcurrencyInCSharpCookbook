<Query Kind="Statements" />

static int ParallelSum(IEnumerable<int> values)
{
	return values.AsParallel().Sum();
}