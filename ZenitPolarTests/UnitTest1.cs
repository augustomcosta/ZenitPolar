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

    [Fact]

    public void Encrypt_WithO_ShouldReturnE()
    {
        //arrange 
        var sut = new ZenitEncrypter();
        
        //act
        var result = sut.Encrypt("O");
        
        //assert
        var expected = "E";
        result.Should().Be(expected);
    }

    [Fact]
    public void Encrypt_WithL_ShouldReturnN()
    {
        //arrange 
        var sut = new ZenitEncrypter();
        
        //act
        var result = sut.Encrypt("L");
        
        //assert
        var expected = "N";
        result.Should().Be(expected);
    }

    [Fact]
    public void Encrypt_WithA_ShouldReturnI()
    {
        //arrange
        var sut = new ZenitEncrypter();
        
        //act
        var result = sut.Encrypt("A");
        
        //assert
        var expected = "I";
        result.Should().Be(expected);
    }

    [Fact]
    public void Encrypt_WithR_ShouldReturnT()
    {
        //arrange 
        var sut = new ZenitEncrypter();
        
        //act
        var result = sut.Encrypt("R");
        
        //assert
        var expected = "T";
        result.Should().Be(expected);
    }
    
    [Fact]
    public void Encrypt_WithPlowerCase_ShouldReturnZlowerCase()
    {
        //arrange
        var sut = new ZenitEncrypter();
        
        //act
        var result = sut.Encrypt("p");
        
        //assert
        var expected = "z";
        result.Should().Be(expected);
    }

    [Fact]

    public void Encrypt_WithOlowerCase_ShouldReturnElowerCase()
    {
        //arrange 
        var sut = new ZenitEncrypter();
        
        //act
        var result = sut.Encrypt("o");
        
        //assert
        var expected = "e";
        result.Should().Be(expected);
    }

    [Fact]
    public void Encrypt_WithLlowercase_ShouldReturnNlowercase()
    {
        //arrange 
        var sut = new ZenitEncrypter();
        
        //act
        var result = sut.Encrypt("l");
        
        //assert
        var expected = "n";
        result.Should().Be(expected);
    }

    [Fact]
    public void Encrypt_WithAlowercase_ShouldReturnIlowercase()
    {
        //arrange
        var sut = new ZenitEncrypter();
        
        //act
        var result = sut.Encrypt("a");
        
        //assert
        var expected = "i";
        result.Should().Be(expected);
    }

    [Fact]
    public void Encrypt_WithRlowercase_ShouldReturnTlowercase()
    {
        //arrange 
        var sut = new ZenitEncrypter();
        
        //act
        var result = sut.Encrypt("r");
        
        //assert
        var expected = "t";
        result.Should().Be(expected);
    }

    [Fact]
    public void Encrypt_WithPolar_ShouldReturnZenit()
    {
        //arrange 
        var sut = new ZenitEncrypter();
        
        //act
        var result = sut.Encrypt("POLAR");
        
        //assert
        var expected = "ZENIT";
        result.Should().Be(expected);
    }
    
    [Fact]
    public void Encrypt_WithPolarlowerCase_ShouldReturnZenitlowerCase()
    {
        //arrange 
        var sut = new ZenitEncrypter();
        
        //act
        var result = sut.Encrypt("polar");
        
        //assert
        var expected = "zenit";
        result.Should().Be(expected);
    }
}