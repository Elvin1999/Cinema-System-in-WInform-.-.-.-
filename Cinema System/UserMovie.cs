using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cinema_System
{
    class UserMovie
    {
        List<Movie> usermovies = new List<Movie>();
        List<Movie> GetList()
        {
            return usermovies;
        }
        public string FileName { get; set; }
    }
}
