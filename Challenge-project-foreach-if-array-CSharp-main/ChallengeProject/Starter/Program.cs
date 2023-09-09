/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/

string GetLetterGrade(decimal currentStudentGrade)
{
    string currentStudentLetterGrade = "";

    // Determine the letter grade based on the numeric grade
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    return currentStudentLetterGrade;
}

int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    // Output the student's name
    Console.Write($"{student}:\t\t");

    int[] currentScores = new int[] { };

    // Determine which student's scores to use
    if (student == "Sophia")
        currentScores = sophiaScores;
    else if (student == "Andrew")
        currentScores = andrewScores;
    else if (student == "Emma")
        currentScores = emmaScores;
    else if (student == "Logan")
        currentScores = loganScores;
    else if (student == "Becky")
        currentScores = beckyScores;
    else if (student == "Chris")
        currentScores = chrisScores;
    else if (student == "Eric")
        currentScores = ericScores;
    else if (student == "Gregor")
        currentScores = gregorScores;
    else
        continue;

    decimal examScoresSum = 0;
    decimal extracreditScoresSum = 0;
    int scoresCount = 0;
    int extraCreditCount = 0;

    // Loop through each score
    foreach (int score in currentScores)
    {
        scoresCount++;

        // If the score is for an exam assignment, add it to the sum
        // If it's not, add a tenth of it to the sum as extra credit
        if (scoresCount <= examAssignments)
            examScoresSum += score;
        else
        {
            extraCreditCount++;
            extracreditScoresSum += score;
        }
    }

    // Output the exam score
    Console.Write($"{(decimal)examScoresSum / examAssignments}\t\t");

    // Calculate the current grade
    var overallGrade = (decimal)(examScoresSum + (extracreditScoresSum / 10)) / examAssignments;

    // Output the overall grade and letter grade
    Console.Write($"{overallGrade}\t{GetLetterGrade(overallGrade)}\t");

    // Output the extra credit
    Console.WriteLine($"{(decimal)extracreditScoresSum / extraCreditCount} ({((decimal)extracreditScoresSum / 10) / examAssignments} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
