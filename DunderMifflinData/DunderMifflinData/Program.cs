using System;
using DunderMifflin;

Data dun = new Data();


Employee michael = new Employee("Michael Scott", 48, "gerente");
Employee jim = new Employee("Jim Halpert", 35, "ventas");
Employee dwight = new Employee("Dwight Schrute", 43, "ventas");

dun.addEmployee(michael).addEmployee(jim);

dun.asignarManager(1);

dun.getInfo();
