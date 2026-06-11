using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EPCPROJECT
{
    public static class UploadedFilesStore
    {
        // List to hold uploaded file details (name and associated DataTable).
        public static List<UploadedFile> UploadedFiles { get; set; } = new List<UploadedFile>();
    }

    public class UploadedFile
    {
        public string FileName { get; set; }
        public DataTable Data { get; set; }
    }
}
