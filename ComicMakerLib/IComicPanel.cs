namespace ComicMakerLib
{
    public interface IComicPanel
    {
        void Add(ComicModel model);
        void Remove(ComicModel model);
        void Move(int x, int y);
    }
}
