# Kurisutaru's KAMiBAKO Mod - BepInEx IL2CPP

A mod for the *KAMiBAKO* game, developed using BepInEx 6 IL2CPP.

## Requirements

- **BepInEx 6**: A modding framework for Unity games.
- **.NET 6.0+**: Required for compiling BepInEx-based plugins.
- **Visual Studio** (or compatible IDE) for building the mod (optional).

## Installation

### 1. Install BepInEx 6

1. Download the [BepInEx 6 Bleeding Edge IL2CPP x64](https://builds.BepInEx.dev/projects/BepInEx_be).
2. Extract the contents into the *KAMiBAKO* game directory (where the game's `KAMiBAKO.exe` is located).

### 2. Install the Mod

1. Download from releases or compile yourself (instruction below).
2. Copy the contents into the `BepInEx/plugins` folder located in the *KAMiBAKO* game directory.

The folder structure should look like this:

```
KAMiBAKO/
│
├── BepInEx/
│   ├── plugins/
│   │   └── YourMod.dll
│   └── config/
└── KAMiBAKO.exe
```

### 3. Verify Installation

Launch *KAMiBAKO*. You should see console output from BepInEx, confirming that the mod is loaded successfully.

## Usage

Once the mod is installed, you can use its features in the game as per the mod's functionality. Please refer to the specific mod documentation for usage instructions.

## Configuration

Configuration file will be generated after first run with the mod installed, they will be located in the `BepInEx/config` folder. The configuration file name was net.kurisutaru.kamibako.cfg

You can edit this file to customize the parameter. I put some description what config for what modify ingame.

## Compile yourself

### Prerequisites

- **Visual Studio 2022** or later.
- **.NET 6 SDK** (or compatible version) for compiling the mod.
- **Assembly-CSharp.dll and Il2Cppmscorlib.dll** to lib folder from BepInEx interop folder.

### Building the Mod

1. Clone or download the repository.
2. Open the solution file in Visual Studio.
3. Build the solution, and the compiled `.dll` will be output to the `bin/Debug` (or `bin/Release`) directory.
4. Copy the compiled `.dll` to the `BepInEx/plugins` folder.

## Troubleshooting

- **Mod Not Loading**: Ensure you're using the IL2CPP version of BepInEx and the mod is placed in the correct `BepInEx/plugins` folder.

## License

This mod is released under the MIT License. See the [LICENSE](LICENSE) file for details.