namespace StatePattern.CursorPointer
{
    public class SelectionTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection Icon");
        }

        public void MouseUp()
        {
          Console.WriteLine("Draw Dashed Rectangle");
        }
    }
}
