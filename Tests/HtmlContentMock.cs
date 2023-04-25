using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Html;

namespace SemestriProject.Tests
{
    internal class HtmlContentMock : IHtmlContent
    {
        private readonly string content;
        public HtmlContentMock(string s) => content = s;
        public void WriteTo(TextWriter writer, HtmlEncoder encoder) => writer.WriteLine(content);
        public override string ToString() => content;
    }
}
