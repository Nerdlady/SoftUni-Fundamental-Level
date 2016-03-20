using System;

public class SimpleMathExam : Exam
{
    private readonly int maxProblemsToSolve = 10;

    private readonly int minProblemsToSolve = 0;

    private int problemsSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            return this.problemsSolved;
        }

        private set
        {
            if (value < this.minProblemsToSolve || value > this.maxProblemsToSolve)
            {
                throw new ArgumentException("Problems solved count has invalid value.");
            }

            this.problemsSolved = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }

        if (this.ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: nothing done.");
        }

        return new ExamResult(6, 2, 6, "Average result: nothing done.");
    }
}