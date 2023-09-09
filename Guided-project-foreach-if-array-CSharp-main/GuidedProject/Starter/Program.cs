using System;

/// <summary>
/// Function to get the letter grade based on the numeric grade.
/// </summary>
/// <param name="currentStudentGrade">The numeric grade of the student.</param>
/// <returns>The letter grade of the student.</returns>
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

// Number of exam assignments
int examAssignments = 5;

// Array of student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

// Array of scores for each student
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

Console.WriteLine("Student\t\tGrade\n");

// Loop through each student
foreach (string student in studentNames)
{
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

    decimal scoresSum = 0;
    int scoresCount = 0;

    // Loop through each score
    foreach (int score in currentScores)
    {
        scoresCount++;

        // If the score is for an exam assignment, add it to the sum
        // If it's not, add a tenth of it to the sum as extra credit
        if (scoresCount <= examAssignments)
            scoresSum += score;
        else
            scoresSum += score / 10;
    }

    // Calculate the current grade
    var currentGrade = (decimal)scoresSum / examAssignments;

    // Output the student's name, grade, and letter grade
    Console.WriteLine($"{student}:\t\t{currentGrade}\t{GetLetterGrade(currentGrade)}");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();