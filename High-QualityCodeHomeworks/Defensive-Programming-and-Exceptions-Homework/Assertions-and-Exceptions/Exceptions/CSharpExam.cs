using System;

public class CSharpExam : Exam
{
    private readonly int maxScore = 100;

    private readonly int minScore = 0;

    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }

        private set
        {
            if (value < this.minScore || value > this.maxScore)
            {
                string message = "Score cannot be less than " + this.minScore + " or greater than " + this.maxScore;
                throw new ArgumentOutOfRangeException(message);
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }
}