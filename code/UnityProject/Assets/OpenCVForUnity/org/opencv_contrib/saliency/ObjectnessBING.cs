
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class ObjectnessBING
    //javadoc: ObjectnessBING

    public class ObjectnessBING : Objectness
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
saliency_ObjectnessBING_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal ObjectnessBING (IntPtr addr) : base (addr) { }

        // internal usage only
        public static new ObjectnessBING __fromPtr__ (IntPtr addr) { return new ObjectnessBING (addr); }

        //
        // C++: static Ptr_ObjectnessBING cv::saliency::ObjectnessBING::create()
        //

        //javadoc: ObjectnessBING::create()
        public static ObjectnessBING create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ObjectnessBING retVal = ObjectnessBING.__fromPtr__(saliency_ObjectnessBING_create_10());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  bool cv::saliency::ObjectnessBING::computeSaliency(Mat image, Mat& saliencyMap)
        //

        //javadoc: ObjectnessBING::computeSaliency(image, saliencyMap)
        public override bool computeSaliency (Mat image, Mat saliencyMap)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
            if (saliencyMap != null) saliencyMap.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = saliency_ObjectnessBING_computeSaliency_10(nativeObj, image.nativeObj, saliencyMap.nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  double cv::saliency::ObjectnessBING::getBase()
        //

        //javadoc: ObjectnessBING::getBase()
        public double getBase ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = saliency_ObjectnessBING_getBase_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::saliency::ObjectnessBING::getNSS()
        //

        //javadoc: ObjectnessBING::getNSS()
        public int getNSS ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = saliency_ObjectnessBING_getNSS_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int cv::saliency::ObjectnessBING::getW()
        //

        //javadoc: ObjectnessBING::getW()
        public int getW ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = saliency_ObjectnessBING_getW_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  vector_float cv::saliency::ObjectnessBING::getobjectnessValues()
        //

        //javadoc: ObjectnessBING::getobjectnessValues()
        public MatOfFloat getobjectnessValues ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        MatOfFloat retVal = MatOfFloat.fromNativeAddr(saliency_ObjectnessBING_getobjectnessValues_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  void cv::saliency::ObjectnessBING::read()
        //

        //javadoc: ObjectnessBING::read()
        public void read ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        saliency_ObjectnessBING_read_10(nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::saliency::ObjectnessBING::setBBResDir(String resultsDir)
        //

        //javadoc: ObjectnessBING::setBBResDir(resultsDir)
        public void setBBResDir (string resultsDir)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        saliency_ObjectnessBING_setBBResDir_10(nativeObj, resultsDir);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::saliency::ObjectnessBING::setBase(double val)
        //

        //javadoc: ObjectnessBING::setBase(val)
        public void setBase (double val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        saliency_ObjectnessBING_setBase_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::saliency::ObjectnessBING::setNSS(int val)
        //

        //javadoc: ObjectnessBING::setNSS(val)
        public void setNSS (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        saliency_ObjectnessBING_setNSS_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::saliency::ObjectnessBING::setTrainingPath(String trainingPath)
        //

        //javadoc: ObjectnessBING::setTrainingPath(trainingPath)
        public void setTrainingPath (string trainingPath)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        saliency_ObjectnessBING_setTrainingPath_10(nativeObj, trainingPath);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::saliency::ObjectnessBING::setW(int val)
        //

        //javadoc: ObjectnessBING::setW(val)
        public void setW (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        saliency_ObjectnessBING_setW_10(nativeObj, val);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void cv::saliency::ObjectnessBING::write()
        //

        //javadoc: ObjectnessBING::write()
        public void write ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        saliency_ObjectnessBING_write_10(nativeObj);
        
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



        // C++: static Ptr_ObjectnessBING cv::saliency::ObjectnessBING::create()
        [DllImport (LIBNAME)]
        private static extern IntPtr saliency_ObjectnessBING_create_10 ();

        // C++:  bool cv::saliency::ObjectnessBING::computeSaliency(Mat image, Mat& saliencyMap)
        [DllImport (LIBNAME)]
        private static extern bool saliency_ObjectnessBING_computeSaliency_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr saliencyMap_nativeObj);

        // C++:  double cv::saliency::ObjectnessBING::getBase()
        [DllImport (LIBNAME)]
        private static extern double saliency_ObjectnessBING_getBase_10 (IntPtr nativeObj);

        // C++:  int cv::saliency::ObjectnessBING::getNSS()
        [DllImport (LIBNAME)]
        private static extern int saliency_ObjectnessBING_getNSS_10 (IntPtr nativeObj);

        // C++:  int cv::saliency::ObjectnessBING::getW()
        [DllImport (LIBNAME)]
        private static extern int saliency_ObjectnessBING_getW_10 (IntPtr nativeObj);

        // C++:  vector_float cv::saliency::ObjectnessBING::getobjectnessValues()
        [DllImport (LIBNAME)]
        private static extern IntPtr saliency_ObjectnessBING_getobjectnessValues_10 (IntPtr nativeObj);

        // C++:  void cv::saliency::ObjectnessBING::read()
        [DllImport (LIBNAME)]
        private static extern void saliency_ObjectnessBING_read_10 (IntPtr nativeObj);

        // C++:  void cv::saliency::ObjectnessBING::setBBResDir(String resultsDir)
        [DllImport (LIBNAME)]
        private static extern void saliency_ObjectnessBING_setBBResDir_10 (IntPtr nativeObj, string resultsDir);

        // C++:  void cv::saliency::ObjectnessBING::setBase(double val)
        [DllImport (LIBNAME)]
        private static extern void saliency_ObjectnessBING_setBase_10 (IntPtr nativeObj, double val);

        // C++:  void cv::saliency::ObjectnessBING::setNSS(int val)
        [DllImport (LIBNAME)]
        private static extern void saliency_ObjectnessBING_setNSS_10 (IntPtr nativeObj, int val);

        // C++:  void cv::saliency::ObjectnessBING::setTrainingPath(String trainingPath)
        [DllImport (LIBNAME)]
        private static extern void saliency_ObjectnessBING_setTrainingPath_10 (IntPtr nativeObj, string trainingPath);

        // C++:  void cv::saliency::ObjectnessBING::setW(int val)
        [DllImport (LIBNAME)]
        private static extern void saliency_ObjectnessBING_setW_10 (IntPtr nativeObj, int val);

        // C++:  void cv::saliency::ObjectnessBING::write()
        [DllImport (LIBNAME)]
        private static extern void saliency_ObjectnessBING_write_10 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void saliency_ObjectnessBING_delete (IntPtr nativeObj);

    }
}
