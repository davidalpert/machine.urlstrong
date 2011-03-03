using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Machine.UrlStrong.Sample.Controllers
{
  public class HomeController : Controller
  {
    public void Index()
    {
      //Redirect(Urls.root.user[3].friend.list);
        Redirect(Urls.root.some.strange.action);
    }

    public void Redirect(ISupportGet url)
    {
      
    }
  }
}
