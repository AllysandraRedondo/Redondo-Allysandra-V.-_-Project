using DATALAYER;
using MODELS;
using System;
using System.Diagnostics;
namespace BUSINESSLOGIC
{
    public class Process
    {
        public void AddAnime(AnimeContent anime)
        {
            List<AnimeContent> animeContents = ARL();
            animeContents.Add(anime);
        }

        public bool Verifying(string name, string pass)
        {
            OwnerData datass = new OwnerData();
            var result = datass.GetUser(name, pass);

            return result.name != null ? true : false;
        }
        public List<AnimeContent> ARL()
        {
            AnimeData data = new AnimeData();
            return data.ARL();
        }
        public void RemoveAnime(string title)
        {
            List<AnimeContent> animeContents = ARL();
            animeContents.RemoveAll(anime => anime.title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }
    }
    
    


