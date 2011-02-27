using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Machine.UrlStrong.Translation.Model;
using Spark;

namespace Machine.UrlStrong.Translation.Generation
{
  public abstract class TemplateBase : AbstractSparkView
  {
    public UrlStrongModel Model { get; set; }

    public string Indent(int tabs, object code)
    {
        if (code == null)
        	return "";

      var indentation = "  ";
      for (int i = 0; i < tabs - 1; i++)
      {
        indentation += "  ";
      }

      var builder = new StringBuilder();
      var reader = new StringReader(code.ToString());
      var line = reader.ReadLine();

      while (line != null)
      {
        builder.Append(indentation);
        builder.Append(line);
        line = reader.ReadLine();
        if (line != null)
        {
          builder.AppendLine();
        }
      }

      return builder.ToString();
    }

    public string Indent(object code)
    {
      return Indent(1, code);
    }
  }
}