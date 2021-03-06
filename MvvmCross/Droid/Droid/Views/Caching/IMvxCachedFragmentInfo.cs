using System;

namespace MvvmCross.Droid.Views.Caching
{
    public interface IMvxCachedFragmentInfo
    {
        string Tag { get; set; }
        Type FragmentType { get; set; }
        Type ViewModelType { get; set; }
        IMvxFragmentView CachedFragment { get; set; }
        bool CacheFragment { get; set; }
        int ContentId { get; set; }
        bool AddToBackStack { get; set; }
    }
}