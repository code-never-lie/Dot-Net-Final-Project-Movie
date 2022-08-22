using Scd_W1_Final_Project_Movie.DL;
using Scd_W1_Final_Project_Movie.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scd_W1_Final_Project_Movie.BL
{
    class MovieBL
    {
        MovieDL mdl;

        public MovieBL()
        {
            mdl = new MovieDL();

        }

        public void AddMovie(MovieDTO mdto)
        {
            mdl.AddMovieInDB(mdto);

        }
        public MovieDTO ViewMovie(MovieDTO mdto)
        {
            MovieDTO rmdto;
             rmdto= mdl.ViewMovieInDB(mdto);
            return rmdto;
        }
        public void RemoveMovie(MovieDTO mdto)
        {
            
             mdl.RemoveMovieInDB(mdto);
            
        }
        public void AddShow(ShowDTO sdto)
        {
            mdl.AddShowInDB(sdto);

        }
        public void RemoveShow(ShowDTO sdto)
        {

            mdl.RemoveShowInDB(sdto);

        }
        public ShowDTO ViewShow(ShowDTO sdto)
        {
            ShowDTO rsdto;
            rsdto = mdl.ViewShowInDB(sdto);
            return rsdto;
        }
    }
}
