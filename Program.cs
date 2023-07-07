namespace GradeCalculator;

public class Program
{
    public static void Main(string[] args)
    {
        //We get the marks that is scored
        var myGrades = new MyGrades()

;       Console.WriteLine("What is the Marks Scored: ");

        //We convert the inpu into integer
        var marks= Convert.ToInt32(Console.ReadLine());
        
        //Then we take the inserted marks, invoke the getgradeinpercentage class to check
        //which grade does the inserted marks fall in and store it in a variable called grade.
        var grade=myGrades.GetGradesInPercentage(marks);

        //Then we output the grade
        Console.WriteLine($"Your grade is: {grade}");
    }
}
