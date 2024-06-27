
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class ThinPlateSplineShapeTransformer
    //javadoc: ThinPlateSplineShapeTransformer

    public class ThinPlateSplineShapeTransformer : ShapeTransformer
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
shape_ThinPlateSplineShapeTransformer_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal ThinPlateSplineShapeTransformer (IntPtr addr) : base (addr) { }

        // internal usage only
        public static new ThinPlateSplineShapeTransformer __fromPtr__ (IntPtr addr) { return new ThinPlateSplineShapeTransformer (addr); }

        //
        // C++:  double cv::ThinPlateSplineShapeTransformer::getRegularizationParameter()
        //

        //javadoc: ThinPlateSplineShapeTransformer::getRegularizationParameter()
        public double getRegularizationParameter ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = shape_ThinPlateSplineShapeTransformer_getRegularizationParameter_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::ThinPlateSplineShapeTransformer::setRegularizationParameter(double beta)
        //

        //javadoc: ThinPlateSplineShapeTransformer::setRegularizationParameter(beta)
        public void setRegularizationParameter (double beta)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ThinPlateSplineShapeTransformer_setRegularizationParameter_10(nativeObj, beta);
        
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



        // C++:  double cv::ThinPlateSplineShapeTransformer::getRegularizationParameter()
        [DllImport (LIBNAME)]
        private static extern double shape_ThinPlateSplineShapeTransformer_getRegularizationParameter_10 (IntPtr nativeObj);

        // C++:  void cv::ThinPlateSplineShapeTransformer::setRegularizationParameter(double beta)
        [DllImport (LIBNAME)]
        private static extern void shape_ThinPlateSplineShapeTransformer_setRegularizationParameter_10 (IntPtr nativeObj, double beta);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void shape_ThinPlateSplineShapeTransformer_delete (IntPtr nativeObj);

    }
}
