using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VfxLib.Models
{
    public class PaginationModel : BasePropertyChangedNotification
    {
        public int CurrentPage
        {
            get => GetValue(() => CurrentPage);
            set
            {
                SetValue(() => CurrentPage, value);
                IsEnableNextPage = CurrentPage < TotalPage;
                IsEnablePrePage = CurrentPage > 1;
            }
        }

        public int PageSize
        {
            get => GetValue(() => PageSize);
            set => SetValue(() => PageSize, value);
        }

        public int TotalPage
        {
            get => GetValue(() => TotalPage);
            set
            {
                SetValue(() => TotalPage, value);
                IsEnableNextPage = CurrentPage < TotalPage;
                IsEnablePrePage = CurrentPage > 1;
            }
        }

        public int TotalRecord
        {
            get => GetValue(() => TotalRecord);
            set
            {
                SetValue(() => TotalRecord, value);
                TotalPage = (int)Math.Ceiling(TotalRecord * 1.0 / PageSize);
            }
        }

        public bool IsEnableNextPage
        {
            get => GetValue(() => IsEnableNextPage);
            set => SetValue(() => IsEnableNextPage, value);
        }

        public bool IsEnablePrePage
        {
            get => GetValue(() => IsEnablePrePage);
            set => SetValue(() => IsEnablePrePage, value);
        }

        public void Reset()
        {
            IsEnableNextPage = false;
            IsEnablePrePage = false;
            TotalRecord = 0;
            TotalPage = 0;
            PageSize = 500;
            CurrentPage = 0;
        }
        public PaginationModel()
        {
            IsEnableNextPage = false;
            IsEnablePrePage = false;
            TotalRecord = 0;
            TotalPage = 0;
            PageSize = 500;
            CurrentPage = 0;
        }
    }
}
