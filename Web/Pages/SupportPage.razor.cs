using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Test.Pages
{
    public partial class SupportPage
    {
        private int IdTopic;
        private string text;
        private string email;


        private void SendReport()
        {
            if (text is null || email is null)
            {
                _snackBar.Add("Заполните все поля");
                return;
            }
            //Далее нужно отправить сам репорт.
            //Либо сохраняем его в бд либо нужно добавить отдельную почту
            _snackBar.Add("Репорт отправлен. Спасибо Вам");
        }

        private void ChangeTopic(ChangeEventArgs obj)
        {
            IdTopic = Convert.ToInt32(obj.Value);
            
        }
    }


}
