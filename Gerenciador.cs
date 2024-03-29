﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorTxt
{
    public static class Gerenciador
    {
        public static string DefaultFolderPath => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
        public static string DefaultFileName => "arquivo";
        public static string DefaultFileExt => ".txt";

        public static string FolderPath { get; set; } = DefaultFolderPath;
        public static string FileName { get; set; } = DefaultFileName;
        public static string FileExt { get; set; } = DefaultFileExt;

        public static string FilePath => FolderPath + FileName + FileExt;



    }
}
