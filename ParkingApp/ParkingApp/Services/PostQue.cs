using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.Services
{
    class PostQue
    {
        public static string POST(string Url, string Data)
        {
            string result;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(Url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            try {
                using (var streamWriter = new

                StreamWriter(httpWebRequest.GetRequestStream()))
                {

                    streamWriter.Write(Data);
                }
            }
            catch
            {
                return "ошибка соединения";
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
    }
}
