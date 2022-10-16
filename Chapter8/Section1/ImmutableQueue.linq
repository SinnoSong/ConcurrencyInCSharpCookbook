<Query Kind="Statements">
  <Namespace>System.Collections.Immutable</Namespace>
</Query>

var queue = ImmutableQueue<int>.Empty;
queue = queue.Enqueue(13);
queue = queue.Enqueue(7);
foreach (var item in queue)
{
	Console.WriteLine(item);
}
int nextItem;
queue = queue.Dequeue(out nextItem);
Console.WriteLine(nextItem);