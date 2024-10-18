class Question
{
    public string QuestionText {get; set;}
    public string Answer {get; set;}

    public Question(string questionText, string answer )
    {
        QuestionText = questionText;
        Answer = answer;
    }

}