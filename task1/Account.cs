using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Account <T>
    {
        T accountNumber;
        string fullName;
        double balance;
       
        public T AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }

        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public void Input()
        {
            Console.Write("Введите номер счёта: ");
            AccountNumber = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.Write("Введите ФИО: ");
            FullName = Convert.ToString(Console.ReadLine());
            Console.Write("Введите баланс: ");
            Balance = Convert.ToDouble(Console.ReadLine());
        }
        public string GetInfo()
        {
            return $"\nНомер счёта: {AccountNumber} \nФИО: {FullName} \nБаланс: {Balance:F2}$";
        }

    }
}
