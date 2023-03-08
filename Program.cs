internal class Program
{
    private static void Main(string[] args)
    {
        Pasta sheb = new("Щебекинские", "твердозерновые", 75, 1);
        Pasta makfa = new("Makfa", "мягкозерновые", 70,  0);
        Pasta sar = new("Саратовские", "среднезерновые", 50, 3);
        sheb.Predstav();
        makfa.Predstav();
        sar.Predstav();
        sar.Prodam();
        sar.Prodam();
        Sausage sosis = new("Деревенские сосиски", "говядина", 500, 5);
        sosis.Predstav();
        sosis.Zakupka();
        sosis.Zakupka();
        sosis.Zakupka();
    }
}   
abstract class Product
{
    public int balance = 1000;
    public virtual void Prodam() { }
    public virtual void Zakupka() { }
    public virtual void Predstav() { }
}
class Pasta : Product
{
    public string name;
    public string sostav;
    public int price;
    public int kolvo;
    public Pasta(string name, string sostav, int price, int kolvo)
    {
        this.name = name;
        this.sostav = sostav;
        this.price = price;
        this.kolvo = kolvo;
    }
    public new void Prodam()
    {
        if (kolvo <= 0)
        {
            Console.WriteLine($"Макароны {name}  отсутсвуют, баланс {balance}");
        }
        else
        {
            this.kolvo = kolvo - 1;
            balance = balance + price;
            Console.WriteLine($"Осталось: макароны {name} {sostav} по {price}P кол-во{kolvo}, баланс {balance}");
        }
    }
    public new void Zakupka()
    {
        if (balance < price)
        {
            Console.WriteLine($"нет денег, {balance}");
        }
        else
        {
            kolvo = kolvo + 1;
            balance = balance - price;
            Console.WriteLine($"Куплены {name} за {price}, теперь {kolvo}шт, баланс {balance}");
        }
    }
    public new void Predstav()
    {
        if (kolvo <= 0)
        {
            Console.WriteLine($"Макароны {name}  отсутсвуют, баланс {balance}");
        }
        else
        {
            Console.WriteLine($"Maкароны {name} {sostav} по {price}P  кол-во {kolvo}, баланс {balance}");
        }
    }
}
class Sausage : Product
{
    public string name;
    public string izKogo;
    public int price;
    public int kolvo;
    public Sausage(string name, string izKogo, int price, int kolvo)
    {
        this.name = name;
        this.izKogo = izKogo;
        this.price = price;
        this.kolvo = kolvo;
    }
    public new void Prodam()
    {
        if (kolvo <= 0)
        {
            Console.WriteLine($"Колбаса {name}  отсутсвуют, баланс {balance}");
        }
        else
        {
            this.kolvo = kolvo - 1;
            balance = balance + price;
            Console.WriteLine($"Осталось: колбаса {name} из {izKogo} по {price}P кол-во{kolvo}кг, баланс {balance}");
        }
    }
    public new void Zakupka()
    {
        if (balance < price)
        {
            Console.WriteLine($"не куплю, баланс {balance}");
        }
        else
        {
            kolvo = kolvo + 1;
            balance = balance - price;
            Console.WriteLine($"Куплена {name} {izKogo} за {price}, теперь {kolvo}кг, баланс {balance}");
        }
    }
    public new void Predstav()
    {
        if (kolvo <= 0)
        {
            Console.WriteLine($"Колбаса {name}  отсутсвует, баланс {balance}");
        }
        else
        {
            Console.WriteLine($"Колбаса {name} из {izKogo} по {price}P кол-во {kolvo}кг, баланс {balance}");
        }
    }
}