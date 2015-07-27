namespace Exception_handling
{
    using System;
    public class SimpleMathExam : Exam
    {
        private const int MinProblemsCount = 0;
        private const int MaxProblemsCount = 10;
        private const string BadResultsComment = "Bad result: nothing done.";
        private const string AverageResultsComment = "Average result: almost nothing done.";
        private const string GoodResultsComment = "Good result: almost everything's done correctly.";
        private const string ExcelentResultsComment = "Excellent result: everything's done correctly.";
        private const int BadGradeMaxProblems = 2;
        private const int AverageGradeMaxProblems = 5;
        private const int GoodGradeMaxProblems = 8;

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
                if (value < MinProblemsCount)
                {
                    this.problemsSolved = MinProblemsCount;
                }
                else if (value > MaxProblemsCount)
                {
                    this.problemsSolved = MaxProblemsCount;
                }
                else
                {
                    this.problemsSolved = value;
                }
            } 
        }

        public override ExamResult Check()
        {
            string comment;

            if (this.ProblemsSolved <= BadGradeMaxProblems)
            {
                comment = BadResultsComment;
            }
            else if (this.ProblemsSolved <= AverageGradeMaxProblems)
            {
                comment = AverageResultsComment;
            }
            else if (this.ProblemsSolved <= GoodGradeMaxProblems)
            {
                comment = GoodResultsComment;
            }
            else
            {
                comment = ExcelentResultsComment;
            }

            return new ExamResult(this.ProblemsSolved, MinProblemsCount, MaxProblemsCount, comment);
        }
    }
}
