<Query Kind="Statements" />

static IEnumerable<int> MultiplyBy2(IEnumerable<int> values)
{
	return values.AsParallel().AsOrdered().Select(item => item * 2)
}