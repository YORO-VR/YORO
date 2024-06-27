

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class Map
    //javadoc: Map

    public class Map : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
reg_Map_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal Map (IntPtr addr) : base (addr) { }


        public IntPtr getNativeObjAddr () { return nativeObj; }

        // internal usage only
        public static Map __fromPtr__ (IntPtr addr) { return new Map (addr); }

        //
        // C++:  Ptr_Map cv::reg::Map::inverseMap()
        //

        //javadoc: Map::inverseMap()
        public virtual Map inverseMap ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Map retVal = Map.__fromPtr__(reg_Map_inverseMap_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::reg::Map::compose(Ptr_Map map)
        //

        //javadoc: Map::compose(map)
        public virtual void compose (Map map)
        {
            ThrowIfDisposed ();
            if (map != null) map.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        reg_Map_compose_10(nativeObj, map.getNativeObjAddr());
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::reg::Map::inverseWarp(Mat img1, Mat& img2)
        //

        //javadoc: Map::inverseWarp(img1, img2)
        public virtual void inverseWarp (Mat img1, Mat img2)
        {
            ThrowIfDisposed ();
            if (img1 != null) img1.ThrowIfDisposed ();
            if (img2 != null) img2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        reg_Map_inverseWarp_10(nativeObj, img1.nativeObj, img2.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::reg::Map::scale(double factor)
        //

        //javadoc: Map::scale(factor)
        public virtual void scale (double factor)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        reg_Map_scale_10(nativeObj, factor);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::reg::Map::warp(Mat img1, Mat& img2)
        //

        //javadoc: Map::warp(img1, img2)
        public void warp (Mat img1, Mat img2)
        {
            ThrowIfDisposed ();
            if (img1 != null) img1.ThrowIfDisposed ();
            if (img2 != null) img2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        reg_Map_warp_10(nativeObj, img1.nativeObj, img2.nativeObj);
        
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



        // C++:  Ptr_Map cv::reg::Map::inverseMap()
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_Map_inverseMap_10 (IntPtr nativeObj);

        // C++:  void cv::reg::Map::compose(Ptr_Map map)
        [DllImport (LIBNAME)]
        private static extern void reg_Map_compose_10 (IntPtr nativeObj, IntPtr map_nativeObj);

        // C++:  void cv::reg::Map::inverseWarp(Mat img1, Mat& img2)
        [DllImport (LIBNAME)]
        private static extern void reg_Map_inverseWarp_10 (IntPtr nativeObj, IntPtr img1_nativeObj, IntPtr img2_nativeObj);

        // C++:  void cv::reg::Map::scale(double factor)
        [DllImport (LIBNAME)]
        private static extern void reg_Map_scale_10 (IntPtr nativeObj, double factor);

        // C++:  void cv::reg::Map::warp(Mat img1, Mat& img2)
        [DllImport (LIBNAME)]
        private static extern void reg_Map_warp_10 (IntPtr nativeObj, IntPtr img1_nativeObj, IntPtr img2_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void reg_Map_delete (IntPtr nativeObj);

    }
}
