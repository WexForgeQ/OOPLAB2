using System;

class House
{
    private const ushort maxexpl = 100;
    private short? explDate;
    private short? hsnumber;
    private static int id;
    private short? floatn, floor, roomn;
    private string street;
    private static string bltype;
    static int counter = 1;
    private static readonly int hashid;

    public House(short hsn, short flt, short flr, short rmn, string str, short expl)
    {
        if(hsn>1)
            hsnumber = hsn;
        else
            Console.WriteLine($"Номер дома {id} введён некоректно(<1)");            
        if(flt>1)
            floatn = flt;
        else
            Console.WriteLine($"Номер квартиры дома {id} введён некоректно(<1)");
        if (flr > 1)
            floor = flr;
        else
            Console.WriteLine($"Этаж дома {id} введён некоректно(<1)");
        if(rmn>1&&rmn<5)
             roomn = rmn;
        else
            Console.WriteLine($"Количество комнат дома {id} введёно некоректно(<1 или >5)");
        street = str;
        if(expl>0)
            explDate = expl;
        else
            Console.WriteLine($"Время экспулатации дома {id} введёно некоректно(<0)");
    }
    static House()
    {
        id = counter++;
        hashid = id.GetHashCode();
        bltype = "9-floor";
    }
    private House(){}
    public void DisplayHouse()
    {
        Console.WriteLine("Дом №"+id+":");
        Console.WriteLine("Номер дома: "+hsnumber);
        Console.WriteLine("Квартира: "+floatn);
        Console.WriteLine("Этаж: "+ floor);
        Console.WriteLine("Кол-во комнат: "+ roomn);
        Console.WriteLine("Улица: "+ street);
        if(explDate<maxexpl)
        {
            Console.WriteLine("Время эксплуатации: " + explDate);
        }
        else
        {
            Console.WriteLine("Время эксплуатации: " + explDate+"(Дому необходим капитальный ремонт)");
        }
        Console.WriteLine("Тип дома: "+ bltype);
        Console.WriteLine("Код дома: "+ hashid);
    }





}



namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            House A = new House(-1, 2, 0, 3, "ba", 101);
            A.DisplayHouse();






        }
    }
}