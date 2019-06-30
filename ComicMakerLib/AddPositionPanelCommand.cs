using System;
using System.Collections.Generic;
using System.Text;

namespace ComicMakerLib
{
    public class AddPositionPanelCommand : IPanelCommand
    {
        private ComicPanel _comicPanel;

        private int _posX;

        public int PosX
        {
            get { return _posX; }
        }

        private int _posY;

        public int PosY
        {
            get { return _posY; }
        }


        public ComicPanel ComicPanel
        {
            get { return _comicPanel; }
        }


        public AddPositionPanelCommand(ComicPanel comicPanel, int posX, int posY)
        {
            this._comicPanel = comicPanel;
            this._posX = posX;
            this._posY = posY;
        }


        public void Apply()
        {
            this.ComicPanel.ChangePosition(PosX, PosY);
        }
    }
}
