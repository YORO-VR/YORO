
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class ShapeDistanceExtractor
    //javadoc: ShapeDistanceExtractor

    public class ShapeDistanceExtractor : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
shape_ShapeDistanceExtractor_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal ShapeDistanceExtractor (IntPtr addr) : base (addr) { }

        // internal usage only
        public static new ShapeDistanceExtractor __fromPtr__ (IntPtr addr) { return new ShapeDistanceExtractor (addr); }

        //
        // C++:  float cv::ShapeDistanceExtractor::computeDistance(Mat contour1, Mat contour2)
        //

        //javadoc: ShapeDistanceExtractor::computeDistance(contour1, contour2)
        public float computeDistance (Mat contour1, Mat contour2)
        {
            ThrowIfDisposed ();
            if (contour1 != null) contour1.ThrowIfDisposed ();
            if (contour2 != null) contour2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = shape_ShapeDistanceExtractor_computeDistance_10(nativeObj, contour1.nativeObj, contour2.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  float cv::ShapeDistanceExtractor::computeDistance(Mat contour1, Mat contour2)
        [DllImport (LIBNAME)]
        private static extern float shape_ShapeDistanceExtractor_computeDistance_10 (IntPtr nativeObj, IntPtr contour1_nativeObj, IntPtr contour2_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeDistanceExtractor_delete (IntPtr nativeObj);

    }
}
