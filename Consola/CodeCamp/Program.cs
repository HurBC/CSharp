namespace CodeCamp
{
    internal class Program
    {

        static void Main( string[] args )
        {
            Console.WriteLine( "Segundo trofeo:" );
            primerTrofeo();

            Console.WriteLine( "Tercer trofeo:" );/*
            tercerTrofeo1();
            tercerTrofeo2();
            tercerTrofeo3();*/
            tercerTrofeoAhoraSiQueSi();
        }

        static void tercerTrofeoAhoraSiQueSi()
        {
            int maxPets = 8;

            String? readResult;
            String[,] ourAnimals = new String[maxPets, 6];

            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        ourAnimals[i, 0] = "dog";
                        ourAnimals[i, 1] = "d1";
                        ourAnimals[i, 2] = "2";
                        ourAnimals[i, 3] = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                        ourAnimals[i, 4] = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                        ourAnimals[i, 5] = "lola";
                        break;
                    case 1:
                        ourAnimals[i, 0] = "dog";
                        ourAnimals[i, 1] = "d2";
                        ourAnimals[i, 2] = "9";
                        ourAnimals[i, 3] = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                        ourAnimals[i, 4] = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        ourAnimals[i, 5] = "loki";
                        break;
                    case 2:
                        ourAnimals[i, 0] = "cat";
                        ourAnimals[i, 1] = "c3";
                        ourAnimals[i, 2] = "1";
                        ourAnimals[i, 3] = "small white female weighing about 8 pounds. litter box trained.";
                        ourAnimals[i, 4] = "friendly";
                        ourAnimals[i, 5] = "Puss";
                        break;
                    case 3:
                        ourAnimals[i, 0] = "cat";
                        ourAnimals[i, 1] = "c4";
                        ourAnimals[i, 2] = "?";
                        ourAnimals[i, 3] = "";
                        ourAnimals[i, 4] = "";
                        ourAnimals[i, 5] = "";
                        break;
                    default:
                        ourAnimals[i, 0] = "";
                        ourAnimals[i, 1] = "";
                        ourAnimals[i, 2] = "";
                        ourAnimals[i, 3] = "";
                        ourAnimals[i, 4] = "";
                        ourAnimals[i, 5] = "";
                        break;
                }
            }

            Console.Clear();

            Console.WriteLine( "Welcome to the Contoso PetFriends app. Your main menu options are:" );
            Console.WriteLine( " 1. List all of our current pet information" );
            Console.WriteLine( " 2. Add a new animal friend to the ourAnimals array" );
            Console.WriteLine( " 3. Ensure animal ages and physical descriptions are complete" );
            Console.WriteLine( " 4. Ensure animal nicknames and personality descriptions are complete" );
            Console.WriteLine( " 5. Edit an animal’s age" );
            Console.WriteLine( " 6. Edit an animal’s personality description" );
            Console.WriteLine( " 7. Display all cats with a specified characteristic" );
            Console.WriteLine( " 8. Display all dogs with a specified characteristic" );
            Console.WriteLine();
            Console.WriteLine( "Enter your selection number (or type Exit to exit the program)" );

            do
            {
                try
                {
                    readResult = Console.WriteLine
                }

            } while ( readResult.ToLower() != "exit" || readResult != null);

        }

        static void tercerTrofeo3()
        {
            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
            int stringsCount = myStrings.Length;

            string myString = "";
            int periodLocation = 0;

            for (int i = 0; i < stringsCount; i++)
            {
                myString = myStrings[i];
                periodLocation = myString.IndexOf( "." );

                string mySentence;

                // extract sentences from each string and display them one at a time
                while (periodLocation != -1)
                {

                    // first sentence is the string value to the left of the period location
                    mySentence = myString.Remove( periodLocation );

                    // the remainder of myString is the string value to the right of the location
                    myString = myString.Substring( periodLocation + 1 );

                    // remove any leading white-space from myString
                    myString = myString.TrimStart();

                    // update the comma location and increment the counter
                    periodLocation = myString.IndexOf( "." );

                    Console.WriteLine( mySentence );
                }

                mySentence = myString.Trim();
                Console.WriteLine( mySentence );
            }

            Console.WriteLine();
        }

        static void tercerTrofeo2()
        {

            Console.WriteLine( "Enter your role name (Administrator, Manager, or User)" );

            string? value;
            bool isValid = false;

            do
            {

                value = Console.ReadLine();

                switch (value.ToLower())
                {
                    case "administrator":
                        Console.WriteLine( $"Your input value ({value}) has been accepted." );

                        isValid = true;

                        break;
                    case "manager":
                        Console.WriteLine( $"Your input value ({value}) has been accepted." );

                        isValid = true;

                        break;
                    case "user":
                        Console.WriteLine( $"Your input value ({value}) has been accepted." );

                        isValid = true;

                        break;
                    default:
                        Console.WriteLine( $"The role name that you entered, \"{value}\" is not valid. Enter your role name (Administrator, Manager, or User)" );

                        break;
                }
            } while (!isValid);

            Console.WriteLine();
        }

        static void tercerTrofeo1()
        {

            Console.WriteLine( "Escribe un numero entero entre el 5 y el 10" );

            int value;

            string? read;

            bool validNumber = false;

            do
            {
                read = Console.ReadLine();

                validNumber = int.TryParse( read, out value );

                if (!validNumber) Console.WriteLine( "Sorry, you entered an invalid number, please try again" );
                else
                {
                    if (value > 10 || value < 5) Console.WriteLine( $"You entered {value}. Please enter a number between 5 and 10." );
                    else
                    {
                        Console.WriteLine( $"Your input value ({value}) has been accepted." );
                        break;
                    }
                }

            } while (true);

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