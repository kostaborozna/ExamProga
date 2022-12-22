namespace forexam2022
{
    public class BankAccount
    {
        private int bank_number;
        private string user;
        private double amount;
        public double Auth(int bank_number, string user, int dep, double summ)
        {
            List<int> bank_number_data = new List<int>();
            List<string> user_data = new List<string>();
            List<double> amount_data = new List<double>();
            user_data.Add("Абдулла");
            bank_number_data.Add(1);
            amount_data.Add(500.0);
            if (dep == 1)
            {
                if (summ > 0 && amount_data[bank_number] - summ >= 0)
                {
                    amount_data[Convert.ToInt32(user)] -= summ;
                    amount_data[bank_number] += summ;
                    Console.WriteLine("Успешный перевод.");
                }
                else
                {
                    Console.WriteLine("Недостаточно средств.");
                }
            }
            else if (bank_number_data.Contains(bank_number) && user_data.Contains(user))
            {
                for (int i = 0; i < bank_number_data.Count; i++)
                {
                    if (bank_number == bank_number_data[i])
                    {
                        Console.WriteLine($"Успешная авторизация. Баланс - {amount_data[i]}");
                        return amount_data[i];
                    }

                }
            }
            return 0.0;
        }
        static void ScoreEmpty()
        {

            void put() { }
            void output() { }
            void balance() { }
            void translation() { }

        }
        public double Score(int bank_number, string user, double amount, int number_task)
        {
            this.bank_number = bank_number;
            this.user = user;
            this.amount = amount;
            double total;
            if (number_task == 1)
            {
                total = put();
                double put()
                {
                    Console.Write("Введите сумму пополнения: ");
                    var putting = Convert.ToInt32(Console.ReadLine());
                    amount = amount + putting;
                    return amount;
                }
                Console.WriteLine("Успешно.");
                System.Threading.Thread.Sleep(1000);
                return total;

            }
            else if (number_task == 2)
            {
                total = output();
                double output()
                {
                    Console.Write("Введите сумму, которую хотите снять: ");
                    var putting = Convert.ToInt32(Console.ReadLine());
                    if (amount - putting < 0)
                    {
                        Console.WriteLine("Ошибка. Недостаточно средств на балансе.");
                        System.Threading.Thread.Sleep(1000);
                    }
                    else
                    {
                        amount = amount - putting;
                        Console.WriteLine("Успешно.");
                        System.Threading.Thread.Sleep(1000);
                    }
                    return amount;
                }
                return total;
            }
            else if (number_task == 3)
            {
                total = balance();
                double balance()
                {
                    Console.Write($"Ваш баланс в данный момент: {amount}");
                    return amount;
                    System.Threading.Thread.Sleep(1000);
                }
                return total;
            }
            else if (number_task == 4)
            {
                total = translation();
                double translation()
                {
                    Console.Write("Введите номер банковского счетa, кому хотите перевести: ");
                    var input_data = Console.ReadLine();
                    int out_data;
                    bool isNumber = int.TryParse(input_data, out out_data);
                    if (isNumber == true)
                    {
                        Console.Write("Введите сумму для перевода: ");
                        input_data = Console.ReadLine();
                        Auth(out_data, Convert.ToString(bank_number), 1, Convert.ToDouble(input_data));
                    }
                    return amount;
                }
                return total;
            }
            return 0;
        }
    }
    public class Program : BankAccount
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ Главное меню ║");
            Console.WriteLine("╠═══════════════════════╦═══════════════════════╦═══════════════════════╣");
            Console.WriteLine("║ 1. Авторизация ║ 2. Пополнение баланса ║ 3. Снять деньги ║");
            Console.WriteLine("╠═══════════════════════╬═══════════════════════╬═══════════════════════╣");
            Console.WriteLine("║ 4. Проверка баланса ║ 5. Перевод денег ║ 6. Выход ║");
            Console.WriteLine("╚═══════════════════════╩═══════════════════════╩═══════════════════════╝");
            BankAccount bankAccount = new BankAccount();
            string num;
            List<string> input_history = new List<string>();
            int input_int_menu;
            double amount_pull;
            num = Console.ReadLine();
            input_history.Add(num);
            bool success = int.TryParse(num, out input_int_menu);

            if (success == true)
            {
                if (input_history[input_history.Count - 1] == "1")
                {
                    Console.Write("Введите номер счета: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите ФИО: ");
                    string user = Console.ReadLine();
                    amount_pull = bankAccount.Auth(id, user,
                    0, 0);
                    System.Threading.Thread.Sleep(1000);
                    while (id != 0)
                    {
                        Console.Clear();
                        Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗");
                        Console.WriteLine("║ Главное меню ║");
                        Console.WriteLine("╠═══════════════════════╦═══════════════════════╦═══════════════════════╣");
                        Console.WriteLine("║ 1. Авторизация ║ 2. Пополнение баланса ║ 3. Снять деньги ║");
                        Console.WriteLine("╠═══════════════════════╬═══════════════════════╬═══════════════════════╣");
                        Console.WriteLine("║ 4. Проверка баланса ║ 5. Перевод денег ║ 6. Выход ║");
                        Console.WriteLine("╚═══════════════════════╩═══════════════════════╩═══════════════════════╝");
                        id = Convert.ToInt32(Console.ReadLine());
                        if (id == 1)
                        {
                            Console.WriteLine("Авторизация успешно пройдена уже.");
                        }
                        else if (id == 2)
                        {
                            amount_pull = bankAccount.Score(id, user, amount_pull, 1);
                        }
                        else if (id == 3)
                        {
                            amount_pull = bankAccount.Score(id, user, amount_pull, 2);
                        }
                        else if (id == 4)
                        {
                            amount_pull = bankAccount.Score(id, user, amount_pull, 3);
                        }
                        else if (id == 5)
                        {
                            amount_pull = bankAccount.Score(id, user, amount_pull, 4);
                        }
                        else if (id == 6)
                        {
                            Console.WriteLine("До свидания.");
                            break;
                            System.Threading.Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.WriteLine("Введите цифру из меню.");
                        }
                        System.Threading.Thread.Sleep(1000);
                    }
                }
                else
                {
                    if (num == "6")
                    {
                        Console.WriteLine("До свидания.");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Пройдите авторизацию.");
                        System.Threading.Thread.Sleep(1000);
                        Main();
                    }

                }

            }
            else
            {
                Console.WriteLine("Введите номер из меню."); System.Threading.Thread.Sleep(1000); Main();
            }
        }
    }

}