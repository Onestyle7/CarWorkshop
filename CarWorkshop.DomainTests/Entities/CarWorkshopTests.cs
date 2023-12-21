using Xunit;
using CarWorkshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Domain.Entities.Tests
{
    public class CarWorkshopTests
    {
        [Fact()]
        public void EncodeName_ShouldSetEncodedName()
        {
            //Arange
            var carworkshop = new CarWorkshop();
            carworkshop.Name = "Test Workshop";

            //act
            carworkshop.EncodeName();

            //assert
            carworkshop.EncodeName.Should().Be("test-workshop");
        }
    }
}