using DesktopBookmaker.Data;
using DesktopBookmaker.View.EditElement;
using InterfaceView.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DesktopBokmeyker.View.View
{
    public class PossibleBetsView
        : IView
    {
        protected EditComboBox TypeOfBets { get; set; }

        protected EditDecimal Coef1 { get; set; }
        protected EditDecimal Coef2 { get; set; }

        protected EditDecimal Min { get; set; }
        protected EditDecimal Max { get; set; }

        protected EditCheckBox IsAvalaible { get; set; }
        protected EditCheckBox IsPast { get; set; }
        protected EditComboBox WinnerTeam { get; set; }
        protected EditCheckBox ToArchive { get; set; }

        public PossibleBetsView()
        {
            TypeOfBets = new EditComboBox() { Hint="Тип ставки", NameItem=nameof(PossibleBets.TypeOfBets) };

            Coef1 = new EditDecimal() { Hint="Коеф. 1", NameItem=nameof(PossibleBets.Coef1) };
            Coef2 = new EditDecimal() { Hint="Коеф. 2", NameItem=nameof(PossibleBets.Coef2) };

            Min = new EditDecimal() { Hint="Минимальная ставка", NameItem=nameof(PossibleBets.Min) };
            Max = new EditDecimal() { Hint="Максимальная ставка", NameItem=nameof(PossibleBets.Max) };

            IsAvalaible = new EditCheckBox() { Hint="Видимость ставки", NameItem=nameof(PossibleBets.IsAvalaible) };
            IsPast = new EditCheckBox() { Hint="Рассчитана", NameItem=nameof(PossibleBets.IsPast) };
            WinnerTeam = new EditComboBox { Hint="Победитель", NameItem=nameof(PossibleBets.WinnerTeam), IsNullable = true };
            ToArchive = new EditCheckBox() { Hint="В архиве", NameItem=nameof(PossibleBets.ToArchive) };
        }

        public object GetUpdateInEditWindow(List<IEditControl> edits, object ob)
        {
            var possibleBets = (PossibleBets)ob ?? new PossibleBets();

            possibleBets.TypeOfBets = (TypeOfBets)TypeOfBets.Title;

            possibleBets.Coef1 = (Single)(Decimal)Coef1.Title;
            possibleBets.Coef2 = (Single)(Decimal)Coef2.Title;

            possibleBets.Min = (Decimal)Min.Title;
            possibleBets.Max = (Decimal)Max.Title;

            possibleBets.IsAvalaible = ((Boolean?)IsAvalaible.Title).Value;
            possibleBets.IsPast = ((Boolean?)IsPast.Title).Value;
            possibleBets.WinnerTeam = (Teams)WinnerTeam.Title;
            possibleBets.ToArchive = ((Boolean?)ToArchive.Title).Value;

#if !DEBUG
            throw new NotImplementedException("Нет проверки на корректность данных!");
#endif
            return possibleBets;
        }

        public void LoadEditWindow(ListView listView)
        {
            listView.Items.Add(TypeOfBets);

            listView.Items.Add(Coef1);
            listView.Items.Add(Coef2);

            listView.Items.Add(Min);
            listView.Items.Add(Max);

            listView.Items.Add(IsAvalaible);
            listView.Items.Add(IsPast);
            listView.Items.Add(WinnerTeam);
            listView.Items.Add(ToArchive);
        }

        public void UpdateEditWindow(List<IEditControl> edits, object ob)
        {
            var possibleBets = (PossibleBets)ob;

            WinnerTeam.Items = new List<Teams>() { possibleBets.Events.Teams, possibleBets.Events.Teams1 };

            if(ob is null)
            {
                TypeOfBets.Title = null;

                Coef1.Title = 1.87;
                Coef2.Title = 1.87;

                Min.Title = 0;
                Max.Title = 10000;

                IsAvalaible.Title = false;
                IsPast.Title = false;
                WinnerTeam.Title = null;
                ToArchive.Title = false;
            }

            TypeOfBets.Title = possibleBets.TypeOfBets;

            Coef1.Title = possibleBets.Coef1;
            Coef2.Title = possibleBets.Coef2;

            Min.Title = possibleBets.Min;
            Max.Title = possibleBets.Max;

            IsAvalaible.Title = possibleBets.IsAvalaible;
            IsPast.Title = possibleBets.IsPast;
            WinnerTeam.Title = possibleBets.WinnerTeam;
            ToArchive.Title = possibleBets.ToArchive;
        }

        public void ViewTable(DataGrid data)
        {
            data.SelectedValuePath = "Id";

            foreach (var item in data.Columns)
            {
                switch (item.Header.ToString())
                {
                    case (nameof(PossibleBets.Id)):
                        item.Visibility = Visibility.Collapsed;
                        break;
                    case (nameof(PossibleBets.IdEvent)):
                        item.Visibility = Visibility.Collapsed;
                        break;
                    case (nameof(PossibleBets.IdTob)):
                        item.Visibility = Visibility.Collapsed;
                        break;
                    case (nameof(PossibleBets.Margin)):
                        item.Visibility = Visibility.Collapsed;
                        break;
                    case (nameof(PossibleBets.Max)):
                        item.Visibility = Visibility.Collapsed;
                        break;
                    case (nameof(PossibleBets.Min)):
                        item.Visibility = Visibility.Collapsed;
                        break;
                    case (nameof(PossibleBets.Coef1)):
                        item.Visibility = Visibility.Collapsed;
                        break;
                    case (nameof(PossibleBets.Coef2)):
                        item.Visibility = Visibility.Collapsed;
                        break;
                    case (nameof(PossibleBets.Winner)):
                        item.Visibility = Visibility.Collapsed;
                        break;
                    case (nameof(PossibleBets.UserBets)):
                        item.Visibility = Visibility.Collapsed;
                        break;
                    case (nameof(PossibleBets.Events)):
                        item.Visibility = Visibility.Collapsed;
                        break;

                    case (nameof(PossibleBets.MaxMin)):
                        item.Header = "Мин-Макс";
                        break;
                    case (nameof(PossibleBets.Coef)):
                        item.Header = "Коеф1-Коеф2";
                        break;

                    case (nameof(PossibleBets.IsPast)):
                        item.Header = "Завершен";
                        break;
                    case (nameof(PossibleBets.WinnerTeam)):
                        item.Header = "Победитель";
                        break;
                    case (nameof(PossibleBets.IsAvalaible)):
                        item.Header = "Видимость";
                        break;
                    case (nameof(PossibleBets.ToArchive)):
                        item.Header = "В архиве";
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
