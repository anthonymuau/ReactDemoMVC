using React;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ReactDemo.ReactConfig), "Configure")]

namespace ReactDemo
{
  public static class ReactConfig
  {
	public static void Configure()
	{
	  ReactSiteConfiguration.Configuration = new ReactSiteConfiguration()
		  .AddScript("~/Scripts/Tutorial.jsx");
	}
  }
}