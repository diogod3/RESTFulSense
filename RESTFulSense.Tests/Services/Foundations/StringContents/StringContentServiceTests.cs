﻿// ---------------------------------------------------------------------------------- 
// Copyright (c) The Standard Organization, a coalition of the Good-Hearted Engineers 
// ----------------------------------------------------------------------------------

using System.Reflection;
using Moq;
using RESTFulSense.Brokers.Reflections;
using RESTFulSense.Models.Attributes;
using RESTFulSense.Services.Foundations.StringContents;
using Tynamix.ObjectFiller;

namespace RESTFulSense.Tests.Services.Foundations.StringContents
{
    public partial class StringContentServiceTests
    {
        private readonly Mock<IReflectionBroker> reflectionBrokerMock;
        private readonly IStringContentService stringContentService;

        public StringContentServiceTests()
        {
            reflectionBrokerMock = new Mock<IReflectionBroker>();
            stringContentService = new StringContentService(reflectionBrokerMock.Object);
        }

        private static PropertyInfo CreateMockPropertyInfo() =>
            new Mock<PropertyInfo>().Object;

        private static PropertyInfo CreateNullPropertyInfo() => null;

        private static RESTFulStringContentAttribute CreateRandomStringContent() =>
            new RESTFulStringContentAttribute(name: CreateRandomString());

        private static string CreateRandomString() =>
            new MnemonicString().GetValue();
    }
}
