
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class DualTVL1OpticalFlow
    //javadoc: DualTVL1OpticalFlow

    public class DualTVL1OpticalFlow : DenseOpticalFlow
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
video_DualTVL1OpticalFlow_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal DualTVL1OpticalFlow (IntPtr addr) : base (addr) { }

        // internal usage only
        public static new DualTVL1OpticalFlow __fromPtr__ (IntPtr addr) { return new DualTVL1OpticalFlow (addr); }

        //
        // C++: static Ptr_DualTVL1OpticalFlow cv::DualTVL1OpticalFlow::create(double tau = 0.25, double lambda = 0.15, double theta = 0.3, int nscales = 5, int warps = 5, double epsilon = 0.01, int innnerIterations = 30, int outerIterations = 10, double scaleStep = 0.8, double gamma = 0.0, int medianFiltering = 5, bool useInitialFlow = false)
        //

        //javadoc: DualTVL1OpticalFlow::create(tau, lambda, theta, nscales, warps, epsilon, innnerIterations, outerIterations, scaleStep, gamma, medianFiltering, useInitialFlow)
        public static DualTVL1OpticalFlow create (double tau, double lambda, double theta, int nscales, int warps, double epsilon, int innnerIterations, int outerIterations, double scaleStep, double gamma, int medianFiltering, bool useInitialFlow)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DualTVL1OpticalFlow retVal = DualTVL1OpticalFlow.__fromPtr__(video_DualTVL1OpticalFlow_create_10(tau, lambda, theta, nscales, warps, epsilon, innnerIterations, outerIterations, scaleStep, gamma, medianFiltering, useInitialFlow));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DualTVL1OpticalFlow::create(tau, lambda, theta, nscales, warps, epsilon, innnerIterations, outerIterations, scaleStep, gamma, medianFiltering)
        public static DualTVL1OpticalFlow create (double tau, double lambda, double theta, int nscales, int warps, double epsilon, int innnerIterations, int outerIterations, double scaleStep, double gamma, int medianFiltering)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DualTVL1OpticalFlow retVal = DualTVL1OpticalFlow.__fromPtr__(video_DualTVL1OpticalFlow_create_11(tau, lambda, theta, nscales, warps, epsilon, innnerIterations, outerIterations, scaleStep, gamma, medianFiltering));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DualTVL1OpticalFlow::create(tau, lambda, theta, nscales, warps, epsilon, innnerIterations, outerIterations, scaleStep, gamma)
        public static DualTVL1OpticalFlow create (double tau, double lambda, double theta, int nscales, int warps, double epsilon, int innnerIterations, int outerIterations, double scaleStep, double gamma)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DualTVL1OpticalFlow retVal = DualTVL1OpticalFlow.__fromPtr__(video_DualTVL1OpticalFlow_create_12(tau, lambda, theta, nscales, warps, epsilon, innnerIterations, outerIterations, scaleStep, gamma));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DualTVL1OpticalFlow::create(tau, lambda, theta, nscales, warps, epsilon, innnerIterations, outerIterations, scaleStep)
        public static DualTVL1OpticalFlow create (double tau, double lambda, double theta, int nscales, int warps, double epsilon, int innnerIterations, int outerIterations, double scaleStep)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DualTVL1OpticalFlow retVal = DualTVL1OpticalFlow.__fromPtr__(video_DualTVL1OpticalFlow_create_13(tau, lambda, theta, nscales, warps, epsilon, innnerIterations, outerIterations, scaleStep));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DualTVL1OpticalFlow::create(tau, lambda, theta, nscales, warps, epsilon, innnerIterations, outerIterations)
        public static DualTVL1OpticalFlow create (double tau, double lambda, double theta, int nscales, int warps, double epsilon, int innnerIterations, int outerIterations)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DualTVL1OpticalFlow retVal = DualTVL1OpticalFlow.__fromPtr__(video_DualTVL1OpticalFlow_create_14(tau, lambda, theta, nscales, warps, epsilon, innnerIterations, outerIterations));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DualTVL1OpticalFlow::create(tau, lambda, theta, nscales, warps, epsilon, innnerIterations)
        public static DualTVL1OpticalFlow create (double tau, double lambda, double theta, int nscales, int warps, double epsilon, int innnerIterations)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DualTVL1OpticalFlow retVal = DualTVL1OpticalFlow.__fromPtr__(video_DualTVL1OpticalFlow_create_15(tau, lambda, theta, nscales, warps, epsilon, innnerIterations));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DualTVL1OpticalFlow::create(tau, lambda, theta, nscales, warps, epsilon)
        public static DualTVL1OpticalFlow create (double tau, double lambda, double theta, int nscales, int warps, double epsilon)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DualTVL1OpticalFlow retVal = DualTVL1OpticalFlow.__fromPtr__(video_DualTVL1OpticalFlow_create_16(tau, lambda, theta, nscales, warps, epsilon));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DualTVL1OpticalFlow::create(tau, lambda, theta, nscales, warps)
        public static DualTVL1OpticalFlow create (double tau, double lambda, double theta, int nscales, int warps)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DualTVL1OpticalFlow retVal = DualTVL1OpticalFlow.__fromPtr__(video_DualTVL1OpticalFlow_create_17(tau, lambda, theta, nscales, warps));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DualTVL1OpticalFlow::create(tau, lambda, theta, nscales)
        public static DualTVL1OpticalFlow create (double tau, double lambda, double theta, int nscales)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DualTVL1OpticalFlow retVal = DualTVL1OpticalFlow.__fromPtr__(video_DualTVL1OpticalFlow_create_18(tau, lambda, theta, nscales));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DualTVL1OpticalFlow::create(tau, lambda, theta)
        public static DualTVL1OpticalFlow create (double tau, double lambda, double theta)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DualTVL1OpticalFlow retVal = DualTVL1OpticalFlow.__fromPtr__(video_DualTVL1OpticalFlow_create_19(tau, lambda, theta));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DualTVL1OpticalFlow::create(tau, lambda)
        public static DualTVL1OpticalFlow create (double tau, double lambda)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DualTVL1OpticalFlow retVal = DualTVL1OpticalFlow.__fromPtr__(video_DualTVL1OpticalFlow_create_110(tau, lambda));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DualTVL1OpticalFlow::create(tau)
        public static DualTVL1OpticalFlow create (double tau)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DualTVL1OpticalFlow retVal = DualTVL1OpticalFlow.__fromPtr__(video_DualTVL1OpticalFlow_create_111(tau));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: DualTVL1OpticalFlow::create()
        public static DualTVL1OpticalFlow create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DualTVL1OpticalFlow retVal = DualTVL1OpticalFlow.__fromPtr__(video_DualTVL1OpticalFlow_create_112());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::DualTVL1OpticalFlow::getUseInitialFlow()
        //

        //javadoc: DualTVL1OpticalFlow::getUseInitialFlow()
        public bool getUseInitialFlow ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = video_DualTVL1OpticalFlow_getUseInitialFlow_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  double cv::DualTVL1OpticalFlow::getEpsilon()
        //

        //javadoc: DualTVL1OpticalFlow::getEpsilon()
        public double getEpsilon ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_DualTVL1OpticalFlow_getEpsilon_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::DualTVL1OpticalFlow::getGamma()
        //

        //javadoc: DualTVL1OpticalFlow::getGamma()
        public double getGamma ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_DualTVL1OpticalFlow_getGamma_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::DualTVL1OpticalFlow::getLambda()
        //

        //javadoc: DualTVL1OpticalFlow::getLambda()
        public double getLambda ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_DualTVL1OpticalFlow_getLambda_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::DualTVL1OpticalFlow::getScaleStep()
        //

        //javadoc: DualTVL1OpticalFlow::getScaleStep()
        public double getScaleStep ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_DualTVL1OpticalFlow_getScaleStep_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::DualTVL1OpticalFlow::getTau()
        //

        //javadoc: DualTVL1OpticalFlow::getTau()
        public double getTau ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_DualTVL1OpticalFlow_getTau_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  double cv::DualTVL1OpticalFlow::getTheta()
        //

        //javadoc: DualTVL1OpticalFlow::getTheta()
        public double getTheta ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_DualTVL1OpticalFlow_getTheta_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::DualTVL1OpticalFlow::getInnerIterations()
        //

        //javadoc: DualTVL1OpticalFlow::getInnerIterations()
        public int getInnerIterations ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_DualTVL1OpticalFlow_getInnerIterations_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::DualTVL1OpticalFlow::getMedianFiltering()
        //

        //javadoc: DualTVL1OpticalFlow::getMedianFiltering()
        public int getMedianFiltering ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_DualTVL1OpticalFlow_getMedianFiltering_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::DualTVL1OpticalFlow::getOuterIterations()
        //

        //javadoc: DualTVL1OpticalFlow::getOuterIterations()
        public int getOuterIterations ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_DualTVL1OpticalFlow_getOuterIterations_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::DualTVL1OpticalFlow::getScalesNumber()
        //

        //javadoc: DualTVL1OpticalFlow::getScalesNumber()
        public int getScalesNumber ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_DualTVL1OpticalFlow_getScalesNumber_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::DualTVL1OpticalFlow::getWarpingsNumber()
        //

        //javadoc: DualTVL1OpticalFlow::getWarpingsNumber()
        public int getWarpingsNumber ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_DualTVL1OpticalFlow_getWarpingsNumber_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::DualTVL1OpticalFlow::setEpsilon(double val)
        //

        //javadoc: DualTVL1OpticalFlow::setEpsilon(val)
        public void setEpsilon (double val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setEpsilon_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DualTVL1OpticalFlow::setGamma(double val)
        //

        //javadoc: DualTVL1OpticalFlow::setGamma(val)
        public void setGamma (double val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setGamma_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DualTVL1OpticalFlow::setInnerIterations(int val)
        //

        //javadoc: DualTVL1OpticalFlow::setInnerIterations(val)
        public void setInnerIterations (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setInnerIterations_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DualTVL1OpticalFlow::setLambda(double val)
        //

        //javadoc: DualTVL1OpticalFlow::setLambda(val)
        public void setLambda (double val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setLambda_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DualTVL1OpticalFlow::setMedianFiltering(int val)
        //

        //javadoc: DualTVL1OpticalFlow::setMedianFiltering(val)
        public void setMedianFiltering (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setMedianFiltering_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DualTVL1OpticalFlow::setOuterIterations(int val)
        //

        //javadoc: DualTVL1OpticalFlow::setOuterIterations(val)
        public void setOuterIterations (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setOuterIterations_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DualTVL1OpticalFlow::setScaleStep(double val)
        //

        //javadoc: DualTVL1OpticalFlow::setScaleStep(val)
        public void setScaleStep (double val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setScaleStep_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DualTVL1OpticalFlow::setScalesNumber(int val)
        //

        //javadoc: DualTVL1OpticalFlow::setScalesNumber(val)
        public void setScalesNumber (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setScalesNumber_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DualTVL1OpticalFlow::setTau(double val)
        //

        //javadoc: DualTVL1OpticalFlow::setTau(val)
        public void setTau (double val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setTau_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DualTVL1OpticalFlow::setTheta(double val)
        //

        //javadoc: DualTVL1OpticalFlow::setTheta(val)
        public void setTheta (double val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setTheta_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DualTVL1OpticalFlow::setUseInitialFlow(bool val)
        //

        //javadoc: DualTVL1OpticalFlow::setUseInitialFlow(val)
        public void setUseInitialFlow (bool val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setUseInitialFlow_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::DualTVL1OpticalFlow::setWarpingsNumber(int val)
        //

        //javadoc: DualTVL1OpticalFlow::setWarpingsNumber(val)
        public void setWarpingsNumber (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setWarpingsNumber_10(nativeObj, val);
        
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



        // C++: static Ptr_DualTVL1OpticalFlow cv::DualTVL1OpticalFlow::create(double tau = 0.25, double lambda = 0.15, double theta = 0.3, int nscales = 5, int warps = 5, double epsilon = 0.01, int innnerIterations = 30, int outerIterations = 10, double scaleStep = 0.8, double gamma = 0.0, int medianFiltering = 5, bool useInitialFlow = false)
        [DllImport (LIBNAME)]
        private static extern IntPtr video_DualTVL1OpticalFlow_create_10 (double tau, double lambda, double theta, int nscales, int warps, double epsilon, int innnerIterations, int outerIterations, double scaleStep, double gamma, int medianFiltering, bool useInitialFlow);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_DualTVL1OpticalFlow_create_11 (double tau, double lambda, double theta, int nscales, int warps, double epsilon, int innnerIterations, int outerIterations, double scaleStep, double gamma, int medianFiltering);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_DualTVL1OpticalFlow_create_12 (double tau, double lambda, double theta, int nscales, int warps, double epsilon, int innnerIterations, int outerIterations, double scaleStep, double gamma);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_DualTVL1OpticalFlow_create_13 (double tau, double lambda, double theta, int nscales, int warps, double epsilon, int innnerIterations, int outerIterations, double scaleStep);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_DualTVL1OpticalFlow_create_14 (double tau, double lambda, double theta, int nscales, int warps, double epsilon, int innnerIterations, int outerIterations);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_DualTVL1OpticalFlow_create_15 (double tau, double lambda, double theta, int nscales, int warps, double epsilon, int innnerIterations);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_DualTVL1OpticalFlow_create_16 (double tau, double lambda, double theta, int nscales, int warps, double epsilon);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_DualTVL1OpticalFlow_create_17 (double tau, double lambda, double theta, int nscales, int warps);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_DualTVL1OpticalFlow_create_18 (double tau, double lambda, double theta, int nscales);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_DualTVL1OpticalFlow_create_19 (double tau, double lambda, double theta);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_DualTVL1OpticalFlow_create_110 (double tau, double lambda);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_DualTVL1OpticalFlow_create_111 (double tau);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_DualTVL1OpticalFlow_create_112 ();

        // C++:  bool cv::DualTVL1OpticalFlow::getUseInitialFlow()
        [DllImport (LIBNAME)]
        private static extern bool video_DualTVL1OpticalFlow_getUseInitialFlow_10 (IntPtr nativeObj);

        // C++:  double cv::DualTVL1OpticalFlow::getEpsilon()
        [DllImport (LIBNAME)]
        private static extern double video_DualTVL1OpticalFlow_getEpsilon_10 (IntPtr nativeObj);

        // C++:  double cv::DualTVL1OpticalFlow::getGamma()
        [DllImport (LIBNAME)]
        private static extern double video_DualTVL1OpticalFlow_getGamma_10 (IntPtr nativeObj);

        // C++:  double cv::DualTVL1OpticalFlow::getLambda()
        [DllImport (LIBNAME)]
        private static extern double video_DualTVL1OpticalFlow_getLambda_10 (IntPtr nativeObj);

        // C++:  double cv::DualTVL1OpticalFlow::getScaleStep()
        [DllImport (LIBNAME)]
        private static extern double video_DualTVL1OpticalFlow_getScaleStep_10 (IntPtr nativeObj);

        // C++:  double cv::DualTVL1OpticalFlow::getTau()
        [DllImport (LIBNAME)]
        private static extern double video_DualTVL1OpticalFlow_getTau_10 (IntPtr nativeObj);

        // C++:  double cv::DualTVL1OpticalFlow::getTheta()
        [DllImport (LIBNAME)]
        private static extern double video_DualTVL1OpticalFlow_getTheta_10 (IntPtr nativeObj);

        // C++:  int cv::DualTVL1OpticalFlow::getInnerIterations()
        [DllImport (LIBNAME)]
        private static extern int video_DualTVL1OpticalFlow_getInnerIterations_10 (IntPtr nativeObj);

        // C++:  int cv::DualTVL1OpticalFlow::getMedianFiltering()
        [DllImport (LIBNAME)]
        private static extern int video_DualTVL1OpticalFlow_getMedianFiltering_10 (IntPtr nativeObj);

        // C++:  int cv::DualTVL1OpticalFlow::getOuterIterations()
        [DllImport (LIBNAME)]
        private static extern int video_DualTVL1OpticalFlow_getOuterIterations_10 (IntPtr nativeObj);

        // C++:  int cv::DualTVL1OpticalFlow::getScalesNumber()
        [DllImport (LIBNAME)]
        private static extern int video_DualTVL1OpticalFlow_getScalesNumber_10 (IntPtr nativeObj);

        // C++:  int cv::DualTVL1OpticalFlow::getWarpingsNumber()
        [DllImport (LIBNAME)]
        private static extern int video_DualTVL1OpticalFlow_getWarpingsNumber_10 (IntPtr nativeObj);

        // C++:  void cv::DualTVL1OpticalFlow::setEpsilon(double val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setEpsilon_10 (IntPtr nativeObj, double val);

        // C++:  void cv::DualTVL1OpticalFlow::setGamma(double val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setGamma_10 (IntPtr nativeObj, double val);

        // C++:  void cv::DualTVL1OpticalFlow::setInnerIterations(int val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setInnerIterations_10 (IntPtr nativeObj, int val);

        // C++:  void cv::DualTVL1OpticalFlow::setLambda(double val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setLambda_10 (IntPtr nativeObj, double val);

        // C++:  void cv::DualTVL1OpticalFlow::setMedianFiltering(int val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setMedianFiltering_10 (IntPtr nativeObj, int val);

        // C++:  void cv::DualTVL1OpticalFlow::setOuterIterations(int val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setOuterIterations_10 (IntPtr nativeObj, int val);

        // C++:  void cv::DualTVL1OpticalFlow::setScaleStep(double val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setScaleStep_10 (IntPtr nativeObj, double val);

        // C++:  void cv::DualTVL1OpticalFlow::setScalesNumber(int val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setScalesNumber_10 (IntPtr nativeObj, int val);

        // C++:  void cv::DualTVL1OpticalFlow::setTau(double val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setTau_10 (IntPtr nativeObj, double val);

        // C++:  void cv::DualTVL1OpticalFlow::setTheta(double val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setTheta_10 (IntPtr nativeObj, double val);

        // C++:  void cv::DualTVL1OpticalFlow::setUseInitialFlow(bool val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setUseInitialFlow_10 (IntPtr nativeObj, bool val);

        // C++:  void cv::DualTVL1OpticalFlow::setWarpingsNumber(int val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setWarpingsNumber_10 (IntPtr nativeObj, int val);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_delete (IntPtr nativeObj);

    }
}
