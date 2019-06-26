using ComicMakerLib;
using System;
using System.Collections.Generic;
using Xunit;

namespace ComicMakerTests
{
    public class Proxy
    {
        public ComicBook Init()
        {
            List<ComicPagePreview> prevs = new List<ComicPagePreview>();
            prevs.Add(new ComicPagePreview(1));
            prevs.Add(new ComicPagePreview(2));
            prevs.Add(new ComicPagePreview(3));

            List<ComicPage> pages = new List<ComicPage>();
            for (int i = 1; i <= 3; i++)
            {

                List<ComicPanel> panels = new List<ComicPanel>();
                panels.Add(new ComicPanel());
                panels.Add(new ComicPanel());
                panels.Add(new ComicPanel());

                pages.Add(new ComicPage(i, panels));
            }

            return new ComicBook(prevs, pages);
        }

        [Fact]
        public void test()
        {
            ComicBook book = Init();

            int index = 1;

           // Assert.book.Clic(index));
                
        }
    }
}
