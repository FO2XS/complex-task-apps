using DesktopBookmaker.Data;
using DesktopBookmaker.View.EditElement;
using InterfaceView.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            throw new NotImplementedException();
        }

        public void UpdateEditWindow(List<IEditControl> edits, object ob)
        {
            var possibleBets = (PossibleBets)ob;

            if(ob is null)
            {
                /*
                TypeOfBets = new EditComboBox() { Hint = "Тип ставки", NameItem = nameof(PossibleBets.TypeOfBets) };

                Coef1 = new EditDecimal() { Hint = "Коеф. 1", NameItem = nameof(PossibleBets.Coef1) };
                Coef2 = new EditDecimal() { Hint = "Коеф. 2", NameItem = nameof(PossibleBets.Coef2) };

                Min = new EditDecimal() { Hint = "Минимальная ставка", NameItem = nameof(PossibleBets.Min) };
                Max = new EditDecimal() { Hint = "Максимальная ставка", NameItem = nameof(PossibleBets.Max) };

                IsAvalaible = new EditCheckBox() { Hint = "Видимость ставки", NameItem = nameof(PossibleBets.IsAvalaible) };
                IsPast = new EditCheckBox() { Hint = "Рассчитана", NameItem = nameof(PossibleBets.IsPast) };
                WinnerTeam = new EditComboBox { Hint = "Победитель", NameItem = nameof(PossibleBets.WinnerTeam), IsNullable = true };
                ToArchive = new EditCheckBox() { Hint = "В архиве", NameItem = nameof(PossibleBets.ToArchive) };*/
            }
        }

        public void ViewTable(DataGrid data)
        {
            throw new NotImplementedException();
        }
    }
}
