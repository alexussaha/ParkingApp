using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.Services
{
    class Questions
    {
        public static string POST(string Url, string Data)
        {
            string result;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(Url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new

            StreamWriter(httpWebRequest.GetRequestStream()))
            {

                streamWriter.Write(Data);
            }

            HttpWebResponse httpResponse;
            try
            {
                httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            }
            catch (System.Net.WebException)
            {
                return "Неверный логин или пароль";
            }



            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            return result;
        }

        public static string GET(string url)
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            System.Net.WebRequest reqGET = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = reqGET.GetResponse();
            System.IO.Stream stream = resp.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(stream);
            string html = sr.ReadToEnd();
            return html;
        }


        public static bool DELETE(string Url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
           
                request.ContentType = "application/json";
                request.Method = "DELETE";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return false;
        }


        public static bool PUT(string Url, string Data)
        {
            //string result;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(Url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";
            using (var streamWriter = new

            StreamWriter(httpWebRequest.GetRequestStream()))
            {

                streamWriter.Write(Data);
            }

            
            HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            return false;
        }

    }
}
