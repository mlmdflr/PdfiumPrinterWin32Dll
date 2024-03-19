using System;
using System.Collections.Generic;
using System.Text;

namespace PdfiumPrinterWin32Dll
{
    public class PdfiumResolveEventArgs : EventArgs
    {
        public string PdfiumFileName { get; set; }
    }

    public delegate void PdfiumResolveEventHandler(object sender, PdfiumResolveEventArgs e);
}
