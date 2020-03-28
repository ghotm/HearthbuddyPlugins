using System;
using System.Reflection;
using Triton.Common;
using Triton.Game.Mapping;
using Triton.Game.Mono;

namespace Triton.Game.Mono
{
    public class SimpleRankMgr : MonoBehaviour
    {
        public SimpleRankMgr(IntPtr address, string className) : base(address, className)
        {
        }

        // Token: 0x06007BB7 RID: 31671 RVA: 0x0006A517 File Offset: 0x00068717
        public SimpleRankMgr(IntPtr address) : this(address, "RankMgr")
        {
        }

        public SimpleMedalInfoTranslator GetLocalPlayerMedalInfo()
        {
            MethodInfo method7 = this.GetType().GetMethod("method_7", BindingFlags.Instance | BindingFlags.NonPublic);
            IntPtr intPtr = (IntPtr) method7.Invoke(this,
                new object[] {"GetLocalPlayerMedalInfo", null, Array.Empty<object>()});
            if (intPtr == IntPtr.Zero)
            {
                return default(SimpleMedalInfoTranslator);
            }

            return FastObjectFactory.CreateObjectInstance<SimpleMedalInfoTranslator>(intPtr);
        }


        public static SimpleRankMgr Get()
        {
            MethodInfo smethod15 = typeof(MonoClass).GetMethod("smethod_15",
                BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);
            MethodInfo smethod15Generic = smethod15.MakeGenericMethod(typeof(SimpleRankMgr));
            return (SimpleRankMgr) smethod15Generic.Invoke(null,
                new object[] {TritonHs.MainAssemblyPath, "", "RankMgr", "Get", Array.Empty<object>()});
            //            return MonoClass.smethod_15<SimpleRankMgr>(TritonHs.MainAssemblyPath, "", "RankMgr", "Get", Array.Empty<object>());
        }

        private T InvokeMethodByRetClass<T>(string methodName) where T : class
        {
            IntPtr intPtr = MonoClassInternalMethod5(methodName);
            if (intPtr == IntPtr.Zero)
            {
                return default(T);
            }

            return FastObjectFactory.CreateObjectInstance<T>(intPtr);
        }

        private IntPtr MonoClassInternalMethod5(string methodName)
        {
            MethodInfo method = this.GetType().GetMethod("method_5", BindingFlags.Instance | BindingFlags.NonPublic);
            MethodInfo finalMethod = method;
            return (IntPtr) finalMethod.Invoke(this, new Object[] {methodName});
        }
    }
}