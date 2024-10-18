class Quiz
{
   List<Question> questions = new List<Question>();

    public void AddQuestion(string questionText, string answer)
    {
        Question newQuestion = new Question(questionText, answer);
        questions.Add(newQuestion);
        
    }

    public void ShowAllQuestions()
    {
        foreach(Question question in questions)
        {
            System.Console.WriteLine(question);
        }
    }
}