namespace ComicMakerLib
{
    public abstract class IComicPage
    {
        public int Index { get; set; }
                
        public abstract string Show();
    }
}
