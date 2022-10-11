<Query Kind="Statements" />

static int ParallelSum(IEnumerable<int> values)
{
	return values.AsParallel().Aggregate(
		seed: 0,
		func: (sum, item) => sum + item
	);
}