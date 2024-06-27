
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class TrackerCSRT
    //javadoc: TrackerCSRT

    public class TrackerCSRT : Tracker
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
tracking_TrackerCSRT_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal TrackerCSRT (IntPtr addr) : base (addr) { }

        // internal usage only
        public static new TrackerCSRT __fromPtr__ (IntPtr addr) { return new TrackerCSRT (addr); }

        //
        // C++: static Ptr_TrackerCSRT cv::TrackerCSRT::create()
        //

        //javadoc: TrackerCSRT::create()
        public static TrackerCSRT create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        TrackerCSRT retVal = TrackerCSRT.__fromPtr__(tracking_TrackerCSRT_create_10());
        
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



        // C++: static Ptr_TrackerCSRT cv::TrackerCSRT::create()
        [DllImport (LIBNAME)]
        private static extern IntPtr tracking_TrackerCSRT_create_10 ();

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void tracking_TrackerCSRT_delete (IntPtr nativeObj);

    }
}
