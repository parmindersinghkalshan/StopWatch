using System;

namespace Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Applyin Brightness!");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Applying Contrast!");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resizing Photo!");
        }
    }
}