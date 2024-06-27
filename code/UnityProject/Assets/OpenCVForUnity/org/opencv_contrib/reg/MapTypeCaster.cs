

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class MapTypeCaster
    //javadoc: MapTypeCaster

    public class MapTypeCaster : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
reg_MapTypeCaster_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal MapTypeCaster (IntPtr addr) : base (addr) { }


        public IntPtr getNativeObjAddr () { return nativeObj; }

        // internal usage only
        public static MapTypeCaster __fromPtr__ (IntPtr addr) { return new MapTypeCaster (addr); }

        //
        // C++: static Ptr_MapAffine cv::reg::MapTypeCaster::toAffine(Ptr_Map sourceMap)
        //

        //javadoc: MapTypeCaster::toAffine(sourceMap)
        public static MapAffine toAffine (Map sourceMap)
        {
            if (sourceMap != null) sourceMap.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        MapAffine retVal = MapAffine.__fromPtr__(reg_MapTypeCaster_toAffine_10(sourceMap.getNativeObjAddr()));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_MapProjec cv::reg::MapTypeCaster::toProjec(Ptr_Map sourceMap)
        //

        //javadoc: MapTypeCaster::toProjec(sourceMap)
        public static MapProjec toProjec (Map sourceMap)
        {
            if (sourceMap != null) sourceMap.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        MapProjec retVal = MapProjec.__fromPtr__(reg_MapTypeCaster_toProjec_10(sourceMap.getNativeObjAddr()));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_MapShift cv::reg::MapTypeCaster::toShift(Ptr_Map sourceMap)
        //

        //javadoc: MapTypeCaster::toShift(sourceMap)
        public static MapShift toShift (Map sourceMap)
        {
            if (sourceMap != null) sourceMap.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        MapShift retVal = MapShift.__fromPtr__(reg_MapTypeCaster_toShift_10(sourceMap.getNativeObjAddr()));
        
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



        // C++: static Ptr_MapAffine cv::reg::MapTypeCaster::toAffine(Ptr_Map sourceMap)
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapTypeCaster_toAffine_10 (IntPtr sourceMap_nativeObj);

        // C++: static Ptr_MapProjec cv::reg::MapTypeCaster::toProjec(Ptr_Map sourceMap)
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapTypeCaster_toProjec_10 (IntPtr sourceMap_nativeObj);

        // C++: static Ptr_MapShift cv::reg::MapTypeCaster::toShift(Ptr_Map sourceMap)
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapTypeCaster_toShift_10 (IntPtr sourceMap_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void reg_MapTypeCaster_delete (IntPtr nativeObj);

    }
}
