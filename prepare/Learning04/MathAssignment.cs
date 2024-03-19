public class MathAssignment : Assignment
{
   private string _textbookSection = "";
   private string _problems = "";

   public string GetTextBookSection()
   {
    return _textbookSection;
   }
   public void SetTextBookSection(string textBook)
   {
    _textbookSection = textBook;
   }
   public string GetProblems()
   {
    return _problems;
   }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
   public string GetHomeworkList()
   {
    return $"{_studentName} has {_topic} with {_textbookSection} and {_problems}";
   }
}