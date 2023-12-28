using System;


class Program
{


    static void Main(string[] args)
    {
        // Dictionary <Tkey, TValue>
        // plaka => (34:İstanbul), (35: İzmir)

        Dictionary<int, string> plakalar = new Dictionary<int, string>();
        plakalar.Add(34, "İstanbul");

        foreach (var item in plakalar)
        {
            // Console.WriteLine(item);
        }

        Dictionary<int, string> sayilar = new Dictionary<int, string>(){
                {1,"Bir"},
                {2,"İki"},
                {3,"Üç"},
                {4,"Üç"},
                {5,"Üç"}
        };
        foreach (var item in sayilar)
        {
            Console.WriteLine($"{item.Key}:{item.Value}");
        }

    }
}