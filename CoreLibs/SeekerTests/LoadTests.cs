using Microsoft.Extensions.Configuration;
using Seeker.Base_Classes;
using Seeker.Interfaces;
using Seeker.SqlOperations;
using SeekerTests.TestModels;

namespace SeekerTests
{
    public class LoadTests
    {
        private IDataContext _context;


        public LoadTests()
        {
            IConfigurationRoot rootConfig = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            _context = new DataContext(rootConfig.GetConnectionString("SqlConnectionString"), "Seeker_Tests");
        }




        [SetUp]
        public void Setup()
        { 

        }

        [Test]
        public void SqlLoadTest()
        {
            Test1 test1 = new Test1();
            Test2 test2 = new Test2();

            IDataOperation ops = new SqlDataOperation(_context);
            ops.Select(test1)
                .Join(test2)
                .Where();
        }
    }
}
