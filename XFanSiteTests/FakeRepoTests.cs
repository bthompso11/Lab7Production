using System;
using Xunit;
using FanSite.Controllers;
using FanSite.Models;
using System.Linq;


namespace XFanSiteTests
{
    public class FakeRepoTests
    {
        [Fact]
        public void TestAddBookNameField()
        {
            //Arrange
            FakeRepository fakeRepo = new FakeRepository();
            HomeController homeController = new HomeController(fakeRepo);
            UserStory newStory = new UserStory()
            {
                Name = "Brian",
                Location = "Springfield",
                Title = "Test story1",
                Story = "Test Story 1"
            };

            //Act
            homeController.Stories(newStory);

            //Assert
            Assert.Equal("Brian", fakeRepo.Stories[fakeRepo.Stories.Count -1].Name );
        }

        [Fact]
        public void TestAddBookLocationField()
        {
            //Arrange
            FakeRepository fakeRepo = new FakeRepository();
            HomeController homeController = new HomeController(fakeRepo);
            UserStory newStory = new UserStory()
            {
                Name = "Brian",
                Location = "Springfield",
                Title = "Test story1",
                Story = "Test Story 1"
            };

            //Act
            homeController.Stories(newStory);

            //Assert
            Assert.Equal("Springfield", fakeRepo.Stories[fakeRepo.Stories.Count - 1].Location);
        }

        [Fact]
        public void TestAddBookTitleField()
        {
            //Arrange
            FakeRepository fakeRepo = new FakeRepository();
            HomeController homeController = new HomeController(fakeRepo);
            UserStory newStory = new UserStory()
            {
                Name = "Brian",
                Location = "Springfield",
                Title = "Test story1",
                Story = "Test Story 1"
            };

            //Act
            homeController.Stories(newStory);

            //Assert
            Assert.Equal("Test story1", fakeRepo.Stories[fakeRepo.Stories.Count - 1].Title);
        }

        [Fact]
        public void TestAddBookStoryField()
        {
            //Arrange
            FakeRepository fakeRepo = new FakeRepository();
            HomeController homeController = new HomeController(fakeRepo);
            UserStory newStory = new UserStory()
            {
                Name = "Brian",
                Location = "Springfield",
                Title = "Test story1",
                Story = "Test Story 1"
            };

            //Act
            homeController.Stories(newStory);

            //Assert
            Assert.Equal("Test Story 1", fakeRepo.Stories[fakeRepo.Stories.Count - 1].Story);
        }

        [Fact]
        public void TestSortByTitle()
        {
            //Arrange
            FakeRepository fakeRepo = new FakeRepository();
            HomeController homeController = new HomeController(fakeRepo);
            UserStory newStory = new UserStory()
            {
                Name = "Brian",
                Location = "Springfield",
                Title = "Test story1",
                Story = "Test Story 1"
            };

            UserStory newStory1 = new UserStory()
            {
                Name = "Bernie",
                Location = "Eugene",
                Title = "Bernie's Story",
                Story = "Test Story 2"
            };

            UserStory newStory2 = new UserStory()
            {
                Name = "Coda",
                Location = "Springfield",
                Title = "Coda's Story",
                Story = "Test Story 3"
            };

            //Act
            //Adding data to the repo
            homeController.Stories(newStory);  //Test story1 title
            homeController.Stories(newStory2); // Coda's Story
            homeController.Stories(newStory1); //Bernie's Story  

            fakeRepo.SortStories();
           

            //Assert
            // Bernie's story should be sorted as the first title
            Assert.Equal("Bernie's Story", fakeRepo.Stories[0].Title);
        }

        [Fact]
        public void TestAddCommentCommentField()
        {
            //Arrange
            FakeRepository fakeRepo = new FakeRepository();
            HomeController homeController = new HomeController(fakeRepo);
            UserComments uC1 = new UserComments()
            {
               Name = "Brian",
               Comment = "Test Comment 1"
            };

            //Act
            homeController.AddComment(uC1.Name, uC1.Comment);
            
            //Assert
            Assert.Equal("Test Comment 1", fakeRepo.Comments[0].Comment);
        }

        [Fact]
        public void TestAddCommentNameField()
        {
            //Arrange
            FakeRepository fakeRepo = new FakeRepository();
            HomeController homeController = new HomeController(fakeRepo);
            UserComments uC1 = new UserComments()
            {
                Name = "Brian",
                Comment = "Test Comment 1"
            };

            //Act
            homeController.AddComment(uC1.Name, uC1.Comment);

            //Assert
            Assert.Equal("Brian", fakeRepo.Comments[0].Name);
        }

    }
}
