using MathGame.NET;

var menu = new Menui();
var date = DateTime.UtcNow;
string name = Helpers.GetName();
menu.ShowMenu(name, date);

