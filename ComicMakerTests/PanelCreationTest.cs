using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ComicMakerLib;

namespace ComicMakerTests
{
    
    public class PanelCreationTest
    {
        [Fact]
        public void ComicPanel_should_not_be_null()
        {
            Guid guid = new Guid();

            DefaultPanelBuilder panelBuilder = new DefaultPanelBuilder(guid);
            ComicPanel panel = panelBuilder.Build();
            Assert.NotNull(panel);
        }

        [Fact]
        public void ComicPanel_posX_should_be_50()
        {
            Guid guid = new Guid();
            DefaultPanelBuilder panelBuilder = new DefaultPanelBuilder(guid);
            ComicPanel panel = panelBuilder.AtPosition(50, 50).Build();
            Assert.Equal(50, panel.PosX);
        }

        [Fact]
        public void ComicPanel_should_have_2_Models()
        {
            Guid guid = new Guid();
            
            ComicPanel panel = new DefaultPanelBuilder(guid)
            .WithModel(new ComicModel())
            .WithModel(new ComicModel())
            .Build();
            
            Assert.Equal(2, panel.ComicModels.Count);
        }
    }
}
