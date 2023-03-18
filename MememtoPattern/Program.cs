using MememtoPattern.BankTransaction;
using MememtoPattern.Editor;

Console.WriteLine("Memento Pattern");

//var editor = new Editor();
//var history = new History();

//editor.SetContent("A");
//history.Push(editor.CreateState());

//editor.SetContent("B");
//history.Push(editor.CreateState());

//editor.SetContent("C");
//editor.Restore(history.Pop());

//Console.WriteLine(editor.GetContent());


var transaction = new Transaction(100);
var transactionHistory = new TransactionHistory<int>();
Console.WriteLine(transaction);

var t1 = transaction.CreateTransaction(50);
transactionHistory.push(t1);
Console.WriteLine(transaction);

var t2 = transaction.CreateTransaction(25);
transactionHistory.push(t2);
Console.WriteLine(transaction);

var t3 = transaction.CreateTransaction(25);
transactionHistory.push(t3);
Console.WriteLine(transaction);

var t4 = transaction.CreateTransaction(-10);
transactionHistory.push(t4);
Console.WriteLine(transaction);

Console.WriteLine("---------------------------");
var cancelTransaction = transactionHistory.pop();
transaction.UndoTransaction(cancelTransaction);
Console.WriteLine(transaction);

var cancelTransaction1 = transactionHistory.pop();
transaction.UndoTransaction(cancelTransaction1);
Console.WriteLine(transaction);

