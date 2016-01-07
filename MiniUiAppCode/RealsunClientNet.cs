using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using MiniUiAppCode.Utils;

namespace MiniUiAppCode
{
   public static class RealsunClientNet
    {
        public  static CookieContainer m_CookieContainer = new CookieContainer();

        public static string strBaseUrl = "http://121.199.9.136:8082/rispweb/";
        private const  string strLoginPage = "rispservice/ajaxSvrLogin.aspx";
        private const string strExecutePage = "risphost/data/AjaxService.aspx";
        public static Task<Hashtable>  Login(string user, string upass)
        {
            var result = Task<Hashtable>.Factory.StartNew(() =>
            {
                Hashtable loginReturnData = new Hashtable() ;
                try
                {
                    Encoding encoding = Encoding.UTF8;
                    string strurl = strBaseUrl + strLoginPage;

                    string strJason = PostHttpResponse.GetStream(PostHttpResponse.CreatePostHttpResponseJson(strurl, "", "user="+user+"&upass="+upass+"&clienttype=mobile", null, "", encoding, "", ref m_CookieContainer, true), encoding);
                    loginReturnData = (Hashtable)MiniUiAppCode.JSON.Decode(strJason);

                }
                catch (Exception ex)
                {

                    loginReturnData.Clear();
                    loginReturnData.Add("error", "-1");
                    loginReturnData.Add("message", "client error:"+ex.Message.ToString());
                }
                return loginReturnData;
            });
            return result;

        }
        public static Task<Hashtable> Execute(string method, Hashtable parms,ref Int64 requestid )
        {
            string strParams="";
            IEnumerator enu = parms.Keys.GetEnumerator();
            while (enu.MoveNext())
            {
                string parm = enu.Current.ToString() + "=" + Convert.ToString(parms[enu.Current.ToString()]);
                strParams = strParams + parm + "&";
            }



            strParams = strParams + "requestid=" + requestid.ToString()+"&";


             var result = Task<Hashtable>.Factory.StartNew(() =>
            {
                Hashtable ReturnData = new Hashtable();
                try
                {
                    Encoding encoding = Encoding.UTF8;
                    string strurl = strBaseUrl + strExecutePage;

                    string strJason = PostHttpResponse.GetStream(PostHttpResponse.CreatePostHttpResponseJson(strurl, "", "method=" + method + "&"+strParams + "clienttype=mobile", 300*1000, "", encoding, "", ref m_CookieContainer, true), encoding);
                    ReturnData = (Hashtable)MiniUiAppCode.JSON.Decode(strJason);

                }
                catch (Exception ex)
                {

                    ReturnData.Clear();
                    ReturnData.Add("error", "-1");
                    ReturnData.Add("message", "client error:" + ex.Message.ToString());
                }
                return ReturnData;
            });
            return result;

        }


        

    }
}
