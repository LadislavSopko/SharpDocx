using SharpDocx;
using System;
using System.IO;
using Test.Model;

namespace Test
{
    class Program
    {
        private static readonly string BasePath =
            Path.GetDirectoryName(typeof(Program).Assembly.Location) + @"/../../../..";

        static void Main(string[] args)
        {
#if DEBUG
            var viewPath = $"{BasePath}/Views/Main.cs.docx";
            var documentPathIT = $"{BasePath}/Documents/Main.IT.docx";  
            var documentPathDE = $"{BasePath}/Documents/Main.DE.docx"; 
            var model = MainModel.CreateIt();

            // Ide.Start(viewPath, documentPath, model);

            DocumentFactory.Create(viewPath, MainModel.Create(Language.IT)).Generate(documentPathIT);
            DocumentFactory.Create(viewPath, MainModel.Create(Language.DE)).Generate(documentPathDE);
            

#else
            
#endif
        }
    }
}
