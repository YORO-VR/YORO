
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class MotionSaliency
    //javadoc: MotionSaliency

    public class MotionSaliency : Saliency
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
saliency_MotionSaliency_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal MotionSaliency (IntPtr addr) : base (addr) { }

        // internal usage only
        public static new MotionSaliency __fromPtr__ (IntPtr addr) { return new MotionSaliency (addr); }

#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void saliency_MotionSaliency_delete (IntPtr nativeObj);

    }
}
