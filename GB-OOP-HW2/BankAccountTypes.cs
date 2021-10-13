using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_OOP_HW2
{
    [Flags]
    public enum BankAccountTypes
    {
        Нет,
        Текущий,
        Дебетовый,
        Кредитный,
        Депозитный
    }
}
