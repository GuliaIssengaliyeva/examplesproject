Console.WriteLine ("Введите имя пользователя: ");
string username = Console.ReadLine ();

if (username.ToLower()  == "gulia")
{
  Console.WriteLine ("HollyShirt! it's Gulia!");
}
else
{
  Console.Write("Hello, ");
  Console.WriteLine(username);
}
