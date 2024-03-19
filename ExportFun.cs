using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PdfiumPrinterWin32Dll
{
    public class ExportFun
    {
        [DllExport]
        public static void PrintFilePath(string filePath, string printerName)
        {
            var printer = new PdfPrinter(printerName);
            printer.Print(filePath);
        }

        [DllExport]
        public static void PrintFilePathP(string filePath, string printerName, string password)
        {
            var printer = new PdfPrinter(printerName);
            printer.PrintP(filePath, password);
        }

        [DllExport]

        public static void PrintStream(Stream filePath, string printerName)
        {
            var printer = new PdfPrinter(printerName);
            printer.Print(filePath);
        }

        [DllExport]

        public static void PrintStreamP(Stream filePath, string printerName, string password)
        {
            var printer = new PdfPrinter(printerName);
            printer.PrintP(filePath, password);
        }
    }
}
