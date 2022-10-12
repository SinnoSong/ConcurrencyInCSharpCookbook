<Query Kind="Statements" />

static IEnumerable<int> MultiplyBy2(IEnumerable<int> values)
{
	return values.AsParallel().Select(item => item * 2)
}