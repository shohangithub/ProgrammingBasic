namespace StatePattern.CursorPointer
{
    public class Canvas
    {
        private ITool CurrentTool;

        public void MouseUp()
        {
            if (CurrentTool != null) CurrentTool.MouseUp();
        }

        public void MouseDown()
        {
            if(CurrentTool != null) CurrentTool.MouseDown();
        }

        public ITool GetCurrentTool() => CurrentTool;
        public void SetCurrentTool(ITool tool)=> CurrentTool = tool;
    }
}
