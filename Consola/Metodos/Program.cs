namespace Metodos
{
    internal class Program
    {
        /*------------------------*/
        /*      Methods in C#     */
        /*------------------------*/

        /* What's is a Method? */

        // A method is an instruction that can be repeated
        // multiple times without rewriting

        // The methods can be classified according to their
        // declaration and return type

        // Methods must always be declared outside the 'Main' method
        // and there must never be methods inside other methods.

        /*-----------------------------*/
        /* Static and instance methods */
        /*-----------------------------*/

        /* Static Methods */

        // Static methods are methods that belong to the class itself,
        // to invoke these methods you must use the name of the class
        // itself together with the name of the method.

        // To declare a static method we use the reserved word static
        // followed by the type of method

        static void sayHello()
        {
            Console.WriteLine( "Hello World" );
        }

        /* Instance Methods */

        // Unlike static methods,
        // instance methods are those methods that require an object
        // of their class before they can be called, these methods
        // rather than belonging to the classes belong to the instance
        // of the class or to the Object.

        // To declare an instance method it is not necessary to write
        // the word static only the type of method with its name

        void presentation()
        {
            Console.WriteLine( "I'm Senko" );
        }

        /*------------------------*/
        /*    Types of Methods    */
        /*------------------------*/

        /* Void Methods */

        // Void methods are those that do not return any value, these
        // methods execute their code without returning anything.

        // This type of method is useful when you need to perform an action,
        // such as printing to the console or changing the value of a variable,
        // but you do not need to return any value.

        static void voidMethod()
        {
            Console.WriteLine( "I feel void every day" );
        }

        /* Return Methods */

        // Unlike void methods, return methods do return a value, being this of any
        // data type, these methods are declared by changing the word void for the
        // data type that the method will return.

        static String returnMethod()
        {
            return "WAKE UP WAKE UP WAKE UP WAKE UP WAKE UP WAKE UP WAKE UP WAKE UP";
        }

        int addition()
        {
            return 6 + 5;
        }

        static int number1()
        {
            return 1;
        }

        static int number2()
        {
            return 2;
        }

        static String message()
        {
            return "Senko is going to dominate the world..";
        }


        /*------------------------*/
        /* Parameters in a method */
        /*------------------------*/

        static void saySomething(string value)
        {
            Console.WriteLine( value );
        }

        static void yourNameAndAge(string name, int age)
        {
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your age is: " + age);
        }

        static void Main( string[] args )
        {

            yourNameAndAge( "Senko", 18 );

        }

    }
}

/* invocation of methods */

// Static Methods
sayHello();

// Intance Methods

Program S = new Program();

S.presentation();

// Void Method
voidMethod();

// Return Methods
String text = returnMethod();

int number = S.addition();
int num1 = number1();
int result = num1 + number2();

Console.WriteLine( text );
Console.WriteLine( number );
Console.WriteLine( result );
Console.WriteLine( message() );
