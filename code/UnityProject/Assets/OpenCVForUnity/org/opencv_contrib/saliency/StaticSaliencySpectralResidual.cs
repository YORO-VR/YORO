
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class StaticSaliencySpectralResidual
    //javadoc: StaticSaliencySpectralResidual

    public class StaticSaliencySpectralResidual : StaticSaliency
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
saliency_StaticSaliencySpectralResidual_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal StaticSaliencySpectralResidual (IntPtr addr) : base (addr) { }

        // internal usage only
        public static new StaticSaliencySpectralResidual __fromPtr__ (IntPtr addr) { return new StaticSaliencySpectralResidual (addr); }

        //
        // C++: static Ptr_StaticSaliencySpectralResidual cv::saliency::StaticSaliencySpectralResidual::create()
        //

        //javadoc: StaticSaliencySpectralResidual::create()
        public static StaticSaliencySpectralResidual create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        StaticSaliencySpectralResidual retVal = StaticSaliencySpectralResidual.__fromPtr__(saliency_StaticSaliencySpectralResidual_create_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::saliency::StaticSaliencySpectralResidual::computeSaliency(Mat image, Mat& saliencyMap)
        //

        //javadoc: StaticSaliencySpectralResidual::computeSaliency(image, saliencyMap)
        public override bool computeSaliency (Mat image, Mat saliencyMap)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
            if (saliencyMap != null) saliencyMap.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = saliency_StaticSaliencySpectralResidual_computeSaliency_10(nativeObj, image.nativeObj, saliencyMap.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  int cv::saliency::StaticSaliencySpectralResidual::getImageHeight()
        //

        //javadoc: StaticSaliencySpectralResidual::getImageHeight()
        public int getImageHeight ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = saliency_StaticSaliencySpectralResidual_getImageHeight_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::saliency::StaticSaliencySpectralResidual::getImageWidth()
        //

        //javadoc: StaticSaliencySpectralResidual::getImageWidth()
        public int getImageWidth ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = saliency_StaticSaliencySpectralResidual_getImageWidth_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::saliency::StaticSaliencySpectralResidual::read(FileNode fn)
        //

        // Unknown type 'FileNode' (I), skipping the function


        //
        // C++:  void cv::saliency::StaticSaliencySpectralResidual::setImageHeight(int val)
        //

        //javadoc: StaticSaliencySpectralResidual::setImageHeight(val)
        public void setImageHeight (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        saliency_StaticSaliencySpectralResidual_setImageHeight_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::saliency::StaticSaliencySpectralResidual::setImageWidth(int val)
        //

        //javadoc: StaticSaliencySpectralResidual::setImageWidth(val)
        public void setImageWidth (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        saliency_StaticSaliencySpectralResidual_setImageWidth_10(nativeObj, val);
        
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



        // C++: static Ptr_StaticSaliencySpectralResidual cv::saliency::StaticSaliencySpectralResidual::create()
        [DllImport (LIBNAME)]
        private static extern IntPtr saliency_StaticSaliencySpectralResidual_create_10 ();

        // C++:  bool cv::saliency::StaticSaliencySpectralResidual::computeSaliency(Mat image, Mat& saliencyMap)
        [DllImport (LIBNAME)]
        private static extern bool saliency_StaticSaliencySpectralResidual_computeSaliency_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr saliencyMap_nativeObj);

        // C++:  int cv::saliency::StaticSaliencySpectralResidual::getImageHeight()
        [DllImport (LIBNAME)]
        private static extern int saliency_StaticSaliencySpectralResidual_getImageHeight_10 (IntPtr nativeObj);

        // C++:  int cv::saliency::StaticSaliencySpectralResidual::getImageWidth()
        [DllImport (LIBNAME)]
        private static extern int saliency_StaticSaliencySpectralResidual_getImageWidth_10 (IntPtr nativeObj);

        // C++:  void cv::saliency::StaticSaliencySpectralResidual::setImageHeight(int val)
        [DllImport (LIBNAME)]
        private static extern void saliency_StaticSaliencySpectralResidual_setImageHeight_10 (IntPtr nativeObj, int val);

        // C++:  void cv::saliency::StaticSaliencySpectralResidual::setImageWidth(int val)
        [DllImport (LIBNAME)]
        private static extern void saliency_StaticSaliencySpectralResidual_setImageWidth_10 (IntPtr nativeObj, int val);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void saliency_StaticSaliencySpectralResidual_delete (IntPtr nativeObj);

    }
}
