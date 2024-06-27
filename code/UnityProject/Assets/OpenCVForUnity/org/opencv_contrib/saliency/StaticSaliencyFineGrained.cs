
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class StaticSaliencyFineGrained
    //javadoc: StaticSaliencyFineGrained

    public class StaticSaliencyFineGrained : StaticSaliency
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
saliency_StaticSaliencyFineGrained_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal StaticSaliencyFineGrained (IntPtr addr) : base (addr) { }

        // internal usage only
        public static new StaticSaliencyFineGrained __fromPtr__ (IntPtr addr) { return new StaticSaliencyFineGrained (addr); }

        //
        // C++: static Ptr_StaticSaliencyFineGrained cv::saliency::StaticSaliencyFineGrained::create()
        //

        //javadoc: StaticSaliencyFineGrained::create()
        public static StaticSaliencyFineGrained create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        StaticSaliencyFineGrained retVal = StaticSaliencyFineGrained.__fromPtr__(saliency_StaticSaliencyFineGrained_create_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::saliency::StaticSaliencyFineGrained::computeSaliency(Mat image, Mat& saliencyMap)
        //

        //javadoc: StaticSaliencyFineGrained::computeSaliency(image, saliencyMap)
        public override bool computeSaliency (Mat image, Mat saliencyMap)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
            if (saliencyMap != null) saliencyMap.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = saliency_StaticSaliencyFineGrained_computeSaliency_10(nativeObj, image.nativeObj, saliencyMap.nativeObj);
        
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



        // C++: static Ptr_StaticSaliencyFineGrained cv::saliency::StaticSaliencyFineGrained::create()
        [DllImport (LIBNAME)]
        private static extern IntPtr saliency_StaticSaliencyFineGrained_create_10 ();

        // C++:  bool cv::saliency::StaticSaliencyFineGrained::computeSaliency(Mat image, Mat& saliencyMap)
        [DllImport (LIBNAME)]
        private static extern bool saliency_StaticSaliencyFineGrained_computeSaliency_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr saliencyMap_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void saliency_StaticSaliencyFineGrained_delete (IntPtr nativeObj);

    }
}
