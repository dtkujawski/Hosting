﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Xunit;

namespace Microsoft.AspNet.TestHost
{
    public class ResponseFeatureTests
    {
        [Fact]
        public void StatusCode_DefaultsTo200()
        {
            // Arrange & Act
            var responseInformation = new ResponseFeature();

            // Assert
            Assert.Equal(200, responseInformation.StatusCode);
            Assert.False(responseInformation.HeadersSent);

            responseInformation.FireOnSendingHeaders();

            Assert.True(responseInformation.HeadersSent);
        }
    }
}