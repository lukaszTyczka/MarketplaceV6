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
        var firstAmount = Money.FromDecimal(5);
        var secondAmount = Money.FromDecimal(5);
        firstAmount.Should().Be(secondAmount, "Because Object has te same amount");
    }

    [Fact]
    public void SumOfMoneyGiveFullAmount()
    {
        var coin1 = Money.FromDecimal(1);
        var coin2 = Money.FromDecimal(2);
        var coin3 = Money.FromDecimal(2);
        var banknot = Money.FromDecimal(5);

        banknot.Should().Be(coin1+ coin2 + coin3);
    }

    [Fact]
    public void SubtractOfMoneyGiveAmount()
    {
        var banknot = Money.FromDecimal(10);
        var banknot2 = Money.FromDecimal(5);
        var resultBanknot = Money.FromDecimal(5);

        resultBanknot.Should().Be(banknot - banknot2);
    }
}

