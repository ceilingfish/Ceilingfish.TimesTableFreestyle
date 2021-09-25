record Result(int UserAnswer, int FirstNumber, int SecondNumber)
{
    public bool Correct => UserAnswer == CorrectAnswer;
    public int CorrectAnswer => FirstNumber * SecondNumber;
}