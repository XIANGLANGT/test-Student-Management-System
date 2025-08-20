using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;

namespace DAL
{
    /// <summary>
    /// 通用验证类
    /// </summary>
    public class DateValidate
    {
        /// <summary>
        /// 验证正整数
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool IsInteger(string txt)
        {
            //Regex objReg = new Regex(@"^[1-9]\d*$");
            Regex objReg = new Regex(@"^\d+$");     // 验证非负整数（包括0）
            //Regex objReg = new Regex(@"^-?\d+$");    // 验证整数（包括负数）
            return objReg.IsMatch(txt);
        }
        /// <summary>
        /// 验证是否是Email
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool IsEmail(string txt)
        {
            Regex objReg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            return objReg.IsMatch(txt);
        }
        /// <summary>
        /// 验证身份证
        /// </summary>
        /// <param name="txt">验证中国大陆身份证号码格式的正则表达式方法</param>
        /// <returns></returns>
        public static bool IsIdentityCard(string txt)
        {
            ////^\d{15}$：匹配15位纯数字的旧版身份证
            ////^\d{18}$：匹配18位纯数字的新版身份证
            ////^\d{17}(\d|X|x)$：匹配17位数字加最后一位数字或X/x的新版身份证
            Regex objReg = new Regex(@"^(\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$");
            ////IsMatch()是Regex类提供的匹配方法，返回布尔值表示是否匹配成功‌
            return objReg.IsMatch(txt);
        }
    }
}
