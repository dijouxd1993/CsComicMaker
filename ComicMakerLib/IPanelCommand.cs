using System;
using System.Collections.Generic;
using System.Text;

namespace ComicMakerLib
{
    public interface IPanelCommand
    {
        ComicPanel ComicPanel { get; }
        void Apply();
    }
}
