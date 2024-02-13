using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Ford
    {
        public string Name { get; private set; }
        public string Body { get; private set; }
        public float Liters { get; private set; }
        public int Hp { get; private set; }

        public static void Main(string[] args)
        {
            Ford[] fords = new Ford[17];
            fords[0] = new Ford(name: "Focus", body:"sedan", liters: 1.6f, hp: 270);
            fords[1] = new Ford(name: "Focus 2", body:"sedan", liters: 2.3f, hp: 350);
            fords[2] = new Ford(name: "Mustang", liters: 2.2f, hp: 85);
            fords[3] = new Ford(name: "Ford C-MAX", body: "hatchback", liters: 1.6f);
            fords[4] = new Ford(name: "Ford C-MAX", body: "hatchback", liters: 1.6f, hp: 109);
            fords[5] = new Ford(name: "Ford C-MAX",liters: 1.6f);
            fords[6] = new Ford(name: "Ford C-MAX", liters: 2.0f, hp: 136);
            fords[7] = new Ford(name: "F150", body: "pickup", liters: 4.6f, hp: 231);
            fords[8] = new Ford(name: "F150", body: "pickup", liters: 5.4f, hp: 300);
            fords[9] = new Ford(name: "Fusion", body: "coupe", liters: 1.2f, hp: 115);
            fords[10] = new Ford(name: "Galaxy", body: "hatchback", liters: 1.5f, hp: 130);
            fords[11] = new Ford(name: "Maverick", body: "sedan", liters: 4.0f, hp: 265);
            fords[12] = new Ford(name: "Mondeo 1", hp: 88);
            fords[13] = new Ford(name: "Mondeo 2", body: "sedan", liters: 1.8f, hp: 110);
            fords[14] = new Ford(name: "Mondeo 3", liters: 2.2f, hp: 125);
            fords[15] = new Ford(name: "Mondeo 4", body: "sedan", liters: 2.0f, hp: 130);
            fords[16] = new Ford(name: "Mondeo 5", body: "sedan", hp: 155);


            //printTable(fords);
            sortByLiters(fords);
            printTable(fords);
            //sortByHp(fords);
            //printTable(fords);

        }

        private Ford(string name, float liters=0, int hp=0, string body = "Unspecified")
        {
            Name = name;
            Body = body;
            Liters = liters;
            Hp = hp;
        }

        static void printTable(Ford[] fords)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("G:/НГТУ/МАГА/ДЗ по ООП/lab1/output.txt"))
                {
                    foreach (Ford ford in fords)
                    {
                        writer.Write(Convert.ToString(ford.Name + " " + ford.Body + " " + ford.Liters + " " + ford.Hp + "\n"));
                    }
                }
            }
            catch(Exception e) { Console.WriteLine(e); }
        }

        static void sortByLiters(Ford[] fords)
        {
            for(int i = 0;i < fords.Length; i++)
            {
                for(int j=i+1;j<fords.Length;j++)
                if (fords[i].Liters<fords[j].Liters)
                {
                    (fords[i], fords[j]) = (fords[j], fords[i]);
                }
            }
        }
        static void sortByHp(Ford[] fords)
        {
            for (int i = 0; i < fords.Length; i++)
            {
                for (int j = i + 1; j < fords.Length; j++)
                    if (fords[i].Hp < fords[j].Hp)
                    {
                        (fords[i], fords[j]) = (fords[j], fords[i]);
                    }
            }
        }

    }
}
