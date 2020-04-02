/*using System;
class A
{
    public void Metot()
    {
        Console.WriteLine("A sınıfı");
    }
}
class B : A
{
    new public void Metot()
    {
        Console.WriteLine("B sınıfı");
    }
    static void Main()
    {
        A nesneA = new A();
        B nesneB = new B();
        nesneA = nesneB;
        nesneA.Metot();

        nesneB.Metot();    

        Console.ReadKey();
    }
}*/

using System;
class A
{
    public int _a1;
    public A(int _a2)
    {
        _a1 = _a2;
        Console.WriteLine("a : " + _a1);
    }

}
class B : A
{
    public int b;
    public B(int _b, int _c) : base(_c)
    {
        this._a1 = _c;
        this.b = _b; 

        Console.WriteLine("b : " + b);
        Console.WriteLine("a : " + _a1);
    }
}
class Ana
{
    static void Main()
    {

        Console.WriteLine("this is a experience");
        B nesne = new B(5,3);


        Console.WriteLine("dal3 added!");

        Console.ReadLine();


    }
}