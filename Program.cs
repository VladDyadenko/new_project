using System;
using System.Collections.Generic;

namespace project
{
    class Program
    {
        static void Main()
        { // ООП
            /*Поліформізм - це принцип ООП, по якому ми можемо в головному класі створити метод
            а в спадкоємці змінити його, або щось дописати і отримати його, якщо він 
            викликається через цього спадкоємця */

            Killer killer = new("Killer", 5, new byte[] { 0, 0, 0 }, 10);
            killer.printValues();


        }



    }

}
