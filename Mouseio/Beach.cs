using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mouseio
{
    // A class that describes the beaches used in greek_beaches form
    class Beach
    {
        private string name_;
        private System.Drawing.Image image_;
        private string description_;

        public Beach(string name, System.Drawing.Image image, string description)
        {
            setName(name);
            setImage(image);
            setDescription(description);
        }
        public string getName()
        {
            return name_;    
        }   

        public string getDescription()
        {
            return description_;
        }

        public System.Drawing.Image getImage()
        {
            return image_;
        }

        public void setName(string name)
        {
            name_ = name;
        }

        public void setImage(System.Drawing.Image image)
        {
            image_ = image;
        }

        public void setDescription (string description)
        {
            description_ = description;
        }
    }
}
