
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class Shape
    //javadoc: Shape

    public class Shape
    {

        //
        // C++:  Ptr_AffineTransformer cv::createAffineTransformer(bool fullAffine)
        //

        //javadoc: createAffineTransformer(fullAffine)
        public static AffineTransformer createAffineTransformer (bool fullAffine)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        AffineTransformer retVal = AffineTransformer.__fromPtr__(shape_Shape_createAffineTransformer_10(fullAffine));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_HausdorffDistanceExtractor cv::createHausdorffDistanceExtractor(int distanceFlag = cv::NORM_L2, float rankProp = 0.6f)
        //

        //javadoc: createHausdorffDistanceExtractor(distanceFlag, rankProp)
        public static HausdorffDistanceExtractor createHausdorffDistanceExtractor (int distanceFlag, float rankProp)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HausdorffDistanceExtractor retVal = HausdorffDistanceExtractor.__fromPtr__(shape_Shape_createHausdorffDistanceExtractor_10(distanceFlag, rankProp));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createHausdorffDistanceExtractor(distanceFlag)
        public static HausdorffDistanceExtractor createHausdorffDistanceExtractor (int distanceFlag)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HausdorffDistanceExtractor retVal = HausdorffDistanceExtractor.__fromPtr__(shape_Shape_createHausdorffDistanceExtractor_11(distanceFlag));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createHausdorffDistanceExtractor()
        public static HausdorffDistanceExtractor createHausdorffDistanceExtractor ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HausdorffDistanceExtractor retVal = HausdorffDistanceExtractor.__fromPtr__(shape_Shape_createHausdorffDistanceExtractor_12());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_HistogramCostExtractor cv::createChiHistogramCostExtractor(int nDummies = 25, float defaultCost = 0.2f)
        //

        //javadoc: createChiHistogramCostExtractor(nDummies, defaultCost)
        public static HistogramCostExtractor createChiHistogramCostExtractor (int nDummies, float defaultCost)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = HistogramCostExtractor.__fromPtr__(shape_Shape_createChiHistogramCostExtractor_10(nDummies, defaultCost));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createChiHistogramCostExtractor(nDummies)
        public static HistogramCostExtractor createChiHistogramCostExtractor (int nDummies)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = HistogramCostExtractor.__fromPtr__(shape_Shape_createChiHistogramCostExtractor_11(nDummies));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createChiHistogramCostExtractor()
        public static HistogramCostExtractor createChiHistogramCostExtractor ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = HistogramCostExtractor.__fromPtr__(shape_Shape_createChiHistogramCostExtractor_12());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_HistogramCostExtractor cv::createEMDHistogramCostExtractor(int flag = DIST_L2, int nDummies = 25, float defaultCost = 0.2f)
        //

        //javadoc: createEMDHistogramCostExtractor(flag, nDummies, defaultCost)
        public static HistogramCostExtractor createEMDHistogramCostExtractor (int flag, int nDummies, float defaultCost)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = HistogramCostExtractor.__fromPtr__(shape_Shape_createEMDHistogramCostExtractor_10(flag, nDummies, defaultCost));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createEMDHistogramCostExtractor(flag, nDummies)
        public static HistogramCostExtractor createEMDHistogramCostExtractor (int flag, int nDummies)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = HistogramCostExtractor.__fromPtr__(shape_Shape_createEMDHistogramCostExtractor_11(flag, nDummies));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createEMDHistogramCostExtractor(flag)
        public static HistogramCostExtractor createEMDHistogramCostExtractor (int flag)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = HistogramCostExtractor.__fromPtr__(shape_Shape_createEMDHistogramCostExtractor_12(flag));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createEMDHistogramCostExtractor()
        public static HistogramCostExtractor createEMDHistogramCostExtractor ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = HistogramCostExtractor.__fromPtr__(shape_Shape_createEMDHistogramCostExtractor_13());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_HistogramCostExtractor cv::createEMDL1HistogramCostExtractor(int nDummies = 25, float defaultCost = 0.2f)
        //

        //javadoc: createEMDL1HistogramCostExtractor(nDummies, defaultCost)
        public static HistogramCostExtractor createEMDL1HistogramCostExtractor (int nDummies, float defaultCost)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = HistogramCostExtractor.__fromPtr__(shape_Shape_createEMDL1HistogramCostExtractor_10(nDummies, defaultCost));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createEMDL1HistogramCostExtractor(nDummies)
        public static HistogramCostExtractor createEMDL1HistogramCostExtractor (int nDummies)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = HistogramCostExtractor.__fromPtr__(shape_Shape_createEMDL1HistogramCostExtractor_11(nDummies));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createEMDL1HistogramCostExtractor()
        public static HistogramCostExtractor createEMDL1HistogramCostExtractor ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = HistogramCostExtractor.__fromPtr__(shape_Shape_createEMDL1HistogramCostExtractor_12());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_HistogramCostExtractor cv::createNormHistogramCostExtractor(int flag = DIST_L2, int nDummies = 25, float defaultCost = 0.2f)
        //

        //javadoc: createNormHistogramCostExtractor(flag, nDummies, defaultCost)
        public static HistogramCostExtractor createNormHistogramCostExtractor (int flag, int nDummies, float defaultCost)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = HistogramCostExtractor.__fromPtr__(shape_Shape_createNormHistogramCostExtractor_10(flag, nDummies, defaultCost));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createNormHistogramCostExtractor(flag, nDummies)
        public static HistogramCostExtractor createNormHistogramCostExtractor (int flag, int nDummies)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = HistogramCostExtractor.__fromPtr__(shape_Shape_createNormHistogramCostExtractor_11(flag, nDummies));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createNormHistogramCostExtractor(flag)
        public static HistogramCostExtractor createNormHistogramCostExtractor (int flag)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = HistogramCostExtractor.__fromPtr__(shape_Shape_createNormHistogramCostExtractor_12(flag));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createNormHistogramCostExtractor()
        public static HistogramCostExtractor createNormHistogramCostExtractor ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = HistogramCostExtractor.__fromPtr__(shape_Shape_createNormHistogramCostExtractor_13());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_ShapeContextDistanceExtractor cv::createShapeContextDistanceExtractor(int nAngularBins = 12, int nRadialBins = 4, float innerRadius = 0.2f, float outerRadius = 2, int iterations = 3, Ptr_HistogramCostExtractor comparer = createChiHistogramCostExtractor(), Ptr_ShapeTransformer transformer = createThinPlateSplineShapeTransformer())
        //

        //javadoc: createShapeContextDistanceExtractor(nAngularBins, nRadialBins, innerRadius, outerRadius, iterations, comparer, transformer)
        public static ShapeContextDistanceExtractor createShapeContextDistanceExtractor (int nAngularBins, int nRadialBins, float innerRadius, float outerRadius, int iterations, HistogramCostExtractor comparer, ShapeTransformer transformer)
        {
            if (comparer != null) comparer.ThrowIfDisposed ();
            if (transformer != null) transformer.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ShapeContextDistanceExtractor retVal = ShapeContextDistanceExtractor.__fromPtr__(shape_Shape_createShapeContextDistanceExtractor_10(nAngularBins, nRadialBins, innerRadius, outerRadius, iterations, comparer.getNativeObjAddr(), transformer.getNativeObjAddr()));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createShapeContextDistanceExtractor(nAngularBins, nRadialBins, innerRadius, outerRadius, iterations, comparer)
        public static ShapeContextDistanceExtractor createShapeContextDistanceExtractor (int nAngularBins, int nRadialBins, float innerRadius, float outerRadius, int iterations, HistogramCostExtractor comparer)
        {
            if (comparer != null) comparer.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ShapeContextDistanceExtractor retVal = ShapeContextDistanceExtractor.__fromPtr__(shape_Shape_createShapeContextDistanceExtractor_11(nAngularBins, nRadialBins, innerRadius, outerRadius, iterations, comparer.getNativeObjAddr()));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createShapeContextDistanceExtractor(nAngularBins, nRadialBins, innerRadius, outerRadius, iterations)
        public static ShapeContextDistanceExtractor createShapeContextDistanceExtractor (int nAngularBins, int nRadialBins, float innerRadius, float outerRadius, int iterations)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ShapeContextDistanceExtractor retVal = ShapeContextDistanceExtractor.__fromPtr__(shape_Shape_createShapeContextDistanceExtractor_12(nAngularBins, nRadialBins, innerRadius, outerRadius, iterations));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createShapeContextDistanceExtractor(nAngularBins, nRadialBins, innerRadius, outerRadius)
        public static ShapeContextDistanceExtractor createShapeContextDistanceExtractor (int nAngularBins, int nRadialBins, float innerRadius, float outerRadius)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ShapeContextDistanceExtractor retVal = ShapeContextDistanceExtractor.__fromPtr__(shape_Shape_createShapeContextDistanceExtractor_13(nAngularBins, nRadialBins, innerRadius, outerRadius));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createShapeContextDistanceExtractor(nAngularBins, nRadialBins, innerRadius)
        public static ShapeContextDistanceExtractor createShapeContextDistanceExtractor (int nAngularBins, int nRadialBins, float innerRadius)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ShapeContextDistanceExtractor retVal = ShapeContextDistanceExtractor.__fromPtr__(shape_Shape_createShapeContextDistanceExtractor_14(nAngularBins, nRadialBins, innerRadius));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createShapeContextDistanceExtractor(nAngularBins, nRadialBins)
        public static ShapeContextDistanceExtractor createShapeContextDistanceExtractor (int nAngularBins, int nRadialBins)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ShapeContextDistanceExtractor retVal = ShapeContextDistanceExtractor.__fromPtr__(shape_Shape_createShapeContextDistanceExtractor_15(nAngularBins, nRadialBins));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createShapeContextDistanceExtractor(nAngularBins)
        public static ShapeContextDistanceExtractor createShapeContextDistanceExtractor (int nAngularBins)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ShapeContextDistanceExtractor retVal = ShapeContextDistanceExtractor.__fromPtr__(shape_Shape_createShapeContextDistanceExtractor_16(nAngularBins));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createShapeContextDistanceExtractor()
        public static ShapeContextDistanceExtractor createShapeContextDistanceExtractor ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ShapeContextDistanceExtractor retVal = ShapeContextDistanceExtractor.__fromPtr__(shape_Shape_createShapeContextDistanceExtractor_17());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_ThinPlateSplineShapeTransformer cv::createThinPlateSplineShapeTransformer(double regularizationParameter = 0)
        //

        //javadoc: createThinPlateSplineShapeTransformer(regularizationParameter)
        public static ThinPlateSplineShapeTransformer createThinPlateSplineShapeTransformer (double regularizationParameter)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ThinPlateSplineShapeTransformer retVal = ThinPlateSplineShapeTransformer.__fromPtr__(shape_Shape_createThinPlateSplineShapeTransformer_10(regularizationParameter));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createThinPlateSplineShapeTransformer()
        public static ThinPlateSplineShapeTransformer createThinPlateSplineShapeTransformer ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ThinPlateSplineShapeTransformer retVal = ThinPlateSplineShapeTransformer.__fromPtr__(shape_Shape_createThinPlateSplineShapeTransformer_11());
        
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



        // C++:  Ptr_AffineTransformer cv::createAffineTransformer(bool fullAffine)
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createAffineTransformer_10 (bool fullAffine);

        // C++:  Ptr_HausdorffDistanceExtractor cv::createHausdorffDistanceExtractor(int distanceFlag = cv::NORM_L2, float rankProp = 0.6f)
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createHausdorffDistanceExtractor_10 (int distanceFlag, float rankProp);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createHausdorffDistanceExtractor_11 (int distanceFlag);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createHausdorffDistanceExtractor_12 ();

        // C++:  Ptr_HistogramCostExtractor cv::createChiHistogramCostExtractor(int nDummies = 25, float defaultCost = 0.2f)
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createChiHistogramCostExtractor_10 (int nDummies, float defaultCost);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createChiHistogramCostExtractor_11 (int nDummies);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createChiHistogramCostExtractor_12 ();

        // C++:  Ptr_HistogramCostExtractor cv::createEMDHistogramCostExtractor(int flag = DIST_L2, int nDummies = 25, float defaultCost = 0.2f)
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createEMDHistogramCostExtractor_10 (int flag, int nDummies, float defaultCost);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createEMDHistogramCostExtractor_11 (int flag, int nDummies);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createEMDHistogramCostExtractor_12 (int flag);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createEMDHistogramCostExtractor_13 ();

        // C++:  Ptr_HistogramCostExtractor cv::createEMDL1HistogramCostExtractor(int nDummies = 25, float defaultCost = 0.2f)
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createEMDL1HistogramCostExtractor_10 (int nDummies, float defaultCost);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createEMDL1HistogramCostExtractor_11 (int nDummies);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createEMDL1HistogramCostExtractor_12 ();

        // C++:  Ptr_HistogramCostExtractor cv::createNormHistogramCostExtractor(int flag = DIST_L2, int nDummies = 25, float defaultCost = 0.2f)
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createNormHistogramCostExtractor_10 (int flag, int nDummies, float defaultCost);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createNormHistogramCostExtractor_11 (int flag, int nDummies);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createNormHistogramCostExtractor_12 (int flag);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createNormHistogramCostExtractor_13 ();

        // C++:  Ptr_ShapeContextDistanceExtractor cv::createShapeContextDistanceExtractor(int nAngularBins = 12, int nRadialBins = 4, float innerRadius = 0.2f, float outerRadius = 2, int iterations = 3, Ptr_HistogramCostExtractor comparer = createChiHistogramCostExtractor(), Ptr_ShapeTransformer transformer = createThinPlateSplineShapeTransformer())
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createShapeContextDistanceExtractor_10 (int nAngularBins, int nRadialBins, float innerRadius, float outerRadius, int iterations, IntPtr comparer_nativeObj, IntPtr transformer_nativeObj);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createShapeContextDistanceExtractor_11 (int nAngularBins, int nRadialBins, float innerRadius, float outerRadius, int iterations, IntPtr comparer_nativeObj);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createShapeContextDistanceExtractor_12 (int nAngularBins, int nRadialBins, float innerRadius, float outerRadius, int iterations);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createShapeContextDistanceExtractor_13 (int nAngularBins, int nRadialBins, float innerRadius, float outerRadius);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createShapeContextDistanceExtractor_14 (int nAngularBins, int nRadialBins, float innerRadius);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createShapeContextDistanceExtractor_15 (int nAngularBins, int nRadialBins);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createShapeContextDistanceExtractor_16 (int nAngularBins);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createShapeContextDistanceExtractor_17 ();

        // C++:  Ptr_ThinPlateSplineShapeTransformer cv::createThinPlateSplineShapeTransformer(double regularizationParameter = 0)
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createThinPlateSplineShapeTransformer_10 (double regularizationParameter);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createThinPlateSplineShapeTransformer_11 ();

    }
}
