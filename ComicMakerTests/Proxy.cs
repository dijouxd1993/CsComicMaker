using ComicMakerLib;
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
                panels.Add(new ComicPanel(1, 1));
                panels.Add(new ComicPanel(1, 1));
                panels.Add(new ComicPanel(1, 1));

                pages.Add(new ComicPage(i, panels));
            }

            return new ComicBook(prevs, pages);
        }

        [Fact]
        public void Show()
        {
            ComicBook book = Init();
            
            Assert.Equal("Page 1", book.Show(1));
        }

        [Fact]
        public void Clic_Show()
        {
            ComicBook book = Init();

            book.Clic(1);

            Assert.Equal("Page 1 Panel 3", book.Show(1));
        }

        [Fact]
        public void Clic1_Show1_Show2()
        {
            ComicBook book = Init();

            book.Clic(1);
            book.Show(1);

            Assert.Equal("Page 2", book.Show(2));
        }
            
    }
}
