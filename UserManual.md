# Game Cheat Template Manual

## Overview

This template is designed for creating game cheats or trainers that interface with a game's memory. It is structured into three scripts:

1. **Program.cs**: Initializes the application and manages the overlay rendering.
2. **MemoryUtils.cs**: Contains utility functions for memory manipulation.
3. **CheatLogic.cs**: Manages cheat logic and user interface rendering.

By following this guide, even beginners can get started with using and customizing the template.

---

## Getting Started

### Prerequisites

1. Install **Visual Studio** with C# development tools.
2. Download and reference the **ImGui.NET** and **ClickableTransparentOverlay** libraries.
3. Have a target game running for testing. Replace placeholders like `GameProcessNameHere` and `GameModuleName.dll` with actual values for the game you're working with.

### Setting Up

1. **Program.cs**:
   - No modifications are needed unless you want to alter the overlay behavior.
   - This script manages the overlay window and starts the cheat logic thread.

2. **MemoryUtils.cs**:
   - Contains methods to read and write memory. Update offsets and logic in `ResolvePointerChain`, `WriteFloat`, and `WriteBytes` as needed for your target game.

3. **CheatLogic.cs**:
   - Replace `ProcessName` and `GameModule` with your game's process and module names.
   - Add offsets and memory manipulation logic specific to your desired features.

---

## How to Use the Template

### Running the Template

1. Compile and run the project in Visual Studio.
2. Launch the target game.
3. The overlay should appear on the game screen.
4. Use the UI rendered by the cheat logic to toggle features.

### Using Memory Functions

The utility functions in **MemoryUtils.cs** are central to interacting with the game's memory. Below are detailed instructions for each function:

#### 1. WriteBytes

**Purpose**: Write a sequence of bytes to a specific memory address.

**Usage**:

```csharp
MemoryUtils.WriteBytes(processHandle, gameBase, 0x123456, new byte[] { 0x90, 0x90, 0x90 });
```

- `processHandle`: Handle to the game's process.
- `gameBase`: Base address of the game module.
- `offset`: Offset from the base address.
- `bytes`: Array of bytes to write.

#### 2. ReadFloat

**Purpose**: Read a float value from a memory address.

**Usage**:

```csharp
float value = MemoryUtils.ReadFloat(processHandle, someAddress);
```

- `processHandle`: Handle to the game's process.
- `someAddress`: Address to read from.

#### 3. WriteFloat

**Purpose**: Write a float value to a memory address.

**Usage**:

```csharp
MemoryUtils.WriteFloat(processHandle, someAddress, 123.45f);
```

- `processHandle`: Handle to the game's process.
- `someAddress`: Address to write to.
- `value`: The float value to write.

#### 4. ResolvePointerChain

**Purpose**: Resolve a chain of pointers to find a dynamic memory address.

**Usage**:

```csharp
IntPtr address = MemoryUtils.ResolvePointerChain(processHandle, baseAddress, new int[] { 0x10, 0x20 });
```

- `processHandle`: Handle to the game's process.
- `baseAddress`: Base pointer address.
- `offsets`: Array of offsets to traverse.

---

## Customizing the Cheat Logic

### Adding Features

1. Open **CheatLogic.cs**.
2. Add toggles in `RenderUI` for the new feature.
3. Implement the feature logic in `RunHackLogic`.

**Example**:

- Add a checkbox in the UI:

```csharp
ImGui.Checkbox("God Mode", ref godMode);
```

- Implement the logic:

```csharp
if (godMode)
{
    MemoryUtils.WriteBytes(processHandle, gameBase, 0x123456, new byte[] { 0x90, 0x90 });
}
else
{
    MemoryUtils.WriteBytes(processHandle, gameBase, 0x123456, new byte[] { 0x89, 0x50 });
}
```

### Adding Tabs

- Use `ImGui.BeginTabItem` to create new categories in the UI.

**Example**:

```csharp
if (ImGui.BeginTabItem("New Feature"))
{
    // Add UI elements here
    ImGui.EndTabItem();
}
```

---

## Notes

- Avoid using this template for unethical purposes.
- Memory manipulation can lead to crashes or bans in online games. Use with caution.

---

## Troubleshooting

- **The overlay doesn't appear**:
  - Ensure the target game is running.
  - Verify `ProcessName` and `GameModule` values.

- **Memory functions fail**:
  - Double-check the offsets and pointer chains.
  - Ensure the game is running with administrator privileges.

- **High CPU usage**:
  - Adjust the `Thread.Sleep` duration in `RunHackLogic`.
