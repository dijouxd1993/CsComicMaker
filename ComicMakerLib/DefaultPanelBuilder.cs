using System;
using System.Collections.Generic;
using System.Text;

namespace ComicMakerLib
{

    public class DefaultPanelBuilder : IPanelBuilder
    {
        private readonly Guid _id;
        private int _posX;
        private int _posY;
        private int _sizeX;
        private int _sizeY;
        private List<ComicModel> _comicModels;

        public int PosX
        {
            get { return _posX; }
        }
        public int PosY
        {
            get { return _posY; }
        }
        public int SizeX
        {
            get { return _sizeX; }
        }
        public int SizeY
        {
            get { return _sizeY; }
        }

        public Guid Id
        {
            get { return _id; }
        }

        public List<ComicModel> ComicModels
        {
            get { return _comicModels; }
        }

        public DefaultPanelBuilder(Guid id)
        {
            this._comicModels = new List<ComicModel>();
            this._id = id;
        }


        public ComicPanel Build()
        {
            return new ComicPanel(this);
        }

        public DefaultPanelBuilder AtPosition(int x, int y)
        {
            this._posX = x;
            this._posY = y;
            return this;
        }

        public DefaultPanelBuilder WithSize(int sizeX, int sizeY)
        {
            this._sizeX = sizeX;
            this._sizeY = sizeY;
            return this;
        }

        public DefaultPanelBuilder WithModel(ComicModel comicModel)
        {
            this.ComicModels.Add(comicModel);
            return this;
        }


    }
}
