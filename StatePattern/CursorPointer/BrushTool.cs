namespace StatePattern.CursorPointer
{
    public class BrushTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush a icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a Line");
        }
    }
}
