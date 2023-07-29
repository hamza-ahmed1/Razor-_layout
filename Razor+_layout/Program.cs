var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();

app.Run();
#region MyRegion
/*
 * Using a Layout Page
In the previous section, you saw that including the same content in many web pages is easy.

Another approach to creating a consistent look is to use a layout page. A layout page contains the structure, but not the content, of a web page. When a web page (content page) is linked to a layout page, it will be displayed according to the layout page (template).

The layout page is just like a normal web page, except from a call to the @RenderBody() method where the content page will be included.

Each content page must start with a Layout directive.

This is how it looks in code:

D.R.Y. - Don't Repeat Yourself
With two ASP.NET tools, Content Blocks and Layout Pages, you can give your web applications a consistent look.

These tools also save you a lot of work, since you don't have to repeat the same information on all pages. Centralizing markup, style, and code makes web applications much more manageable and easier to maintain.

Preventing Files from Being Browsed
With ASP.NET, files with a name that starts with an underscore cannot be browsed from the web.

If you want to prevent your content blocks or layout files from being viewed by your users, rename the files to:

_header.cshtml

_footer.cshtml

_Layout.cshtml
 */
#endregion
