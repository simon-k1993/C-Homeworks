using Exercise3.Classes2;


Console.WriteLine("Enter a name!");
string name = Console.ReadLine();

Student student1= new Student("Simon","SEDC",5);
Student student2 = new Student("Petko", "Brainster", 2);
Student student3 = new Student("Mile", "Code Academy", 15);
Student student4 = new Student("Toso", "Brainster", 4);
Student student5 = new Student("Cacko", "SEDC", 12);

Student[] studentArray = new Student[] {student1,student2,student3,student4,student5 };


int counter = 0;

for (int i = 0; i < studentArray.Length;i++) 
{
    Student student = studentArray[i];
   


    if (student.Name.ToLower() == name.ToLower()) 
    {
        
        Console.WriteLine($"{student.Name} from academy {student.Academy} is in group {student.Group}!!!");
        break;
        
    }counter++;
  

  
    
}
if (counter == 5)
{
    Console.WriteLine($"We don't have {name} in our database!!! Keep searching! ");
}



