using System;
using System.Text;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharp.Net.Http;
using Crestron.SimplSharp.Net;
using Crestron.SimplSharp.CrestronIO;
using System.Collections.Generic;
using System.Threading;

namespace VenstarIPControl101 {

    public class Venstar {

        /// <summary>
        /// SIMPL+ can only execute the default constructor. If you have variables that require initialization, please
        /// use an Initialize method
        /// </summary>
        /// 

        private static readonly HttpClient client = new HttpClient();

        private string ip;

        public Venstar() {
        }

        public void VenstarIP(string iptxt) {
            ip = iptxt;
        }

        public string FanTo0() {

            var request = new HttpClientRequest();

            request.Url.Parse("http://" + ip + "/control");

            request.RequestType = RequestType.Post;

            request.Header.SetHeaderValue("content-type", "application/x-www-form-urlencoded");
            request.Header.SetHeaderValue("content-length", "17");
            request.Header.SetHeaderValue("connection", "close");

            request.ContentString = "fan=0";

            var response = client.Dispatch(request);

            client.Abort();

            // TODO: Fb Handler

            return response.ContentString.ToString();
        }

        public string FanTo1() {

            var request = new HttpClientRequest();

            request.Url.Parse("http://" + ip + "/control");

            request.RequestType = RequestType.Post;

            request.Header.SetHeaderValue("content-type", "application/x-www-form-urlencoded");
            request.Header.SetHeaderValue("content-length", "17");
            request.Header.SetHeaderValue("connection", "close");

            request.ContentString = "fan=1";

            var response = client.Dispatch(request);

            client.Abort();

            // TODO: Fb Handler

            return response.ContentString.ToString();
        }

        public string ModeTo0() {

            var request = new HttpClientRequest();

            request.Url.Parse("http://" + ip + "/control");

            request.RequestType = RequestType.Post;

            request.Header.SetHeaderValue("content-type", "application/x-www-form-urlencoded");
            request.Header.SetHeaderValue("content-length", "17");
            request.Header.SetHeaderValue("connection", "close");

            request.ContentString = "mode=0";

            var response = client.Dispatch(request);

            client.Abort();

            return response.ContentString.ToString();

        }

        public string ModeTo1() {

            var request = new HttpClientRequest();

            request.Url.Parse("http://" + ip + "/control");

            request.RequestType = RequestType.Post;

            request.Header.SetHeaderValue("content-type", "application/x-www-form-urlencoded");
            request.Header.SetHeaderValue("content-length", "17");
            request.Header.SetHeaderValue("connection", "close");

            request.ContentString = "mode=1";

            var response = client.Dispatch(request);

            client.Abort();

            return response.ContentString.ToString();

        }

        public string ModeTo2() {

            var request = new HttpClientRequest();

            request.Url.Parse("http://" + ip + "/control");

            request.RequestType = RequestType.Post;

            request.Header.SetHeaderValue("content-type", "application/x-www-form-urlencoded");
            request.Header.SetHeaderValue("content-length", "17");
            request.Header.SetHeaderValue("connection", "close");

            request.ContentString = "mode=2";

            var response = client.Dispatch(request);

            client.Abort();

            return response.ContentString.ToString();

        }

        public string ModeTo3() {

            var request = new HttpClientRequest();

            request.Url.Parse("http://" + ip + "/control");

            request.RequestType = RequestType.Post;

            request.Header.SetHeaderValue("content-type", "application/x-www-form-urlencoded");
            request.Header.SetHeaderValue("content-length", "17");
            request.Header.SetHeaderValue("connection", "close");

            request.ContentString = "mode=3";

            var response = client.Dispatch(request);

            client.Abort();

            return response.ContentString.ToString();

        }

        public string HeatTempUp() {

            var request = new HttpClientRequest();

            request.Url.Parse("http://" + ip + "/control");

            request.RequestType = RequestType.Post;

            request.Header.SetHeaderValue("content-type", "application/x-www-form-urlencoded");
            request.Header.SetHeaderValue("content-length", "17");
            request.Header.SetHeaderValue("connection", "close");

            double HeatTemptemp = Convert.ToDouble(HeatTempFb);
            string HeatTemp = Convert.ToString(HeatTemptemp + 0.5);

            request.ContentString = "heattemp=" + HeatTemp;

            var response = client.Dispatch(request);

            client.Abort();

            return response.ContentString.ToString();
        }

        public string HeatTempDown() {

            var request = new HttpClientRequest();

            request.Url.Parse("http://" + ip + "/control");

            request.RequestType = RequestType.Post;

            request.Header.SetHeaderValue("content-type", "application/x-www-form-urlencoded");
            request.Header.SetHeaderValue("content-length", "17");
            request.Header.SetHeaderValue("connection", "close");

            double HeatTemptemp = Convert.ToDouble(HeatTempFb);
            string HeatTemp = Convert.ToString(HeatTemptemp - 0.5);

            request.ContentString = "heattemp=" + HeatTemp;

            var response = client.Dispatch(request);

            client.Abort();

            return response.ContentString.ToString();
        }


        public string CoolTempUp() {

            var request = new HttpClientRequest();

            request.Url.Parse("http://" + ip + "/control");

            request.RequestType = RequestType.Post;

            request.Header.SetHeaderValue("content-type", "application/x-www-form-urlencoded");
            request.Header.SetHeaderValue("content-length", "17");
            request.Header.SetHeaderValue("connection", "close");

            double CoolTemptemp = Convert.ToDouble(CoolTempFb);
            string CoolTemp = Convert.ToString(CoolTemptemp + 0.5);

            request.ContentString = "cooltemp=" + CoolTemp;

            var response = client.Dispatch(request);

            client.Abort();

            return response.ContentString.ToString();
        }

        public string CoolTempDown() {

            var request = new HttpClientRequest();

            request.Url.Parse("http://" + ip + "/control");

            request.RequestType = RequestType.Post;

            request.Header.SetHeaderValue("content-type", "application/x-www-form-urlencoded");
            request.Header.SetHeaderValue("content-length", "17");
            request.Header.SetHeaderValue("connection", "close");

            double CoolTemptemp = Convert.ToDouble(CoolTempFb);
            string CoolTemp = Convert.ToString(CoolTemptemp - 0.5);

            request.ContentString = "cooltemp=" + CoolTemp;

            var response = client.Dispatch(request);

            client.Abort();

            return response.ContentString.ToString();
        }



        public string QueryInfo() {
            var response = client.Get("http://" + ip + "/query/info");
            return response;
        }

        public string SensorQueryInfo() {
            var response = client.Get("http://" + ip + "/query/sensors");
            return response;
        }

        private static string getBetween(string strSource, string strStart, string strEnd) {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd)) {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }

            else {
                return "";
            }
        }

        public ushort ModeFb, FanFb, SpaceTempFb, FanStateFb, AwayFb;
        public string HeatTempFb, CoolTempFb, TempFb;
        public string SensorNameFb;
        public ushort SensorTempFb;
        public string NameFb;

        public void InfoFbHandler(string responsein) {

            string ModeFbs = getBetween(responsein, "\"mode\":", ",");
            string FanFbs = getBetween(responsein, "\"fan\":", ",");
            string SpaceTempFbs = getBetween(responsein, "\"spacetemp\":", ",");
            string FanStateFbs = getBetween(responsein, "\"fanstate\":", ",");
            string HeatTempFbs = getBetween(responsein, "\"heattemp\":", ",");
            string CoolTempFbs = getBetween(responsein, "\"cooltemp\":", ",");
            string AwayFbs = getBetween(responsein, "\"away\":", ",");
            string NameFbs = getBetween(responsein, "\"name\":", ",");

            /* ModeFb = 12312;
            FanFb = UInt16.Parse(FanFbs);
            SpaceTempFb = UInt16.Parse(SpaceTempFbs);
            FanStateFb = UInt16.Parse(FanStateFbs);
            HeatTempFb = UInt16.Parse(HeatTempFbs);
            CoolTempFb = UInt16.Parse(CoolTempFbs);
            AwayFb = UInt16.Parse(AwayFbs); */

            FanFb = Convert.ToUInt16(FanFbs.Trim());
            ModeFb = Convert.ToUInt16(ModeFbs.Trim());
            HeatTempFb = Convert.ToString(HeatTempFbs.Trim());
            CoolTempFb = Convert.ToString(CoolTempFbs.Trim());
            AwayFb = Convert.ToUInt16(AwayFbs.Trim());
            TempFb = Convert.ToString(SpaceTempFbs.Trim());
            FanStateFb = UInt16.Parse(FanStateFbs);
        }

        public void SensorFbHandler(string responsein) {
            string ogstring = responsein.Substring(77);
            string SensorNameFbs = getBetween(ogstring, "\"name\":\"", "\",");      // "name":"
            string TempFbs = getBetween(ogstring, "\"temp\":", ",");

            SensorNameFb = Convert.ToString(SensorNameFbs.Trim());
            SensorTempFb = Convert.ToUInt16(TempFbs.Trim());


            CrestronConsole.PrintLine("Sensor Name is: " + SensorNameFb + ", Sensor Temp is: " + SensorTempFb);
        }

    }
}
