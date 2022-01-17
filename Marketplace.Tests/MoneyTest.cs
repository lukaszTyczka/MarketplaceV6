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

    [Fact]
    public void SumOfMoneyGiveFullAmount()
    {
        var coin1 = new Money(1);
        var coin2 = new Money(2);
        var coin3 = new Money(2);
        var banknot = new Money(5);

        banknot.Should().Be(coin1+ coin2 + coin3);
    }

    [Fact]
    public void SubtractOfMoneyGiveAmount()
    {
        var banknot = new Money(10);
        var banknot2 = new Money(5);
        var resultBanknot = new Money(5);

        resultBanknot.Should().Be(banknot - banknot2);
    }
}

