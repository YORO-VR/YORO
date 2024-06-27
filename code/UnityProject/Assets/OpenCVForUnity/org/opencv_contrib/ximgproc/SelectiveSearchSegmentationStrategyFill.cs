
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class SelectiveSearchSegmentationStrategyFill
    //javadoc: SelectiveSearchSegmentationStrategyFill

    public class SelectiveSearchSegmentationStrategyFill : SelectiveSearchSegmentationStrategy
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ximgproc_SelectiveSearchSegmentationStrategyFill_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal SelectiveSearchSegmentationStrategyFill (IntPtr addr) : base (addr) { }

        // internal usage only
        public static new SelectiveSearchSegmentationStrategyFill __fromPtr__ (IntPtr addr) { return new SelectiveSearchSegmentationStrategyFill (addr); }

#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentationStrategyFill_delete (IntPtr nativeObj);

    }
}
