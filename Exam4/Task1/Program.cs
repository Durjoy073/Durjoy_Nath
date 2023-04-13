// See https://aka.ms/new-console-template for more information
List<(int id, string courseName, double price)> courses = 
    new List<(int id, string courseName, double price)>();

courses.Add((1, "C#", 8000));
courses.Add((2, "Asp.net", 30000));
courses.Add((3, "Java", 7000));
courses.Add((4, "Python",10000));
List<(int id, string name, string address, int courseId)> students = 
    new List<(int id, string name, string address, int courseId)>();
students.Add((1, "Jalaluddin", "Mirpur", 2));
students.Add((2, "Hasan", "Moghbazar", 1));
students.Add((3, "Nishan", "Feni", 3));
students.Add((4, "Durjoy", "Chattogram", 4));

var add = students.Join(courses, student => student.courseId, course=> course.id,(student,course)
    => new {student.name,course.courseName});
var match = add.ToList();
foreach(var item in match)
{
    Console.WriteLine(" "+item.name+","+ ""+item.courseName);
}