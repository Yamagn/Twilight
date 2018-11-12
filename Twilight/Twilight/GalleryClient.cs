using Plugin.Media;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Twilight
{
    public static class GalleryClient
    {
        public static async Task<string> PickPhotoAsync()
        {
            var photo = await CrossMedia.Current.PickPhotoAsync();
            return photo.Path;
        }
    }
}
