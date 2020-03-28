using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Triton.Game.Mapping;

namespace Triton.Game.Mono
{
    public class SimplTranslatedMedalInfo : MonoBehaviour
    {
        // Token: 0x06007BB6 RID: 31670 RVA: 0x0001388D File Offset: 0x00011A8D
        public SimplTranslatedMedalInfo(IntPtr address, string className) : base(address, className)
        {
        }

        // Token: 0x06007BB7 RID: 31671 RVA: 0x0006A517 File Offset: 0x00068717
        public SimplTranslatedMedalInfo(IntPtr address) : this(address, "TranslatedMedalInfo")
        {
        }

        //排名名称
        public string GetRankName()
        {
            MethodInfo method = this.GetType().GetMethod("method_13", BindingFlags.Instance | BindingFlags.NonPublic);
            return (string) method.Invoke(this, new object[] {"GetRankName", Array.Empty<object>()});
        }

        //旧版排名
        public int GetLegacyRankNumber()
        {
            MethodInfo method = this.GetType().GetMethod("method_11", BindingFlags.Instance | BindingFlags.NonPublic);
            MethodInfo genericMethod = method.MakeGenericMethod(typeof(int));
            return (int) genericMethod.Invoke(this, new object[] {"GetLegacyRankNumber", Array.Empty<object>()});
        }

        //最大星数(一般用不上)
        public int GetMaxStarsAtRank()
        {
            MethodInfo method = this.GetType().GetMethod("method_11", BindingFlags.Instance | BindingFlags.NonPublic);
            MethodInfo genericMethod = method.MakeGenericMethod(typeof(int));
            return (int) genericMethod.Invoke(this, new object[] {"GetMaxStarsAtRank", Array.Empty<object>()});
        }

        //获得星数
        public int earnedStars
        {
            get
            {
                MethodInfo method =
                    this.GetType().GetMethod("method_2", BindingFlags.Instance | BindingFlags.NonPublic);
                MethodInfo genericMethod = method.MakeGenericMethod(typeof(int));
                return (int) genericMethod.Invoke(this, new object[] {"earnedStars"});
            }
        }
    }
}