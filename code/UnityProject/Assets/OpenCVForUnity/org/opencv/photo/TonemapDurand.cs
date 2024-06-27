
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class TonemapDurand
    //javadoc: TonemapDurand

    public class TonemapDurand : Tonemap
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
photo_TonemapDurand_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal TonemapDurand (IntPtr addr) : base (addr) { }

        // internal usage only
        public static new TonemapDurand __fromPtr__ (IntPtr addr) { return new TonemapDurand (addr); }

        //
        // C++:  float cv::TonemapDurand::getContrast()
        //

        //javadoc: TonemapDurand::getContrast()
        public float getContrast ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapDurand_getContrast_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::TonemapDurand::getSaturation()
        //

        //javadoc: TonemapDurand::getSaturation()
        public float getSaturation ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapDurand_getSaturation_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::TonemapDurand::getSigmaColor()
        //

        //javadoc: TonemapDurand::getSigmaColor()
        public float getSigmaColor ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapDurand_getSigmaColor_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::TonemapDurand::getSigmaSpace()
        //

        //javadoc: TonemapDurand::getSigmaSpace()
        public float getSigmaSpace ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapDurand_getSigmaSpace_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::TonemapDurand::setContrast(float contrast)
        //

        //javadoc: TonemapDurand::setContrast(contrast)
        public void setContrast (float contrast)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_TonemapDurand_setContrast_10(nativeObj, contrast);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::TonemapDurand::setSaturation(float saturation)
        //

        //javadoc: TonemapDurand::setSaturation(saturation)
        public void setSaturation (float saturation)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_TonemapDurand_setSaturation_10(nativeObj, saturation);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::TonemapDurand::setSigmaColor(float sigma_color)
        //

        //javadoc: TonemapDurand::setSigmaColor(sigma_color)
        public void setSigmaColor (float sigma_color)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_TonemapDurand_setSigmaColor_10(nativeObj, sigma_color);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::TonemapDurand::setSigmaSpace(float sigma_space)
        //

        //javadoc: TonemapDurand::setSigmaSpace(sigma_space)
        public void setSigmaSpace (float sigma_space)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_TonemapDurand_setSigmaSpace_10(nativeObj, sigma_space);
        
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



        // C++:  float cv::TonemapDurand::getContrast()
        [DllImport (LIBNAME)]
        private static extern float photo_TonemapDurand_getContrast_10 (IntPtr nativeObj);

        // C++:  float cv::TonemapDurand::getSaturation()
        [DllImport (LIBNAME)]
        private static extern float photo_TonemapDurand_getSaturation_10 (IntPtr nativeObj);

        // C++:  float cv::TonemapDurand::getSigmaColor()
        [DllImport (LIBNAME)]
        private static extern float photo_TonemapDurand_getSigmaColor_10 (IntPtr nativeObj);

        // C++:  float cv::TonemapDurand::getSigmaSpace()
        [DllImport (LIBNAME)]
        private static extern float photo_TonemapDurand_getSigmaSpace_10 (IntPtr nativeObj);

        // C++:  void cv::TonemapDurand::setContrast(float contrast)
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapDurand_setContrast_10 (IntPtr nativeObj, float contrast);

        // C++:  void cv::TonemapDurand::setSaturation(float saturation)
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapDurand_setSaturation_10 (IntPtr nativeObj, float saturation);

        // C++:  void cv::TonemapDurand::setSigmaColor(float sigma_color)
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapDurand_setSigmaColor_10 (IntPtr nativeObj, float sigma_color);

        // C++:  void cv::TonemapDurand::setSigmaSpace(float sigma_space)
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapDurand_setSigmaSpace_10 (IntPtr nativeObj, float sigma_space);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapDurand_delete (IntPtr nativeObj);

    }
}
