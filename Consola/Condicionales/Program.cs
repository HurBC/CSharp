class Program
{
    static void Main( string[] args )
    {
        int Edad = 20;
        bool Licencia = false;

        /*---------------*/
        /* Condicionales */
        /*---------------*/

        //Las condicionales nos ayudan a comparar datos
        //Existen 4 tipos de condicionales "if", "else", "else if" y "switch"

        /* Condicionales if, else y else if */
        //Estos condicionales ocupan los siguientes signos
        // == para preguntar si un dato es IGUAL que el otro
        // != para preguntar si un dato es DIFERENTE que el otro
        // > para preguntar si un dato es MAYOR que el otro
        // < para preguntar si un dato es MENOR que el otro
        // >= para preguntar si un dato es IGUAL O MAYOR que el otro
        // <= para preguntar si un dato es IGUAL O MENOR que el otro

        //Tambien estan los operadores los cuales pueden poner varias condiciones en una sola condicional
        // "||" para preguntar si algo es de un tipo O de otro
        // "&&" para preguntar si algo es de un tipo Y otro


        /* Condicional If */

        //para esto ocuparemos el condicional "if" el cual se contruye ocupando la palabra "if" con la comparacion a hacer entre parentesis
        if (Edad == 18)
        {
            Console.WriteLine( "Tiene 18 años" );
        }

        if (Edad < 18)
        {
            Console.WriteLine( "Es menor de 18 años" );
        }

        if (Edad > 18)
        {
            Console.WriteLine( "Es mayor de 18 años" );
        }

        if (Edad != 18)
        {
            Console.WriteLine( "NO tiene 18 años" );
        }

        if (Edad <= 18)
        {
            Console.WriteLine( "Tiene 18 o menos años" );
        }

        if (Edad >= 18)
        {
            Console.WriteLine( "Tiene 18 o mas años" );
        }

        //Bien ahora agreguemos un dato bool que verifique si esta persona puede conducir
        //Para este ejemplo utilizaremos "&&" y "||"

        //si Edad es mayor o igual a 18 Y Licencia es igual a true
        if (Edad >= 18 && Licencia == true)
        {
            Console.WriteLine( "Puedes conducir" );
        }

        //Si licencia es false O Edad es menor a 18
        if (Licencia == false || Edad < 18)
        {
            Console.WriteLine( "No puedes conducir" );
        }

        /* Condicional Else */

        //La condicional else se utilizza cuando no se cumple el if
        //estas condicionales se declaran con la palabra "else" y siempre deben pertenecer a un "if" o a un "else if"(mas adelante se hablara sobre este)

        if (Edad >= 18 && Licencia == true)
        {
            Console.WriteLine( "Puedes conducir" );
        }
        else
        {
            Console.WriteLine( "No puedes conducir" );
        }

        /* Condicional Else If */

        //Las condicionales "else if" sirven para comparar codigo en caso de que el primer if no se cumpla y deben ir siempre despues de un if
        //estas condicionales se declaran con la palabra reservada "else if" y al igual que un if llevan parentesis donde dentro de estos se hace la comparacion

        if (Edad < 18)
        {
            Console.WriteLine( "Eres menor de edad, no puedes conducir" );
        }
        else if (Edad >= 18 && Licencia == true)
        {
            Console.WriteLine( "Puedes conducir" );
        }
        else
        {
            Console.WriteLine( "No puedes conducir" );
        }

        //Condicionales anidadas
        //Las condicionales de tipo if, else y else if pueden tener otras condicionales adentro de estas
        //tomemos el ejemplo de arriba para hacer esto

        //preguntamos si la persona es mayor a 18
        //Si es menor de 18 se ejecuta este codigo
        if (Edad < 18)
        {
            Console.WriteLine( "No puedes conducir" );
        }
        //si es mayor de 18 se ejecuta este otro codigo
        else
        {
            //preguntamos si tiene licencia de conducir
            if (Licencia == true)
            {
                Console.WriteLine( "Puedes conducir" );
            }
            else
            {
                Console.WriteLine( "No puedes conducir" );
            }
        }

        //En caso de que una condicional solo tenga una linea no es necesario poner las llaves
        //C# sabra que la linea siguiente a la condicional es parte de la condicional
        //aqui un ejemplo de como se veria con el ejemplo anterior

        if (Edad < 18) Console.WriteLine( "No puedes conducir" );
        else
        {
            if (Licencia == true) Console.WriteLine( "Puedes conducir" );
            else Console.WriteLine( "No puedes conducir" );
        }
        //Esto hara que nuestro codigo se vea mas limpio y mas leible

        /*----------------------*/
        /* Operadores Ternarios */
        /*----------------------*/

        //El operador ternario o condicional ?, se encarga de devolver datos booleanos
        //Sirve mas que nada cuando solo se necesita evaluar cuando algo es verdare o falso
        //estos se conforman por la condicion seguido de "?" y el resultado si es verdadero
        //seguido de ":" y el resultado si es falso


        // Let's use the example from the previous post

        int gfAge = 18;









        if (gfAge >= 18)
        {
            if(gfAge < 80)
            {
                Console.WriteLine( "Your girlfriend is cute Bro, what's her Instagram?" );
            }
            else
            {
                Console.WriteLine( "Your girlfriend looks like my grandmother....wait a minute 💀" );
            }
        }
        else
        {
            Console.WriteLine( "Bro call the FBI NOW" );
        }







        int age = 20;

        //Operador ternario
        string msg = (age >= 18) ? "Mayor de edad" : "Menor de edad";

        //en este caso el valor de mensaje es "Mayor de edad", si "age" fuera menor a 18
        //el valor de msg seria "Menor de edad"


        /* swicth */

        //estos condicionales se encargar de comparar un numero de datos mayor y toman un UNICO parametro el cual se compara dentro de este
        //Esta concicional se declara usando la palabra reservada "switch" y dentro de este estan los "case" y el "default"

        /* Case */

        //Los case se utilizan para comparar un valor con el dato entregado al "switch"
        //se declaran usando la palabra reservada "case" junto al valor a comparar junto a ":" al final
        //Los case deben SIEMPRE tener un "break;" al final para determinar el limite de este
        //EJ: case 1:
        //      Console.WriteLine( "Mes de Enero" );
        //      break;

        /* Default */

        //Los default se utilizan al final del "switch" y se ejecutan cuando ningun "case" se cumple
        //se declaran con la palabra reservada "default" junto a unos ":"
        //Al igual de los case deben llevar un "break;" al final para determinar su limite
        //EJ: default:
        //       Console.WriteLine( "Introduce un numero valido" );
        //       break;

        //aqui un pequeño programa que compara el valor de "mes" con los numeros de los meses del año
        //en case de que mes no coincida con ningun caso se ejecutara el defaul pidiendo que se de un numero valido

        int mes = 4;

        //Se le asigna a switch el valor de "mes"
        switch (mes)
        {
            //Se asigna el case donde mes sea igual a 1 y se imprime el primer mes del año, se hace lo mismo con el resto de meses
            case 1:
                Console.WriteLine( "Mes de Enero" );
                break;
            case 2:
                Console.WriteLine( "Mes de Febrero" );
                break;
            case 3:
                Console.WriteLine( "Mes de Marzo" );
                break;
            case 4:
                Console.WriteLine( "Mes de Abril" );
                break;
            case 5:
                Console.WriteLine( "Mes de Mayo" );
                break;
            case 6:
                Console.WriteLine( "Mes de Junio" );
                break;
            case 7:
                Console.WriteLine( "Mes de Julio" );
                break;
            case 8:
                Console.WriteLine( "Mes de Agosto" );
                break;
            case 9:
                Console.WriteLine( "Mes de Septiembre" );
                break;
            case 10:
                Console.WriteLine( "Mes de Octubre" );
                break;
            case 11:
                Console.WriteLine( "Mes de Noviembre" );
                break;
            case 12:
                Console.WriteLine( "Mes de Diciembre" );
                break;

            //en case de que ningun case se cumpla se ejecutara este default diciendo que el valor de "mes" no es valido
            default:
                Console.WriteLine( "Introduce un numero valido" );
                break;

        }


        int Weekday = 5;

        switch (Weekday)
        {
            case 1:
                Console.WriteLine( "It's Monday, I don't want to work" );
                break;
            case 2:
                Console.WriteLine( "It's Tuesday, I don't want to work" );
                break;
            case 3:
                Console.WriteLine( "It's Wednesday, I don't want to work" );
                break;
            case 4:
                Console.WriteLine( "It's Thursday, I don't want to work" );
                break;
            case 5:
                Console.WriteLine( "It's Friday lets gooo, I can finally rest" );
                break;
            case 6:
                Console.WriteLine( "Saturday, *sleeps all day*" );
                break;
            case 7:
                Console.Write( "How the fuck is it Sunday?!?!?" );
                Console.Write( ", bro I don't even enjoy the weekend *starts crying*" );
                break;
            default:
                Console.WriteLine( "There are no more than 7 days of the week stupid" );
                break;
        }



    }
}