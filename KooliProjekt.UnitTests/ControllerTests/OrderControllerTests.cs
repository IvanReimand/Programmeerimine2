﻿using System;
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
    public class OrederControllerTests
    {
        private readonly Mock<IOrderService> _orderServiceMock;
        private readonly OrderController _controller;

        public OrederControllerTests()
        {
            _orderServiceMock = new Mock<IOrderService>();
            _controller = new OrderController(null, _orderServiceMock.Object);
        }

        [Fact]
        public async Task Index_should_return_correct_view_with_data()
        {
            // Arrange
            int page = 1;
            var data = new List<Order>
            {
                new Order { Id = 1 },
                new Order { Id = 2 }
            };
            var pagedResult = new PagedResult<Order> { Results = data };
            _orderServiceMock.Setup(x => x.List(page, It.IsAny<int>(), null)).ReturnsAsync(pagedResult);

            // Act
            var result = await _controller.Index(page) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(pagedResult, result.Model);
        }
    }
}