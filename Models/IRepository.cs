using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public interface IRepository
    {
      
        List<UserStory> Stories { get; }
        List<BooksAndPrint> PrintMedia { get; }
        List<OnlineResources> OnlineResources { get; }
        void AddStory(UserStory story);
        void SortStories();
        void SortBooksAndPrintList();
        void AddResponse(UserStory userStories);
        void AddCommentToStory(String userComment);
        void AddComment(UserComments userComment);
                
    }
}
