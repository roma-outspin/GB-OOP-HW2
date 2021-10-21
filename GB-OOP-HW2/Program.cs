using System;
using System.IO;

namespace GB_OOP_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            //реверс строки
            string reverseTest = "abcdefghijklomnopqrstuvwxy z";
            Console.WriteLine(reverseTest.Reverse());


            var myAccount1 = new BankAccount(99999.99m);
            var myAccount2 = new BankAccount(666.66m);
            Console.WriteLine("Введите команды add или take для добавления/снятия денег на счет и сумму через пробел\n" +
                "Введите exit для завершения программы\n" +
                "Введите transfer для перевода денег с другого счета(баланс: 666.66$)" +
                $"Сейчас у Вас на счету: {myAccount1.Balance}$");
            while (true)
            {
                try
                {
                    var comm = Console.ReadLine().Split(' ');
                    if (comm[0].ToLower().Equals("add"))
                    {
                        myAccount1.AddMoney(Convert.ToDecimal(comm[1]));
                    }
                    else if (comm[0].ToLower().Equals("take"))
                    {
                        myAccount1.TakeOffMoney(Convert.ToDecimal(comm[1]));
                    }
                    else if (comm[0].ToLower().Equals("transfer"))
                    {
                        if (myAccount1.TransferMoney(ref myAccount2, Convert.ToDecimal(comm[1])))
                        {
                            Console.WriteLine($"Перевод прошел успешно, остаток на другом счете: {myAccount2.Balance}$");
                        } else
                        {
                            Console.WriteLine($"Ошибка при переводе, убедитесь, что сумма перевода не превышает {myAccount2.Balance}$") ;
                        }
                    }
                    else if (comm[0].ToLower().Equals("exit"))
                    {
                        Console.WriteLine("Завершение программы");
                        break;
                    } else if(comm[0].ToLower().Equals("getemails"))
                    {
                        if(comm.Length==3)
                        {
                            var entries = GetEntriesFromFile(comm[1]);
                            if (entries == null)
                            {
                                Console.WriteLine("записи не найдены");
                                continue;
                            }

                            if (entries.Length>0)
                            {
                                SaveEntries(entries, comm[2]);
                            }else
                            {
                                Console.WriteLine("Записи не найдены");
                            }
                            
                        } else
                        {
                            Console.WriteLine("Не верное количество аргуменетов команды");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Введите команды add или take для добавления / снятия денег на счет и сумму через пробел");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine($"Ваш баланс: {myAccount1.Balance}$");
            }

        }

        public static string[] GetEntriesFromFile(string path)
        {
            try
            {
                return File.ReadAllLines(path);
            }
            catch(Exception e)
            {
                Console.WriteLine("Ошибка при чтении файла! \n"+e.Message);
                return null; 
            }
            
        }

        public static void SaveEntries(string[] entries, string path)
        {
            using StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default);
            for (var i = 0; i < entries.Length; i++)
            {
                SearchMail(ref entries[i]);
                sw.WriteLine(entries[i]);
            }
        }
        public static void SearchMail(ref string s)
        {
            s = s.Split('&')[1].Trim(' ');
        }

    }
}
