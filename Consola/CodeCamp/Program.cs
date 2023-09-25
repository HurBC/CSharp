namespace CodeCamp
{
    internal class Program
    {

        static void Main( string[] args )
        {
            Console.WriteLine( "Segundo trofeo:" );
            primerTrofeo();

            Console.WriteLine( "Tercer trofeo:" );
            tercerTrofeo();
        }

        static void tercerTrofeo()
        {

            Console.WriteLine();
        }

        static void primerTrofeo()
        {

            String[] estudiantes = {"Sophia", "Andrew", "Emma", "Logan"};
            String[] grado = new String[estudiantes.Length];

            int[] scoreClave = {60, 70, 80, 90, 97};
            int[][] notasEstudiantes =
            {
                // Notas de Sophia
                new int[] { 90, 86, 87, 98, 100, 94, 90 },
                // Notas de Andrew
                new int[] { 92, 89, 81, 96, 90, 89 },
                // Notas de Emma
                new int[] { 90, 85, 87, 98, 68, 89, 89, 89 },
                // Notas de Logan
                new int[] { 90, 95, 87, 88, 96, 96 }
            };
            int[] extraCredits = new int[estudiantes.Length];

            decimal[] studentGrade = new decimal[estudiantes.Length];
            decimal[] studentExamScore = new decimal[estudiantes.Length];
            decimal[] studentExtraCreditScore = new decimal[estudiantes.Length];

            int examAssignments = 5;

            for (int i = 0; i < notasEstudiantes.Length; i++)
            {
                int gradedAssignments = 0;
                int gradedExtraCreditAssignments = 0;
                int sumScore = 0;
                int sumExtraCredits = 0;

                decimal currentStudentGrade = 0;
                decimal currentStudentExamScore = 0;
                decimal currentStudentExtraCreditScore = 0;

                foreach (int nota in notasEstudiantes[i])
                {
                    gradedAssignments += 1;

                    if (gradedAssignments <= examAssignments) sumScore = sumScore + nota;
                    else
                    {
                        gradedExtraCreditAssignments++;

                        sumExtraCredits += nota;
                    }
                }

                currentStudentExamScore = (decimal) ( sumScore ) / examAssignments;
                currentStudentExtraCreditScore = (decimal) ( sumExtraCredits ) / gradedExtraCreditAssignments;

                currentStudentGrade = (decimal) ( (decimal) sumScore + ( (decimal) sumExtraCredits / 10 ) ) / examAssignments;

                extraCredits[i] = sumExtraCredits;
                studentGrade[i] = currentStudentExamScore;
                studentExamScore[i] = currentStudentGrade;
                studentExtraCreditScore[i] = currentStudentExtraCreditScore;


            }
            for (int i = 0; i < notasEstudiantes.Length; i++)
            {
                studentGrade[i] = ( studentGrade[i] > 100 ) ? 100 : studentGrade[i];

                if (studentGrade[i] > scoreClave[4]) grado[i] = "A+";
                else
                {
                    if (studentGrade[i] > scoreClave[3])
                        grado[i] = ( studentGrade[i] < 93 ) ? "A-" : "A";
                    else if (studentGrade[i] > scoreClave[2])
                    {
                        if (studentGrade[i] > 87) grado[i] = "B+";
                        else
                        {
                            grado[i] = ( studentGrade[i] > 83 ) ? "B" : "B-";
                        }
                    }
                    else if (studentGrade[i] > scoreClave[1])
                    {
                        if (studentGrade[i] > 77) grado[i] = "C+";
                        else
                        {
                            grado[i] = ( studentGrade[i] > 73 ) ? "C" : "C-";
                        }
                    }
                    else if (studentGrade[i] > scoreClave[0])
                    {
                        if (studentGrade[i] > 67) grado[i] = "D+";
                        else
                        {
                            grado[i] = ( studentGrade[i] > 63 ) ? "D" : "D-";
                        }
                    }
                    else grado[i] = "F";
                }
            }

            Console.WriteLine( "Student\t\tExam Score\tOverall Grade\tExtra Credit\n" );

            for (int i = 0; i < studentGrade.Length; i++)
            {
                Console.WriteLine( $"{estudiantes[i]}\t\t{studentGrade[i]}\t\t{studentExamScore[i]}\t{grado[i]}\t{studentExtraCreditScore[i]}({( ( (decimal) extraCredits[i] / 10 ) / examAssignments )} pts)" );
            }

            Console.WriteLine();
        }
    }
}