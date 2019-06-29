using Xunit;
using ComicMakerLib;

namespace ComicMakerTests
{
    public class Observer
    {
        [Fact]
        public void good_panelX()
        {
            ComicPanel panel = new ComicPanel(20, 20);
            panel.Move(10, 10);

            Assert.Equal(10, panel.X);
        }

        [Fact]
        public void good_modelX()
        {
            ComicPanel panel = new ComicPanel(14, 32);

            ComicModel model = new ComicModel(27, 48);
            panel.Add(model);

            panel.Move(10, 10);

            Assert.Equal(23, model.X);
        }

        [Fact]
        public void good_modelY()
        {
            ComicPanel panel = new ComicPanel(14, 32);

            ComicModel model = new ComicModel(27, 48);
            panel.Add(model);

            panel.Move(10, 10);

            Assert.Equal(26, model.Y);
        }

        [Fact]
        public void good_modelX_2()
        {
            ComicPanel panel = new ComicPanel(10, 10);

            ComicModel model = new ComicModel(20, 20);
            panel.Add(model);

            panel.Move(40, 40);

            Assert.Equal(50, model.X);
        }
    }
}
