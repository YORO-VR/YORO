
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class EMDHistogramCostExtractor
    //javadoc: EMDHistogramCostExtractor

    public class EMDHistogramCostExtractor : HistogramCostExtractor
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
shape_EMDHistogramCostExtractor_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal EMDHistogramCostExtractor (IntPtr addr) : base (addr) { }

        // internal usage only
        public static new EMDHistogramCostExtractor __fromPtr__ (IntPtr addr) { return new EMDHistogramCostExtractor (addr); }

        //
        // C++:  int cv::EMDHistogramCostExtractor::getNormFlag()
        //

        //javadoc: EMDHistogramCostExtractor::getNormFlag()
        public int getNormFlag ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = shape_EMDHistogramCostExtractor_getNormFlag_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::EMDHistogramCostExtractor::setNormFlag(int flag)
        //

        //javadoc: EMDHistogramCostExtractor::setNormFlag(flag)
        public void setNormFlag (int flag)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_EMDHistogramCostExtractor_setNormFlag_10(nativeObj, flag);
        
        return;
#else
            return;
#endif
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::EMDHistogramCostExtractor::getNormFlag()
        [DllImport (LIBNAME)]
        private static extern int shape_EMDHistogramCostExtractor_getNormFlag_10 (IntPtr nativeObj);

        // C++:  void cv::EMDHistogramCostExtractor::setNormFlag(int flag)
        [DllImport (LIBNAME)]
        private static extern void shape_EMDHistogramCostExtractor_setNormFlag_10 (IntPtr nativeObj, int flag);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void shape_EMDHistogramCostExtractor_delete (IntPtr nativeObj);

    }
}
