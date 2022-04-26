# Optimizely add-on sample

Sample with boilerplate code for an Optimizely add-on.

## Summary
Solution consists of one project for the add-on (**Addon** folder), and a second project for the website (**Website** folder).

The website project was set up using the **Optimizely CMS empty** Visual Studio template.

# Get started
1. Clone project
1. Create empty database and update `appsettings.json` (or run `create-db.bat` in the solution folder if you're using **LocalDB**)
1. Start **Website** project and browse to https://localhost:5000/ which will prompt you to create an admin user
1. Access the Optimizely UI through: https://localhost:5000/episerver/cms using the credentials of the admin user
1. Create a new page of type `SamplePageType`
1. Notice how the `SomeString` property has a wider textbox for editing

## Add-on development tips

* Load client resources from add-on project to make refreshing client resources easier (see `ServiceCollectionExtensions.cs` in **Addon** project).
* Enable UI debugging (see `ServiceCollectionExtensions.cs` in **Addon** project).
* Add the `EPiServer.UI.Sources` NuGet package to get uncompressed source code of the Optimizely UI including Dojo.