﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;

using Xunit;

using Amazon;

namespace DependencyInjectionTests
{
    public class LoadOptionsTests
    {
        public LoadOptionsTests()
        {
        }

        [Fact]
        public void GetProfileAndRegion()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetProfileAndRegionTest.json");

            IConfiguration config = builder.Build();
            var options = config.GetAWSOptions();

            Assert.Equal(RegionEndpoint.USWest2, options.Region);
            Assert.Equal("myProfile", options.Profile);
        }
    }
}
