using System.Text;

namespace CodingChallenge.Data.Classes.Editors
{
    public abstract class Editor
    {
        protected StringBuilder _stringBuilder = new StringBuilder();

        public abstract void WriteTitle(string title);
        public abstract void WriteLine(string line);
        
        public abstract void AddLineBreak();
        
        public string Text => _stringBuilder.ToString();
    }
}