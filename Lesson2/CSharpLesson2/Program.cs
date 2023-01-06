// See https://aka.ms/new-console-template for more information
using CSharpLesson2;
delegate void funcType();
delegate int funcType2(int x,int y);
class Malben
{
    public int MyProperty { get; set; }
}
enum eDays
{

}

public class Program
{
    private static void f()
{
        Console.WriteLine("number 1");
}
    private static void f1()
    {
        Console.WriteLine("number 2");
    }
    private static void f2(string s)
    { }
    private static int ComparePersonByName(Person p1, Person p2)
    {
        return p1.Name.CompareTo(p2.Name);  
    }
    private static  int ComparePersonById(Person p1, Person p2)
    {
        return p1.Id.CompareTo(p2.Id);
    }
    public static void Main()
    {
        funcType func;
        func = f;
        // שתי השורות הבאות עושות אותו דבר
        f();
        func();
        func = f1;
        func();// מפעיל את אף1
        // מה עושים עם זה? 
        // כאשר יש לי פעולה שלא יודעים איך לבצע אותה,
        // היא יכולה לקבל פונקציה שתודיע לה איך לבצע פעולות
       
        List<int> list = new List<int>(){ 1, 2, 6, 1, 7, 3, 4 };
        list.Sort();    // יודע איך ממינים
        List<Person> list2 = new List<Person>() {  new Person()
                                                  ,new Person()};  
        // כאן צריך למלא את הרשימה
        list2.Sort();// איך ממינים אנשים????  האם לפי תז או לפי גיל?
        //ComparePersonByName()
        list2.Sort(ComparePersonByName); // לא מפעילים את פונקצית ההשואה
        list2.Sort(ComparePersonById);
        Group g = new Group();
        g.CorrectSort(ComparePersonByName);
        g.CorrectSort(ComparePersonById);

        // error  func = f2;
        //אפשר להתחיל?
        //Console.WriteLine("Hello, World!");
        int x;
        string s;
        DateTime d;
        // תרגיל
       // דליגייט בתרגיל+להבין טוב טוב את מה שלמדנו ולהוסיף 
    }
 }