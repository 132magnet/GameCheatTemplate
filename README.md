# How to Install

Follow these steps to get started with your project.

### Step 1: Create a New Project
- Open **Visual Studio** and create a new project.
  ![Create New Project](./pictures/1.png)

### Step 2: Select Console App with .NET
- Choose **Console App** under the .NET section.
  ![Select Console App](./pictures/2.png)

### Step 3: Choose a Project Name
- Enter a name for your project.
  ![Project Name](./pictures/3.png)

### Step 4: Select .NET 6.0
- Ensure **.NET 6.0** is selected. If you don’t have it installed, use the Visual Studio Installer to download it.
  ![Select .NET 6.0](./pictures/4.png)

### Step 5: Open the Project
- After the project loads, double-click on the **ProjectName** in the Solution Explorer to open it.
  ![Open Project](./pictures/5.png)

### Step 6: Add Required Packages
- In the project file, paste the following code to install the necessary packages:

  ```csharp
  <ItemGroup>
      <PackageReference Include="ClickableTransparentOverlay" Version="6.2.1" />
      <PackageReference Include="ImGui.NET" Version="1.89.7.1" />
      <PackageReference Include="SixLabors.ImageSharp" Version="3.1.6" />
      <PackageReference Include="Veldrid.ImGui" Version="5.72.0" />
      <PackageReference Include="Vortice.Mathematics" Version="1.6.2" />
  </ItemGroup>
  ```

  ![Add Packages](./pictures/6.png)

### Step 7: Open the Project in Explorer
- Right-click on the **Project Explorer** and select **Open in Explorer**.
  ![Open in Explorer](./pictures/7.png)

### Step 8: Download and Add Scripts
- Download the [Scripts](./scripts) folder, then drag and drop them into your project.
  ![Add Scripts](./pictures/8.png)

### Step 9: Replace `Program.cs`
- Replace the original **Program.cs** with the one from the downloaded scripts.
  ![Replace Program.cs](./pictures/9.png)

### Step 10: Open and Review Scripts
- Double-click on the scripts in the **Solution Explorer** to open and review them.
  ![Open Scripts](./pictures/10.png)

### Step 11: Verify the Final Setup
- After following all steps, your project should look like this:
  ![Final Setup](./pictures/11_finish.png)

---

## Test the Project

### Step 1: Start the Project
- Click **Start** to run the project.
  ![Start Project](./pictures/12_test.png)

### Step 2: Verify the Output
- The project should look like this when it runs successfully:
  ![Test Output](./pictures/13_test.png)
