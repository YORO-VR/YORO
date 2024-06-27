
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class Saliency
    //javadoc: Saliency

    public class Saliency : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
saliency_Saliency_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal Saliency (IntPtr addr) : base (addr) { }

        // internal usage only
        public static new Saliency __fromPtr__ (IntPtr addr) { return new Saliency (addr); }

        //
        // C++:  bool cv::saliency::Saliency::computeSaliency(Mat image, Mat& saliencyMap)
        //

        //javadoc: Saliency::computeSaliency(image, saliencyMap)
        public virtual bool computeSaliency (Mat image, Mat saliencyMap)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
            if (saliencyMap != null) saliencyMap.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = saliency_Saliency_computeSaliency_10(nativeObj, image.nativeObj, saliencyMap.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  bool cv::saliency::Saliency::computeSaliency(Mat image, Mat& saliencyMap)
        [DllImport (LIBNAME)]
        private static extern bool saliency_Saliency_computeSaliency_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr saliencyMap_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void saliency_Saliency_delete (IntPtr nativeObj);

    }
}
