// See https://aka.ms/new-console-template for more information

int[] arr = { 12, 44, 3, 42, 6, 7, 3, 1 };
string[] strs = { "hadassa", "sara", "esti", "michal", "neomi" };
// גרסא א
for (int i = 0; i < arr.Length ; i++)
{
    if(arr[i]%2==0)
        Console.WriteLine(arr[i]);
}
// גרסה ב
foreach (var item in arr)
{
    if(item%2==0)
        Console.WriteLine(item);
}
// גרסה ג שאילתת לינק
var x = from n in arr
        where n % 2 == 0
        select n;

foreach (var item in x)
{
    Console.WriteLine(item);
}
// הציגי את כל השמות שמתחילים בh

IEnumerable<string> x2 = from s in strs
                          where s[0] == 'h'
                          select s;
// מיון
var x3 = from s in strs
//where s[0] == 'h'
        orderby s[0] descending 
        select new { s, letter= s[0] };

foreach (var item in x3)
{
    Console.WriteLine(item);
}
// הגדרת משתנה שמקבלצ את הטיפוס שלו לפי צד ימין של ההגדרה
// לפי הטיפוס של הערך שמוצב לו בשורת ההגדרה
int num;
int num1 = 4;

var num3=67;
var str = "asdasdf";
// error var num4;
// error var num4 = null;
// error num3 = "sadfasdf";

// טיפוס אנונימי
var p = new { name= "yakov", city = "jerusalem" };
Console.WriteLine(p.name);
Console.WriteLine(p);


// הציגי את כל המספרים הזוגיים מעל 10 ואת המספר העוקב להם
var numbers = from n in arr
              where n > 10 && n % 2 == 0
              select new { n, okev = n + 1 };

foreach (var item in numbers)
{
    Console.WriteLine(item);

}
Console.WriteLine("Hello, World!");
////class pesron
////{
////    public int MyProperty { get; set; }
////    public int MyProperty { get; set; }
////    person p = new person();
////}