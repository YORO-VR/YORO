
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class ShapeTransformer
    //javadoc: ShapeTransformer

    public class ShapeTransformer : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
shape_ShapeTransformer_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal ShapeTransformer (IntPtr addr) : base (addr) { }

        // internal usage only
        public static new ShapeTransformer __fromPtr__ (IntPtr addr) { return new ShapeTransformer (addr); }

        //
        // C++:  float cv::ShapeTransformer::applyTransformation(Mat input, Mat& output = Mat())
        //

        //javadoc: ShapeTransformer::applyTransformation(input, output)
        public float applyTransformation (Mat input, Mat output)
        {
            ThrowIfDisposed ();
            if (input != null) input.ThrowIfDisposed ();
            if (output != null) output.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = shape_ShapeTransformer_applyTransformation_10(nativeObj, input.nativeObj, output.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: ShapeTransformer::applyTransformation(input)
        public float applyTransformation (Mat input)
        {
            ThrowIfDisposed ();
            if (input != null) input.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = shape_ShapeTransformer_applyTransformation_11(nativeObj, input.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::ShapeTransformer::estimateTransformation(Mat transformingShape, Mat targetShape, vector_DMatch matches)
        //

        //javadoc: ShapeTransformer::estimateTransformation(transformingShape, targetShape, matches)
        public void estimateTransformation (Mat transformingShape, Mat targetShape, MatOfDMatch matches)
        {
            ThrowIfDisposed ();
            if (transformingShape != null) transformingShape.ThrowIfDisposed ();
            if (targetShape != null) targetShape.ThrowIfDisposed ();
            if (matches != null) matches.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat matches_mat = matches;
        shape_ShapeTransformer_estimateTransformation_10(nativeObj, transformingShape.nativeObj, targetShape.nativeObj, matches_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ShapeTransformer::warpImage(Mat transformingImage, Mat& output, int flags = INTER_LINEAR, int borderMode = BORDER_CONSTANT, Scalar borderValue = Scalar())
        //

        //javadoc: ShapeTransformer::warpImage(transformingImage, output, flags, borderMode, borderValue)
        public void warpImage (Mat transformingImage, Mat output, int flags, int borderMode, Scalar borderValue)
        {
            ThrowIfDisposed ();
            if (transformingImage != null) transformingImage.ThrowIfDisposed ();
            if (output != null) output.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ShapeTransformer_warpImage_10(nativeObj, transformingImage.nativeObj, output.nativeObj, flags, borderMode, borderValue.val[0], borderValue.val[1], borderValue.val[2], borderValue.val[3]);
        
        return;
#else
            return;
#endif
        }

        //javadoc: ShapeTransformer::warpImage(transformingImage, output, flags, borderMode)
        public void warpImage (Mat transformingImage, Mat output, int flags, int borderMode)
        {
            ThrowIfDisposed ();
            if (transformingImage != null) transformingImage.ThrowIfDisposed ();
            if (output != null) output.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ShapeTransformer_warpImage_11(nativeObj, transformingImage.nativeObj, output.nativeObj, flags, borderMode);
        
        return;
#else
            return;
#endif
        }

        //javadoc: ShapeTransformer::warpImage(transformingImage, output, flags)
        public void warpImage (Mat transformingImage, Mat output, int flags)
        {
            ThrowIfDisposed ();
            if (transformingImage != null) transformingImage.ThrowIfDisposed ();
            if (output != null) output.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ShapeTransformer_warpImage_12(nativeObj, transformingImage.nativeObj, output.nativeObj, flags);
        
        return;
#else
            return;
#endif
        }

        //javadoc: ShapeTransformer::warpImage(transformingImage, output)
        public void warpImage (Mat transformingImage, Mat output)
        {
            ThrowIfDisposed ();
            if (transformingImage != null) transformingImage.ThrowIfDisposed ();
            if (output != null) output.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ShapeTransformer_warpImage_13(nativeObj, transformingImage.nativeObj, output.nativeObj);
        
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



        // C++:  float cv::ShapeTransformer::applyTransformation(Mat input, Mat& output = Mat())
        [DllImport (LIBNAME)]
        private static extern float shape_ShapeTransformer_applyTransformation_10 (IntPtr nativeObj, IntPtr input_nativeObj, IntPtr output_nativeObj);
        [DllImport (LIBNAME)]
        private static extern float shape_ShapeTransformer_applyTransformation_11 (IntPtr nativeObj, IntPtr input_nativeObj);

        // C++:  void cv::ShapeTransformer::estimateTransformation(Mat transformingShape, Mat targetShape, vector_DMatch matches)
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeTransformer_estimateTransformation_10 (IntPtr nativeObj, IntPtr transformingShape_nativeObj, IntPtr targetShape_nativeObj, IntPtr matches_mat_nativeObj);

        // C++:  void cv::ShapeTransformer::warpImage(Mat transformingImage, Mat& output, int flags = INTER_LINEAR, int borderMode = BORDER_CONSTANT, Scalar borderValue = Scalar())
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeTransformer_warpImage_10 (IntPtr nativeObj, IntPtr transformingImage_nativeObj, IntPtr output_nativeObj, int flags, int borderMode, double borderValue_val0, double borderValue_val1, double borderValue_val2, double borderValue_val3);
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeTransformer_warpImage_11 (IntPtr nativeObj, IntPtr transformingImage_nativeObj, IntPtr output_nativeObj, int flags, int borderMode);
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeTransformer_warpImage_12 (IntPtr nativeObj, IntPtr transformingImage_nativeObj, IntPtr output_nativeObj, int flags);
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeTransformer_warpImage_13 (IntPtr nativeObj, IntPtr transformingImage_nativeObj, IntPtr output_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeTransformer_delete (IntPtr nativeObj);

    }
}
