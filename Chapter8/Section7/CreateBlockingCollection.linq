<Query Kind="Statements">
  <Namespace>System.Collections.Concurrent</Namespace>
</Query>

BlockingCollection<int> blockingStack = new BlockingCollection<int>(new ConcurrentStack<int>());
BlockingCollection<int> blockingBag = new BlockingCollection<int>(new ConcurrentBag<int>());