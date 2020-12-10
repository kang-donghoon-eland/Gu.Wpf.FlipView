using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Gu.Wpf.FlipViewDemo2
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MoviePage> MoviePages { get; set; }

        private MoviePage selectedPage;

        public event PropertyChangedEventHandler PropertyChanged;

        public MoviePage SelectedPage
        {
            get { return selectedPage; }
            set
            {
                selectedPage = value;
            }
        }

        public ObservableCollection<MoviePage> LoadImage()
        {
            ObservableCollection<MoviePage> list = new ObservableCollection<MoviePage>();
            string[] filesPath = System.IO.Directory.GetDirectories(System.Environment.CurrentDirectory + "\\StyleImage\\");
            int i = 0;
            foreach (string path in filesPath)
            {
                string name = System.IO.Path.GetFileName(path); // 폴더명 (페이지명)
                string[] files = System.IO.Directory.GetFiles(path);
                MoviePage page = new MoviePage();
                page.PageNo = i;
                page.PageName = name;
                page.MovieList = new List<Movie>();
                foreach (string file in files)
                {
                    Movie mv = new Movie();
                    mv.Name = System.IO.Path.GetFileName(file);
                    mv.Image = file;
                    mv.Detail = name;
                    page.MovieList.Add(mv);
                }
                list.Add(page);
            }
            return list;
        }

        public ViewModel()
        {
            MoviePages = LoadImage();
        }
    }
}
