using System;
using Android.Runtime;

namespace Com.Facebook.React.Modules.Network
{
    public partial class ForwardingCookieHandler
    {
        static IntPtr id_get_Ljava_net_URI_Ljava_util_Map_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.react.modules.network']/class[@name='ForwardingCookieHandler']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.net.URI'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;']]"
        [Register("get", "(Ljava/net/URI;Ljava/util/Map;)Ljava/util/Map;", "GetGet_Ljava_net_URI_Ljava_util_Map_Handler")]
        public override unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> Get(global::Java.Net.URI p0, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p1)
        {
            if (id_get_Ljava_net_URI_Ljava_util_Map_ == IntPtr.Zero)
                id_get_Ljava_net_URI_Ljava_util_Map_ = JNIEnv.GetMethodID(class_ref, "get", "(Ljava/net/URI;Ljava/util/Map;)Ljava/util/Map;");
            IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle(p1);
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(native_p1);

                global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> __ret;
                if (GetType() == ThresholdType)
                    __ret = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_Ljava_net_URI_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
                else
                    __ret = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(Ljava/net/URI;Ljava/util/Map;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p1);
            }
        }

        static IntPtr id_put_Ljava_net_URI_Ljava_util_Map_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.react.modules.network']/class[@name='ForwardingCookieHandler']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.net.URI'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;']]"
        [Register("put", "(Ljava/net/URI;Ljava/util/Map;)V", "GetPut_Ljava_net_URI_Ljava_util_Map_Handler")]
        public override unsafe void Put(global::Java.Net.URI p0, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p1)
        {
            if (id_put_Ljava_net_URI_Ljava_util_Map_ == IntPtr.Zero)
                id_put_Ljava_net_URI_Ljava_util_Map_ = JNIEnv.GetMethodID(class_ref, "put", "(Ljava/net/URI;Ljava/util/Map;)V");
            IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle(p1);
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(native_p1);

                if (GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_put_Ljava_net_URI_Ljava_util_Map_, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "put", "(Ljava/net/URI;Ljava/util/Map;)V"), __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p1);
            }
        }
    }
}