﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Helper
{
    public static class PathHelper
    {
        public static string GetFullPathNormalized(string path)
        {
            return Path.TrimEndingDirectorySeparator(Path.GetFullPath(path));
        }

        public static string MapPath(string path, string basePath = null)
        {
            if (string.IsNullOrEmpty(basePath))
            {
                basePath = Startup.WebRootPath;
            }

            path = path.Replace("~/", "").TrimStart('/').Replace('/', '\\');
            return GetFullPathNormalized(Path.Combine(basePath, path));
        }
    }
}
