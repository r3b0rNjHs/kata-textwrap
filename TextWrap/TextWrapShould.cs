using System;
using System.Collections.Generic;
using System.Globalization;
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

        [Fact]
        public void wrap_before_word_if_exists_space()
        {
            Wrap("hola, mundo", 9).Should().Be("hola,\nmundo");
        }

        public string Wrap(string text, int columns)
        {
            if (text.Length <= columns)
            {
                return text;
            }

            if (text.Length > columns)
            {
                for (int i = columns; i > 0; i--)
                {
                    if (text.ElementAt(i) == ' ')
                    {
                        StringBuilder sb = new StringBuilder(text);
                        sb[i] = '\n';
                        return sb.ToString();
                    }
                }
                return text.Insert(columns,"\n");
            }

            throw new NotImplementedException();
        }
    }
}
