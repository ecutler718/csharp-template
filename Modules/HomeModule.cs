using Nancy;

namespace Sample
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["sample.html"];

    }
  }
}
