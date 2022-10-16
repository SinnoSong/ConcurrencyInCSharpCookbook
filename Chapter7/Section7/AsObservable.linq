<Query Kind="Statements">
  <NuGetReference>System.Reactive</NuGetReference>
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
</Query>

var buffer = new BufferBlock<int>();
IObservable<int> integers = buffer.AsObservable();
integers.Subscribe(data => Console.WriteLine(data),
	ex => Console.WriteLine(ex),
	() => Console.WriteLine("Done")
);
buffer.Post(13);