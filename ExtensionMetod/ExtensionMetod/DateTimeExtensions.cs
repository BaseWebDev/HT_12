using System;
using System.Collections.Generic;

namespace ExtensionMetod
{
    /// <summary>
    /// Возвращает итератор со значеняими days - кол-ва дней после текущего дня
    /// </summary>
    static class DateTimeExtensions {
        public static IEnumerable<DateTime> TakeDays(this DateTime dateTime, int days) {
            for (int i = 0; i < days; i++) {
                yield return dateTime.AddDays(i + 1); // Поскольку n слудующих за текущим днем, то +1
            }
        }
    }
}