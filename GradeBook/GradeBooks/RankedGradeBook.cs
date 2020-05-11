using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (this.Students.Count < 5)
            {
                throw new InvalidOperationException();
            }

            if (((this.Students.FindAll(x => x.AverageGrade >= 90).Count * 100) / this.Students.Count) <= 20)
            {
                return 'A';
            }
            else if ((((this.Students.FindAll(x => x.AverageGrade >= 80).Count * 100) / this.Students.Count) > 20) &&
                    (((this.Students.FindAll(x => x.AverageGrade >= 80).Count * 100) / this.Students.Count) <= 40))
            {
                return 'B';
            }
            else if ((((this.Students.FindAll(x => x.AverageGrade >= 80).Count * 100) / this.Students.Count) > 40) &&
                    (((this.Students.FindAll(x => x.AverageGrade >= 80).Count * 100) / this.Students.Count) <= 60))
            {
                return 'C';
            }
            else if ((((this.Students.FindAll(x => x.AverageGrade >= 80).Count * 100) / this.Students.Count) > 60) &&
                    (((this.Students.FindAll(x => x.AverageGrade >= 80).Count * 100) / this.Students.Count) <= 80))
            {
                return 'D';
            }

            return 'F';
        }
    }
}