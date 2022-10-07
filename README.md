# Serve staticfiles

Create a folder named wwwroot and then you can add folders inside that.

## Program.cs

Add below code 

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
           Path.Combine(builder.Environment.ContentRootPath, "wwwroot/images")),
    RequestPath = "/images"
});

Then you can check the images with your browser like
https://localhost:x/images/aku.jpg