using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace TextWrap
{
    public class TextWrapShould
    {
        [Fact]
        public void not_wrap_if_enough_columns()
        {
            Wrap("hello", 7).Should().Be("hello");
        }

        [Fact]
        public void wrap_if_not_enough_columns_and_no_spaces()
        {
            Wrap("hola",2 ).Should().Be("ho\nla");
        }

        public string Wrap(string text, int columns)
        {
            if (text.Length <= columns)
            {
                return text;
            }
            throw new NotImplementedException();
        }
    }
}
