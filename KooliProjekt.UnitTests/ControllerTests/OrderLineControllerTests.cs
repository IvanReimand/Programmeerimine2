using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KooliProjekt.Controllers;
using KooliProjekt.Data;
using KooliProjekt.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace KooliProjekt.UnitTests.ControllerTests
{
    public class OrederLineControllerTests
    {
        private readonly Mock<IOrderLineService> _orderLineServiceMock;
        private readonly OrderLineController _controller;

        public OrederLineControllerTests()
        {
            _orderLineServiceMock = new Mock<IOrderLineService>();
            _controller = new OrderLineController(null, _orderLineServiceMock.Object);
        }

        [Fact]
        public async Task Index_should_return_correct_view_with_data()
        {
            // Arrange
            int page = 1;
            var data = new List<OrderLine>
            {
                new OrderLine { Id = 1 },
                new OrderLine { Id = 2 }
            };
            var pagedResult = new PagedResult<OrderLine> { Results = data };
            _orderLineServiceMock.Setup(x => x.List(page, It.IsAny<int>(), null)).ReturnsAsync(pagedResult);

            // Act
            var result = await _controller.Index(page) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(pagedResult, result.Model);
        }
    }
}
