﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace My_News
{
    class StrHelper
    {
        public string HtmlToPlainText(string html)
        {
            const string tagWhiteSpace = @"(>|$)(\W|\n|\r)+<";//matches one or more (white space or line breaks) between '>' and '<'
            const string stripFormatting = @"<[^>]*(>|$)";//match any character between '<' and '>', even when end tag is missing
            const string lineBreak = @"<(br|BR)\s{0,1}\/{0,1}>";//matches: <br>,<br/>,<br />,<BR>,<BR/>,<BR />
            var lineBreakRegex = new Regex(lineBreak, RegexOptions.Multiline);
            var stripFormattingRegex = new Regex(stripFormatting, RegexOptions.Multiline);
            var tagWhiteSpaceRegex = new Regex(tagWhiteSpace, RegexOptions.Multiline);

            var text = html;
            //Decode html specific characters
            //text = System.Net.WebUtility.HtmlDecode(text);
            text = XmlDecode(text);
            //Remove tag whitespace/line breaks
            text = tagWhiteSpaceRegex.Replace(text, "><");
            //Replace <br /> with line breaks
            text = lineBreakRegex.Replace(text, Environment.NewLine);
            //Strip formatting
            text = stripFormattingRegex.Replace(text, string.Empty);
            //Wrap

            text = Regex.Replace(text, @"(.{50}\s)", @"$1" + Environment.NewLine);
            return text;
        }
        public string XmlEncode(string value)
        {
            return value
              .Replace("<", "&lt;")
              .Replace(">", "&gt;")
              .Replace("\"", "&quot;")
              .Replace("'", "&apos;")
              .Replace("&", "&amp;")
              .Replace(" ", "&nbsp;");
        }

        public string XmlDecode(string value)
        {
            return value
              .Replace("&lt;", "<")
              .Replace("&gt;", ">")
              .Replace("&quot;", "\"")
              .Replace("&apos;", "'")
              .Replace("&amp;", "&")
              .Replace("&nbsp;", " ");
        }
        public bool isNumber(string str)
        {
            int result;
            return int.TryParse(str, out result);
        }
    }
}
