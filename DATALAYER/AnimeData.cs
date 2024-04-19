using MODELS;
using System.Collections;


namespace DATALAYER
{
    public class AnimeData
    {

        public AnimeData() 
        {
            AnimeList();
        }

        List<AnimeContent> contentlist = new List<AnimeContent>();

        public void AnimeList()
        {

            AnimeContent num1 = new AnimeContent();
            num1.title = "Cardcaptor Sakura";
            num1.studio = "Madhouse";
            num1.releasedate = "Apr 7, 1998";
            num1.status = "Completed";
            num1.genre = "Adventure, Comedy, Drama, Fantasy, Romance";
            num1.episodes = "70";
            num1.summary = "Ten-year-old Sakura Kinomoto, an ordinary fourth-grade student in Tomoeda, accidentally stumbles upon a book of magical cards called \"The Clow.\" In her curiosity, she scatters the cards, awakening Keroberos, the Beast of the Seal. Kero informs Sakura that she must now become the \"Cardcaptor\" and retrieve the powerful Clow Cards she released. With her friend Tomoyo by her side, Sakura embarks on magical adventures to capture the cards and save the world from their unpredictable powers.";

            AnimeContent num2 = new AnimeContent
            {
                title = "Solo Leveling",
                studio = " A-1 Pictures",
                releasedate = "January 7, 2024",
                status = "Completed",
                genre = "Action, Fantasy",
                episodes = "12",
                summary = "In a world of gifted hunters and monsters, a weak hunter Sung Jinwoo gains extraordinary powers through a mysterious program, leading him to become one of the strongest hunters and conquering even the strongest dungeons.\r\n",
            };

            AnimeContent num3 = new AnimeContent
            {
                title = "Yume-iro Pâtissière",
                studio = "Studio Hibari",
                releasedate = "Oct 4, 2009",
                status = "Completed",
                genre = "Gourmet",
                episodes = "50",
                summary = "Ichigo Amano, a clumsy girl with a love for cakes, gets discovered by renowned patissier Henri Lucas for her exceptional tasting abilities. He offers her a spot at St. Marie Academy, a prestigious culinary school. Despite her lack of experience, Ichigo joins the top group, known as the \"Sweets Princes,\" alongside experts like Sennosuke Andou, Satsuki Hanabusa, and Makoto Kashino. With the help of their \"Sweets Spirits,\" they aim to excel in the world of sweets and achieve their culinary dreams.",
            };

            AnimeContent num4 = new AnimeContent
            {
                title = "Mob Psycho 100",
                studio = "Bones",
                releasedate = "Jan 7, 2019",
                status = "Completed",
                genre = "Action, Comedy, Supernatural",
                episodes = "37 + 2 OVAs",
                summary = "Shigeo \"Mob\" Kageyama, a maturing psychic with immense power, navigates his role alongside mentor Reigen Arataka in handling supernatural requests. From exorcisms to confronting urban legends, they tackle various challenges. However, Mob's growth brings a newfound seriousness to their adventures, as they face tangible and unsettling dangers. Their experiences take on a darker tone, reflecting Mob's evolving understanding of his abilities and their impact on others.",
            };

            AnimeContent num5 = new AnimeContent
            {
                title = "Haikyu!!",
                studio = "Production I.G",
                releasedate = "April 6, 2014",
                status = "Completed",
                genre = "Sports",
                episodes = "85 + 5 OVAs",
                summary = "Shouyou Hinata, inspired by the \"Little Giant,\" is determined to excel in volleyball despite his short stature. Enrolling at Karasuno High School, he hopes to follow in the footsteps of his idol. However, his dreams are challenged when he discovers that Tobio Kageyama, a former rival, is now his teammate. To succeed, Hinata must overcome his differences with Kageyama and learn the true meaning of teamwork in the competitive world of volleyball.",
            };
            contentlist.Add(num1);
            contentlist.Add(num2);
            contentlist.Add(num3);
            contentlist.Add(num4);
            contentlist.Add(num5);

            contentlist = ARL();

        }
        public List<AnimeContent> ARL()
        {
            return contentlist;
        }
    }
}

