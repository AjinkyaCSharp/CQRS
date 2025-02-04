using CQRSWithMediatR.Model;
using CQRSWithMediatR.Queries;
using MediatR;
using Moq;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Mock<IMediator> mediator= new Mock<IMediator>();
           // mediator.Setup(m => m.Send(It.IsAny<GetEmployeeCommad>())).ReturnsAsync

            Assert.Pass();
        }
    }
}