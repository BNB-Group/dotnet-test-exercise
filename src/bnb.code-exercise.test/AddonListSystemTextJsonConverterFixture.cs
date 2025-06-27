using System.Text.Json;
using Bnb.CodeExercise.Controllers.Models;

namespace bnb.code_exercise.test;

[TestFixture]
public class AddonListSystemTextJsonConverterFixture
{
    private JsonSerializerOptions _options;

    [SetUp]
    public void Setup()
    {
        _options = new JsonSerializerOptions
        {
            Converters = { new AddonListSystemTextJsonConverter() }
        };
    }

    [Test]
    public void should_be_able_to_convert_json_to_addon_list()
    {
        var json = @"[ ""Addon1:10.01"", ""Addon2"" ]";

        var addons = JsonSerializer.Deserialize<Addon[]>(json, _options);

        Assert.That(addons, Is.Not.Null);
        Assert.That(addons.Length, Is.EqualTo(2));
        Assert.That(addons[0].Type, Is.EqualTo("Addon1"));
        Assert.That(addons[0].Value, Is.EqualTo(10.01m));
        Assert.That(addons[1].Type, Is.EqualTo("Addon2"));
        Assert.That(addons[1].Value, Is.Null);
    }

    [Test]
    public void should_be_able_to_convert_addon_list_to_json()
    {
        var addons = new[]
        {
            new Addon { Type = "Addon1", Value = 5m },
            new Addon { Type = "Addon2" }
        };

        var json = JsonSerializer.Serialize(addons, _options);

        Assert.That(json, Is.EqualTo(@"[""Addon1:5"",""Addon2""]"));
    }
}
