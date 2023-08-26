using System;
using DunderMifflin;

class Program
{
    static void Main(string[] args)
    {
        Branches nb = new Branches();

        Branches scranton = new Branches(Branches.s_branches[0]);
        Branches stanford = new Branches(Branches.s_branches[1]);
        Branches NY = new Branches(Branches.s_branches[2]);
        Branches santiago = new Branches(Branches.s_branches[3]);

        Employee jim = new Employee("James Duncan Halpert", 34, "ventas", "scranton");
        Employee mike = new Employee("Michael Gary Scott ", 34, "ventas", "scranton");

        scranton._addEmployee(jim);
        scranton._addEmployee(mike);

        scranton.GetInfo();


    }
}