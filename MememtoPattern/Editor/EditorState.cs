namespace MememtoPattern.Editor
{
    public class EditorState
    {
        private string _content;
        public EditorState(string content)
        {
            _content = content;
        }
        public EditorState CreateState() => new EditorState(_content);
        public string GetContent() => _content;

    }
}
