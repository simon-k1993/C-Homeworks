namespace Exercise3.Classes2
{
   public class Student
    {
        public Student(string name, string academy,int group ) {
            Name = name;
            Academy = academy;
            Group = group;
        }

        public string Name { get; set; }
        public string Academy { get; set;}
        public int Group { get; set;}

    }

}
