using Kata.CodeWars.DoubleChar;
using NUnit.Framework;
using System;

[TestFixture]
public class Test
{
    [Test]
    [TestCase("abcd", ExpectedResult = "aabbccdd")]
    [TestCase("Adidas", ExpectedResult = "AAddiiddaass")]
    [TestCase("1337", ExpectedResult = "11333377")]
    [TestCase("illuminati", ExpectedResult = "iilllluummiinnaattii")]
    [TestCase("123456", ExpectedResult = "112233445566")]
    [TestCase("%^&*(", ExpectedResult = "%%^^&&**((")]
    public static string FixedTest(string s)
    {
        return Kata.CodeWars.DoubleChar.Kata.DoubleChar(s);
    }
}