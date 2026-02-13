public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problem;

    public MathAssignment(string studentName, string topic, string textBookSection, string problem) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problem = problem;
    }

    

    public string GetHomeWorkList()
    {
        return $"{GetStudentName()} - {GetTopic()}\n{_textBookSection} {_problem}";
    }
}