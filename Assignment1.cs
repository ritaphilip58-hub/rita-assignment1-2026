#region Q1,2
Book b = new Book();
b.pages = 900;
b.title = "Me before you";
Console.WriteLine(b.title);
Console.WriteLine(b.pages);
Console.WriteLine(b.pages.ToString ());
Console.WriteLine(b.title.Equals ("Me before you"));
Console.WriteLine(b.title.GetHashCode());
Console.WriteLine(b.title.GetType());
Console.WriteLine(b.pages.GetType());
class Book
{
    public string title;
    public int pages;
}
#endregion

#region Q3
//compile-time-error
//int pages = 464;
#endregion

#region Q4
try
{
    int z = 0;
    int divides = 10 / z;
    Console.WriteLine(divides);
}
catch (DivideByZeroExeption) {
    Console.WriteLine("cannot devided by zero");
}
finally {
    Console.WriteLine("done ");

}
#endregion

#region Q5
int pages = 300;
Double y = Convert.ToDouble(pages);
Console.WriteLine(y);
#endregion

#region Q6
double price = 49.99;
int x = (int)price;
Console.WriteLine(x);
#endregion region


#region Q7
string pagesText = "464";
int k = Convert.ToInt32(pagesText);
Console.WriteLine(k);
#endregion

#region Q8
string yearText = "2023";
int year = int.Parse(yearText);
Console.WriteLine(year);
string badText = "abc";
bool isValid = int.TryParse(badText,out int badNumber);
Console.WriteLine(isValid);
#endregion

#region Q9
int pages09 = 464;
String m = pages09.ToString();
Console.WriteLine(m.GetType());
#endregion

#region Q10
int copies = 100;
object boxed = copies;
int unboxed = (int)boxed;
Console.WriteLine(boxed);
Console.WriteLine(unboxed);
#endregion
