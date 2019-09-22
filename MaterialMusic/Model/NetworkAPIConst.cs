using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialMusic.Model
{
    public class NetworkAPIConst
    {

        /// <summary>
        /// 基础URL
        /// </summary>
        public const string BaseURL = "https://music.163.com/weapi/";

        /// <summary>
        /// 邮箱登录
        /// <para>调用例子 : /login?email=xxx@163.com&password=yyy</para>
        /// </summary>
        public const string LoginByMail = "/login";

        /// <summary>
        /// 手机登录
        /// <para>调用例子 : /login/cellphone?phone=xxx&password=yyy</para>
        /// <para>可选参数 : countrycode: 国家码，用于国外手机号登陆，例如美国传入：1</para>
        /// </summary>
        public const string LoginByCellPhone = "login/cellphone";

        /// <summary>
        /// 注册(修改密码)
        /// <para>调用例子 : /register/cellphone?phone=13xxx&password=xxxxx&captcha=1234&nickname=binary1345</para>
        /// </summary>
        public const string Register = "register/cellphone";

        /// <summary>
        /// 发送手机验证码
        /// <para>调用例子 : /captcha/sent?phone=13xxx</para>
        /// </summary>
        public const string CaptchaSend = "captcha/sent";

        /// <summary>
        /// 验证验证码
        /// <para>调用例子 : /captcha/verify?phone=13xxx&captcha=1597</para>
        /// </summary>
        public const string CaptchaVerify = "captcha/verify";

        /// <summary>
        /// 检测手机号码是否已注册
        /// <para>调用例子 : /cellphone/existence/check?phone=13xxx</para>
        /// </summary>
        public const string CheckRegistered = "cellphone/existence/check";

        /// <summary>
        /// 初始化昵称
        /// <para>调用例子 : /activate/init/profile?nickname=testUser2019</para>
        /// </summary>
        public const string ActiveProfile = "activate/init/profile";

        /// <summary>
        /// 更换绑定手机
        /// <para>调用例子 : /rebind?phone=xxx&oldcaptcha=1234&captcha=5678</para>
        /// </summary>
        public const string ReBind = "rebind";

        /// <summary>
        /// 退出登录
        /// </summary>
        public const string Logout = "logout";

        /// <summary>
        /// 更换绑定手机
        /// <para>调用例子 : /user/detail?uid=32953014</para>
        /// </summary>
        public const string UserDetail = "user/detail";

        /// <summary>
        /// 获取用户信息 , 歌单，收藏，mv, dj 数量
        /// <para>调用例子 : /user/subcount</para>
        /// </summary>
        public const string Subcount = "user/subcount";

        /// <summary>
        /// 更新用户信息
        /// <para>调用例子 : /user/update?gender=0&signature=测试签名&city=440300&nickname=binary&birthday=1525918298004&province=440000</para>
        /// </summary>
        public const string UpdateUser = "user/update";

        /// <summary>
        /// 退出登录
        /// </summary>
        public const string Logout = "logout";

        /// <summary>
        /// 退出登录
        /// </summary>
        public const string Logout = "logout";

        /// <summary>
        /// 退出登录
        /// </summary>
        public const string Logout = "logout";


    }
}
