using System;
using System.Collections.Generic;
using System.Text;

namespace ComicMakerLib
{
    public class PanelCommands
    {
        Stack<IPanelCommand> commands;
        Stack<IPanelCommand> redoCommands;

        public PanelCommands()
        {
            commands = new Stack<IPanelCommand>();
            redoCommands = new Stack<IPanelCommand>();
        }

        public void AddCommand(IPanelCommand command)
        {
            command.Apply();
            commands.Push(command);
        }

        public void Undo()
        {
            redoCommands.Push(commands.Pop());
            commands.Peek().Apply();
        }

        public void Redo()
        {
            commands.Push(redoCommands.Pop());
            commands.Peek().Apply();

        }




    }
}
