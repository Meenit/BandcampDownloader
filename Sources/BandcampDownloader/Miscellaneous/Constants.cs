﻿using System;
using System.IO;
using System.Reflection;

namespace BandcampDownloader {

    internal static class Constants {
        /// <summary>
        /// The version number of BandcampDownloader.
        /// </summary>
        public static readonly String AppVersion = Assembly.GetEntryAssembly().GetName().Version.ToString();
        /// <summary>
        /// The URL redirecting to the latest release on GitHub.
        /// </summary>
        public static readonly String LatestReleaseWebsite = "https://github.com/Otiel/BandcampDownloader/releases/latest";
        /// <summary>
        /// The absolute path to the log file.
        /// </summary>
        public static readonly String LogFilePath = Directory.GetParent(Assembly.GetExecutingAssembly().Location) + @"\BandcampDownloader.log";
        /// <summary>
        /// The log file maximum size in bytes.
        /// </summary>
        public static readonly long MaxLogSize = 1024 * 1024;
        /// <summary>
        /// The website URL of BandcampDownloader.
        /// </summary>
        public static readonly String ProjectWebsite = "https://github.com/Otiel/BandcampDownloader";
        /// <summary>
        /// The help text displayed in the URL list textbox.
        /// </summary>
        public static readonly String UrlsHint = "Paste URLs of albums to download here. You can specify multiple URLs by writing one URL per line.\n\nA Bandcamp URL looks like: http://[artist].bandcamp.com/album/[album] or http://[artist].bandcamp.com/track/[track]\nPaste artist pages: http://[artist].bandcamp.com and check \"☑ Download artist discography\" to download all their albums.";
        /// <summary>
        /// The absolute path to the settings file.
        /// </summary>
        public static readonly String UserSettingsFilePath = Directory.GetParent(Assembly.GetExecutingAssembly().Location) + @"\BandcampDownloader.ini";
    }
}