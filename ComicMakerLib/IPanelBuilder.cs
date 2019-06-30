using System;
using System.Collections.Generic;
using System.Text;

namespace ComicMakerLib
{
    public interface IPanelBuilder
    {
   
        int PosX { get; }
        int PosY { get; }
        int SizeX { get; }
        int SizeY { get; }
        Guid Id { get; }
        List<ComicModel> ComicModels { get; }
      
        ComicPanel Build();
    }
}
