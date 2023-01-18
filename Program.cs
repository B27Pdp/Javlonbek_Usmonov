using OOP_9;
using OOP_9._2_masala;

/*Triangle object1= new Triangle(10,20,30);
Triangle object2 = new Triangle();
object2 =-object1;
object2.GetABC();*/
Minus m = new(10, 20, 30);
//m =-m;
//m.Minus_2();
Minus n = new(5, 5, 5);
m=m-n;
m.Minus_2();
Creature.Insects a = new(5);
Console.WriteLine(a.Legs);




