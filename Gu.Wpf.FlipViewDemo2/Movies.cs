using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gu.Wpf.FlipViewDemo2
{
    public class Movie
    {
        public string Name { get; set; }

        public string Image { get; set; }

        public string Detail { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class MoviePage
    {
        public int PageNo { get; set; }
        public string PageName { get; set; }
        public List<Movie> MovieList { get; set; }
        private bool _selected;

        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }
    }
}
