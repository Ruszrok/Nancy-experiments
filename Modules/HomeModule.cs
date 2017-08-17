using Nancy;

public class HomeModule : NancyModule
{
	public HomeModule()
	{
		Get("/", args => "Hello World");
	}
}