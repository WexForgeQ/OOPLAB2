using System;

class House
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
    private short? explDate;
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
        {explDate = value;}
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
            if (floor > 0 && floor <10)
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
    private static int hashid;

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
        id = counter++;
    }
    public House(string str="undf")
    {
        hsnumber = null;
        floatn = null;
        floor = null;
        roomn = null;
        explDate = null;
        street = str;
        id = counter++;
    }
    static House()
    {
        
        hashid = id.GetHashCode();
        bltype = "9-floor";
        id = counter++;
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
        Console.WriteLine("Время эксплуатации: " + explDate);
        Console.WriteLine("Тип дома: "+ bltype);
        Console.WriteLine("Код дома: "+ hashid);
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


}



namespace LAB2
{
    class Program
    {
         static void Main(string[] args)
        {
            House A = new House(-1, 2, 0, 3, "ba", 101);
            A.DisplayHouse();
            House B = new House();
            B.DisplayHouse();
            A.Floor = 4;
            Console.WriteLine(A.Floor);





        }
    }
}