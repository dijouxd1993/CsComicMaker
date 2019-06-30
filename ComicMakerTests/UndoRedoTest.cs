using ComicMakerLib;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ComicMakerTests
{
    public class UndoRedoTest
    {
        [Fact]
        public void PosX_should_be_50()
        {
            PanelCommands commands = new PanelCommands();
            ComicPanel panel = new DefaultPanelBuilder(new Guid())
                   .AtPosition(0, 0)
                   .Build();
            commands.AddCommand(new AddPositionPanelCommand(panel, 50, 0));
            Assert.Equal(50, panel.PosX);
        }

        [Fact]
        public void PosX_should_be_100_before_Undo()
        {
            PanelCommands commands = new PanelCommands();
            ComicPanel panel = new DefaultPanelBuilder(new Guid())
                   .AtPosition(0, 0)
                   .Build();
            commands.AddCommand(new AddPositionPanelCommand(panel, 50, 0));
            commands.AddCommand(new AddPositionPanelCommand(panel, 100, 0));
            Assert.Equal(100, panel.PosX);
        }

        [Fact]
        public void PosX_should_be_50_After_Undo()
        {
            PanelCommands commands = new PanelCommands();
            ComicPanel panel = new DefaultPanelBuilder(new Guid())
                   .AtPosition(0, 0)
                   .Build();
            commands.AddCommand(new AddPositionPanelCommand(panel, 50, 0));
            commands.AddCommand(new AddPositionPanelCommand(panel, 100, 0));
            commands.Undo();
            Assert.Equal(50, panel.PosX);
        }
        [Fact]
        public void PosX_should_be_100_After_Redo()
        {
            PanelCommands commands = new PanelCommands();
            ComicPanel panel = new DefaultPanelBuilder(new Guid())
                   .AtPosition(0, 0)
                   .Build();
            commands.AddCommand(new AddPositionPanelCommand(panel, 50, 0));
            commands.AddCommand(new AddPositionPanelCommand(panel, 100, 0));
            commands.Undo();
            commands.Redo();
            Assert.Equal(100, panel.PosX);
        }

    }
}
