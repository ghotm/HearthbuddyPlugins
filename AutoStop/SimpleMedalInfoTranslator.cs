using System;
using System.Reflection;
using Triton.Common;
using Triton.Game.Mapping;

namespace Triton.Game.Mono
{
    public class SimpleMedalInfoTranslator : MonoBehaviour
    {
        // Token: 0x06007BB6 RID: 31670 RVA: 0x0001388D File Offset: 0x00011A8D
        public SimpleMedalInfoTranslator(IntPtr address, string className) : base(address, className)
        {
        }

        // Token: 0x06007BB7 RID: 31671 RVA: 0x0006A517 File Offset: 0x00068717
        public SimpleMedalInfoTranslator(IntPtr address) : this(address, "MedalInfoTranslator")
        {
        }

        public SimplTranslatedMedalInfo GetCurrentMedal(bool useWildMedal)
        {
            MethodInfo method7 = this.GetType().GetMethod("method_7", BindingFlags.Instance | BindingFlags.NonPublic);
            IntPtr intPtr = (IntPtr) method7.Invoke(this,
                new object[] {"GetCurrentMedal", null, new object[] {useWildMedal}});
            if (intPtr == IntPtr.Zero)
            {
                return default(SimplTranslatedMedalInfo);
            }

            return FastObjectFactory.CreateObjectInstance<SimplTranslatedMedalInfo>(intPtr);
        }

        public int TotalRankedWins
        {
            get
            {
                //                return base.method_11<int>("get_TotalRankedWins", Array.Empty<object>());
                MethodInfo method = this.GetType().GetMethod("method_11", BindingFlags.Instance | BindingFlags.NonPublic);
                MethodInfo genericMethod = method.MakeGenericMethod(typeof(int));
                return (int)genericMethod.Invoke(this, new object[] { "get_TotalRankedWins", Array.Empty<object>() });
            }
        }

        // Token: 0x170006DD RID: 1757
        // (get) Token: 0x060056E8 RID: 22248 RVA: 0x002A9E00 File Offset: 0x002A8200
        public int TotalRankedWinsPrevious
        {
            get
            {
                MethodInfo method = this.GetType().GetMethod("method_11", BindingFlags.Instance | BindingFlags.NonPublic);
                MethodInfo genericMethod = method.MakeGenericMethod(typeof(int));
                return (int)genericMethod.Invoke(this, new object[] { "get_TotalRankedWinsPrevious", Array.Empty<object>() });
            }
        }

        // Token: 0x170006DE RID: 1758
        // (get) Token: 0x060056E9 RID: 22249 RVA: 0x002A9E19 File Offset: 0x002A8219
        public int TotalRankedGames
        {
            get
            {
                MethodInfo method = this.GetType().GetMethod("method_11", BindingFlags.Instance | BindingFlags.NonPublic);
                MethodInfo genericMethod = method.MakeGenericMethod(typeof(int));
                return (int)genericMethod.Invoke(this, new object[] { "get_TotalRankedGames", Array.Empty<object>() });
            }
        }

        // Token: 0x170006DF RID: 1759
        // (get) Token: 0x060056EA RID: 22250 RVA: 0x002A9E32 File Offset: 0x002A8232
        public int TotalRankedGamesPrevious
        {
            get
            {
                MethodInfo method = this.GetType().GetMethod("method_11", BindingFlags.Instance | BindingFlags.NonPublic);
                MethodInfo genericMethod = method.MakeGenericMethod(typeof(int));
                return (int)genericMethod.Invoke(this, new object[] { "get_TotalRankedGamesPrevious", Array.Empty<object>() });
            }
        }

        // Token: 0x060056EB RID: 22251 RVA: 0x002A9E4C File Offset: 0x002A824C
        public bool IsDisplayable()
        {
//            return InvokeMethodByRetStruct<bool>("IsDisplayable");
            MethodInfo method = this.GetType().GetMethod("method_11", BindingFlags.Instance | BindingFlags.NonPublic);
            MethodInfo genericMethod = method.MakeGenericMethod(typeof(bool));
            return (bool)genericMethod.Invoke(this, new object[] { "IsDisplayable", Array.Empty<object>() });
        }


    }
}