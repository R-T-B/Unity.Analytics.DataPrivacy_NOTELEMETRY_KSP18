﻿using System;
using System.Text;
using UnityEngine.Networking;

namespace UnityEngine.Analytics
{
    public class DataPrivacy
    {
        private const string kVersion = "STOPMININGMYDATAUNITY1.0";
        private const string kVersionString = "STOPMININGMYDATAUNITY1.0";
        internal const string kBaseUrl = "";
        private const string kTokenUrl = "";

        internal static DataPrivacy.UserPostData GetUserData()
        {
            return new DataPrivacy.UserPostData()
            {
                appid = "",
                userid = "",
                sessionid = 0,
                platform = "",
                platformid = 0,
                sdk_ver = "",
                debug_device = false,
                deviceid = "",
                plugin_ver = "STOPMININGMYDATAUNITY1.0"
            };
        }

        private static string GetUserAgent()
        {
            return "";
        }

        private static string getErrorString(UnityWebRequest www)
        {
            return "";
        }

        public static void FetchPrivacyUrl(Action<string> success, Action<string> failure = null)
        {
            return;
        }

        [Serializable]
        internal struct UserPostData
        {
            public string appid;
            public string userid;
            public long sessionid;
            public string platform;
            public uint platformid;
            public string sdk_ver;
            public bool debug_device;
            public string deviceid;
            public string plugin_ver;
        }

        [Serializable]
        internal struct TokenData
        {
            public const string url ="";
            public const string token = "";
        }
    }
}
