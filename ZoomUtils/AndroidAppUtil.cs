using System;
using Java.Interop;

namespace US.Zoom.Androidlib.Util
{
    partial class AndroidAppUtil
    {
        partial class ResolbeInfoComparator
        {

            int Java.Util.IComparator.Compare(Java.Lang.Object o1, Java.Lang.Object o2)
            {
                return this.Compare((global::Android.Content.PM.ResolveInfo)o1, (global::Android.Content.PM.ResolveInfo)o2);
            }
        }
    }
}
