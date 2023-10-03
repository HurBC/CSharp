namespace CodeCamp
{
    internal class Program
    {

        static void Main( string[] args )
        {

            cuartoTrofeo();

        }

        static void cuartoTrofeo()
        {

            // ourAnimals array will store the following: 
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";
            string suggestedDonation = "";

            // variables that support data entry
            int maxPets = 8;
            string? readResult;
            string menuSelection = "";
            decimal decimalDonation = 0.00m;

            // array used to store runtime data
            string[,] ourAnimals = new string[maxPets, 7];

            // sample data ourAnimals array entries
            for ( int i = 0; i < maxPets; i++ )
            {
                switch ( i )
                {
                    case 0:
                        animalSpecies = "dog";
                        animalID = "d1";
                        animalAge = "2";
                        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                        animalNickname = "lola";
                        suggestedDonation = "85.00";
                        break;

                    case 1:
                        animalSpecies = "dog";
                        animalID = "d2";
                        animalAge = "9";
                        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        animalNickname = "gus";
                        suggestedDonation = "49.99";
                        break;

                    case 2:
                        animalSpecies = "cat";
                        animalID = "c3";
                        animalAge = "1";
                        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                        animalPersonalityDescription = "friendly";
                        animalNickname = "snow";
                        suggestedDonation = "40.00";
                        break;

                    case 3:
                        animalSpecies = "cat";
                        animalID = "c4";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "lion";
                        suggestedDonation = "";

                        break;

                    default:
                        animalSpecies = "";
                        animalID = "";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        suggestedDonation = "";
                        break;

                }

                ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Species: " + animalSpecies;
                ourAnimals[i, 2] = "Age: " + animalAge;
                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

                if ( !decimal.TryParse( suggestedDonation, out decimalDonation ) )
                {
                    decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
                }
                ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
            }

            // top-level menu options
            do
            {
                // NOTE: the Console.Clear method is throwing an exception in debug sessions
                Console.Clear();

                Console.WriteLine( "Welcome to the Contoso PetFriends app. Your main menu options are:" );
                Console.WriteLine( " 1. List all of our current pet information" );
                Console.WriteLine( " 2. Display all dogs with a specified characteristic" );
                Console.WriteLine();
                Console.WriteLine( "Enter your selection number (or type Exit to exit the program)" );

                readResult = Console.ReadLine();
                if ( readResult != null )
                {
                    menuSelection = readResult.ToLower();
                }

                // switch-case to process the selected menu option
                switch ( menuSelection )
                {
                    case "1":
                        // list all pet info
                        for ( int i = 0; i < maxPets; i++ )
                        {
                            if ( ourAnimals[i, 0] != "ID #: " )
                            {
                                Console.WriteLine();
                                for ( int j = 0; j < 7; j++ )
                                {
                                    Console.WriteLine( ourAnimals[i, j].ToString() );
                                }
                            }
                        }

                        Console.WriteLine( "\r\nPress the Enter key to continue" );
                        readResult = Console.ReadLine();

                        break;

                    case "2":
                        // #1 Display all dogs with a multiple search characteristics

                        string dogCharacteristic = "";
                        string[] dogCharacteristics;

                        while ( dogCharacteristic == "" )
                        {
                            // #2 have user enter multiple comma separated characteristics to search for
                            Console.WriteLine( $"\r\nEnter one desired dog characteristic to search for separated by comas" );
                            readResult = Console.ReadLine();
                            if ( ( readResult != null ) && ( readResult.Length != 0 ) )
                            {
                                dogCharacteristic = readResult.ToLower().Trim();

                                dogCharacteristics = dogCharacteristic.Split( ", " );

                                Console.WriteLine();
                            }
                        }

                        bool noMatchesDog = true;
                        string dogDescription = "";

                        // #4 update to "rotating" animation with countdown
                        string[] searchingIcons = {"|", "\\", "-", "/", "|", "-"};

                        // loop ourAnimals array to search for matching animals
                        for ( int i = 0; i < maxPets; i++ )
                        {

                            if ( ourAnimals[i, 1].Contains( "dog" ) )
                            {

                                // Search combined descriptions and report results
                                dogDescription = ourAnimals[i, 4] + "\r\n" + ourAnimals[i, 5];

                                for ( int j = 5; j > -1; j-- )
                                {
                                    // #5 update "searching" message to show countdown 
                                    foreach ( string characteristic in dogCharacteristics )
                                    {
                                        Console.Write( $"\rsearching...{dogCharacteristic} {icon}" );
                                        Thread.Sleep( 250 );
                                    }

                                    Console.Write( $"\r{new String( ' ', Console.BufferWidth )}" );
                                }

                                // #3a iterate submitted characteristic terms and search description for each term

                                if ( dogDescription.Contains( dogCharacteristic ) )
                                {
                                    // #3b update message to reflect term 
                                    // #3c set a flag "this dog" is a match
                                    Console.WriteLine( $"\nOur dog {ourAnimals[i, 3]} is a match!" );

                                    noMatchesDog = false;
                                }

                                // #3d if "this dog" is match write match message + dog description
                            }
                        }

                        if ( noMatchesDog )
                        {
                            Console.WriteLine( "None of our dogs are a match found for: " + dogCharacteristic );
                        }

                        Console.WriteLine( "\n\rPress the Enter key to continue" );
                        readResult = Console.ReadLine();

                        break;

                    default:
                        break;
                }

            } while ( menuSelection != "exit" );


        }

        static void stringMethods4()
        {
            //Remove

            String data = "12345John Smith          5000  3  ";
            String updateData = data.Remove(5, 20);

            Console.WriteLine( updateData );

            //Replace

            String message = "This--is--ex-amp-le--da-ta";

            message = message.Replace( "--", " " );
            message = message.Replace( "-", "" );

            Console.WriteLine( message );


        }

        static void stringMethods3()
        {

            //IndexOf
            string message = "What is the value <span>between the tags</span>?";

            const string openSpan = "<span>";
            const string closeSpan = "</span>";

            int openingPosition = message.IndexOf(openSpan);
            int closingPosition = message.IndexOf(closeSpan);

            openingPosition += openSpan.Length;

            int length = closingPosition - openingPosition;

            Console.WriteLine( message.Substring( openingPosition, length ) + "\n" );

            //LastIndexOf
            string message2 = "(What if) I am (only interested) in the last (set of parentheses)?";

            int openingPosition2 = message2.LastIndexOf('(');
            int closingPosition2 = message2.LastIndexOf(')');
            int length2 = closingPosition2 - ++openingPosition2;

            Console.WriteLine( message2.Substring( openingPosition2, length2 ) + "\n" );

            //IndexOfAny
            string message3 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

            // The IndexOfAny() helper method requires a char array of characters. 
            // You want to look for:

            char[] openSymbols = { '[', '{', '(' };

            // You'll use a slightly different technique for iterating through 
            // the characters in the string. This time, use the closing 
            // position of the previous iteration as the starting index for the 
            //next open symbol. So, you need to initialize the closingPosition 
            // variable to zero:

            int closingPosition3 = 0;

            while ( true )
            {
                int openingPosition3 = message3.IndexOfAny(openSymbols, closingPosition3);

                if ( openingPosition3 == -1 )
                    break;

                string currentSymbol = message3.Substring(openingPosition3, 1);

                // Now  find the matching closing symbol
                char matchingSymbol = ' ';

                switch ( currentSymbol )
                {
                    case "[":
                        matchingSymbol = ']';
                        break;
                    case "{":
                        matchingSymbol = '}';
                        break;
                    case "(":
                        matchingSymbol = ')';
                        break;
                }

                // To find the closingPosition, use an overload of the IndexOf method to specify 
                // that the search for the matchingSymbol should start at the openingPosition in the string. 

                openingPosition3 += 1;
                closingPosition3 = message3.IndexOf( matchingSymbol, openingPosition3 );

                // Finally, use the techniques you've already learned to display the sub-string:

                int length3 = closingPosition3 - openingPosition3;
                Console.WriteLine( message3.Substring( openingPosition3, length3 ) );
            }

        }

        static void formateoDeStrings()
        {

            //Formateo compuesto
            string first = "Hello";
            string second = "World";

            Console.WriteLine( "{1} {0}!", first, second );
            Console.WriteLine( "{0} {0} {0}!", first, second );

            Console.WriteLine();

            //Foramteo de monedas
            decimal price = 123.45m;

            int discount = 50;

            Console.WriteLine( $"Price: {price:C} (Save {discount:C})" );

            Console.WriteLine();

            //Formateo de numeros
            decimal measurement = 123456.78912m;

            Console.WriteLine( $"Measurement: {measurement:N} units" );
            Console.WriteLine( $"Measurement: {measurement:N4} units" );

            Console.WriteLine();

            //Formateo de porcentajes
            decimal tax = .36785m;

            Console.WriteLine( $"Tax rate: {tax:P2}" );

            Console.WriteLine();

            //Combinacion de enfoques de formateo

            decimal price2 = 67.55m;
            decimal salePrice = 59.99m;

            string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price2 - salePrice), price2);

            yourDiscount += $"A discount of {( ( price2 - salePrice ) / price2 ):P2}!"; //inserted

            Console.WriteLine( yourDiscount );

            Console.WriteLine();

            //Formateo con adicion de espacion en blanco
            string input = "Pad this";

            Console.WriteLine( input.PadLeft( 12, '-' ) );
            Console.WriteLine( input.PadRight( 12, '-' ) );

        }

        static void stringMethods2()
        {

            String value = "abc123";

            char[] valueArray = value.ToCharArray();

            Array.Reverse( valueArray );

            String result = new String( valueArray );

            Console.WriteLine("reverse: {0}", result);
            Console.WriteLine();

            String result2 = String.Join(",", valueArray);

            Console.WriteLine("Join: {0}", result2);
            Console.WriteLine();

            String[] items = result2.Split(',');

            Console.WriteLine( "Split:" );

            foreach ( String item in items )
            {
                Console.WriteLine(item);
            }

        }

        static void arrayMethods()
        {

            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine( "Sorted..." );

            Array.Sort( pallets );

            foreach ( var pallet in pallets )
            {
                Console.WriteLine( $"-- {pallet}" );
            }

            Console.WriteLine();
            Console.WriteLine( "Reversed..." );

            Array.Reverse( pallets );

            foreach ( var pallet in pallets )
            {
                Console.WriteLine( $"-- {pallet}" );
            }

            Console.WriteLine();

            Array.Clear( pallets, 0, 2 );

            Console.WriteLine( $"Clearing 2 ... count: {pallets.Length}" );

            foreach ( var pallet in pallets )
            {
                Console.WriteLine( $"-- {pallet}" );
            }

            Console.WriteLine();

            Array.Resize(ref pallets, 6);

            Console.WriteLine( $"Resizing 6 ... count: {pallets.Length}" );

            pallets[4] = "C01";
            pallets[5] = "C02";

            foreach (var pallet in pallets )
            {
                Console.WriteLine( $"-- {pallet}" );
            }

            Console.WriteLine( "" );

            Array.Resize( ref pallets, 3 );

            Console.WriteLine( $"Resizing 3 ... count: {pallets.Length}" );

            foreach ( var pallet in pallets )
            {
                Console.WriteLine( $"-- {pallet}" );
            }

        }

        static void tercerTrofeo()
        {
            // the ourAnimals array will store the following: 
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";

            // variables that support data entry
            int maxPets = 8;
            string? readResult;
            string menuSelection = "";
            int petCount = 0;
            string anotherPet = "y";
            bool validEntry = false;
            int petAge = 0;


            // array used to store runtime data, there is no persisted data
            string[,] ourAnimals = new string[maxPets, 6];

            for ( int i = 0; i < maxPets; i++ )
            {
                switch ( i )
                {
                    case 0:
                        animalSpecies = "dog";
                        animalID = "d1";
                        animalAge = "2";
                        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                        animalNickname = "lola";
                        break;
                    case 1:
                        animalSpecies = "dog";
                        animalID = "d2";
                        animalAge = "9";
                        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        animalNickname = "loki";
                        break;
                    case 2:
                        animalSpecies = "cat";
                        animalID = "c3";
                        animalAge = "1";
                        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                        animalPersonalityDescription = "friendly";
                        animalNickname = "Puss";
                        break;
                    case 3:
                        animalSpecies = "cat";
                        animalID = "c4";
                        animalAge = "?";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        break;
                    default:
                        animalSpecies = "";
                        animalID = "";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        break;
                }

                ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Species: " + animalSpecies;
                ourAnimals[i, 2] = "Age: " + animalAge;
                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
            }

            do
            {

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

                readResult = Console.ReadLine();

                switch ( readResult )
                {
                    case "1":
                        // List all of our current pet information
                        for ( int i = 0; i < maxPets; i++ )
                        {
                            if ( ourAnimals[i, 0] != "ID #: " )
                            {

                                for ( int j = 0; j < 6; j++ )
                                    Console.WriteLine( ourAnimals[i, j] );
                            }

                            Console.WriteLine();
                        }

                        Console.WriteLine( "Press the Enter key to continue." );

                        readResult = Console.ReadLine();
                        break;

                    case "2":
                        // Add a new animal friend to the ourAnimals array
                        anotherPet = "y";

                        petCount = 0;

                        for ( int i = 0; i < maxPets; i++ )
                        {
                            if ( ourAnimals[i, 0] != "ID #: " )
                                petCount += 1;
                        }

                        if ( petCount < maxPets )
                            Console.WriteLine( $"We currently have {petCount} pets that need homes. We can manage {( maxPets - petCount )} more." );

                        while ( anotherPet == "y" && petCount < maxPets )
                        {

                            validEntry = false;

                            // get species (cat or dog) - string animalSpecies is a required field 
                            do
                            {

                                Console.WriteLine( "\n\rEnter 'dog' or 'cat' to begin a new entry" );

                                readResult = Console.ReadLine();

                                if ( readResult != null )
                                {
                                    animalSpecies = readResult.ToLower();

                                    validEntry = ( animalSpecies != "dog" && animalSpecies != "cat" ) ? false : true;
                                }

                            } while ( validEntry == false );

                            animalID = animalSpecies.Substring( 0, 1 ) + ( petCount + 1 ).ToString();

                            // get the pet's age. can be ? at initial entry.
                            do
                            {

                                Console.WriteLine( "Enter the pet's age or enter ? if unknown" );

                                readResult = Console.ReadLine();

                                if ( readResult != null )
                                    animalAge = readResult;

                                if ( animalAge != "?" )
                                    validEntry = int.TryParse( animalAge, out petAge );
                                else
                                    validEntry = true;


                            } while ( validEntry == false );

                            // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                            do
                            {

                                Console.WriteLine( "Enter a physical description of the pet (size, color, gender, weight, housebroken) Required" );

                                readResult = Console.ReadLine();

                                if ( readResult != null )
                                    animalPhysicalDescription = readResult.ToLower();

                                if ( animalPhysicalDescription == "" )
                                    Console.WriteLine( "Write something" );


                            } while ( animalPhysicalDescription == "" );

                            // get a description of the pet's personality - animalPersonalityDescription can be blank.
                            do
                            {

                                Console.WriteLine( "Enter a description of the pet's personality (likes or dislikes, tricks, energy level)" );

                                readResult = Console.ReadLine();

                                if ( readResult == null )
                                    animalPersonalityDescription = readResult.ToLower();

                                if ( animalPersonalityDescription == "" )
                                    animalPersonalityDescription = "tbd";

                            } while ( animalPersonalityDescription == "" );

                            // get the pet's nickname. animalNickname can be blank.
                            do
                            {
                                Console.WriteLine( "Enter a nickname for the pet" );
                                readResult = Console.ReadLine();
                                if ( readResult != null )
                                {
                                    animalNickname = readResult.ToLower();
                                    if ( animalNickname == "" )
                                    {
                                        animalNickname = "tbd";
                                    }
                                }
                            } while ( animalNickname == "" );

                            // store the pet information in the ourAnimals array (zero based)
                            ourAnimals[petCount, 0] = "ID #: " + animalID;
                            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                            ourAnimals[petCount, 2] = "Age: " + animalAge;
                            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                            petCount = petCount + 1;

                            if ( petCount < maxPets )
                            {
                                // another pet?
                                Console.WriteLine( "Do you want to enter info for another pet (y/n)" );
                                do
                                {
                                    readResult = Console.ReadLine();

                                    if ( readResult != null )
                                        anotherPet = readResult.ToLower();

                                } while ( anotherPet != "y" && anotherPet != "n" );
                            }

                        }

                        if ( petCount >= maxPets )
                        {
                            Console.WriteLine( "We have reached our limit on the number of pets that we can manage." );
                            Console.WriteLine( "Press the Enter key to continue." );

                            readResult = Console.ReadLine();
                        }

                        break;

                    case "3":
                        // Ensure animal ages and physical descriptions are complete
                        //
                        //    ourAnimals[i, 2] = "Age: " + animalAge;
                        //    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;

                        for ( int i = 0; i < maxPets; i++ )
                        {
                            if ( ourAnimals[i, 2] == "Age: ?" && ourAnimals[i, 0] != "ID #: " )
                            {
                                do
                                {
                                    Console.WriteLine( $"Enter an age for {ourAnimals[i, 0]}" );
                                    readResult = Console.ReadLine();
                                    if ( readResult != null )
                                    {
                                        animalAge = readResult;
                                        validEntry = int.TryParse( animalAge, out petAge );
                                    }
                                } while ( validEntry == false );
                                ourAnimals[i, 2] = "Age: " + animalAge.ToString();
                            }

                            if ( ourAnimals[i, 4] == "Physical description: " && ourAnimals[i, 0] != "ID #: " )
                            {
                                do
                                {
                                    Console.WriteLine( $"Enter a physical description for {ourAnimals[i, 0]} (size, color, gender, weight, housebroken)" );
                                    readResult = Console.ReadLine();
                                    if ( readResult != null )
                                    {
                                        animalPhysicalDescription = readResult.ToLower();
                                        if ( animalPhysicalDescription == "" )
                                        {
                                            validEntry = false;
                                        }
                                        else
                                        {
                                            validEntry = true;
                                        }

                                    }
                                } while ( validEntry == false );

                                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                            }
                        }
                        Console.WriteLine( "\n\rAge and physical description fields are complete for all of our friends. \n\rPress the Enter key to continue" );
                        readResult = Console.ReadLine();

                        break;

                    case "4":
                        // Ensure animal nickname and personality descriptions are complete
                        //
                        //    ourAnimals[i, 3] = "Nickname: " + animalNickname;
                        //    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

                        for ( int i = 0; i < maxPets; i++ )
                        {
                            if ( ourAnimals[i, 3] == "Nickname: " && ourAnimals[i, 0] != "ID #: " )
                            {
                                do
                                {
                                    Console.WriteLine( $"Enter a nickname for {ourAnimals[i, 0]}" );
                                    readResult = Console.ReadLine();
                                    if ( readResult != null )
                                    {
                                        animalNickname = readResult;
                                        if ( animalNickname == "" )
                                        {
                                            validEntry = false;
                                        }
                                        else
                                        {
                                            validEntry = true;
                                        }

                                    }

                                } while ( validEntry == false );

                                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                            }

                            if ( ourAnimals[i, 5] == "Personality: " && ourAnimals[i, 0] != "ID #: " )
                            {
                                do
                                {
                                    //"Enter a description of the pet's personality (likes or dislikes, tricks, energy level"
                                    Console.WriteLine( $"Enter a personality description for {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level)" );
                                    readResult = Console.ReadLine();
                                    if ( readResult != null )
                                    {
                                        animalPersonalityDescription = readResult.ToLower();
                                        if ( animalPersonalityDescription == "" )
                                        {
                                            validEntry = false;
                                        }
                                        else
                                        {
                                            validEntry = true;
                                        }
                                    }
                                } while ( validEntry == false );

                                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
                            }
                        }
                        Console.WriteLine( "\n\rAge and physical description fields are complete for all of our friends. \n\rPress the Enter key to continue" );
                        readResult = Console.ReadLine();

                        break;

                    case "5":
                        Console.WriteLine( "UNDER CONSTRUCTION - please check back next month to see progress." );
                        Console.WriteLine( "Press the Enter key to continue." );
                        readResult = Console.ReadLine();
                        break;

                    case "6":
                        Console.WriteLine( "UNDER CONSTRUCTION - please check back next month to see progress." );
                        Console.WriteLine( "Press the Enter key to continue." );
                        readResult = Console.ReadLine();
                        break;

                    case "7":
                        Console.WriteLine( "UNDER CONSTRUCTION - please check back next month to see progress." );
                        Console.WriteLine( "Press the Enter key to continue." );
                        readResult = Console.ReadLine();
                        break;

                    case "8":
                        Console.WriteLine( "UNDER CONSTRUCTION - please check back next month to see progress." );
                        Console.WriteLine( "Press the Enter key to continue." );
                        readResult = Console.ReadLine();
                        break;

                    default:
                        break;
                }

            } while ( readResult.ToLower() != "exit" && readResult != null );

        }

        static void stringsMethods()
        {
            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
            int stringsCount = myStrings.Length;

            string myString = "";
            int periodLocation = 0;

            for ( int i = 0; i < stringsCount; i++ )
            {
                myString = myStrings[i];
                periodLocation = myString.IndexOf( "." );

                string mySentence;

                // extract sentences from each string and display them one at a time
                while ( periodLocation != -1 )
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

        static void swicthExample()
        {

            Console.WriteLine( "Enter your role name (Administrator, Manager, or User)" );

            string? value;
            bool isValid = false;

            do
            {

                value = Console.ReadLine();

                switch ( value.ToLower() )
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
            } while ( !isValid );

            Console.WriteLine();
        }

        static void doWhileLoop()
        {

            Console.WriteLine( "Escribe un numero entero entre el 5 y el 10" );

            int value;

            string? read;

            bool validNumber = false;

            do
            {
                read = Console.ReadLine();

                validNumber = int.TryParse( read, out value );

                if ( !validNumber )
                    Console.WriteLine( "Sorry, you entered an invalid number, please try again" );
                else
                {
                    if ( value > 10 || value < 5 )
                        Console.WriteLine( $"You entered {value}. Please enter a number between 5 and 10." );
                    else
                    {
                        Console.WriteLine( $"Your input value ({value}) has been accepted." );
                        break;
                    }
                }

            } while ( true );

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

            for ( int i = 0; i < notasEstudiantes.Length; i++ )
            {
                int gradedAssignments = 0;
                int gradedExtraCreditAssignments = 0;
                int sumScore = 0;
                int sumExtraCredits = 0;

                decimal currentStudentGrade = 0;
                decimal currentStudentExamScore = 0;
                decimal currentStudentExtraCreditScore = 0;

                foreach ( int nota in notasEstudiantes[i] )
                {
                    gradedAssignments += 1;

                    if ( gradedAssignments <= examAssignments )
                        sumScore = sumScore + nota;
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
            for ( int i = 0; i < notasEstudiantes.Length; i++ )
            {
                studentGrade[i] = ( studentGrade[i] > 100 ) ? 100 : studentGrade[i];

                if ( studentGrade[i] > scoreClave[4] )
                    grado[i] = "A+";
                else
                {
                    if ( studentGrade[i] > scoreClave[3] )
                        grado[i] = ( studentGrade[i] < 93 ) ? "A-" : "A";
                    else if ( studentGrade[i] > scoreClave[2] )
                    {
                        if ( studentGrade[i] > 87 )
                            grado[i] = "B+";
                        else
                        {
                            grado[i] = ( studentGrade[i] > 83 ) ? "B" : "B-";
                        }
                    }
                    else if ( studentGrade[i] > scoreClave[1] )
                    {
                        if ( studentGrade[i] > 77 )
                            grado[i] = "C+";
                        else
                        {
                            grado[i] = ( studentGrade[i] > 73 ) ? "C" : "C-";
                        }
                    }
                    else if ( studentGrade[i] > scoreClave[0] )
                    {
                        if ( studentGrade[i] > 67 )
                            grado[i] = "D+";
                        else
                        {
                            grado[i] = ( studentGrade[i] > 63 ) ? "D" : "D-";
                        }
                    }
                    else
                        grado[i] = "F";
                }
            }

            Console.WriteLine( "Student\t\tExam Score\tOverall Grade\tExtra Credit\n" );

            for ( int i = 0; i < studentGrade.Length; i++ )
            {
                Console.WriteLine( $"{estudiantes[i]}\t\t{studentGrade[i]}\t\t{studentExamScore[i]}\t{grado[i]}\t{studentExtraCreditScore[i]}({( ( (decimal) extraCredits[i] / 10 ) / examAssignments )} pts)" );
            }

            Console.WriteLine();
        }
    }
}