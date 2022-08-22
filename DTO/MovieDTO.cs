using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scd_W1_Final_Project_Movie.DTO
{
    class MovieDTO
    {
        string _movie_id;
        string _movie_name;
        string _movie_language;
        string _movie_cast;
        string _movie_type;
        string _image_location;
        byte[] images;

        public string Movie_id { get => _movie_id; set => _movie_id = value; }
        public string Movie_name { get => _movie_name; set => _movie_name = value; }
        public string Movie_language { get => _movie_language; set => _movie_language = value; }
        public string Movie_cast { get => _movie_cast; set => _movie_cast = value; }
        public string Movie_type { get => _movie_type; set => _movie_type = value; }
        public string Image_location { get => _image_location; set => _image_location = value; }
        public byte[] Images { get => images; set => images = value; }
    }
}
