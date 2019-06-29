using System.Collections.Generic;

namespace ComicMakerLib
{
    public class ComicPanel : IComicPanel
    {
        public int X { get; set; }
        public int Y { get; set; }
        public List<ComicModel> models;

        public ComicPanel(int x, int y)
        {
            X = x;
            Y = y;
            models = new List<ComicModel>();
        }

        public void Add(ComicModel model)
        {
            models.Add(model);
        }

        public void Remove(ComicModel model)
        {
            models.Remove(model);
        }

        public void Move(int x, int y)
        {
            int diffX = X - x;
            int diffY = Y - y;

            X = x;
            Y = y;

            foreach (ComicModel model in models)
            {
                model.Update(diffX, diffY);
            }
        }
    }
}
