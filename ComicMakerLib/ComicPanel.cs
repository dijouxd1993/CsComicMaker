using System;
using System.Collections.Generic;


namespace ComicMakerLib
{
    public class ComicPanel : IComicPanel
    {
        private ComicPanel() { }

        private readonly Guid _id;
        private int _posX;
        private int _posY;
        private int _sizeX;
        private int _sizeY;
        private List<ComicModel> _comicModels;

        public ComicPanel(IPanelBuilder panelBuilder)
        {
            this._id = panelBuilder.Id;
            this._posX = panelBuilder.PosX;
            this._posY = panelBuilder.PosY;
            this._sizeX = panelBuilder.SizeX;
            this._sizeY = panelBuilder.SizeY;
            this._comicModels = panelBuilder.ComicModels;
        }

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

        public void AddComicModel(ComicModel comicModel)
        {
            this._comicModels.Add(comicModel);
        }

        public void Move(int posX, int posY)
        {
            foreach (ComicModel model in _comicModels)
            {
                model.Update(this._posX - posX, this.PosY -posY);
            }

            this._posX = posX;
            this._posY = posY;
        }
    }
}
