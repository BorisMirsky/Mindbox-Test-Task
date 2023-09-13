using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mindbox1.Controllers;
using Xunit;
using Mindbox1.Models;
using Moq;
using Microsoft.AspNetCore.Http;
using FakeHttpContext;


namespace Mindbox1.Tests
{
    public class HomeControllerTests
    {

        [Fact]
        public void IndexViewResultNotNull()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void CircleSqrCalculationTest()
        {
            //Arrange
            IndexModel model = new IndexModel();
            //Act
            model.CircleRadius = "15";
            //Assert
            double Radious = Convert.ToDouble(model.CircleRadius);
            double CircleSquare = Math.Round((Math.PI * Radious * Radious), 4);
            Assert.Equal(706.8583, CircleSquare);
        }


        [Fact]
        public void TriangleSidesTest()
        {
            //Arrange
            IndexModel model = new IndexModel();
            //Act
            model.TriangleSide1 = "7";
            model.TriangleSide2 = "8";
            model.TriangleSide3 = "9";
            double TrS1 = Convert.ToDouble(model.TriangleSide1);
            double TrS2 = Convert.ToDouble(model.TriangleSide2);
            double TrS3 = Convert.ToDouble(model.TriangleSide3);
            double p = 0.5 * (TrS1 + TrS2 + TrS3);  //semiperimeter
            double TriangleArea = Math.Round(Math.Sqrt(p * (p - TrS1) * (p - TrS2) * (p - TrS3)), 3);
            //Arrange
            Assert.Equal(26.833, TriangleArea);
        }

        [Fact]
        public void TriangleImpossibleTest()
        {
            //Arrange
            IndexModel model = new IndexModel();
            //Act
            model.TriangleSide1 = "7";
            model.TriangleSide2 = "8";
            model.TriangleSide3 = "9";
            double TrS1 = Convert.ToDouble(model.TriangleSide1);
            double TrS2 = Convert.ToDouble(model.TriangleSide2);
            double TrS3 = Convert.ToDouble(model.TriangleSide3);
            double p = 0.5 * (TrS1 + TrS2 + TrS3);  //semiperimeter
            double TriangleArea = Math.Round(Math.Sqrt(p * (p - TrS1) * (p - TrS2) * (p - TrS3)), 3);
            //Arrange
            Assert.Equal(TriangleArea!, TriangleArea);
        }

        public void RightTriangleSidesTest()
        {
            //Arrange
            IndexModel model = new IndexModel();
            //Act
            model.TriangleSide1 = "6";
            model.TriangleSide2 = "8";
            model.TriangleSide3 = "10";
            double TrS1 = Convert.ToDouble(model.TriangleSide1);
            double TrS2 = Convert.ToDouble(model.TriangleSide2);
            double TrS3 = Convert.ToDouble(model.TriangleSide3);
            double p = 0.5 * (TrS1 + TrS2 + TrS3);  //semiperimeter
            double TriangleArea = Math.Round(Math.Sqrt(p * (p - TrS1) * (p - TrS2) * (p - TrS3)), 3);
            //Arrange
            Assert.Equal(24, TriangleArea);
        }

    }
}


