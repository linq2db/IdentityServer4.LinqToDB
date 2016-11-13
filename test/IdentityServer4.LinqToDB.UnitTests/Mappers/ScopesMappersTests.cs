﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.LinqToDB.Mappers;
using IdentityServer4.Models;
using Xunit;

namespace IdentityServer4.LinqToDB.UnitTests.Mappers
{
    public class ScopesMappersTests
    {
        [Fact]
        public void ScopeAutomapperConfigurationIsValid()
        {
            var model = new Scope();
            var mappedEntity = model.ToEntity();
            var mappedModel = mappedEntity.ToModel();

            Assert.NotNull(mappedModel);
            Assert.NotNull(mappedEntity);
            ScopeMappers.Mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}