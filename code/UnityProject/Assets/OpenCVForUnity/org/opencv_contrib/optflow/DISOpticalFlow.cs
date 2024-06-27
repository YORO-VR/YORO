
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class DISOpticalFlow
    //javadoc: DISOpticalFlow

    public class DISOpticalFlow : DenseOpticalFlow
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
optflow_DISOpticalFlow_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal DISOpticalFlow (IntPtr addr) : base (addr) { }

        // internal usage only
        public static new DISOpticalFlow __fromPtr__ (IntPtr addr) { return new DISOpticalFlow (addr); }

        public const int PRESET_ULTRAFAST = 0;
        public const int PRESET_FAST = 1;
        public const int PRESET_MEDIUM = 2;
        //
        // C++:  bool cv::optflow::DISOpticalFlow::getUseMeanNormalization()
        //

        //javadoc: DISOpticalFlow::getUseMeanNormalization()
        public bool getUseMeanNormalization ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = optflow_DISOpticalFlow_getUseMeanNormalization_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool cv::optflow::DISOpticalFlow::getUseSpatialPropagation()
        //

        //javadoc: DISOpticalFlow::getUseSpatialPropagation()
        public bool getUseSpatialPropagation ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = optflow_DISOpticalFlow_getUseSpatialPropagation_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  float cv::optflow::DISOpticalFlow::getVariationalRefinementAlpha()
        //

        //javadoc: DISOpticalFlow::getVariationalRefinementAlpha()
        public float getVariationalRefinementAlpha ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = optflow_DISOpticalFlow_getVariationalRefinementAlpha_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::optflow::DISOpticalFlow::getVariationalRefinementDelta()
        //

        //javadoc: DISOpticalFlow::getVariationalRefinementDelta()
        public float getVariationalRefinementDelta ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = optflow_DISOpticalFlow_getVariationalRefinementDelta_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  float cv::optflow::DISOpticalFlow::getVariationalRefinementGamma()
        //

        //javadoc: DISOpticalFlow::getVariationalRefinementGamma()
        public float getVariationalRefinementGamma ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = optflow_DISOpticalFlow_getVariationalRefinementGamma_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::optflow::DISOpticalFlow::getFinestScale()
        //

        //javadoc: DISOpticalFlow::getFinestScale()
        public int getFinestScale ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = optflow_DISOpticalFlow_getFinestScale_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::optflow::DISOpticalFlow::getGradientDescentIterations()
        //

        //javadoc: DISOpticalFlow::getGradientDescentIterations()
        public int getGradientDescentIterations ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = optflow_DISOpticalFlow_getGradientDescentIterations_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::optflow::DISOpticalFlow::getPatchSize()
        //

        //javadoc: DISOpticalFlow::getPatchSize()
        public int getPatchSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = optflow_DISOpticalFlow_getPatchSize_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::optflow::DISOpticalFlow::getPatchStride()
        //

        //javadoc: DISOpticalFlow::getPatchStride()
        public int getPatchStride ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = optflow_DISOpticalFlow_getPatchStride_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::optflow::DISOpticalFlow::getVariationalRefinementIterations()
        //

        //javadoc: DISOpticalFlow::getVariationalRefinementIterations()
        public int getVariationalRefinementIterations ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = optflow_DISOpticalFlow_getVariationalRefinementIterations_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void cv::optflow::DISOpticalFlow::setFinestScale(int val)
        //

        //javadoc: DISOpticalFlow::setFinestScale(val)
        public void setFinestScale (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_DISOpticalFlow_setFinestScale_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::optflow::DISOpticalFlow::setGradientDescentIterations(int val)
        //

        //javadoc: DISOpticalFlow::setGradientDescentIterations(val)
        public void setGradientDescentIterations (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_DISOpticalFlow_setGradientDescentIterations_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::optflow::DISOpticalFlow::setPatchSize(int val)
        //

        //javadoc: DISOpticalFlow::setPatchSize(val)
        public void setPatchSize (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_DISOpticalFlow_setPatchSize_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::optflow::DISOpticalFlow::setPatchStride(int val)
        //

        //javadoc: DISOpticalFlow::setPatchStride(val)
        public void setPatchStride (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_DISOpticalFlow_setPatchStride_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::optflow::DISOpticalFlow::setUseMeanNormalization(bool val)
        //

        //javadoc: DISOpticalFlow::setUseMeanNormalization(val)
        public void setUseMeanNormalization (bool val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_DISOpticalFlow_setUseMeanNormalization_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::optflow::DISOpticalFlow::setUseSpatialPropagation(bool val)
        //

        //javadoc: DISOpticalFlow::setUseSpatialPropagation(val)
        public void setUseSpatialPropagation (bool val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_DISOpticalFlow_setUseSpatialPropagation_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::optflow::DISOpticalFlow::setVariationalRefinementAlpha(float val)
        //

        //javadoc: DISOpticalFlow::setVariationalRefinementAlpha(val)
        public void setVariationalRefinementAlpha (float val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_DISOpticalFlow_setVariationalRefinementAlpha_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::optflow::DISOpticalFlow::setVariationalRefinementDelta(float val)
        //

        //javadoc: DISOpticalFlow::setVariationalRefinementDelta(val)
        public void setVariationalRefinementDelta (float val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_DISOpticalFlow_setVariationalRefinementDelta_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::optflow::DISOpticalFlow::setVariationalRefinementGamma(float val)
        //

        //javadoc: DISOpticalFlow::setVariationalRefinementGamma(val)
        public void setVariationalRefinementGamma (float val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_DISOpticalFlow_setVariationalRefinementGamma_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::optflow::DISOpticalFlow::setVariationalRefinementIterations(int val)
        //

        //javadoc: DISOpticalFlow::setVariationalRefinementIterations(val)
        public void setVariationalRefinementIterations (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_DISOpticalFlow_setVariationalRefinementIterations_10(nativeObj, val);
        
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



        // C++:  bool cv::optflow::DISOpticalFlow::getUseMeanNormalization()
        [DllImport (LIBNAME)]
        private static extern bool optflow_DISOpticalFlow_getUseMeanNormalization_10 (IntPtr nativeObj);

        // C++:  bool cv::optflow::DISOpticalFlow::getUseSpatialPropagation()
        [DllImport (LIBNAME)]
        private static extern bool optflow_DISOpticalFlow_getUseSpatialPropagation_10 (IntPtr nativeObj);

        // C++:  float cv::optflow::DISOpticalFlow::getVariationalRefinementAlpha()
        [DllImport (LIBNAME)]
        private static extern float optflow_DISOpticalFlow_getVariationalRefinementAlpha_10 (IntPtr nativeObj);

        // C++:  float cv::optflow::DISOpticalFlow::getVariationalRefinementDelta()
        [DllImport (LIBNAME)]
        private static extern float optflow_DISOpticalFlow_getVariationalRefinementDelta_10 (IntPtr nativeObj);

        // C++:  float cv::optflow::DISOpticalFlow::getVariationalRefinementGamma()
        [DllImport (LIBNAME)]
        private static extern float optflow_DISOpticalFlow_getVariationalRefinementGamma_10 (IntPtr nativeObj);

        // C++:  int cv::optflow::DISOpticalFlow::getFinestScale()
        [DllImport (LIBNAME)]
        private static extern int optflow_DISOpticalFlow_getFinestScale_10 (IntPtr nativeObj);

        // C++:  int cv::optflow::DISOpticalFlow::getGradientDescentIterations()
        [DllImport (LIBNAME)]
        private static extern int optflow_DISOpticalFlow_getGradientDescentIterations_10 (IntPtr nativeObj);

        // C++:  int cv::optflow::DISOpticalFlow::getPatchSize()
        [DllImport (LIBNAME)]
        private static extern int optflow_DISOpticalFlow_getPatchSize_10 (IntPtr nativeObj);

        // C++:  int cv::optflow::DISOpticalFlow::getPatchStride()
        [DllImport (LIBNAME)]
        private static extern int optflow_DISOpticalFlow_getPatchStride_10 (IntPtr nativeObj);

        // C++:  int cv::optflow::DISOpticalFlow::getVariationalRefinementIterations()
        [DllImport (LIBNAME)]
        private static extern int optflow_DISOpticalFlow_getVariationalRefinementIterations_10 (IntPtr nativeObj);

        // C++:  void cv::optflow::DISOpticalFlow::setFinestScale(int val)
        [DllImport (LIBNAME)]
        private static extern void optflow_DISOpticalFlow_setFinestScale_10 (IntPtr nativeObj, int val);

        // C++:  void cv::optflow::DISOpticalFlow::setGradientDescentIterations(int val)
        [DllImport (LIBNAME)]
        private static extern void optflow_DISOpticalFlow_setGradientDescentIterations_10 (IntPtr nativeObj, int val);

        // C++:  void cv::optflow::DISOpticalFlow::setPatchSize(int val)
        [DllImport (LIBNAME)]
        private static extern void optflow_DISOpticalFlow_setPatchSize_10 (IntPtr nativeObj, int val);

        // C++:  void cv::optflow::DISOpticalFlow::setPatchStride(int val)
        [DllImport (LIBNAME)]
        private static extern void optflow_DISOpticalFlow_setPatchStride_10 (IntPtr nativeObj, int val);

        // C++:  void cv::optflow::DISOpticalFlow::setUseMeanNormalization(bool val)
        [DllImport (LIBNAME)]
        private static extern void optflow_DISOpticalFlow_setUseMeanNormalization_10 (IntPtr nativeObj, bool val);

        // C++:  void cv::optflow::DISOpticalFlow::setUseSpatialPropagation(bool val)
        [DllImport (LIBNAME)]
        private static extern void optflow_DISOpticalFlow_setUseSpatialPropagation_10 (IntPtr nativeObj, bool val);

        // C++:  void cv::optflow::DISOpticalFlow::setVariationalRefinementAlpha(float val)
        [DllImport (LIBNAME)]
        private static extern void optflow_DISOpticalFlow_setVariationalRefinementAlpha_10 (IntPtr nativeObj, float val);

        // C++:  void cv::optflow::DISOpticalFlow::setVariationalRefinementDelta(float val)
        [DllImport (LIBNAME)]
        private static extern void optflow_DISOpticalFlow_setVariationalRefinementDelta_10 (IntPtr nativeObj, float val);

        // C++:  void cv::optflow::DISOpticalFlow::setVariationalRefinementGamma(float val)
        [DllImport (LIBNAME)]
        private static extern void optflow_DISOpticalFlow_setVariationalRefinementGamma_10 (IntPtr nativeObj, float val);

        // C++:  void cv::optflow::DISOpticalFlow::setVariationalRefinementIterations(int val)
        [DllImport (LIBNAME)]
        private static extern void optflow_DISOpticalFlow_setVariationalRefinementIterations_10 (IntPtr nativeObj, int val);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void optflow_DISOpticalFlow_delete (IntPtr nativeObj);

    }
}
