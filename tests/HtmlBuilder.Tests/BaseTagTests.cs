namespace HtmlBuilder.Tests
{
    public class BaseTagTests
    {
        private class TestTag(string name) : BaseTag(name)
        {
            public override void Accept(IHtmlVisitor visitor)
            {
                throw new NotImplementedException();
            }
        }

        [Fact]
        public void Constructor_ShouldSetName()
        {
            // Arrange & Act
            var tag = new TestTag("div");

            // Assert
            Assert.Equal("div", tag.Name);
        }

        [Fact]
        public void AddAttribute_ShouldAddAttributeToAttributesCollection()
        {
            // Arrange
            var tag = new TestTag("div");

            // Act
            tag.AddAttribute("key", "value");

            // Assert
            Assert.Contains("key", tag.Attributes);
            Assert.Equal("value", tag.Attributes["key"]);
        }

        [Fact]
        public void AddAttribute_ShouldAddAttributeWithNullValue()
        {
            // Arrange
            var tag = new TestTag("div");

            // Act
            tag.AddAttribute("key");

            // Assert
            Assert.Contains("key", tag.Attributes);
            Assert.Null(tag.Attributes["key"]);
        }

        [Fact]
        public void AddAttributes_ShouldAddMultipleAttributes()
        {
            // Arrange
            var tag = new TestTag("div");
            var attributes = new Dictionary<string, string?>
            {
                { "key1", "value1" },
                { "key2", "value2" }
            };

            // Act
            tag.AddAttributes(attributes);

            // Assert
            Assert.Equal("value1", tag.Attributes["key1"]);
            Assert.Equal("value2", tag.Attributes["key2"]);
        }

        [Fact]
        public void SetId_ShouldSetIdAttribute()
        {
            // Arrange
            var tag = new TestTag("div");

            // Act
            tag.SetId("test-id");

            // Assert
            Assert.Equal("test-id", tag.Attributes["id"]);
        }

        [Fact]
        public void AddClass_ShouldAddClassToClassesCollection()
        {
            // Arrange
            var tag = new TestTag("div");

            // Act
            tag.AddClass("test-class");

            // Assert
            Assert.Contains("test-class", tag.Classes);
        }

        [Fact]
        public void RenderAttributes_ShouldRenderAttributesCorrectly()
        {
            // Arrange
            var tag = new TestTag("div");
            tag.AddAttribute("key1", "value1");
            tag.AddAttribute("key2");

            // Act
            var result = tag.RenderAttributes();

            // Assert
            Assert.Contains(" key1=\"value1\"", result);
            Assert.Contains(" key2", result);
        }
    }
}
