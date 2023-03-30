using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClassLibrary1;
using System.IO;

namespace prakt14_var19
{
    internal class Program
    {

        static public string word(string name)
        {
                for (int i = 0; i < name.Length; i++)
                {
                    if (!char.IsLetter(name[i]) )
                    {
                    return "введите буквы";
                    } 
                }
            return "";
            
            
            
        }
        static public string prow(string name)
        {
                for (int i = 0; i < name.Length; i++)
                {
                    if (name == " ")
                    {
                    return "введите буквы";
                    }
                   
                }
            return "";


        }
        static void Main(string[] args)
        {
           List<Dogs> spisok=new List<Dogs>();
            string trainer, type_of_service, breed, data,name, owner, kol_medaliei, haircut;
            // WorkingDogs wd = new WorkingDogs("вася пупкин", "аджилити", "бордюр колли", "7 марта", "санч", "вася пупкин");
            while (true)
            {
            Console.WriteLine("выберите: \n1-Working Dogs\n2-Decorative Dogs");
            int n = int.Parse(Console.ReadLine());
                if(n>2||n<1)
                {
                    Console.WriteLine("error");
                    break;
                }
                else
            Console.WriteLine("введите кол-во собак");
            int num = int.Parse(Console.ReadLine());
          
                for (int i = 0; i < num; i++)
                {
                    
                    if (n == 1)
                    {
                        Console.WriteLine("введите дрессировщика: ");
                        trainer = Console.ReadLine();
                        prow(trainer);
                        Console.WriteLine("введите вид занятие: ");
                        type_of_service = Console.ReadLine();
                        prow(type_of_service);
                        Console.WriteLine("порода собаки: ");
                        breed = Console.ReadLine();
                        prow(breed);
                        Console.WriteLine("дата рождения собаки: ");
                        data = Console.ReadLine();
                        prow(data);
                        Console.WriteLine("кличка собаки: ");
                        name = Console.ReadLine();
                        prow(name);
                        Console.WriteLine("владелец собаки: ");
                        owner = Console.ReadLine();
                        prow(owner);
                        WorkingDogs wd = new WorkingDogs(trainer, type_of_service,breed, data,name,owner);
                        spisok.Add(wd);
                        break;

                    }
                    if(n==2)
                    {
                        Console.WriteLine("участие в выставках(да или нет): ");
                        string show = Console.ReadLine();
                        if(show=="yes" || show=="да")
                        {
                            Console.WriteLine("кол-во медалей у собаки: ");
                             kol_medaliei = Console.ReadLine();
                            prow(kol_medaliei);
                            Console.WriteLine("нуждается ли собака в стрижке: ");
                             haircut = Console.ReadLine();
                            prow(haircut);
                            Console.WriteLine("порода собаки: ");
                             breed = Console.ReadLine();
                           word(breed);
                            Console.WriteLine("дата рождения собаки: ");
                             data = Console.ReadLine();
                            prow(data);
                            Console.WriteLine("кличка собаки: ");
                             name = Console.ReadLine();
                            word(name);
                            Console.WriteLine("владелец собаки: ");
                             owner = Console.ReadLine();
                             word(owner);
                            DecorativeDogs wd1 = new DecorativeDogs(show, haircut, kol_medaliei, breed, data, name, owner);
                            spisok.Add(wd1);
                        }
                        else
                        {
                             kol_medaliei = "0";
                            Console.WriteLine("нуждается ли собака в стрижке: ");
                             haircut = Console.ReadLine();
                           // prow(haircut);
                            Console.WriteLine("порода собаки: ");
                             breed = Console.ReadLine();
                           // word(breed);
                            Console.WriteLine("дата рождения собаки: ");
                             data = Console.ReadLine();
                            //prow(data);
                            Console.WriteLine("кличка собаки: ");
                             name = Console.ReadLine();
                           // word(name);
                            Console.WriteLine("владелец собаки: ");
                             owner = Console.ReadLine();
                            // word(owner);
                            DecorativeDogs wdd = new DecorativeDogs(show, haircut, kol_medaliei, breed, data, name, owner);
                            spisok.Add(wdd);
                            
                        }
                        
                    }
                   
                }
                Console.WriteLine("вы хотите закончить или продолжить?");
                string otv = Console.ReadLine();
                if (otv == "закончить") break;
                else if (otv == "продолжить") continue;
                Console.WriteLine("vse v file");
                StreamWriter sw = File.CreateText("file.txt");
                for (int i = 0; i < num; i++)
                {
                    sw.WriteLine(spisok[i].Info());
                }
                sw.Close();
            }
            
        }
       
    }
}
