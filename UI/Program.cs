using BUSINESSLOGIC;
using DATALAYER;
using MODELS;
using System;


namespace projectexample
{
    internal class Program
    {
        public static void DISPLAY(AnimeContent anime)
        {
            Console.WriteLine("TITLE: " + anime.title);
            Console.WriteLine("STUDIO: " + anime.studio);
            Console.WriteLine("RELEASE DATE: " + anime.releasedate);
            Console.WriteLine("STATUS: " + anime.status);
            Console.WriteLine("GENRE: " + anime.genre);
            Console.WriteLine("EPISODES: " + anime.episodes);
            Console.WriteLine("SUMMARY: " + anime.summary);
            Console.WriteLine("____________________________________________________");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("HELLO! WELCOME TO MY PROGRAM..." + "\n ");
            Console.WriteLine("BEFORE YOU CONTINUE, PLEASE ENTER YOUR USERNAME AND PASSWORD...");
            Console.WriteLine("\n____________________________________________________" + "\n");
            Console.Write("USERNAME: ");
            string name = Console.ReadLine();
            Console.Write("PASSWORD: ");
            string pass = Console.ReadLine();

            Process veri = new Process();
            bool result = veri.Verifying(name, pass);

            if (result)
            {
                Console.WriteLine("\nLogin Successfully");
            }
            else
            {
                Console.WriteLine("\nError");
                Environment.Exit(0);
            }

            while (true)
            {
                Process process = new Process();


                Console.WriteLine("____________________________________________________");
                Console.WriteLine("PLEASE PICK WHAT DO YOU LIKE TO DO: " + "\n");
                Console.WriteLine("ONE - SEARCH AN ANIME IN THE EXISTING LIST");
                Console.WriteLine("TWO - LOOK AT THE WHOLE LIST");
                Console.WriteLine("THREE - ADD ANOTHER ANIME");
                Console.WriteLine("FOUR - REMOVE A ANIME");
                Console.WriteLine("EXIT - ENDING PROGRAM");
                Console.WriteLine("\n____________________________________________________");
                Console.Write("YOUR CHOOSEN NUMBER IS: ");
                string num = Console.ReadLine().ToUpper(); ;
                Console.WriteLine("____________________________________________________");

                Console.Clear();

                if (num == "ONE")
                {
                    Console.WriteLine("MY ANIME RECCOMENDATION" +
                                 "\n  " +
                                 "\n____________________________________________________" +
                                 "\nCardcaptor Sakura" +
                                 "\n____________________________________________________" +
                                 "\nSolo Leveling" +
                                 "\n____________________________________________________" +
                                 "\nYume-iro Pâtissière" +
                                 "\n____________________________________________________" +
                                 "\nMob Psycho '100'" +
                                 "\n____________________________________________________" +
                                 "\nHaikyu!!" +
                                 "\n____________________________________________________" +
                                 "\n  ");

                    Console.Write("PICK ANY ANIME TO KNOW MORE ABOUT: ");
                    string title = Console.ReadLine();
                    Console.WriteLine("____________________________________________________");

                    List<AnimeContent> animeContents = process.ARL();
                    bool found = false;
                    foreach (var anime in animeContents)
                    {
                        if (anime.title.Contains(title))
                        {
                            DISPLAY(anime);
                            found = true;

                            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                            Console.ReadKey(true);
                            Console.Clear();
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Error\n");
                        Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                        Console.ReadKey(true);
                        Console.Clear();
                    }
                }
                else if (num == "TWO")
                {
                    Console.WriteLine("MY ANIME RECOMMENDATION");
                    Console.WriteLine("____________________________________________________\n");

                    List<AnimeContent> animeContents = process.ARL();
                    DISPLAY(animeContents[0]);
                    DISPLAY(animeContents[1]);
                    DISPLAY(animeContents[2]);
                    DISPLAY(animeContents[3]);
                    DISPLAY(animeContents[4]);
                       

                    Console.WriteLine("____________________________________________________\n");
                    Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey(true);
                    Console.Clear();
                    
                }
                else if (num == "THREE")
                {
                    Console.WriteLine("ENTER THE DETAILS FOR THE NEW ANIME: ");
                    Console.Write("TITLE: ");
                    string NewTitle = Console.ReadLine();
                    Console.Write("STUDIO: ");
                    string NewStudio = Console.ReadLine();
                    Console.Write("RELEASE DATE: ");
                    string NewRD = Console.ReadLine();
                    Console.Write("STATUS: ");
                    string NewSta = Console.ReadLine();
                    Console.Write("GENRE: ");
                    string NewGen = Console.ReadLine();
                    Console.Write("EPISODES: ");
                    string NewEp = Console.ReadLine();
                    Console.Write("SUMMARY: ");
                    string NewSum = Console.ReadLine();

                    AnimeContent News = new AnimeContent
                    {
                        title = NewTitle,
                        studio = NewStudio,
                        releasedate = NewRD,
                        status = NewSta,
                        genre = NewGen,
                        episodes = NewEp,
                        summary = NewSum,
                    };
                    process.AddAnime(News);

                    List<AnimeContent> animeContents = process.ARL();
                    Console.WriteLine("____________________________________________________\n");
                    Console.WriteLine("NEW ANIME HAS BEEN ADDED TO THE LIST");
                    Console.WriteLine("____________________________________________________\n");
                    Console.WriteLine("NEW UPDATED LIST");
                    Console.WriteLine("____________________________________________________\n");


                    foreach (var anime in animeContents)
                    {
                        DISPLAY(anime);
                    }
                    DISPLAY(News);

                    Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                else if (num == "FOUR")
                {
                    Console.Write("ENTER THE TITLE OF THE ANIME TO REMOVE: ");
                    string removeT = Console.ReadLine();
                    Console.WriteLine("____________________________________________________\n");
                    bool removed = false;
                    process.RemoveAnime(removeT);
                    Console.WriteLine("UPDATED LIST");
                    List<AnimeContent> animeContents = process.ARL();

                    foreach (var anime in animeContents)
                    {
                        if (anime.title.Equals(removeT, StringComparison.OrdinalIgnoreCase))
                        {
                            removed = true;
                            continue; 
                        }

                        DISPLAY(anime);
                    }

                    if (removed)
                    {
                        Console.WriteLine($"{removeT} HAS BEEN REMOVED");
                        Console.WriteLine("____________________________________________________\n");
                    }
                    else
                    {
                        Console.WriteLine($"{removeT} DOES NOT EXIST");
                        Console.WriteLine("____________________________________________________\n");

                    }

                    Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                else if (num == "EXIT")
                {
                    Console.WriteLine("ENDING PROGRAM");
                    break;
                }
                else
                {
                    Console.WriteLine(" ERROR");
                    Console.WriteLine("____________________________________________________\n");
                    Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey(true);
                    Console.Clear();

                }
            }
            }
        }
    }




