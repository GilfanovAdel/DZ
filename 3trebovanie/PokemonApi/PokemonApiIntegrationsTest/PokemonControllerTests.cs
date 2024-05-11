using System.Net;
using PokemonApi.Controllers;

namespace PokemonApi.IntegrationsTests
{
    [TestClass]
    public class PokemonControllerTests
    {
        //private PokemonController _controller;

        [TestInitialize]
        public void Initialize()
        {
            //TODO: написать минимум по 4 теста на каждый метод контроллера
            //TODO: в качестве данных использовать Moq (vk)
            //TODO: тестировать через http_client

            //_controller = new PokemonController();
        }

        [TestMethod]
        public void GetAll_WhenQueryIsNull_ReturnData()
        {
            // Arrange

            // Act

            // Assert

        }
    }
}