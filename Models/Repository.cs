using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{

    
    public class Repository : IRepository
    {
        // private static Repository sharedRepository = new Repository();
        //public static Repository SharedRepository => sharedRepository;

        private static List<UserStory> stories = new List<UserStory>();
        public List<UserStory> Stories { get { return stories; } }

        private static List<BooksAndPrint> printMedia = new List<BooksAndPrint>();
        public List<BooksAndPrint> PrintMedia { get { return printMedia; } }

        private static List<OnlineResources> onlineResources = new List<OnlineResources>();
        public List<OnlineResources> OnlineResources { get { return onlineResources; } }
                
       
        public Repository()
        {
            if (stories.Count == 0)
            {
                AddTestData();
            }
            
        }        

        public void AddStory(UserStory story) => stories.Add(story);

        //Adding responses to the list stories
        public void AddResponse(UserStory userStories)
        {
            stories.Add(userStories);
        }

        public void SortBooksAndPrintList()
        {
            printMedia.Sort((pm1, pm2) => string.Compare(pm1.PublicationYear, pm2.PublicationYear, StringComparison.Ordinal));
        }

        public void SortStories()
        {
            stories.Sort((s1, s2) => string.Compare(s1.Title, s2.Title, StringComparison.Ordinal));
        }

        public void AddCommentToStory(String userComment)
        {
            //TODO: Create logic for this to work
        }

        public void AddComment(UserComments userComment)
        {
            comments.Add(userComment);
        }

        public void AddTestData()
        {
            UserStory story = new UserStory()
            {
                Name = "Brian",
                Location = "Springfield",
                Title = "First Story",
                Story = "This is the First Story"
            };
            stories.Add(story);

            UserStory story1 = new UserStory()
            {
                Name = "Ashley",
                Location = "Eugene",
                Title = "Second story",
                Story = "This is the second story"
            };
            stories.Add(story1);

            BooksAndPrint bnp = new BooksAndPrint()
            {
                Title = "Secret History of Twin Peaks",
                Hyperlink = "http://www.bymarkfrost.com/books/secret_history_of_twin_peaks.html",
                PublicationYear = "2016"
            };
            printMedia.Add(bnp);

            BooksAndPrint bnp2 = new BooksAndPrint()
            {
                Title = "Twin Peaks Final Dossier",
                Hyperlink = "http://www.bymarkfrost.com/books/twin_peaks_final_dossier.html",
                PublicationYear = "2017"
            };
            printMedia.Add(bnp2);

            BooksAndPrint bnp3 = new BooksAndPrint()
            {
                Title = "Secret Diary of Laura Palmer",
                Hyperlink = "http://www.bymarkfrost.com/books/secret_diary_of_laura_palmer.html",
                PublicationYear = "2011"
            };
            printMedia.Add(bnp3);

            OnlineResources oL1 = new OnlineResources()
            {
                Title = "Twin Peaks Wiki",
                Hyperlink = "https://en.wikipedia.org/wiki/Twin_Peaks"
            };
            onlineResources.Add(oL1);
        }


        public static List<UserComments> comments = new List<UserComments>();      
            
                

        


      

     

        //public static void AddCommentToStory(String userComment)
        //{
        //    //TODO: Figure out logic to make this line work.
        //    //stories[0].StoryComments = userComment;
        //}

        //TODO: Need to put the comment object in all of the lists!!!! 

      
        public static IEnumerable<UserComments> Comment
        {
            get
            {
                return comments;
            }
        }

        //public static void AddComment(UserComments userComment)
        //{
        //    comments.Add(userComment);
        //}

        //Use of Lambda Expression for Lab3
      //  public static IEnumerable<BooksAndPrint> PrintMedia { get => printMedia; }      
        //Use if Lambda Expression for Lab3
       // public static IEnumerable<OnlineResources> OnlineResources { get => onlineResources; }





        ////BooksAndPrint list is hardcoded at this time
        //public static List<BooksAndPrint> printMedia = new List<BooksAndPrint> {         
        //    new BooksAndPrint{Title = "Secret History of Twin Peaks", Hyperlink = "http://www.bymarkfrost.com/books/secret_history_of_twin_peaks.html", PublicationYear = "2016"},
        //    new BooksAndPrint{Title = "Twin Peaks Final Dossier", Hyperlink = "http://www.bymarkfrost.com/books/twin_peaks_final_dossier.html", PublicationYear = "2017"},
        //    new BooksAndPrint{Title = "Secret Diary of Laura Palmer", Hyperlink = "http://www.bymarkfrost.com/books/secret_diary_of_laura_palmer.html", PublicationYear = "2011"}           
        //    };    

        ////OnlineResources list is hardcoded at this time.
        //public static List<OnlineResources> onlineResources = new List<OnlineResources> { 
        //    new OnlineResources{Title = "Twin Peaks Wiki", Hyperlink = "https://en.wikipedia.org/wiki/Twin_Peaks"}      
        //    };



        //Hard coded data for UserStories
        //public static List<UserStory> stories = new List<UserStory>
        //{
        //    new UserStory{Name = "Brian", Location = "Springfield", Title = "first story", Story = "This is the first story",},                
        //    new UserStory{Name = "Ashley", Location = "Eugene", Title = "Second story", Story = "This is the second story"}
        //};

        //public static UserComments testStory = new UserComments { Name = "Brian", Comment = "Test Comment 1" };

        //public static IEnumerable<UserStory> Stories
        //{
        //    get
        //    {
        //        return stories;
        //    }
        //}

    }
}
