using System;

public partial class House
{
    private const ushort maxexpl = 2022;
    public ushort MaxExpl
    {
        get
        {
            return maxexpl;
        }
        private set
        {
            value = 100; ;
        }

    }
    public short? explDate;
    public short? Expl
    {
        get
        {
            if (explDate > 0)
                return explDate;
            else
            {
                Console.WriteLine("Неверно введедна дата эксплуатации");
                explDate = null;
                return explDate;
            }
        }
        set
        { explDate = value; }
    }
    private short? hsnumber;
    public short? Hsn
    {
        get
        {
            if (hsnumber > 0)
                return hsnumber;
            else
            {
                Console.WriteLine("Неверно введен номер дома");
                hsnumber = null;
                return hsnumber;
            }
        }
        set
        {
            hsnumber = value;
        }
    }
    private static int id;
    private short? floatn, floor, roomn;
    public short? Flat
    {
        get
        {
            if (floatn > 0)
                return floor;
            else
            {
                Console.WriteLine("Неверно введен номер квартиры");
                floatn = null;
                return floatn;
            }
        }
        set
        {
            floatn = value;
        }
    }
    public short? Floor
    {
        get
        {
            if (floor > 0 && floor < 10)
                return floor;
            else
            {
                Console.WriteLine("Неверно введен номер этажа");
                floor = null;
                return floor;
            }
        }
        set
        {
            floor = value;
        }
    }
    public short? Room
    {
        get
        {
            if (roomn > 0)
                return roomn;
            else
            {
                Console.WriteLine("Неверно введен номер дома");
                roomn = null;
                return roomn;
            }
        }
        set
        {
            roomn = value;
        }
    }
    private string? street;
    public string? Street
    {
        get
        {
            return street;
        }
        set
        {
            street = value;
        }
    }
    private static string bltype;
    static int counter = 0;
    private readonly static int hashid;

    public House(short hsn, short flt, short flr, short rmn, string str, short expl)
    {
        if (hsn >= 1)
            hsnumber = hsn;
        else
            Console.WriteLine($"Номер дома {id} введён некоректно(<1)");
        if (flt >= 1)
            floatn = flt;
        else
            Console.WriteLine($"Номер квартиры дома {id} введён некоректно(<1)");
        if (flr >= 1)
            floor = flr;
        else
            Console.WriteLine($"Этаж дома {id} введён некоректно(<1)");
        if (rmn >= 1 && rmn < 5)
            roomn = rmn;
        else
            Console.WriteLine($"Количество комнат дома {id} введёно некоректно(<1 или >5)");
        street = str;
        if (expl > 0)
            explDate = expl;
        else
            Console.WriteLine($"Время экспулатации дома {id} введёно некоректно(<0)");
        id = counter++;
    }
    public House(string str = "undf")
    {
        hsnumber = null;
        floatn = null;
        floor = null;
        roomn = null;
        explDate = null;
        street = "Неопрелена(По умолчанию)";
        id = counter++;
    }
    static House()
    {

        hashid = id.GetHashCode();
        bltype = "9-floor";
        id = counter++;
    }
    private House() { }
    public void DisplayHouse()
    {
       
        Console.WriteLine("Дом:");
        Console.WriteLine("Номер дома: " + hsnumber);
        Console.WriteLine("Квартира: " + floatn);
        Console.WriteLine("Этаж: " + floor);
        Console.WriteLine("Кол-во комнат: " + roomn);
        Console.WriteLine("Улица: " + street);
        Console.WriteLine("Дата начала эксплуатации: " + explDate);
        Console.WriteLine("Тип дома: " + bltype);
        Console.WriteLine("Код дома: " + hsnumber.GetHashCode());
        Console.WriteLine("-------------------------------");
    }

    public void TestOld(ref short? explDate)
    {
        if(MaxExpl-explDate<100)
        {
            Console.WriteLine($"Дом №{hsnumber} не нуждается в капремонте");
        }
        else
        {
            Console.WriteLine($"Дом №{hsnumber} нуждается в капремонте");
        }
    

    }
    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public override string ToString()
    {
        return base.ToString();
    }

    ~House()
    {
        Console.WriteLine($"Дом {hsnumber} был удалён");
    }

    public static void DisplayObjectNum()
    {
        Console.WriteLine("Количество членов в классе:" + id);
    }

}

public partial class House
{
    public void Partial()
    {
        Console.WriteLine("Этот класс частичен");
    }
}

namespace LAB2
{
    class Program
    {
         static void Main(string[] args)
        {
            House A = new House(2, 2, 0, 3, "ba", 1922);
            House B = new House(3, 1, 1, 2, "hg", 1937);
            House C = new House(4, 1, 1, 3, "hg", 1970);
            A.DisplayHouse();
            B.DisplayHouse();
            C.DisplayHouse();
            A.Partial();
            A.TestOld(ref A.explDate);
            Console.WriteLine(A.Equals(C));
            House.DisplayObjectNum();
            Console.WriteLine(A.ToString());
            Console.WriteLine(A.GetHashCode());
            Console.WriteLine(B.GetHashCode());
            House[] houses = new House[3];
            houses[0] = new House(2, 2, 0, 3, "ba", 1922);
            houses[1] = new House(4, 1, 1, 3, "hg", 1970);
            houses[2] = new House(3, 1, 1, 2, "hg", 1937);
            for(int i=0; i<3; i++)
            {
                houses[i].DisplayHouse();
            }
            House.DisplayObjectNum();
            var G = new House();
            G.DisplayHouse();
            Console.WriteLine("Введите необходимое количество комнат и разброс лет");
            int rooms, year1, year2;
            rooms = Convert.ToInt32(Console.ReadLine());
            year1 = Convert.ToInt32(Console.ReadLine());
            year2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                if(houses[i].Room==rooms)
                {
                    Console.Write($"{rooms} комнаты(-у) имеет ");
                    houses[i].DisplayHouse();
                }

            }
            for (int i = 0; i < 3; i++)
            {
                if (houses[i].Room == rooms&&houses[i].explDate<year2&&houses[i].explDate>year1)
                {

                    Console.Write($"Попадает в промежуток времени и {rooms} комнаты(-у) имеет ");
                    houses[i].DisplayHouse();
                }

            }
        }
    }
}