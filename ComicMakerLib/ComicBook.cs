using System;

namespace ComicMakerLib
{
    public class ComicBook
    {
        public bool  Export(IExporter exporter)
        {
            try
            {
                return  exporter.Export(this);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Un problème est survenu {e.Message}");
                return false;
            }
            
        }

    }
}