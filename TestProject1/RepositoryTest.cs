using ConsoleApp1;

namespace TestProject1
{
    public class RepositoryTest
    {
        [Fact]
        public void CreateRepo()
        {
            var repo = new Repository();
            var act = repo.CreateRepo();

            Assert.Equal("Sam RepoCreated", act);
        }

        [Fact]
        public void ReadRepo()
        {
            var act = Repository.ReadRepo();

            Assert.Equal("Readed repo", act);
        }

        [Fact]
        public void DeleteRepo()
        {
            var act = Repository.ReadRepo();

            Assert.Equal("Readed repo", act);
        }
    }
}