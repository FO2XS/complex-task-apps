using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.ModalEntity
{
    public partial class MoneyManagement
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdOperator { get; set; }
        public bool TakeOrAdd { get; set; }
        public decimal Sum { get; set; }
        public DateTime Date { get; set; }
        public string Details { get; set; }

        public virtual Operator IdOperatorNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }


        
        /// <summary>
        /// Функция осуществляет проверку входящих значений при создании операции ввода/вывода финансов
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <param name="takeOrAdd">Операция вывод - true, операция на ввод - false</param>
        /// <param name="sum">Денежная сумма</param>
        /// <param name="numberCard">Номер счёта пользователя</param>
        /// <returns>Возвращает объект MoneyManagement в случае прохождения проверки, null в остальных случаях</returns>
        public static MoneyManagement AddNewOperation(User user, bool takeOrAdd, decimal sum, string numberCard)
        {
            if (CheckBankCard(numberCard) && CheckUserMoney(user, takeOrAdd, sum))
            {
                return new MoneyManagement()
                {
                    IdUser = user.Id,
                    IdOperator = StorageKeys.GeneralOperatorId,
                    TakeOrAdd = takeOrAdd,
                    Sum = sum,
                    Date = DateTime.Now,
                    Details = $"Номер карты: {numberCard}"
                };
            }
            return null;
        }


        private static bool CheckBankCard(string card)
        {
            //Здесь необходимо реализовать проверку банковской карты, а то вдруг нам введут фывФАЫАВИ вместо карты

            return card is not null;
        }

        private static bool CheckUserMoney(User user, bool takeOrAdd, decimal sum)
        {
            if (sum <= 0) return false;

            if (!takeOrAdd) return true;

            return user.Balance-sum>=0;
        }
    }
}
