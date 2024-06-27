
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class Ccalib
    //javadoc: Ccalib

    public class Ccalib
    {

        public const int CALIB_USE_GUESS = 1;
        public const int CALIB_FIX_SKEW = 2;
        public const int CALIB_FIX_K1 = 4;
        public const int CALIB_FIX_K2 = 8;
        public const int CALIB_FIX_P1 = 16;
        public const int CALIB_FIX_P2 = 32;
        public const int CALIB_FIX_XI = 64;
        public const int CALIB_FIX_GAMMA = 128;
        public const int CALIB_FIX_CENTER = 256;
        public const int RECTIFY_PERSPECTIVE = 1;
        public const int RECTIFY_CYLINDRICAL = 2;
        public const int RECTIFY_LONGLATI = 3;
        public const int RECTIFY_STEREOGRAPHIC = 4;
        public const int XYZRGB = 1;
        public const int XYZ = 2;
        //
        // C++:  double cv::omnidir::calibrate(vector_Mat objectPoints, vector_Mat imagePoints, Size size, Mat& K, Mat& xi, Mat& D, vector_Mat& rvecs, vector_Mat& tvecs, int flags, TermCriteria criteria, Mat& idx = Mat())
        //

        //javadoc: calibrate(objectPoints, imagePoints, size, K, xi, D, rvecs, tvecs, flags, criteria, idx)
        public static double calibrate (List<Mat> objectPoints, List<Mat> imagePoints, Size size, Mat K, Mat xi, Mat D, List<Mat> rvecs, List<Mat> tvecs, int flags, TermCriteria criteria, Mat idx)
        {
            if (K != null) K.ThrowIfDisposed ();
            if (xi != null) xi.ThrowIfDisposed ();
            if (D != null) D.ThrowIfDisposed ();
            if (idx != null) idx.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = ccalib_Ccalib_calibrate_10(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, size.width, size.height, K.nativeObj, xi.nativeObj, D.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon, idx.nativeObj);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: calibrate(objectPoints, imagePoints, size, K, xi, D, rvecs, tvecs, flags, criteria)
        public static double calibrate (List<Mat> objectPoints, List<Mat> imagePoints, Size size, Mat K, Mat xi, Mat D, List<Mat> rvecs, List<Mat> tvecs, int flags, TermCriteria criteria)
        {
            if (K != null) K.ThrowIfDisposed ();
            if (xi != null) xi.ThrowIfDisposed ();
            if (D != null) D.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
        Mat rvecs_mat = new Mat();
        Mat tvecs_mat = new Mat();
        double retVal = ccalib_Ccalib_calibrate_11(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, size.width, size.height, K.nativeObj, xi.nativeObj, D.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
        Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
        rvecs_mat.release();
        Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
        tvecs_mat.release();
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::omnidir::stereoCalibrate(vector_Mat& objectPoints, vector_Mat& imagePoints1, vector_Mat& imagePoints2, Size imageSize1, Size imageSize2, Mat& K1, Mat& xi1, Mat& D1, Mat& K2, Mat& xi2, Mat& D2, Mat& rvec, Mat& tvec, vector_Mat& rvecsL, vector_Mat& tvecsL, int flags, TermCriteria criteria, Mat& idx = Mat())
        //

        //javadoc: stereoCalibrate(objectPoints, imagePoints1, imagePoints2, imageSize1, imageSize2, K1, xi1, D1, K2, xi2, D2, rvec, tvec, rvecsL, tvecsL, flags, criteria, idx)
        public static double stereoCalibrate (List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Size imageSize1, Size imageSize2, Mat K1, Mat xi1, Mat D1, Mat K2, Mat xi2, Mat D2, Mat rvec, Mat tvec, List<Mat> rvecsL, List<Mat> tvecsL, int flags, TermCriteria criteria, Mat idx)
        {
            if (K1 != null) K1.ThrowIfDisposed ();
            if (xi1 != null) xi1.ThrowIfDisposed ();
            if (D1 != null) D1.ThrowIfDisposed ();
            if (K2 != null) K2.ThrowIfDisposed ();
            if (xi2 != null) xi2.ThrowIfDisposed ();
            if (D2 != null) D2.ThrowIfDisposed ();
            if (rvec != null) rvec.ThrowIfDisposed ();
            if (tvec != null) tvec.ThrowIfDisposed ();
            if (idx != null) idx.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
        Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
        Mat rvecsL_mat = new Mat();
        Mat tvecsL_mat = new Mat();
        double retVal = ccalib_Ccalib_stereoCalibrate_10(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, imageSize1.width, imageSize1.height, imageSize2.width, imageSize2.height, K1.nativeObj, xi1.nativeObj, D1.nativeObj, K2.nativeObj, xi2.nativeObj, D2.nativeObj, rvec.nativeObj, tvec.nativeObj, rvecsL_mat.nativeObj, tvecsL_mat.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon, idx.nativeObj);
        Converters.Mat_to_vector_Mat(objectPoints_mat, objectPoints);
        objectPoints_mat.release();
        Converters.Mat_to_vector_Mat(imagePoints1_mat, imagePoints1);
        imagePoints1_mat.release();
        Converters.Mat_to_vector_Mat(imagePoints2_mat, imagePoints2);
        imagePoints2_mat.release();
        Converters.Mat_to_vector_Mat(rvecsL_mat, rvecsL);
        rvecsL_mat.release();
        Converters.Mat_to_vector_Mat(tvecsL_mat, tvecsL);
        tvecsL_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: stereoCalibrate(objectPoints, imagePoints1, imagePoints2, imageSize1, imageSize2, K1, xi1, D1, K2, xi2, D2, rvec, tvec, rvecsL, tvecsL, flags, criteria)
        public static double stereoCalibrate (List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Size imageSize1, Size imageSize2, Mat K1, Mat xi1, Mat D1, Mat K2, Mat xi2, Mat D2, Mat rvec, Mat tvec, List<Mat> rvecsL, List<Mat> tvecsL, int flags, TermCriteria criteria)
        {
            if (K1 != null) K1.ThrowIfDisposed ();
            if (xi1 != null) xi1.ThrowIfDisposed ();
            if (D1 != null) D1.ThrowIfDisposed ();
            if (K2 != null) K2.ThrowIfDisposed ();
            if (xi2 != null) xi2.ThrowIfDisposed ();
            if (D2 != null) D2.ThrowIfDisposed ();
            if (rvec != null) rvec.ThrowIfDisposed ();
            if (tvec != null) tvec.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
        Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
        Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
        Mat rvecsL_mat = new Mat();
        Mat tvecsL_mat = new Mat();
        double retVal = ccalib_Ccalib_stereoCalibrate_11(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, imageSize1.width, imageSize1.height, imageSize2.width, imageSize2.height, K1.nativeObj, xi1.nativeObj, D1.nativeObj, K2.nativeObj, xi2.nativeObj, D2.nativeObj, rvec.nativeObj, tvec.nativeObj, rvecsL_mat.nativeObj, tvecsL_mat.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
        Converters.Mat_to_vector_Mat(objectPoints_mat, objectPoints);
        objectPoints_mat.release();
        Converters.Mat_to_vector_Mat(imagePoints1_mat, imagePoints1);
        imagePoints1_mat.release();
        Converters.Mat_to_vector_Mat(imagePoints2_mat, imagePoints2);
        imagePoints2_mat.release();
        Converters.Mat_to_vector_Mat(rvecsL_mat, rvecsL);
        rvecsL_mat.release();
        Converters.Mat_to_vector_Mat(tvecsL_mat, tvecsL);
        tvecsL_mat.release();
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::omnidir::initUndistortRectifyMap(Mat K, Mat D, Mat xi, Mat R, Mat P, Size size, int mltype, Mat& map1, Mat& map2, int flags)
        //

        //javadoc: initUndistortRectifyMap(K, D, xi, R, P, size, mltype, map1, map2, flags)
        public static void initUndistortRectifyMap (Mat K, Mat D, Mat xi, Mat R, Mat P, Size size, int mltype, Mat map1, Mat map2, int flags)
        {
            if (K != null) K.ThrowIfDisposed ();
            if (D != null) D.ThrowIfDisposed ();
            if (xi != null) xi.ThrowIfDisposed ();
            if (R != null) R.ThrowIfDisposed ();
            if (P != null) P.ThrowIfDisposed ();
            if (map1 != null) map1.ThrowIfDisposed ();
            if (map2 != null) map2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ccalib_Ccalib_initUndistortRectifyMap_10(K.nativeObj, D.nativeObj, xi.nativeObj, R.nativeObj, P.nativeObj, size.width, size.height, mltype, map1.nativeObj, map2.nativeObj, flags);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::omnidir::projectPoints(vector_Point3f objectPoints, vector_Point2f& imagePoints, Mat rvec, Mat tvec, Mat K, double xi, Mat D, Mat& jacobian = Mat())
        //

        //javadoc: projectPoints(objectPoints, imagePoints, rvec, tvec, K, xi, D, jacobian)
        public static void projectPoints (MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat rvec, Mat tvec, Mat K, double xi, Mat D, Mat jacobian)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed ();
            if (imagePoints != null) imagePoints.ThrowIfDisposed ();
            if (rvec != null) rvec.ThrowIfDisposed ();
            if (tvec != null) tvec.ThrowIfDisposed ();
            if (K != null) K.ThrowIfDisposed ();
            if (D != null) D.ThrowIfDisposed ();
            if (jacobian != null) jacobian.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = objectPoints;
        Mat imagePoints_mat = imagePoints;
        ccalib_Ccalib_projectPoints_10(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, K.nativeObj, xi, D.nativeObj, jacobian.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: projectPoints(objectPoints, imagePoints, rvec, tvec, K, xi, D)
        public static void projectPoints (MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat rvec, Mat tvec, Mat K, double xi, Mat D)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed ();
            if (imagePoints != null) imagePoints.ThrowIfDisposed ();
            if (rvec != null) rvec.ThrowIfDisposed ();
            if (tvec != null) tvec.ThrowIfDisposed ();
            if (K != null) K.ThrowIfDisposed ();
            if (D != null) D.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat objectPoints_mat = objectPoints;
        Mat imagePoints_mat = imagePoints;
        ccalib_Ccalib_projectPoints_11(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, K.nativeObj, xi, D.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::omnidir::stereoReconstruct(Mat image1, Mat image2, Mat K1, Mat D1, Mat xi1, Mat K2, Mat D2, Mat xi2, Mat R, Mat T, int flag, int numDisparities, int SADWindowSize, Mat& disparity, Mat& image1Rec, Mat& image2Rec, Size newSize = Size(), Mat Knew = cv::Mat(), Mat& pointCloud = cv::Mat(), int pointType = XYZRGB)
        //

        //javadoc: stereoReconstruct(image1, image2, K1, D1, xi1, K2, D2, xi2, R, T, flag, numDisparities, SADWindowSize, disparity, image1Rec, image2Rec, newSize, Knew, pointCloud, pointType)
        public static void stereoReconstruct (Mat image1, Mat image2, Mat K1, Mat D1, Mat xi1, Mat K2, Mat D2, Mat xi2, Mat R, Mat T, int flag, int numDisparities, int SADWindowSize, Mat disparity, Mat image1Rec, Mat image2Rec, Size newSize, Mat Knew, Mat pointCloud, int pointType)
        {
            if (image1 != null) image1.ThrowIfDisposed ();
            if (image2 != null) image2.ThrowIfDisposed ();
            if (K1 != null) K1.ThrowIfDisposed ();
            if (D1 != null) D1.ThrowIfDisposed ();
            if (xi1 != null) xi1.ThrowIfDisposed ();
            if (K2 != null) K2.ThrowIfDisposed ();
            if (D2 != null) D2.ThrowIfDisposed ();
            if (xi2 != null) xi2.ThrowIfDisposed ();
            if (R != null) R.ThrowIfDisposed ();
            if (T != null) T.ThrowIfDisposed ();
            if (disparity != null) disparity.ThrowIfDisposed ();
            if (image1Rec != null) image1Rec.ThrowIfDisposed ();
            if (image2Rec != null) image2Rec.ThrowIfDisposed ();
            if (Knew != null) Knew.ThrowIfDisposed ();
            if (pointCloud != null) pointCloud.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ccalib_Ccalib_stereoReconstruct_10(image1.nativeObj, image2.nativeObj, K1.nativeObj, D1.nativeObj, xi1.nativeObj, K2.nativeObj, D2.nativeObj, xi2.nativeObj, R.nativeObj, T.nativeObj, flag, numDisparities, SADWindowSize, disparity.nativeObj, image1Rec.nativeObj, image2Rec.nativeObj, newSize.width, newSize.height, Knew.nativeObj, pointCloud.nativeObj, pointType);
        
        return;
#else
            return;
#endif
        }

        //javadoc: stereoReconstruct(image1, image2, K1, D1, xi1, K2, D2, xi2, R, T, flag, numDisparities, SADWindowSize, disparity, image1Rec, image2Rec, newSize, Knew, pointCloud)
        public static void stereoReconstruct (Mat image1, Mat image2, Mat K1, Mat D1, Mat xi1, Mat K2, Mat D2, Mat xi2, Mat R, Mat T, int flag, int numDisparities, int SADWindowSize, Mat disparity, Mat image1Rec, Mat image2Rec, Size newSize, Mat Knew, Mat pointCloud)
        {
            if (image1 != null) image1.ThrowIfDisposed ();
            if (image2 != null) image2.ThrowIfDisposed ();
            if (K1 != null) K1.ThrowIfDisposed ();
            if (D1 != null) D1.ThrowIfDisposed ();
            if (xi1 != null) xi1.ThrowIfDisposed ();
            if (K2 != null) K2.ThrowIfDisposed ();
            if (D2 != null) D2.ThrowIfDisposed ();
            if (xi2 != null) xi2.ThrowIfDisposed ();
            if (R != null) R.ThrowIfDisposed ();
            if (T != null) T.ThrowIfDisposed ();
            if (disparity != null) disparity.ThrowIfDisposed ();
            if (image1Rec != null) image1Rec.ThrowIfDisposed ();
            if (image2Rec != null) image2Rec.ThrowIfDisposed ();
            if (Knew != null) Knew.ThrowIfDisposed ();
            if (pointCloud != null) pointCloud.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ccalib_Ccalib_stereoReconstruct_11(image1.nativeObj, image2.nativeObj, K1.nativeObj, D1.nativeObj, xi1.nativeObj, K2.nativeObj, D2.nativeObj, xi2.nativeObj, R.nativeObj, T.nativeObj, flag, numDisparities, SADWindowSize, disparity.nativeObj, image1Rec.nativeObj, image2Rec.nativeObj, newSize.width, newSize.height, Knew.nativeObj, pointCloud.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: stereoReconstruct(image1, image2, K1, D1, xi1, K2, D2, xi2, R, T, flag, numDisparities, SADWindowSize, disparity, image1Rec, image2Rec, newSize, Knew)
        public static void stereoReconstruct (Mat image1, Mat image2, Mat K1, Mat D1, Mat xi1, Mat K2, Mat D2, Mat xi2, Mat R, Mat T, int flag, int numDisparities, int SADWindowSize, Mat disparity, Mat image1Rec, Mat image2Rec, Size newSize, Mat Knew)
        {
            if (image1 != null) image1.ThrowIfDisposed ();
            if (image2 != null) image2.ThrowIfDisposed ();
            if (K1 != null) K1.ThrowIfDisposed ();
            if (D1 != null) D1.ThrowIfDisposed ();
            if (xi1 != null) xi1.ThrowIfDisposed ();
            if (K2 != null) K2.ThrowIfDisposed ();
            if (D2 != null) D2.ThrowIfDisposed ();
            if (xi2 != null) xi2.ThrowIfDisposed ();
            if (R != null) R.ThrowIfDisposed ();
            if (T != null) T.ThrowIfDisposed ();
            if (disparity != null) disparity.ThrowIfDisposed ();
            if (image1Rec != null) image1Rec.ThrowIfDisposed ();
            if (image2Rec != null) image2Rec.ThrowIfDisposed ();
            if (Knew != null) Knew.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ccalib_Ccalib_stereoReconstruct_12(image1.nativeObj, image2.nativeObj, K1.nativeObj, D1.nativeObj, xi1.nativeObj, K2.nativeObj, D2.nativeObj, xi2.nativeObj, R.nativeObj, T.nativeObj, flag, numDisparities, SADWindowSize, disparity.nativeObj, image1Rec.nativeObj, image2Rec.nativeObj, newSize.width, newSize.height, Knew.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: stereoReconstruct(image1, image2, K1, D1, xi1, K2, D2, xi2, R, T, flag, numDisparities, SADWindowSize, disparity, image1Rec, image2Rec, newSize)
        public static void stereoReconstruct (Mat image1, Mat image2, Mat K1, Mat D1, Mat xi1, Mat K2, Mat D2, Mat xi2, Mat R, Mat T, int flag, int numDisparities, int SADWindowSize, Mat disparity, Mat image1Rec, Mat image2Rec, Size newSize)
        {
            if (image1 != null) image1.ThrowIfDisposed ();
            if (image2 != null) image2.ThrowIfDisposed ();
            if (K1 != null) K1.ThrowIfDisposed ();
            if (D1 != null) D1.ThrowIfDisposed ();
            if (xi1 != null) xi1.ThrowIfDisposed ();
            if (K2 != null) K2.ThrowIfDisposed ();
            if (D2 != null) D2.ThrowIfDisposed ();
            if (xi2 != null) xi2.ThrowIfDisposed ();
            if (R != null) R.ThrowIfDisposed ();
            if (T != null) T.ThrowIfDisposed ();
            if (disparity != null) disparity.ThrowIfDisposed ();
            if (image1Rec != null) image1Rec.ThrowIfDisposed ();
            if (image2Rec != null) image2Rec.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ccalib_Ccalib_stereoReconstruct_13(image1.nativeObj, image2.nativeObj, K1.nativeObj, D1.nativeObj, xi1.nativeObj, K2.nativeObj, D2.nativeObj, xi2.nativeObj, R.nativeObj, T.nativeObj, flag, numDisparities, SADWindowSize, disparity.nativeObj, image1Rec.nativeObj, image2Rec.nativeObj, newSize.width, newSize.height);
        
        return;
#else
            return;
#endif
        }

        //javadoc: stereoReconstruct(image1, image2, K1, D1, xi1, K2, D2, xi2, R, T, flag, numDisparities, SADWindowSize, disparity, image1Rec, image2Rec)
        public static void stereoReconstruct (Mat image1, Mat image2, Mat K1, Mat D1, Mat xi1, Mat K2, Mat D2, Mat xi2, Mat R, Mat T, int flag, int numDisparities, int SADWindowSize, Mat disparity, Mat image1Rec, Mat image2Rec)
        {
            if (image1 != null) image1.ThrowIfDisposed ();
            if (image2 != null) image2.ThrowIfDisposed ();
            if (K1 != null) K1.ThrowIfDisposed ();
            if (D1 != null) D1.ThrowIfDisposed ();
            if (xi1 != null) xi1.ThrowIfDisposed ();
            if (K2 != null) K2.ThrowIfDisposed ();
            if (D2 != null) D2.ThrowIfDisposed ();
            if (xi2 != null) xi2.ThrowIfDisposed ();
            if (R != null) R.ThrowIfDisposed ();
            if (T != null) T.ThrowIfDisposed ();
            if (disparity != null) disparity.ThrowIfDisposed ();
            if (image1Rec != null) image1Rec.ThrowIfDisposed ();
            if (image2Rec != null) image2Rec.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ccalib_Ccalib_stereoReconstruct_14(image1.nativeObj, image2.nativeObj, K1.nativeObj, D1.nativeObj, xi1.nativeObj, K2.nativeObj, D2.nativeObj, xi2.nativeObj, R.nativeObj, T.nativeObj, flag, numDisparities, SADWindowSize, disparity.nativeObj, image1Rec.nativeObj, image2Rec.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::omnidir::stereoRectify(Mat R, Mat T, Mat& R1, Mat& R2)
        //

        //javadoc: stereoRectify(R, T, R1, R2)
        public static void stereoRectify (Mat R, Mat T, Mat R1, Mat R2)
        {
            if (R != null) R.ThrowIfDisposed ();
            if (T != null) T.ThrowIfDisposed ();
            if (R1 != null) R1.ThrowIfDisposed ();
            if (R2 != null) R2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ccalib_Ccalib_stereoRectify_10(R.nativeObj, T.nativeObj, R1.nativeObj, R2.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::omnidir::undistortImage(Mat distorted, Mat& undistorted, Mat K, Mat D, Mat xi, int flags, Mat Knew = cv::Mat(), Size new_size = Size(), Mat R = Mat::eye(3, 3, CV_64F))
        //

        //javadoc: undistortImage(distorted, undistorted, K, D, xi, flags, Knew, new_size, R)
        public static void undistortImage (Mat distorted, Mat undistorted, Mat K, Mat D, Mat xi, int flags, Mat Knew, Size new_size, Mat R)
        {
            if (distorted != null) distorted.ThrowIfDisposed ();
            if (undistorted != null) undistorted.ThrowIfDisposed ();
            if (K != null) K.ThrowIfDisposed ();
            if (D != null) D.ThrowIfDisposed ();
            if (xi != null) xi.ThrowIfDisposed ();
            if (Knew != null) Knew.ThrowIfDisposed ();
            if (R != null) R.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ccalib_Ccalib_undistortImage_10(distorted.nativeObj, undistorted.nativeObj, K.nativeObj, D.nativeObj, xi.nativeObj, flags, Knew.nativeObj, new_size.width, new_size.height, R.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: undistortImage(distorted, undistorted, K, D, xi, flags, Knew, new_size)
        public static void undistortImage (Mat distorted, Mat undistorted, Mat K, Mat D, Mat xi, int flags, Mat Knew, Size new_size)
        {
            if (distorted != null) distorted.ThrowIfDisposed ();
            if (undistorted != null) undistorted.ThrowIfDisposed ();
            if (K != null) K.ThrowIfDisposed ();
            if (D != null) D.ThrowIfDisposed ();
            if (xi != null) xi.ThrowIfDisposed ();
            if (Knew != null) Knew.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ccalib_Ccalib_undistortImage_11(distorted.nativeObj, undistorted.nativeObj, K.nativeObj, D.nativeObj, xi.nativeObj, flags, Knew.nativeObj, new_size.width, new_size.height);
        
        return;
#else
            return;
#endif
        }

        //javadoc: undistortImage(distorted, undistorted, K, D, xi, flags, Knew)
        public static void undistortImage (Mat distorted, Mat undistorted, Mat K, Mat D, Mat xi, int flags, Mat Knew)
        {
            if (distorted != null) distorted.ThrowIfDisposed ();
            if (undistorted != null) undistorted.ThrowIfDisposed ();
            if (K != null) K.ThrowIfDisposed ();
            if (D != null) D.ThrowIfDisposed ();
            if (xi != null) xi.ThrowIfDisposed ();
            if (Knew != null) Knew.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ccalib_Ccalib_undistortImage_12(distorted.nativeObj, undistorted.nativeObj, K.nativeObj, D.nativeObj, xi.nativeObj, flags, Knew.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: undistortImage(distorted, undistorted, K, D, xi, flags)
        public static void undistortImage (Mat distorted, Mat undistorted, Mat K, Mat D, Mat xi, int flags)
        {
            if (distorted != null) distorted.ThrowIfDisposed ();
            if (undistorted != null) undistorted.ThrowIfDisposed ();
            if (K != null) K.ThrowIfDisposed ();
            if (D != null) D.ThrowIfDisposed ();
            if (xi != null) xi.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ccalib_Ccalib_undistortImage_13(distorted.nativeObj, undistorted.nativeObj, K.nativeObj, D.nativeObj, xi.nativeObj, flags);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::omnidir::undistortPoints(Mat distorted, Mat& undistorted, Mat K, Mat D, Mat xi, Mat R)
        //

        //javadoc: undistortPoints(distorted, undistorted, K, D, xi, R)
        public static void undistortPoints (Mat distorted, Mat undistorted, Mat K, Mat D, Mat xi, Mat R)
        {
            if (distorted != null) distorted.ThrowIfDisposed ();
            if (undistorted != null) undistorted.ThrowIfDisposed ();
            if (K != null) K.ThrowIfDisposed ();
            if (D != null) D.ThrowIfDisposed ();
            if (xi != null) xi.ThrowIfDisposed ();
            if (R != null) R.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ccalib_Ccalib_undistortPoints_10(distorted.nativeObj, undistorted.nativeObj, K.nativeObj, D.nativeObj, xi.nativeObj, R.nativeObj);
        
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



        // C++:  double cv::omnidir::calibrate(vector_Mat objectPoints, vector_Mat imagePoints, Size size, Mat& K, Mat& xi, Mat& D, vector_Mat& rvecs, vector_Mat& tvecs, int flags, TermCriteria criteria, Mat& idx = Mat())
        [DllImport (LIBNAME)]
        private static extern double ccalib_Ccalib_calibrate_10 (IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double size_width, double size_height, IntPtr K_nativeObj, IntPtr xi_nativeObj, IntPtr D_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon, IntPtr idx_nativeObj);
        [DllImport (LIBNAME)]
        private static extern double ccalib_Ccalib_calibrate_11 (IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double size_width, double size_height, IntPtr K_nativeObj, IntPtr xi_nativeObj, IntPtr D_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);

        // C++:  double cv::omnidir::stereoCalibrate(vector_Mat& objectPoints, vector_Mat& imagePoints1, vector_Mat& imagePoints2, Size imageSize1, Size imageSize2, Mat& K1, Mat& xi1, Mat& D1, Mat& K2, Mat& xi2, Mat& D2, Mat& rvec, Mat& tvec, vector_Mat& rvecsL, vector_Mat& tvecsL, int flags, TermCriteria criteria, Mat& idx = Mat())
        [DllImport (LIBNAME)]
        private static extern double ccalib_Ccalib_stereoCalibrate_10 (IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, double imageSize1_width, double imageSize1_height, double imageSize2_width, double imageSize2_height, IntPtr K1_nativeObj, IntPtr xi1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr xi2_nativeObj, IntPtr D2_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr rvecsL_mat_nativeObj, IntPtr tvecsL_mat_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon, IntPtr idx_nativeObj);
        [DllImport (LIBNAME)]
        private static extern double ccalib_Ccalib_stereoCalibrate_11 (IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, double imageSize1_width, double imageSize1_height, double imageSize2_width, double imageSize2_height, IntPtr K1_nativeObj, IntPtr xi1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr xi2_nativeObj, IntPtr D2_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr rvecsL_mat_nativeObj, IntPtr tvecsL_mat_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);

        // C++:  void cv::omnidir::initUndistortRectifyMap(Mat K, Mat D, Mat xi, Mat R, Mat P, Size size, int mltype, Mat& map1, Mat& map2, int flags)
        [DllImport (LIBNAME)]
        private static extern void ccalib_Ccalib_initUndistortRectifyMap_10 (IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr xi_nativeObj, IntPtr R_nativeObj, IntPtr P_nativeObj, double size_width, double size_height, int mltype, IntPtr map1_nativeObj, IntPtr map2_nativeObj, int flags);

        // C++:  void cv::omnidir::projectPoints(vector_Point3f objectPoints, vector_Point2f& imagePoints, Mat rvec, Mat tvec, Mat K, double xi, Mat D, Mat& jacobian = Mat())
        [DllImport (LIBNAME)]
        private static extern void ccalib_Ccalib_projectPoints_10 (IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr K_nativeObj, double xi, IntPtr D_nativeObj, IntPtr jacobian_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void ccalib_Ccalib_projectPoints_11 (IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr K_nativeObj, double xi, IntPtr D_nativeObj);

        // C++:  void cv::omnidir::stereoReconstruct(Mat image1, Mat image2, Mat K1, Mat D1, Mat xi1, Mat K2, Mat D2, Mat xi2, Mat R, Mat T, int flag, int numDisparities, int SADWindowSize, Mat& disparity, Mat& image1Rec, Mat& image2Rec, Size newSize = Size(), Mat Knew = cv::Mat(), Mat& pointCloud = cv::Mat(), int pointType = XYZRGB)
        [DllImport (LIBNAME)]
        private static extern void ccalib_Ccalib_stereoReconstruct_10 (IntPtr image1_nativeObj, IntPtr image2_nativeObj, IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr xi1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, IntPtr xi2_nativeObj, IntPtr R_nativeObj, IntPtr T_nativeObj, int flag, int numDisparities, int SADWindowSize, IntPtr disparity_nativeObj, IntPtr image1Rec_nativeObj, IntPtr image2Rec_nativeObj, double newSize_width, double newSize_height, IntPtr Knew_nativeObj, IntPtr pointCloud_nativeObj, int pointType);
        [DllImport (LIBNAME)]
        private static extern void ccalib_Ccalib_stereoReconstruct_11 (IntPtr image1_nativeObj, IntPtr image2_nativeObj, IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr xi1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, IntPtr xi2_nativeObj, IntPtr R_nativeObj, IntPtr T_nativeObj, int flag, int numDisparities, int SADWindowSize, IntPtr disparity_nativeObj, IntPtr image1Rec_nativeObj, IntPtr image2Rec_nativeObj, double newSize_width, double newSize_height, IntPtr Knew_nativeObj, IntPtr pointCloud_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void ccalib_Ccalib_stereoReconstruct_12 (IntPtr image1_nativeObj, IntPtr image2_nativeObj, IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr xi1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, IntPtr xi2_nativeObj, IntPtr R_nativeObj, IntPtr T_nativeObj, int flag, int numDisparities, int SADWindowSize, IntPtr disparity_nativeObj, IntPtr image1Rec_nativeObj, IntPtr image2Rec_nativeObj, double newSize_width, double newSize_height, IntPtr Knew_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void ccalib_Ccalib_stereoReconstruct_13 (IntPtr image1_nativeObj, IntPtr image2_nativeObj, IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr xi1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, IntPtr xi2_nativeObj, IntPtr R_nativeObj, IntPtr T_nativeObj, int flag, int numDisparities, int SADWindowSize, IntPtr disparity_nativeObj, IntPtr image1Rec_nativeObj, IntPtr image2Rec_nativeObj, double newSize_width, double newSize_height);
        [DllImport (LIBNAME)]
        private static extern void ccalib_Ccalib_stereoReconstruct_14 (IntPtr image1_nativeObj, IntPtr image2_nativeObj, IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr xi1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, IntPtr xi2_nativeObj, IntPtr R_nativeObj, IntPtr T_nativeObj, int flag, int numDisparities, int SADWindowSize, IntPtr disparity_nativeObj, IntPtr image1Rec_nativeObj, IntPtr image2Rec_nativeObj);

        // C++:  void cv::omnidir::stereoRectify(Mat R, Mat T, Mat& R1, Mat& R2)
        [DllImport (LIBNAME)]
        private static extern void ccalib_Ccalib_stereoRectify_10 (IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj);

        // C++:  void cv::omnidir::undistortImage(Mat distorted, Mat& undistorted, Mat K, Mat D, Mat xi, int flags, Mat Knew = cv::Mat(), Size new_size = Size(), Mat R = Mat::eye(3, 3, CV_64F))
        [DllImport (LIBNAME)]
        private static extern void ccalib_Ccalib_undistortImage_10 (IntPtr distorted_nativeObj, IntPtr undistorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr xi_nativeObj, int flags, IntPtr Knew_nativeObj, double new_size_width, double new_size_height, IntPtr R_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void ccalib_Ccalib_undistortImage_11 (IntPtr distorted_nativeObj, IntPtr undistorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr xi_nativeObj, int flags, IntPtr Knew_nativeObj, double new_size_width, double new_size_height);
        [DllImport (LIBNAME)]
        private static extern void ccalib_Ccalib_undistortImage_12 (IntPtr distorted_nativeObj, IntPtr undistorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr xi_nativeObj, int flags, IntPtr Knew_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void ccalib_Ccalib_undistortImage_13 (IntPtr distorted_nativeObj, IntPtr undistorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr xi_nativeObj, int flags);

        // C++:  void cv::omnidir::undistortPoints(Mat distorted, Mat& undistorted, Mat K, Mat D, Mat xi, Mat R)
        [DllImport (LIBNAME)]
        private static extern void ccalib_Ccalib_undistortPoints_10 (IntPtr distorted_nativeObj, IntPtr undistorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr xi_nativeObj, IntPtr R_nativeObj);

    }
}
