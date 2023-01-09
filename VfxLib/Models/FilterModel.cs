using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VfxLib.Models
{
    public class FilterModel : BasePropertyChangedNotification
    {
        public List<string> ListKeyFilter
        {
            get => GetValue(() => ListKeyFilter);
            set => SetValue(() => ListKeyFilter, value);
        }

        public string SeletedKeyFilter
        {
            get => GetValue(() => SeletedKeyFilter);
            set => SetValue(() => SeletedKeyFilter, value);
        }

        public string KeySearch
        {
            get => GetValue(() => KeySearch);
            set => SetValue(() => KeySearch, value);
        }

        public int CurrentIndexFilter
        {
            get => GetValue(() => CurrentIndexFilter);
            set
            {
                SetValue(() => CurrentIndexFilter, value);
                IsEnableNextFilter = CurrentIndexFilter > 0 && CurrentIndexFilter < LengthSearchedFilter;
            }
        }

        public int LengthSearchedFilter
        {
            get => GetValue(() => LengthSearchedFilter);
            set
            {
                SetValue(() => LengthSearchedFilter, value);
                IsEnableNextFilter = CurrentIndexFilter > 0 && CurrentIndexFilter < LengthSearchedFilter;
            }
        }

        public bool IsEnableNextFilter
        {
            get => GetValue(() => IsEnableNextFilter);
            set => SetValue(() => IsEnableNextFilter, value);
        }
        public List<object> ListModelsFilter
        {
            get => GetValue(() => ListModelsFilter);
            set => SetValue(() => ListModelsFilter, value);
        }

    }
}
