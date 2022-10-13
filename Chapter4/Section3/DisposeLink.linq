<Query Kind="Statements">
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
</Query>

var multiplyBlock = new TransformBlock<int, int>(item => item * 2);
var subtractBlock = new TransformBlock<int, int>(item => item - 2);
IDisposable link = multiplyBlock.LinkTo(subtractBlock);
multiplyBlock.Post(1);
multiplyBlock.Post(2);
link.Dispose();