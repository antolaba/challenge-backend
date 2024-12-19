namespace CodingChallenge.Data.Classes.Editors
{
    public class HtmlEditor: Editor
    {
        public override void WriteTitle(string title)
        {
            _stringBuilder.Append($"<h1>{title}</h1>");
        }

        public override void WriteLine(string line)
        {
            _stringBuilder.Append(line);
        }

        public override void AddLineBreak()
        {
            _stringBuilder.Append("<br/>");
        }
    }
}