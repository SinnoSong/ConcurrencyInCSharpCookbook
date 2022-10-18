<Query Kind="Statements">
  <NuGetReference>System.Reactive</NuGetReference>
  <Namespace>System.Windows</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
  <Namespace>System.Windows.Forms</Namespace>
  <Namespace>System.Reactive.Threading.Tasks</Namespace>
</Query>

CancellationToken cancellationToken = new CancellationToken();
IObservable<int> observable = Enumerable.Range(0, 19).ToObservable();
int lastElement = await observable.TakeLast(1).ToTask(cancellationToken);
int firstElement = await observable.Take(1).ToTask(cancellationToken);
IList<int> allElements = await observable.ToList().ToTask(cancellationToken);