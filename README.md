# How to install

1. Open Visual Studio and create a new project.
![How?](./pictures/1.png)

2. Select Console App with .NET.
![How?](./pictures/2.png)

3. Choose a Projectname.
![How?](./pictures/3.png)

4. Select .NET 6.0. If you dont have it, download it with the visual studio installer.
![How?](./pictures/4.png)

5. The Project should open, Double-Click on the Projectname as shown.
![How?](./pictures/5.png)

6. Paste the following code to install all needed packages:

```csharp
<ItemGroup>
	<PackageReference Include="ClickableTransparentOverlay" Version="6.2.1" />
	<PackageReference Include="ImGui.NET" Version="1.89.7.1" />
	<PackageReference Include="SixLabors.ImageSharp" Version="3.1.6" />
	<PackageReference Include="Veldrid.ImGui" Version="5.72.0" />
	<PackageReference Include="Vortice.Mathematics" Version="1.6.2" />
</ItemGroup>
```
![How?](./pictures/6.png)

7. Right-Click on the Project Explorer and Select open in Explorer.
![How?](./pictures/7.png)

8. Download the [Scripts](./scripts) and drag them into you project.
![How?](./pictures/8.png)

9. Replace the original `Program.cs`.
![How?](./pictures/9.png)

10. Double-Click on the Scripts to Open them.
![How?](./pictures/10.png)

11. It should look like this:
![How?](./pictures/11_finish.png)

## Test the Project

1. Click here to start.
![How?](./pictures/12_test.png)

2. It should look like this:
![How?](./pictures/13_test.png)
