using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MememtoPattern.Editor
{
    public class History
    {
        private IList<EditorState> states = new List<EditorState>();

        public void Push(EditorState state) => states.Add(state);
        public EditorState Pop()
        {
            var lastState = states[states.Count - 1];
            states.Remove(lastState);
            return lastState;
        }
    }
}