using FluentAssertions;
using ZenitPolarProject;

namespace ZenitPolarTests;

public class ZenitTest
{
    [Fact]
    public void Encrypt_WithP_ShouldReturnZ()
    {
        //arrange
        var sut = new ZenitEncrypter();
        
        //act
        var result = sut.Encrypt("P");
        
        //assert
        var expected = "Z";
        result.Should().Be(expected);
    }
}