
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class MotionSaliencyBinWangApr2014
    //javadoc: MotionSaliencyBinWangApr2014

    public class MotionSaliencyBinWangApr2014 : MotionSaliency
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
saliency_MotionSaliencyBinWangApr2014_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal MotionSaliencyBinWangApr2014 (IntPtr addr) : base (addr) { }

        // internal usage only
        public static new MotionSaliencyBinWangApr2014 __fromPtr__ (IntPtr addr) { return new MotionSaliencyBinWangApr2014 (addr); }

        //
        // C++: static Ptr_MotionSaliencyBinWangApr2014 cv::saliency::MotionSaliencyBinWangApr2014::create()
        //

        //javadoc: MotionSaliencyBinWangApr2014::create()
        public static MotionSaliencyBinWangApr2014 create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        MotionSaliencyBinWangApr2014 retVal = MotionSaliencyBinWangApr2014.__fromPtr__(saliency_MotionSaliencyBinWangApr2014_create_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::saliency::MotionSaliencyBinWangApr2014::computeSaliency(Mat image, Mat& saliencyMap)
        //

        //javadoc: MotionSaliencyBinWangApr2014::computeSaliency(image, saliencyMap)
        public override bool computeSaliency (Mat image, Mat saliencyMap)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
            if (saliencyMap != null) saliencyMap.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = saliency_MotionSaliencyBinWangApr2014_computeSaliency_10(nativeObj, image.nativeObj, saliencyMap.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::saliency::MotionSaliencyBinWangApr2014::init()
        //

        //javadoc: MotionSaliencyBinWangApr2014::init()
        public bool init ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = saliency_MotionSaliencyBinWangApr2014_init_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  int cv::saliency::MotionSaliencyBinWangApr2014::getImageHeight()
        //

        //javadoc: MotionSaliencyBinWangApr2014::getImageHeight()
        public int getImageHeight ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = saliency_MotionSaliencyBinWangApr2014_getImageHeight_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::saliency::MotionSaliencyBinWangApr2014::getImageWidth()
        //

        //javadoc: MotionSaliencyBinWangApr2014::getImageWidth()
        public int getImageWidth ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = saliency_MotionSaliencyBinWangApr2014_getImageWidth_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::saliency::MotionSaliencyBinWangApr2014::setImageHeight(int val)
        //

        //javadoc: MotionSaliencyBinWangApr2014::setImageHeight(val)
        public void setImageHeight (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        saliency_MotionSaliencyBinWangApr2014_setImageHeight_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::saliency::MotionSaliencyBinWangApr2014::setImageWidth(int val)
        //

        //javadoc: MotionSaliencyBinWangApr2014::setImageWidth(val)
        public void setImageWidth (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        saliency_MotionSaliencyBinWangApr2014_setImageWidth_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::saliency::MotionSaliencyBinWangApr2014::setImagesize(int W, int H)
        //

        //javadoc: MotionSaliencyBinWangApr2014::setImagesize(W, H)
        public void setImagesize (int W, int H)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        saliency_MotionSaliencyBinWangApr2014_setImagesize_10(nativeObj, W, H);
        
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



        // C++: static Ptr_MotionSaliencyBinWangApr2014 cv::saliency::MotionSaliencyBinWangApr2014::create()
        [DllImport (LIBNAME)]
        private static extern IntPtr saliency_MotionSaliencyBinWangApr2014_create_10 ();

        // C++:  bool cv::saliency::MotionSaliencyBinWangApr2014::computeSaliency(Mat image, Mat& saliencyMap)
        [DllImport (LIBNAME)]
        private static extern bool saliency_MotionSaliencyBinWangApr2014_computeSaliency_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr saliencyMap_nativeObj);

        // C++:  bool cv::saliency::MotionSaliencyBinWangApr2014::init()
        [DllImport (LIBNAME)]
        private static extern bool saliency_MotionSaliencyBinWangApr2014_init_10 (IntPtr nativeObj);

        // C++:  int cv::saliency::MotionSaliencyBinWangApr2014::getImageHeight()
        [DllImport (LIBNAME)]
        private static extern int saliency_MotionSaliencyBinWangApr2014_getImageHeight_10 (IntPtr nativeObj);

        // C++:  int cv::saliency::MotionSaliencyBinWangApr2014::getImageWidth()
        [DllImport (LIBNAME)]
        private static extern int saliency_MotionSaliencyBinWangApr2014_getImageWidth_10 (IntPtr nativeObj);

        // C++:  void cv::saliency::MotionSaliencyBinWangApr2014::setImageHeight(int val)
        [DllImport (LIBNAME)]
        private static extern void saliency_MotionSaliencyBinWangApr2014_setImageHeight_10 (IntPtr nativeObj, int val);

        // C++:  void cv::saliency::MotionSaliencyBinWangApr2014::setImageWidth(int val)
        [DllImport (LIBNAME)]
        private static extern void saliency_MotionSaliencyBinWangApr2014_setImageWidth_10 (IntPtr nativeObj, int val);

        // C++:  void cv::saliency::MotionSaliencyBinWangApr2014::setImagesize(int W, int H)
        [DllImport (LIBNAME)]
        private static extern void saliency_MotionSaliencyBinWangApr2014_setImagesize_10 (IntPtr nativeObj, int W, int H);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void saliency_MotionSaliencyBinWangApr2014_delete (IntPtr nativeObj);

    }
}
