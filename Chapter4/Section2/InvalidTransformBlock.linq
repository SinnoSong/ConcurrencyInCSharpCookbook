<Query Kind="Statements">
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
</Query>

var block = new TransformBlock<int, int>(item =>
 {
	 if (item == 1)
	 {
		 throw new InvalidOperationException("Blech.");
	 }
	 return item * 2;
 });
 block.Post(1);
 block.Post(2);