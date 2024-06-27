
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class MapperGradEuclid
    //javadoc: MapperGradEuclid

    public class MapperGradEuclid : Mapper
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
reg_MapperGradEuclid_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal MapperGradEuclid (IntPtr addr) : base (addr) { }

        // internal usage only
        public static new MapperGradEuclid __fromPtr__ (IntPtr addr) { return new MapperGradEuclid (addr); }

        //
        // C++:   cv::reg::MapperGradEuclid::MapperGradEuclid()
        //

        //javadoc: MapperGradEuclid::MapperGradEuclid()
        public MapperGradEuclid () :
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        base( reg_MapperGradEuclid_MapperGradEuclid_10() )
        
#else
            base (IntPtr.Zero)
#endif
        {

            return;

        }


        //
        // C++:  Ptr_Map cv::reg::MapperGradEuclid::calculate(Mat img1, Mat img2, Ptr_Map init = cv::Ptr<Map>())
        //

        //javadoc: MapperGradEuclid::calculate(img1, img2, init)
        public override Map calculate (Mat img1, Mat img2, Map init)
        {
            ThrowIfDisposed ();
            if (img1 != null) img1.ThrowIfDisposed ();
            if (img2 != null) img2.ThrowIfDisposed ();
            if (init != null) init.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Map retVal = Map.__fromPtr__(reg_MapperGradEuclid_calculate_10(nativeObj, img1.nativeObj, img2.nativeObj, init.getNativeObjAddr()));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: MapperGradEuclid::calculate(img1, img2)
        public override Map calculate (Mat img1, Mat img2)
        {
            ThrowIfDisposed ();
            if (img1 != null) img1.ThrowIfDisposed ();
            if (img2 != null) img2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Map retVal = Map.__fromPtr__(reg_MapperGradEuclid_calculate_11(nativeObj, img1.nativeObj, img2.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_Map cv::reg::MapperGradEuclid::getMap()
        //

        //javadoc: MapperGradEuclid::getMap()
        public override Map getMap ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Map retVal = Map.__fromPtr__(reg_MapperGradEuclid_getMap_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::reg::MapperGradEuclid::MapperGradEuclid()
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapperGradEuclid_MapperGradEuclid_10 ();

        // C++:  Ptr_Map cv::reg::MapperGradEuclid::calculate(Mat img1, Mat img2, Ptr_Map init = cv::Ptr<Map>())
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapperGradEuclid_calculate_10 (IntPtr nativeObj, IntPtr img1_nativeObj, IntPtr img2_nativeObj, IntPtr init_nativeObj);
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapperGradEuclid_calculate_11 (IntPtr nativeObj, IntPtr img1_nativeObj, IntPtr img2_nativeObj);

        // C++:  Ptr_Map cv::reg::MapperGradEuclid::getMap()
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapperGradEuclid_getMap_10 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void reg_MapperGradEuclid_delete (IntPtr nativeObj);

    }
}
