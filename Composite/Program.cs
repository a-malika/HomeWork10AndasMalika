using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Directory desktop = new Directory("Desktop");
            Directory dir1 = new Directory("Books");
            Directory dir2 = new Directory("Studying");
            Directory dir3 = new Directory("Projects");
            File f1 = new File("test.cpp", 1927.0);
            File f2 = new File("LabNew", 238.4);

            desktop.AddComponent(f1);
            desktop.AddComponent(dir1);
            desktop.AddComponent(dir2);
            desktop.AddComponent(dir3);
            desktop.AddComponent(f2);

            File book1 = new File("Dzhoshua_Bloh_Java_effektivnoe_programmirovanie_3-e_izdanie_", 34608.0);
            File book2 = new File("Keti_Serra_Izuchaem_Java_2-e_izdanie_", 71136.0);
            File book3 = new File("Java_Polnoe_rukovodstvo", 152383.0);
            dir1.AddComponent(book1);
            dir1.AddComponent(book2);
            dir1.AddComponent(book3);

            File lab1 = new File("Laboratory_1", 175.0);
            File lab2 = new File("Laboratory_2", 103.0);
            File lab3 = new File("Laboratory_3", 98.0);
            dir2.AddComponent(lab1);
            dir2.AddComponent(lab2);
            dir2.AddComponent(lab3);

            desktop.Display(0);
        }
    }
}
