<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static int ParallelSum(IEnumerable<int> values)
{
	object mutex = new object();
	int result = 0;
	Parallel.ForEach(source: values,
	localInit:() => 0,
	body: (item, state, localValue) => localValue + item,
	localFinally: localValue =>
	 {
		 lock (mutex)
		 {
			 result += localValue;
		 }
	 });
	return result;
}