namespace ComicMakerLib
{

    public class ComicModel : IComicModel
    {
        public int X { get; set; }
        public int Y { get; set; }

        public ComicModel(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Update(int x, int y)
        {
            X -= x;
            Y -= y;
        }
    }
}

