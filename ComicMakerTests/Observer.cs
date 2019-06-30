using Xunit;
using ComicMakerLib;
using System;

namespace ComicMakerTests
{
    public class Observer
    {
        [Fact]
        public void good_panelX()
        {
            ComicPanel panel = new DefaultPanelBuilder(new Guid()).AtPosition(20, 20).Build();
            panel.Move(10, 10);

            Assert.Equal(10, panel.PosX);
        }

        [Fact]
        public void good_modelX()
        {
            ComicModel model = new ComicModel(27, 48);
            ComicPanel panel = new DefaultPanelBuilder(new Guid())
                .AtPosition(14, 32)
                .WithModel(model)
                .Build();

            panel.Move(10, 10);

            Assert.Equal(23, model.X);
        }

        [Fact]
        public void good_modelY()
        {
            ComicModel model = new ComicModel(27, 48);
            ComicPanel panel = new DefaultPanelBuilder(new Guid())
                .AtPosition(14, 32)
                .WithModel(model)
                .Build();

            panel.Move(10, 10);

            Assert.Equal(26, model.Y);
        }

        [Fact]
        public void good_modelX_2()
        {
            ComicModel model = new ComicModel(20, 20);
            ComicPanel panel = new DefaultPanelBuilder(new Guid())
                .AtPosition(10, 10)
                .WithModel(model)
                .Build();

            panel.Move(40, 40);

            Assert.Equal(50, model.X);
        }
    }
}
