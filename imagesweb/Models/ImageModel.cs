using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace imagesweb.Models
{
    public class ImageModel : List<Image>
    {
        public ImageModel(string directoryOfImage)
        {
            directoryOfImage = directoryOfImage+ "\\Images\\";
            XDocument imageData = XDocument.Load(directoryOfImage + @"/ImageMetaData.xml");
            var images = from image in imageData.Descendants("image") select new Image(image.Element("filename").Value, image.Element("description").Value);
            this.AddRange(images.ToList<Image>());
        }
    }
}
