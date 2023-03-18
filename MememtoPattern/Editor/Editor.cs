namespace MememtoPattern.Editor
{
    public class Editor
    {
        private string _content;

        public EditorState CreateState() => new EditorState(_content);
        public void Restore(EditorState state) => _content = state.GetContent();
        public void SetContent(string content) => _content = content;
        public string GetContent() => _content;

    }
}
