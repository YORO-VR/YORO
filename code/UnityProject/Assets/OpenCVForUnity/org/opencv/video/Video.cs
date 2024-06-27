
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class Video
    //javadoc: Video

    public class Video
    {

        private const int CV_LKFLOW_INITIAL_GUESSES = 4;
        private const int CV_LKFLOW_GET_MIN_EIGENVALS = 8;
        public const int OPTFLOW_USE_INITIAL_FLOW = 4;
        public const int OPTFLOW_LK_GET_MIN_EIGENVALS = 8;
        public const int OPTFLOW_FARNEBACK_GAUSSIAN = 256;
        public const int MOTION_TRANSLATION = 0;
        public const int MOTION_EUCLIDEAN = 1;
        public const int MOTION_AFFINE = 2;
        public const int MOTION_HOMOGRAPHY = 3;
        //
        // C++:  Mat cv::estimateRigidTransform(Mat src, Mat dst, bool fullAffine, int ransacMaxIters, double ransacGoodRatio, int ransacSize0)
        //

        //javadoc: estimateRigidTransform(src, dst, fullAffine, ransacMaxIters, ransacGoodRatio, ransacSize0)
        public static Mat estimateRigidTransform (Mat src, Mat dst, bool fullAffine, int ransacMaxIters, double ransacGoodRatio, int ransacSize0)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(video_Video_estimateRigidTransform_10(src.nativeObj, dst.nativeObj, fullAffine, ransacMaxIters, ransacGoodRatio, ransacSize0));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Mat cv::estimateRigidTransform(Mat src, Mat dst, bool fullAffine)
        //

        //javadoc: estimateRigidTransform(src, dst, fullAffine)
        public static Mat estimateRigidTransform (Mat src, Mat dst, bool fullAffine)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(video_Video_estimateRigidTransform_11(src.nativeObj, dst.nativeObj, fullAffine));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_BackgroundSubtractorKNN cv::createBackgroundSubtractorKNN(int history = 500, double dist2Threshold = 400.0, bool detectShadows = true)
        //

        //javadoc: createBackgroundSubtractorKNN(history, dist2Threshold, detectShadows)
        public static BackgroundSubtractorKNN createBackgroundSubtractorKNN (int history, double dist2Threshold, bool detectShadows)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorKNN retVal = BackgroundSubtractorKNN.__fromPtr__(video_Video_createBackgroundSubtractorKNN_10(history, dist2Threshold, detectShadows));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorKNN(history, dist2Threshold)
        public static BackgroundSubtractorKNN createBackgroundSubtractorKNN (int history, double dist2Threshold)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorKNN retVal = BackgroundSubtractorKNN.__fromPtr__(video_Video_createBackgroundSubtractorKNN_11(history, dist2Threshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorKNN(history)
        public static BackgroundSubtractorKNN createBackgroundSubtractorKNN (int history)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorKNN retVal = BackgroundSubtractorKNN.__fromPtr__(video_Video_createBackgroundSubtractorKNN_12(history));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorKNN()
        public static BackgroundSubtractorKNN createBackgroundSubtractorKNN ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorKNN retVal = BackgroundSubtractorKNN.__fromPtr__(video_Video_createBackgroundSubtractorKNN_13());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_BackgroundSubtractorMOG2 cv::createBackgroundSubtractorMOG2(int history = 500, double varThreshold = 16, bool detectShadows = true)
        //

        //javadoc: createBackgroundSubtractorMOG2(history, varThreshold, detectShadows)
        public static BackgroundSubtractorMOG2 createBackgroundSubtractorMOG2 (int history, double varThreshold, bool detectShadows)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorMOG2 retVal = BackgroundSubtractorMOG2.__fromPtr__(video_Video_createBackgroundSubtractorMOG2_10(history, varThreshold, detectShadows));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorMOG2(history, varThreshold)
        public static BackgroundSubtractorMOG2 createBackgroundSubtractorMOG2 (int history, double varThreshold)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorMOG2 retVal = BackgroundSubtractorMOG2.__fromPtr__(video_Video_createBackgroundSubtractorMOG2_11(history, varThreshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorMOG2(history)
        public static BackgroundSubtractorMOG2 createBackgroundSubtractorMOG2 (int history)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorMOG2 retVal = BackgroundSubtractorMOG2.__fromPtr__(video_Video_createBackgroundSubtractorMOG2_12(history));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createBackgroundSubtractorMOG2()
        public static BackgroundSubtractorMOG2 createBackgroundSubtractorMOG2 ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorMOG2 retVal = BackgroundSubtractorMOG2.__fromPtr__(video_Video_createBackgroundSubtractorMOG2_13());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_DualTVL1OpticalFlow cv::createOptFlow_DualTVL1()
        //

        //javadoc: createOptFlow_DualTVL1()
        public static DualTVL1OpticalFlow createOptFlow_DualTVL1 ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DualTVL1OpticalFlow retVal = DualTVL1OpticalFlow.__fromPtr__(video_Video_createOptFlow_1DualTVL1_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  RotatedRect cv::CamShift(Mat probImage, Rect& window, TermCriteria criteria)
        //

        //javadoc: CamShift(probImage, window, criteria)
        public static RotatedRect CamShift (Mat probImage, Rect window, TermCriteria criteria)
        {
            if (probImage != null) probImage.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        double[] window_out = new double[4];
        double[] tmpArray = new double[5];
video_Video_CamShift_10(probImage.nativeObj, window.x, window.y, window.width, window.height, window_out, criteria.type, criteria.maxCount, criteria.epsilon, tmpArray);
RotatedRect retVal = new RotatedRect (tmpArray);
        if(window!=null){ window.x = (int)window_out[0]; window.y = (int)window_out[1]; window.width = (int)window_out[2]; window.height = (int)window_out[3]; } 
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  double cv::findTransformECC(Mat templateImage, Mat inputImage, Mat& warpMatrix, int motionType = MOTION_AFFINE, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 50, 0.001), Mat inputMask = Mat())
        //

        //javadoc: findTransformECC(templateImage, inputImage, warpMatrix, motionType, criteria, inputMask)
        public static double findTransformECC (Mat templateImage, Mat inputImage, Mat warpMatrix, int motionType, TermCriteria criteria, Mat inputMask)
        {
            if (templateImage != null) templateImage.ThrowIfDisposed ();
            if (inputImage != null) inputImage.ThrowIfDisposed ();
            if (warpMatrix != null) warpMatrix.ThrowIfDisposed ();
            if (inputMask != null) inputMask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_Video_findTransformECC_10(templateImage.nativeObj, inputImage.nativeObj, warpMatrix.nativeObj, motionType, criteria.type, criteria.maxCount, criteria.epsilon, inputMask.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: findTransformECC(templateImage, inputImage, warpMatrix, motionType, criteria)
        public static double findTransformECC (Mat templateImage, Mat inputImage, Mat warpMatrix, int motionType, TermCriteria criteria)
        {
            if (templateImage != null) templateImage.ThrowIfDisposed ();
            if (inputImage != null) inputImage.ThrowIfDisposed ();
            if (warpMatrix != null) warpMatrix.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_Video_findTransformECC_11(templateImage.nativeObj, inputImage.nativeObj, warpMatrix.nativeObj, motionType, criteria.type, criteria.maxCount, criteria.epsilon);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: findTransformECC(templateImage, inputImage, warpMatrix, motionType)
        public static double findTransformECC (Mat templateImage, Mat inputImage, Mat warpMatrix, int motionType)
        {
            if (templateImage != null) templateImage.ThrowIfDisposed ();
            if (inputImage != null) inputImage.ThrowIfDisposed ();
            if (warpMatrix != null) warpMatrix.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_Video_findTransformECC_12(templateImage.nativeObj, inputImage.nativeObj, warpMatrix.nativeObj, motionType);
        
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: findTransformECC(templateImage, inputImage, warpMatrix)
        public static double findTransformECC (Mat templateImage, Mat inputImage, Mat warpMatrix)
        {
            if (templateImage != null) templateImage.ThrowIfDisposed ();
            if (inputImage != null) inputImage.ThrowIfDisposed ();
            if (warpMatrix != null) warpMatrix.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_Video_findTransformECC_13(templateImage.nativeObj, inputImage.nativeObj, warpMatrix.nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::buildOpticalFlowPyramid(Mat img, vector_Mat& pyramid, Size winSize, int maxLevel, bool withDerivatives = true, int pyrBorder = BORDER_REFLECT_101, int derivBorder = BORDER_CONSTANT, bool tryReuseInputImage = true)
        //

        //javadoc: buildOpticalFlowPyramid(img, pyramid, winSize, maxLevel, withDerivatives, pyrBorder, derivBorder, tryReuseInputImage)
        public static int buildOpticalFlowPyramid (Mat img, List<Mat> pyramid, Size winSize, int maxLevel, bool withDerivatives, int pyrBorder, int derivBorder, bool tryReuseInputImage)
        {
            if (img != null) img.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat pyramid_mat = new Mat();
        int retVal = video_Video_buildOpticalFlowPyramid_10(img.nativeObj, pyramid_mat.nativeObj, winSize.width, winSize.height, maxLevel, withDerivatives, pyrBorder, derivBorder, tryReuseInputImage);
        Converters.Mat_to_vector_Mat(pyramid_mat, pyramid);
        pyramid_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: buildOpticalFlowPyramid(img, pyramid, winSize, maxLevel, withDerivatives, pyrBorder, derivBorder)
        public static int buildOpticalFlowPyramid (Mat img, List<Mat> pyramid, Size winSize, int maxLevel, bool withDerivatives, int pyrBorder, int derivBorder)
        {
            if (img != null) img.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat pyramid_mat = new Mat();
        int retVal = video_Video_buildOpticalFlowPyramid_11(img.nativeObj, pyramid_mat.nativeObj, winSize.width, winSize.height, maxLevel, withDerivatives, pyrBorder, derivBorder);
        Converters.Mat_to_vector_Mat(pyramid_mat, pyramid);
        pyramid_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: buildOpticalFlowPyramid(img, pyramid, winSize, maxLevel, withDerivatives, pyrBorder)
        public static int buildOpticalFlowPyramid (Mat img, List<Mat> pyramid, Size winSize, int maxLevel, bool withDerivatives, int pyrBorder)
        {
            if (img != null) img.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat pyramid_mat = new Mat();
        int retVal = video_Video_buildOpticalFlowPyramid_12(img.nativeObj, pyramid_mat.nativeObj, winSize.width, winSize.height, maxLevel, withDerivatives, pyrBorder);
        Converters.Mat_to_vector_Mat(pyramid_mat, pyramid);
        pyramid_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: buildOpticalFlowPyramid(img, pyramid, winSize, maxLevel, withDerivatives)
        public static int buildOpticalFlowPyramid (Mat img, List<Mat> pyramid, Size winSize, int maxLevel, bool withDerivatives)
        {
            if (img != null) img.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat pyramid_mat = new Mat();
        int retVal = video_Video_buildOpticalFlowPyramid_13(img.nativeObj, pyramid_mat.nativeObj, winSize.width, winSize.height, maxLevel, withDerivatives);
        Converters.Mat_to_vector_Mat(pyramid_mat, pyramid);
        pyramid_mat.release();
        return retVal;
#else
            return -1;
#endif
        }

        //javadoc: buildOpticalFlowPyramid(img, pyramid, winSize, maxLevel)
        public static int buildOpticalFlowPyramid (Mat img, List<Mat> pyramid, Size winSize, int maxLevel)
        {
            if (img != null) img.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat pyramid_mat = new Mat();
        int retVal = video_Video_buildOpticalFlowPyramid_14(img.nativeObj, pyramid_mat.nativeObj, winSize.width, winSize.height, maxLevel);
        Converters.Mat_to_vector_Mat(pyramid_mat, pyramid);
        pyramid_mat.release();
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::meanShift(Mat probImage, Rect& window, TermCriteria criteria)
        //

        //javadoc: meanShift(probImage, window, criteria)
        public static int meanShift (Mat probImage, Rect window, TermCriteria criteria)
        {
            if (probImage != null) probImage.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        double[] window_out = new double[4];
        int retVal = video_Video_meanShift_10(probImage.nativeObj, window.x, window.y, window.width, window.height, window_out, criteria.type, criteria.maxCount, criteria.epsilon);
        if(window!=null){ window.x = (int)window_out[0]; window.y = (int)window_out[1]; window.width = (int)window_out[2]; window.height = (int)window_out[3]; } 
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::calcOpticalFlowFarneback(Mat prev, Mat next, Mat& flow, double pyr_scale, int levels, int winsize, int iterations, int poly_n, double poly_sigma, int flags)
        //

        //javadoc: calcOpticalFlowFarneback(prev, next, flow, pyr_scale, levels, winsize, iterations, poly_n, poly_sigma, flags)
        public static void calcOpticalFlowFarneback (Mat prev, Mat next, Mat flow, double pyr_scale, int levels, int winsize, int iterations, int poly_n, double poly_sigma, int flags)
        {
            if (prev != null) prev.ThrowIfDisposed ();
            if (next != null) next.ThrowIfDisposed ();
            if (flow != null) flow.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_Video_calcOpticalFlowFarneback_10(prev.nativeObj, next.nativeObj, flow.nativeObj, pyr_scale, levels, winsize, iterations, poly_n, poly_sigma, flags);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::calcOpticalFlowPyrLK(Mat prevImg, Mat nextImg, vector_Point2f prevPts, vector_Point2f& nextPts, vector_uchar& status, vector_float& err, Size winSize = Size(21,21), int maxLevel = 3, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 0.01), int flags = 0, double minEigThreshold = 1e-4)
        //

        //javadoc: calcOpticalFlowPyrLK(prevImg, nextImg, prevPts, nextPts, status, err, winSize, maxLevel, criteria, flags, minEigThreshold)
        public static void calcOpticalFlowPyrLK (Mat prevImg, Mat nextImg, MatOfPoint2f prevPts, MatOfPoint2f nextPts, MatOfByte status, MatOfFloat err, Size winSize, int maxLevel, TermCriteria criteria, int flags, double minEigThreshold)
        {
            if (prevImg != null) prevImg.ThrowIfDisposed ();
            if (nextImg != null) nextImg.ThrowIfDisposed ();
            if (prevPts != null) prevPts.ThrowIfDisposed ();
            if (nextPts != null) nextPts.ThrowIfDisposed ();
            if (status != null) status.ThrowIfDisposed ();
            if (err != null) err.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat prevPts_mat = prevPts;
        Mat nextPts_mat = nextPts;
        Mat status_mat = status;
        Mat err_mat = err;
        video_Video_calcOpticalFlowPyrLK_10(prevImg.nativeObj, nextImg.nativeObj, prevPts_mat.nativeObj, nextPts_mat.nativeObj, status_mat.nativeObj, err_mat.nativeObj, winSize.width, winSize.height, maxLevel, criteria.type, criteria.maxCount, criteria.epsilon, flags, minEigThreshold);
        
        return;
#else
            return;
#endif
        }

        //javadoc: calcOpticalFlowPyrLK(prevImg, nextImg, prevPts, nextPts, status, err, winSize, maxLevel, criteria, flags)
        public static void calcOpticalFlowPyrLK (Mat prevImg, Mat nextImg, MatOfPoint2f prevPts, MatOfPoint2f nextPts, MatOfByte status, MatOfFloat err, Size winSize, int maxLevel, TermCriteria criteria, int flags)
        {
            if (prevImg != null) prevImg.ThrowIfDisposed ();
            if (nextImg != null) nextImg.ThrowIfDisposed ();
            if (prevPts != null) prevPts.ThrowIfDisposed ();
            if (nextPts != null) nextPts.ThrowIfDisposed ();
            if (status != null) status.ThrowIfDisposed ();
            if (err != null) err.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat prevPts_mat = prevPts;
        Mat nextPts_mat = nextPts;
        Mat status_mat = status;
        Mat err_mat = err;
        video_Video_calcOpticalFlowPyrLK_11(prevImg.nativeObj, nextImg.nativeObj, prevPts_mat.nativeObj, nextPts_mat.nativeObj, status_mat.nativeObj, err_mat.nativeObj, winSize.width, winSize.height, maxLevel, criteria.type, criteria.maxCount, criteria.epsilon, flags);
        
        return;
#else
            return;
#endif
        }

        //javadoc: calcOpticalFlowPyrLK(prevImg, nextImg, prevPts, nextPts, status, err, winSize, maxLevel, criteria)
        public static void calcOpticalFlowPyrLK (Mat prevImg, Mat nextImg, MatOfPoint2f prevPts, MatOfPoint2f nextPts, MatOfByte status, MatOfFloat err, Size winSize, int maxLevel, TermCriteria criteria)
        {
            if (prevImg != null) prevImg.ThrowIfDisposed ();
            if (nextImg != null) nextImg.ThrowIfDisposed ();
            if (prevPts != null) prevPts.ThrowIfDisposed ();
            if (nextPts != null) nextPts.ThrowIfDisposed ();
            if (status != null) status.ThrowIfDisposed ();
            if (err != null) err.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat prevPts_mat = prevPts;
        Mat nextPts_mat = nextPts;
        Mat status_mat = status;
        Mat err_mat = err;
        video_Video_calcOpticalFlowPyrLK_12(prevImg.nativeObj, nextImg.nativeObj, prevPts_mat.nativeObj, nextPts_mat.nativeObj, status_mat.nativeObj, err_mat.nativeObj, winSize.width, winSize.height, maxLevel, criteria.type, criteria.maxCount, criteria.epsilon);
        
        return;
#else
            return;
#endif
        }

        //javadoc: calcOpticalFlowPyrLK(prevImg, nextImg, prevPts, nextPts, status, err, winSize, maxLevel)
        public static void calcOpticalFlowPyrLK (Mat prevImg, Mat nextImg, MatOfPoint2f prevPts, MatOfPoint2f nextPts, MatOfByte status, MatOfFloat err, Size winSize, int maxLevel)
        {
            if (prevImg != null) prevImg.ThrowIfDisposed ();
            if (nextImg != null) nextImg.ThrowIfDisposed ();
            if (prevPts != null) prevPts.ThrowIfDisposed ();
            if (nextPts != null) nextPts.ThrowIfDisposed ();
            if (status != null) status.ThrowIfDisposed ();
            if (err != null) err.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat prevPts_mat = prevPts;
        Mat nextPts_mat = nextPts;
        Mat status_mat = status;
        Mat err_mat = err;
        video_Video_calcOpticalFlowPyrLK_13(prevImg.nativeObj, nextImg.nativeObj, prevPts_mat.nativeObj, nextPts_mat.nativeObj, status_mat.nativeObj, err_mat.nativeObj, winSize.width, winSize.height, maxLevel);
        
        return;
#else
            return;
#endif
        }

        //javadoc: calcOpticalFlowPyrLK(prevImg, nextImg, prevPts, nextPts, status, err, winSize)
        public static void calcOpticalFlowPyrLK (Mat prevImg, Mat nextImg, MatOfPoint2f prevPts, MatOfPoint2f nextPts, MatOfByte status, MatOfFloat err, Size winSize)
        {
            if (prevImg != null) prevImg.ThrowIfDisposed ();
            if (nextImg != null) nextImg.ThrowIfDisposed ();
            if (prevPts != null) prevPts.ThrowIfDisposed ();
            if (nextPts != null) nextPts.ThrowIfDisposed ();
            if (status != null) status.ThrowIfDisposed ();
            if (err != null) err.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat prevPts_mat = prevPts;
        Mat nextPts_mat = nextPts;
        Mat status_mat = status;
        Mat err_mat = err;
        video_Video_calcOpticalFlowPyrLK_14(prevImg.nativeObj, nextImg.nativeObj, prevPts_mat.nativeObj, nextPts_mat.nativeObj, status_mat.nativeObj, err_mat.nativeObj, winSize.width, winSize.height);
        
        return;
#else
            return;
#endif
        }

        //javadoc: calcOpticalFlowPyrLK(prevImg, nextImg, prevPts, nextPts, status, err)
        public static void calcOpticalFlowPyrLK (Mat prevImg, Mat nextImg, MatOfPoint2f prevPts, MatOfPoint2f nextPts, MatOfByte status, MatOfFloat err)
        {
            if (prevImg != null) prevImg.ThrowIfDisposed ();
            if (nextImg != null) nextImg.ThrowIfDisposed ();
            if (prevPts != null) prevPts.ThrowIfDisposed ();
            if (nextPts != null) nextPts.ThrowIfDisposed ();
            if (status != null) status.ThrowIfDisposed ();
            if (err != null) err.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat prevPts_mat = prevPts;
        Mat nextPts_mat = nextPts;
        Mat status_mat = status;
        Mat err_mat = err;
        video_Video_calcOpticalFlowPyrLK_15(prevImg.nativeObj, nextImg.nativeObj, prevPts_mat.nativeObj, nextPts_mat.nativeObj, status_mat.nativeObj, err_mat.nativeObj);
        
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



        // C++:  Mat cv::estimateRigidTransform(Mat src, Mat dst, bool fullAffine, int ransacMaxIters, double ransacGoodRatio, int ransacSize0)
        [DllImport (LIBNAME)]
        private static extern IntPtr video_Video_estimateRigidTransform_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, bool fullAffine, int ransacMaxIters, double ransacGoodRatio, int ransacSize0);

        // C++:  Mat cv::estimateRigidTransform(Mat src, Mat dst, bool fullAffine)
        [DllImport (LIBNAME)]
        private static extern IntPtr video_Video_estimateRigidTransform_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, bool fullAffine);

        // C++:  Ptr_BackgroundSubtractorKNN cv::createBackgroundSubtractorKNN(int history = 500, double dist2Threshold = 400.0, bool detectShadows = true)
        [DllImport (LIBNAME)]
        private static extern IntPtr video_Video_createBackgroundSubtractorKNN_10 (int history, double dist2Threshold, bool detectShadows);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_Video_createBackgroundSubtractorKNN_11 (int history, double dist2Threshold);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_Video_createBackgroundSubtractorKNN_12 (int history);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_Video_createBackgroundSubtractorKNN_13 ();

        // C++:  Ptr_BackgroundSubtractorMOG2 cv::createBackgroundSubtractorMOG2(int history = 500, double varThreshold = 16, bool detectShadows = true)
        [DllImport (LIBNAME)]
        private static extern IntPtr video_Video_createBackgroundSubtractorMOG2_10 (int history, double varThreshold, bool detectShadows);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_Video_createBackgroundSubtractorMOG2_11 (int history, double varThreshold);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_Video_createBackgroundSubtractorMOG2_12 (int history);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_Video_createBackgroundSubtractorMOG2_13 ();

        // C++:  Ptr_DualTVL1OpticalFlow cv::createOptFlow_DualTVL1()
        [DllImport (LIBNAME)]
        private static extern IntPtr video_Video_createOptFlow_1DualTVL1_10 ();

        // C++:  RotatedRect cv::CamShift(Mat probImage, Rect& window, TermCriteria criteria)
        [DllImport (LIBNAME)]
        private static extern void video_Video_CamShift_10 (IntPtr probImage_nativeObj, int window_x, int window_y, int window_width, int window_height, double[] window_out, int criteria_type, int criteria_maxCount, double criteria_epsilon, double[] retVal);

        // C++:  double cv::findTransformECC(Mat templateImage, Mat inputImage, Mat& warpMatrix, int motionType = MOTION_AFFINE, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 50, 0.001), Mat inputMask = Mat())
        [DllImport (LIBNAME)]
        private static extern double video_Video_findTransformECC_10 (IntPtr templateImage_nativeObj, IntPtr inputImage_nativeObj, IntPtr warpMatrix_nativeObj, int motionType, int criteria_type, int criteria_maxCount, double criteria_epsilon, IntPtr inputMask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern double video_Video_findTransformECC_11 (IntPtr templateImage_nativeObj, IntPtr inputImage_nativeObj, IntPtr warpMatrix_nativeObj, int motionType, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport (LIBNAME)]
        private static extern double video_Video_findTransformECC_12 (IntPtr templateImage_nativeObj, IntPtr inputImage_nativeObj, IntPtr warpMatrix_nativeObj, int motionType);
        [DllImport (LIBNAME)]
        private static extern double video_Video_findTransformECC_13 (IntPtr templateImage_nativeObj, IntPtr inputImage_nativeObj, IntPtr warpMatrix_nativeObj);

        // C++:  int cv::buildOpticalFlowPyramid(Mat img, vector_Mat& pyramid, Size winSize, int maxLevel, bool withDerivatives = true, int pyrBorder = BORDER_REFLECT_101, int derivBorder = BORDER_CONSTANT, bool tryReuseInputImage = true)
        [DllImport (LIBNAME)]
        private static extern int video_Video_buildOpticalFlowPyramid_10 (IntPtr img_nativeObj, IntPtr pyramid_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel, bool withDerivatives, int pyrBorder, int derivBorder, bool tryReuseInputImage);
        [DllImport (LIBNAME)]
        private static extern int video_Video_buildOpticalFlowPyramid_11 (IntPtr img_nativeObj, IntPtr pyramid_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel, bool withDerivatives, int pyrBorder, int derivBorder);
        [DllImport (LIBNAME)]
        private static extern int video_Video_buildOpticalFlowPyramid_12 (IntPtr img_nativeObj, IntPtr pyramid_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel, bool withDerivatives, int pyrBorder);
        [DllImport (LIBNAME)]
        private static extern int video_Video_buildOpticalFlowPyramid_13 (IntPtr img_nativeObj, IntPtr pyramid_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel, bool withDerivatives);
        [DllImport (LIBNAME)]
        private static extern int video_Video_buildOpticalFlowPyramid_14 (IntPtr img_nativeObj, IntPtr pyramid_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel);

        // C++:  int cv::meanShift(Mat probImage, Rect& window, TermCriteria criteria)
        [DllImport (LIBNAME)]
        private static extern int video_Video_meanShift_10 (IntPtr probImage_nativeObj, int window_x, int window_y, int window_width, int window_height, double[] window_out, int criteria_type, int criteria_maxCount, double criteria_epsilon);

        // C++:  void cv::calcOpticalFlowFarneback(Mat prev, Mat next, Mat& flow, double pyr_scale, int levels, int winsize, int iterations, int poly_n, double poly_sigma, int flags)
        [DllImport (LIBNAME)]
        private static extern void video_Video_calcOpticalFlowFarneback_10 (IntPtr prev_nativeObj, IntPtr next_nativeObj, IntPtr flow_nativeObj, double pyr_scale, int levels, int winsize, int iterations, int poly_n, double poly_sigma, int flags);

        // C++:  void cv::calcOpticalFlowPyrLK(Mat prevImg, Mat nextImg, vector_Point2f prevPts, vector_Point2f& nextPts, vector_uchar& status, vector_float& err, Size winSize = Size(21,21), int maxLevel = 3, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 0.01), int flags = 0, double minEigThreshold = 1e-4)
        [DllImport (LIBNAME)]
        private static extern void video_Video_calcOpticalFlowPyrLK_10 (IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_mat_nativeObj, IntPtr nextPts_mat_nativeObj, IntPtr status_mat_nativeObj, IntPtr err_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel, int criteria_type, int criteria_maxCount, double criteria_epsilon, int flags, double minEigThreshold);
        [DllImport (LIBNAME)]
        private static extern void video_Video_calcOpticalFlowPyrLK_11 (IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_mat_nativeObj, IntPtr nextPts_mat_nativeObj, IntPtr status_mat_nativeObj, IntPtr err_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel, int criteria_type, int criteria_maxCount, double criteria_epsilon, int flags);
        [DllImport (LIBNAME)]
        private static extern void video_Video_calcOpticalFlowPyrLK_12 (IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_mat_nativeObj, IntPtr nextPts_mat_nativeObj, IntPtr status_mat_nativeObj, IntPtr err_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport (LIBNAME)]
        private static extern void video_Video_calcOpticalFlowPyrLK_13 (IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_mat_nativeObj, IntPtr nextPts_mat_nativeObj, IntPtr status_mat_nativeObj, IntPtr err_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel);
        [DllImport (LIBNAME)]
        private static extern void video_Video_calcOpticalFlowPyrLK_14 (IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_mat_nativeObj, IntPtr nextPts_mat_nativeObj, IntPtr status_mat_nativeObj, IntPtr err_mat_nativeObj, double winSize_width, double winSize_height);
        [DllImport (LIBNAME)]
        private static extern void video_Video_calcOpticalFlowPyrLK_15 (IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_mat_nativeObj, IntPtr nextPts_mat_nativeObj, IntPtr status_mat_nativeObj, IntPtr err_mat_nativeObj);

    }
}
