
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class Fuzzy
    //javadoc: Fuzzy

    public class Fuzzy
    {

        public const int LINEAR = 1;
        public const int SINUS = 2;
        public const int ONE_STEP = 1;
        public const int MULTI_STEP = 2;
        public const int ITERATIVE = 3;
        //
        // C++:  int cv::ft::FT02D_iteration(Mat matrix, Mat kernel, Mat& output, Mat mask, Mat& maskOutput, bool firstStop)
        //

        //javadoc: FT02D_iteration(matrix, kernel, output, mask, maskOutput, firstStop)
        public static int FT02D_iteration (Mat matrix, Mat kernel, Mat output, Mat mask, Mat maskOutput, bool firstStop)
        {
            if (matrix != null) matrix.ThrowIfDisposed ();
            if (kernel != null) kernel.ThrowIfDisposed ();
            if (output != null) output.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
            if (maskOutput != null) maskOutput.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = fuzzy_Fuzzy_FT02D_1iteration_10(matrix.nativeObj, kernel.nativeObj, output.nativeObj, mask.nativeObj, maskOutput.nativeObj, firstStop);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::ft::FT02D_FL_process(Mat matrix, int radius, Mat& output)
        //

        //javadoc: FT02D_FL_process(matrix, radius, output)
        public static void FT02D_FL_process (Mat matrix, int radius, Mat output)
        {
            if (matrix != null) matrix.ThrowIfDisposed ();
            if (output != null) output.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_FT02D_1FL_1process_10(matrix.nativeObj, radius, output.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ft::FT02D_FL_process_float(Mat matrix, int radius, Mat& output)
        //

        //javadoc: FT02D_FL_process_float(matrix, radius, output)
        public static void FT02D_FL_process_float (Mat matrix, int radius, Mat output)
        {
            if (matrix != null) matrix.ThrowIfDisposed ();
            if (output != null) output.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_FT02D_1FL_1process_1float_10(matrix.nativeObj, radius, output.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ft::FT02D_components(Mat matrix, Mat kernel, Mat& components, Mat mask = Mat())
        //

        //javadoc: FT02D_components(matrix, kernel, components, mask)
        public static void FT02D_components (Mat matrix, Mat kernel, Mat components, Mat mask)
        {
            if (matrix != null) matrix.ThrowIfDisposed ();
            if (kernel != null) kernel.ThrowIfDisposed ();
            if (components != null) components.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_FT02D_1components_10(matrix.nativeObj, kernel.nativeObj, components.nativeObj, mask.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: FT02D_components(matrix, kernel, components)
        public static void FT02D_components (Mat matrix, Mat kernel, Mat components)
        {
            if (matrix != null) matrix.ThrowIfDisposed ();
            if (kernel != null) kernel.ThrowIfDisposed ();
            if (components != null) components.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_FT02D_1components_11(matrix.nativeObj, kernel.nativeObj, components.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ft::FT02D_inverseFT(Mat components, Mat kernel, Mat& output, int width, int height)
        //

        //javadoc: FT02D_inverseFT(components, kernel, output, width, height)
        public static void FT02D_inverseFT (Mat components, Mat kernel, Mat output, int width, int height)
        {
            if (components != null) components.ThrowIfDisposed ();
            if (kernel != null) kernel.ThrowIfDisposed ();
            if (output != null) output.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_FT02D_1inverseFT_10(components.nativeObj, kernel.nativeObj, output.nativeObj, width, height);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ft::FT02D_process(Mat matrix, Mat kernel, Mat& output, Mat mask = Mat())
        //

        //javadoc: FT02D_process(matrix, kernel, output, mask)
        public static void FT02D_process (Mat matrix, Mat kernel, Mat output, Mat mask)
        {
            if (matrix != null) matrix.ThrowIfDisposed ();
            if (kernel != null) kernel.ThrowIfDisposed ();
            if (output != null) output.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_FT02D_1process_10(matrix.nativeObj, kernel.nativeObj, output.nativeObj, mask.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: FT02D_process(matrix, kernel, output)
        public static void FT02D_process (Mat matrix, Mat kernel, Mat output)
        {
            if (matrix != null) matrix.ThrowIfDisposed ();
            if (kernel != null) kernel.ThrowIfDisposed ();
            if (output != null) output.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_FT02D_1process_11(matrix.nativeObj, kernel.nativeObj, output.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ft::FT12D_components(Mat matrix, Mat kernel, Mat& components)
        //

        //javadoc: FT12D_components(matrix, kernel, components)
        public static void FT12D_components (Mat matrix, Mat kernel, Mat components)
        {
            if (matrix != null) matrix.ThrowIfDisposed ();
            if (kernel != null) kernel.ThrowIfDisposed ();
            if (components != null) components.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_FT12D_1components_10(matrix.nativeObj, kernel.nativeObj, components.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ft::FT12D_createPolynomMatrixHorizontal(int radius, Mat& matrix, int chn)
        //

        //javadoc: FT12D_createPolynomMatrixHorizontal(radius, matrix, chn)
        public static void FT12D_createPolynomMatrixHorizontal (int radius, Mat matrix, int chn)
        {
            if (matrix != null) matrix.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_FT12D_1createPolynomMatrixHorizontal_10(radius, matrix.nativeObj, chn);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ft::FT12D_createPolynomMatrixVertical(int radius, Mat& matrix, int chn)
        //

        //javadoc: FT12D_createPolynomMatrixVertical(radius, matrix, chn)
        public static void FT12D_createPolynomMatrixVertical (int radius, Mat matrix, int chn)
        {
            if (matrix != null) matrix.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_FT12D_1createPolynomMatrixVertical_10(radius, matrix.nativeObj, chn);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ft::FT12D_inverseFT(Mat components, Mat kernel, Mat& output, int width, int height)
        //

        //javadoc: FT12D_inverseFT(components, kernel, output, width, height)
        public static void FT12D_inverseFT (Mat components, Mat kernel, Mat output, int width, int height)
        {
            if (components != null) components.ThrowIfDisposed ();
            if (kernel != null) kernel.ThrowIfDisposed ();
            if (output != null) output.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_FT12D_1inverseFT_10(components.nativeObj, kernel.nativeObj, output.nativeObj, width, height);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ft::FT12D_polynomial(Mat matrix, Mat kernel, Mat& c00, Mat& c10, Mat& c01, Mat& components, Mat mask = Mat())
        //

        //javadoc: FT12D_polynomial(matrix, kernel, c00, c10, c01, components, mask)
        public static void FT12D_polynomial (Mat matrix, Mat kernel, Mat c00, Mat c10, Mat c01, Mat components, Mat mask)
        {
            if (matrix != null) matrix.ThrowIfDisposed ();
            if (kernel != null) kernel.ThrowIfDisposed ();
            if (c00 != null) c00.ThrowIfDisposed ();
            if (c10 != null) c10.ThrowIfDisposed ();
            if (c01 != null) c01.ThrowIfDisposed ();
            if (components != null) components.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_FT12D_1polynomial_10(matrix.nativeObj, kernel.nativeObj, c00.nativeObj, c10.nativeObj, c01.nativeObj, components.nativeObj, mask.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: FT12D_polynomial(matrix, kernel, c00, c10, c01, components)
        public static void FT12D_polynomial (Mat matrix, Mat kernel, Mat c00, Mat c10, Mat c01, Mat components)
        {
            if (matrix != null) matrix.ThrowIfDisposed ();
            if (kernel != null) kernel.ThrowIfDisposed ();
            if (c00 != null) c00.ThrowIfDisposed ();
            if (c10 != null) c10.ThrowIfDisposed ();
            if (c01 != null) c01.ThrowIfDisposed ();
            if (components != null) components.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_FT12D_1polynomial_11(matrix.nativeObj, kernel.nativeObj, c00.nativeObj, c10.nativeObj, c01.nativeObj, components.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ft::FT12D_process(Mat matrix, Mat kernel, Mat& output, Mat mask = Mat())
        //

        //javadoc: FT12D_process(matrix, kernel, output, mask)
        public static void FT12D_process (Mat matrix, Mat kernel, Mat output, Mat mask)
        {
            if (matrix != null) matrix.ThrowIfDisposed ();
            if (kernel != null) kernel.ThrowIfDisposed ();
            if (output != null) output.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_FT12D_1process_10(matrix.nativeObj, kernel.nativeObj, output.nativeObj, mask.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: FT12D_process(matrix, kernel, output)
        public static void FT12D_process (Mat matrix, Mat kernel, Mat output)
        {
            if (matrix != null) matrix.ThrowIfDisposed ();
            if (kernel != null) kernel.ThrowIfDisposed ();
            if (output != null) output.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_FT12D_1process_11(matrix.nativeObj, kernel.nativeObj, output.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ft::createKernel(Mat A, Mat B, Mat& kernel, int chn)
        //

        //javadoc: createKernel1(A, B, kernel, chn)
        public static void createKernel1 (Mat A, Mat B, Mat kernel, int chn)
        {
            if (A != null) A.ThrowIfDisposed ();
            if (B != null) B.ThrowIfDisposed ();
            if (kernel != null) kernel.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_createKernel1_10(A.nativeObj, B.nativeObj, kernel.nativeObj, chn);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ft::createKernel(int function, int radius, Mat& kernel, int chn)
        //

        //javadoc: createKernel(function, radius, kernel, chn)
        public static void createKernel (int function, int radius, Mat kernel, int chn)
        {
            if (kernel != null) kernel.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_createKernel_10(function, radius, kernel.nativeObj, chn);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ft::filter(Mat image, Mat kernel, Mat& output)
        //

        //javadoc: filter(image, kernel, output)
        public static void filter (Mat image, Mat kernel, Mat output)
        {
            if (image != null) image.ThrowIfDisposed ();
            if (kernel != null) kernel.ThrowIfDisposed ();
            if (output != null) output.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_filter_10(image.nativeObj, kernel.nativeObj, output.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::ft::inpaint(Mat image, Mat mask, Mat& output, int radius, int function, int algorithm)
        //

        //javadoc: inpaint(image, mask, output, radius, function, algorithm)
        public static void inpaint (Mat image, Mat mask, Mat output, int radius, int function, int algorithm)
        {
            if (image != null) image.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
            if (output != null) output.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        fuzzy_Fuzzy_inpaint_10(image.nativeObj, mask.nativeObj, output.nativeObj, radius, function, algorithm);
        
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



        // C++:  int cv::ft::FT02D_iteration(Mat matrix, Mat kernel, Mat& output, Mat mask, Mat& maskOutput, bool firstStop)
        [DllImport (LIBNAME)]
        private static extern int fuzzy_Fuzzy_FT02D_1iteration_10 (IntPtr matrix_nativeObj, IntPtr kernel_nativeObj, IntPtr output_nativeObj, IntPtr mask_nativeObj, IntPtr maskOutput_nativeObj, bool firstStop);

        // C++:  void cv::ft::FT02D_FL_process(Mat matrix, int radius, Mat& output)
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_FT02D_1FL_1process_10 (IntPtr matrix_nativeObj, int radius, IntPtr output_nativeObj);

        // C++:  void cv::ft::FT02D_FL_process_float(Mat matrix, int radius, Mat& output)
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_FT02D_1FL_1process_1float_10 (IntPtr matrix_nativeObj, int radius, IntPtr output_nativeObj);

        // C++:  void cv::ft::FT02D_components(Mat matrix, Mat kernel, Mat& components, Mat mask = Mat())
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_FT02D_1components_10 (IntPtr matrix_nativeObj, IntPtr kernel_nativeObj, IntPtr components_nativeObj, IntPtr mask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_FT02D_1components_11 (IntPtr matrix_nativeObj, IntPtr kernel_nativeObj, IntPtr components_nativeObj);

        // C++:  void cv::ft::FT02D_inverseFT(Mat components, Mat kernel, Mat& output, int width, int height)
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_FT02D_1inverseFT_10 (IntPtr components_nativeObj, IntPtr kernel_nativeObj, IntPtr output_nativeObj, int width, int height);

        // C++:  void cv::ft::FT02D_process(Mat matrix, Mat kernel, Mat& output, Mat mask = Mat())
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_FT02D_1process_10 (IntPtr matrix_nativeObj, IntPtr kernel_nativeObj, IntPtr output_nativeObj, IntPtr mask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_FT02D_1process_11 (IntPtr matrix_nativeObj, IntPtr kernel_nativeObj, IntPtr output_nativeObj);

        // C++:  void cv::ft::FT12D_components(Mat matrix, Mat kernel, Mat& components)
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_FT12D_1components_10 (IntPtr matrix_nativeObj, IntPtr kernel_nativeObj, IntPtr components_nativeObj);

        // C++:  void cv::ft::FT12D_createPolynomMatrixHorizontal(int radius, Mat& matrix, int chn)
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_FT12D_1createPolynomMatrixHorizontal_10 (int radius, IntPtr matrix_nativeObj, int chn);

        // C++:  void cv::ft::FT12D_createPolynomMatrixVertical(int radius, Mat& matrix, int chn)
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_FT12D_1createPolynomMatrixVertical_10 (int radius, IntPtr matrix_nativeObj, int chn);

        // C++:  void cv::ft::FT12D_inverseFT(Mat components, Mat kernel, Mat& output, int width, int height)
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_FT12D_1inverseFT_10 (IntPtr components_nativeObj, IntPtr kernel_nativeObj, IntPtr output_nativeObj, int width, int height);

        // C++:  void cv::ft::FT12D_polynomial(Mat matrix, Mat kernel, Mat& c00, Mat& c10, Mat& c01, Mat& components, Mat mask = Mat())
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_FT12D_1polynomial_10 (IntPtr matrix_nativeObj, IntPtr kernel_nativeObj, IntPtr c00_nativeObj, IntPtr c10_nativeObj, IntPtr c01_nativeObj, IntPtr components_nativeObj, IntPtr mask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_FT12D_1polynomial_11 (IntPtr matrix_nativeObj, IntPtr kernel_nativeObj, IntPtr c00_nativeObj, IntPtr c10_nativeObj, IntPtr c01_nativeObj, IntPtr components_nativeObj);

        // C++:  void cv::ft::FT12D_process(Mat matrix, Mat kernel, Mat& output, Mat mask = Mat())
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_FT12D_1process_10 (IntPtr matrix_nativeObj, IntPtr kernel_nativeObj, IntPtr output_nativeObj, IntPtr mask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_FT12D_1process_11 (IntPtr matrix_nativeObj, IntPtr kernel_nativeObj, IntPtr output_nativeObj);

        // C++:  void cv::ft::createKernel(Mat A, Mat B, Mat& kernel, int chn)
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_createKernel1_10 (IntPtr A_nativeObj, IntPtr B_nativeObj, IntPtr kernel_nativeObj, int chn);

        // C++:  void cv::ft::createKernel(int function, int radius, Mat& kernel, int chn)
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_createKernel_10 (int function, int radius, IntPtr kernel_nativeObj, int chn);

        // C++:  void cv::ft::filter(Mat image, Mat kernel, Mat& output)
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_filter_10 (IntPtr image_nativeObj, IntPtr kernel_nativeObj, IntPtr output_nativeObj);

        // C++:  void cv::ft::inpaint(Mat image, Mat mask, Mat& output, int radius, int function, int algorithm)
        [DllImport (LIBNAME)]
        private static extern void fuzzy_Fuzzy_inpaint_10 (IntPtr image_nativeObj, IntPtr mask_nativeObj, IntPtr output_nativeObj, int radius, int function, int algorithm);

    }
}
