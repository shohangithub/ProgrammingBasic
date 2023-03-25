// See https://aka.ms/new-console-template for more information
//using ObserverPattern.Concept;
//using ObserverPattern.PushStyle;
using ObserverPattern.PullStyle;

Console.WriteLine("Observer Pattern");

var dataSource = new DataSource();

//var spreadSheet1 = new SpreadSheet();
//var spreadSheet2 = new SpreadSheet();
//var spreadSheet3 = new SpreadSheet();
//var chart = new Chart();

var spreadSheet1 = new SpreadSheet(dataSource);
var spreadSheet2 = new SpreadSheet(dataSource);
var spreadSheet3 = new SpreadSheet(dataSource);
var chart = new Chart(dataSource);

dataSource.AddObserver(spreadSheet1);
dataSource.AddObserver(spreadSheet2);
dataSource.AddObserver(spreadSheet3);
dataSource.AddObserver(chart);

dataSource.SetValue(5);