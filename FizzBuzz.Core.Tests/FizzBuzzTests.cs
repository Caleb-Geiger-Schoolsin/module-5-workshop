using Xunit;

namespace FizzBuzz.Core.Tests;

public class FizzBuzzTests
{
    private FizzBuzzService _fizzbuzzservice;

    public FizzBuzzTests()
    {
        _fizzbuzzservice = new FizzBuzzService();
    }

    [Fact]
    public void Should_Return_Number()
    {
        //assert
        Assert.Equal("1", _fizzbuzzservice.Print(1));
        Assert.Equal("2", _fizzbuzzservice.Print(2));
    }

    [Fact]
    public void Should_Return_Fizz() 
    {
        Assert.Equal("Fizz", _fizzbuzzservice.Print(3));
        Assert.Equal("Fizz", _fizzbuzzservice.Print(6));
    }

    [Fact]
    public void Should_Return_Buzz() 
    {
        Assert.Equal("Buzz", _fizzbuzzservice.Print(5));
        Assert.Equal("Buzz", _fizzbuzzservice.Print(10));
    }

    [Fact]
    public void Should_Return_FizzBuzz() 
    {
        Assert.Equal("FizzBuzz", _fizzbuzzservice.Print(15));
        Assert.Equal("FizzBuzz", _fizzbuzzservice.Print(30));
    }
}