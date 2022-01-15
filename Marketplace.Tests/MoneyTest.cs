using FluentAssertions;
using Marketplace.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Marketplace.Tests;

public class MoneyTest
{
    [Fact]
    public void MoneyObjectsWithTheSameAmountShouldBeEqual()
    {
        var firstAmount = new Money(5);
        var secondAmount = new Money(5);
        firstAmount.Should().Be(secondAmount, "Because Object has te same amount");
    }
}

