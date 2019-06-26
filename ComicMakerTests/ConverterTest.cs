using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ComicMakerLib;

namespace ComicMakerTests
{
    public class ConverterTest
    {
        [Fact]
        public void Pdf_Exporter_should_return_true()
        {
            IExporter Exporter = new PDFExporter();
            ComicBook comicBook = new ComicBook(null,null);
            bool result = comicBook.Export(Exporter);

            Assert.True(result);
        }

        [Fact]
        public void EPub_Exporter_should_return_true()
        {
            IExporter Exporter = new EpubExporter();
            ComicBook comicBook = new ComicBook(null,null);
            bool result = comicBook.Export(Exporter);

            Assert.True(result);
        }


        [Fact]
        public void Null_Exporter_should_return_false()
        {
            IExporter Exporter = null;
            ComicBook comicBook = new ComicBook(null, null);
            bool result = comicBook.Export(Exporter);

            Assert.False(result);
        }


    }
}
