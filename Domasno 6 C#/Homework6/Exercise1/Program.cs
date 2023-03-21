using ClassLibrary1.Classes;

SalesPerson salesPersonOne = new SalesPerson("Simon", "Kozoloski");

salesPersonOne.AddSuccessRevenue(3600);
salesPersonOne.GetSalary();

Manager managerOne = new Manager("Tosho", "Malerot");

managerOne.AddBonus(455);
managerOne.GetSalary();