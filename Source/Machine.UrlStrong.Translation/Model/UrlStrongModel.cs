﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Machine.UrlStrong.Translation.Model
{
  public class UrlStrongModel
  {
    readonly List<ParsedUrl> _urls;
    readonly List<string> _namespaces;
    readonly string _defaultNamespace;
    readonly UrlTree _urlTree;
    readonly string _className;

    public UrlStrongModel(List<ParsedUrl> urls, List<string> namespaces, string defaultNamespace, string className)
    {
      _urls = urls;
      _namespaces = namespaces;
      _defaultNamespace = defaultNamespace;
      _urlTree = new UrlTree(_urls);
      _className = className;
    }

    public UrlTree UrlTree
    {
      get { return _urlTree; }
    }

    public string DefaultNamespace
    {
      get { return _defaultNamespace; }
    }

    public IEnumerable<ParsedUrl> Urls
    {
      get { return _urls; }
    }

    public IEnumerable<string> Namespaces
    {
      get { return _namespaces; }
    }

    public string ClassName
    {
      get { return _className; }
    }
  }
}
