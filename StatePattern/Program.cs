// See https://aka.ms/new-console-template for more information
using StatePattern.CursorPointer;

Console.WriteLine("Implementation of State Pattern");

var canvas = new Canvas();
canvas.SetCurrentTool(new EraserTool());
canvas.MouseUp();
canvas.MouseDown();

