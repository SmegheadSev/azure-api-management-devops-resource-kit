﻿using Xunit;
using Microsoft.OpenApi.Models;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Test
{
    public class OpenAPISpecReaderTests
    {
        [Fact]
        public async void ShouldConvertOpenApiSpecToDocument()
        {
            // arrange
            OpenAPISpecReader openAPISpecReader = new OpenAPISpecReader();
            string fileLocation = "https://petstore.swagger.io/v2/swagger.json";

            // act
            OpenApiDocument doc = await openAPISpecReader.ConvertOpenAPISpecToDoc(fileLocation);

            // assert
            // document is only used to pull protocols, ensure servers is not null (contains protocols)
            Assert.NotNull(doc.Servers);
        }
    }
}
