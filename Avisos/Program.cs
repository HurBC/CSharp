namespace Avisos
{
    class Program
    {
        static void Main( string[] args )
        {

            AvisosTrafico av1 = new AvisosTrafico();

            AvisosTrafico av2 = new AvisosTrafico("Jefatura provincial Madrid", "Sancion de velocidad: 300$", "22/08/2023");

            av1.MostrarAviso();

            av2.MostrarAviso();

        }
    }
}