﻿using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RDHT_Backend
{
    internal static class Globals
    {
        public static readonly HttpClient Client;
        public const string ClonePath = "clone";
        public const string BackendTrackerRepositoryPath = "RobloxExploitingUnion/RDHT-Backend";
        public const string TrackerRepositoryPath = "RobloxExploitingUnion/Roblox-DeployHistory-Tracker";
        public static string[] BinaryTypes { get; } = new string[]
        {
            // CJV = LUOBU
            // WINDOWS
            "WindowsPlayer",
            "WindowsPlayerCJV",
            "WindowsStudio",
            "WindowsStudioCJV",
            "WindowsStudio64",
            "WindowsStudio64CJV",
            // MAC
            "MacPlayer",
            "MacPlayerCJV",
            "MacStudio",
            "MacStudioCJV"
        };

        static Globals()
        {
            HttpClientHandler handler = new HttpClientHandler 
            {
                AutomaticDecompression = DecompressionMethods.All,
            };

            Client = new HttpClient(handler);

            // 30s to respond
            Client.Timeout = new TimeSpan(0, 0, 30);

            // dont cache
            Client.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue
            {
                NoCache = true
            };
        }
    }
}
