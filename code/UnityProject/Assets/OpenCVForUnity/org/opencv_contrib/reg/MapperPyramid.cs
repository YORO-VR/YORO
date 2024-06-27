
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class MapperPyramid
    //javadoc: MapperPyramid

    public class MapperPyramid : Mapper
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
reg_MapperPyramid_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal MapperPyramid (IntPtr addr) : base (addr) { }

        // internal usage only
        public static new MapperPyramid __fromPtr__ (IntPtr addr) { return new MapperPyramid (addr); }

        //
        // C++:   cv::reg::MapperPyramid::MapperPyramid(Ptr_Mapper baseMapper)
        //

        //javadoc: MapperPyramid::MapperPyramid(baseMapper)
        public MapperPyramid (Mapper baseMapper) :
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        base( reg_MapperPyramid_MapperPyramid_10(baseMapper.getNativeObjAddr()) )
        
#else
            base (IntPtr.Zero)
#endif
        {

            return;

        }


        //
        // C++:  Ptr_Map cv::reg::MapperPyramid::calculate(Mat img1, Mat img2, Ptr_Map init = cv::Ptr<Map>())
        //

        //javadoc: MapperPyramid::calculate(img1, img2, init)
        public override Map calculate (Mat img1, Mat img2, Map init)
        {
            ThrowIfDisposed ();
            if (img1 != null) img1.ThrowIfDisposed ();
            if (img2 != null) img2.ThrowIfDisposed ();
            if (init != null) init.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Map retVal = Map.__fromPtr__(reg_MapperPyramid_calculate_10(nativeObj, img1.nativeObj, img2.nativeObj, init.getNativeObjAddr()));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: MapperPyramid::calculate(img1, img2)
        public override Map calculate (Mat img1, Mat img2)
        {
            ThrowIfDisposed ();
            if (img1 != null) img1.ThrowIfDisposed ();
            if (img2 != null) img2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Map retVal = Map.__fromPtr__(reg_MapperPyramid_calculate_11(nativeObj, img1.nativeObj, img2.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_Map cv::reg::MapperPyramid::getMap()
        //

        //javadoc: MapperPyramid::getMap()
        public override Map getMap ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Map retVal = Map.__fromPtr__(reg_MapperPyramid_getMap_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: int MapperPyramid::numLev_
        //

        //javadoc: MapperPyramid::get_numLev_()
        public int get_numLev_ ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = reg_MapperPyramid_get_1numLev_1_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: void MapperPyramid::numLev_
        //

        //javadoc: MapperPyramid::set_numLev_(numLev_)
        public void set_numLev_ (int numLev_)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        reg_MapperPyramid_set_1numLev_1_10(nativeObj, numLev_);
        
        return;
#else
            return;
#endif
        }


        //
        // C++: int MapperPyramid::numIterPerScale_
        //

        //javadoc: MapperPyramid::get_numIterPerScale_()
        public int get_numIterPerScale_ ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = reg_MapperPyramid_get_1numIterPerScale_1_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++: void MapperPyramid::numIterPerScale_
        //

        //javadoc: MapperPyramid::set_numIterPerScale_(numIterPerScale_)
        public void set_numIterPerScale_ (int numIterPerScale_)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        reg_MapperPyramid_set_1numIterPerScale_1_10(nativeObj, numIterPerScale_);
        
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



        // C++:   cv::reg::MapperPyramid::MapperPyramid(Ptr_Mapper baseMapper)
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapperPyramid_MapperPyramid_10 (IntPtr baseMapper_nativeObj);

        // C++:  Ptr_Map cv::reg::MapperPyramid::calculate(Mat img1, Mat img2, Ptr_Map init = cv::Ptr<Map>())
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapperPyramid_calculate_10 (IntPtr nativeObj, IntPtr img1_nativeObj, IntPtr img2_nativeObj, IntPtr init_nativeObj);
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapperPyramid_calculate_11 (IntPtr nativeObj, IntPtr img1_nativeObj, IntPtr img2_nativeObj);

        // C++:  Ptr_Map cv::reg::MapperPyramid::getMap()
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapperPyramid_getMap_10 (IntPtr nativeObj);

        // C++: int MapperPyramid::numLev_
        [DllImport (LIBNAME)]
        private static extern int reg_MapperPyramid_get_1numLev_1_10 (IntPtr nativeObj);

        // C++: void MapperPyramid::numLev_
        [DllImport (LIBNAME)]
        private static extern void reg_MapperPyramid_set_1numLev_1_10 (IntPtr nativeObj, int numLev_);

        // C++: int MapperPyramid::numIterPerScale_
        [DllImport (LIBNAME)]
        private static extern int reg_MapperPyramid_get_1numIterPerScale_1_10 (IntPtr nativeObj);

        // C++: void MapperPyramid::numIterPerScale_
        [DllImport (LIBNAME)]
        private static extern void reg_MapperPyramid_set_1numIterPerScale_1_10 (IntPtr nativeObj, int numIterPerScale_);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void reg_MapperPyramid_delete (IntPtr nativeObj);

    }
}
