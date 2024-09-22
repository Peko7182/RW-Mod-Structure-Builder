# RimWorld Mod Structure Builder

![App Icon](RW%20Mod%20Structure%20Builder.png)

A simple console application that automates the creation of a RimWorld mod structure based on user inputs.

## Features

- Automatically creates the basic folder structure for a RimWorld mod
- Optionally **creates a Visual Studio project** if selected
- Automatically saves build output to `Common/Assemblies`
- Generates the `About.xml` file with user-provided metadata
- Supports adding mod dependencies, load order, and incompatibilities
- Handles mod preview image and icon
- Provides helpful information about mod structure and file purposes

## How It Works

*Video from v0.0.0 (Outdated)*
![Demo GIF](Ussage.gif)

1. Run the application.
2. Provide paths for your mod preview image and icon.
3. Follow the prompts to enter your mod details:
    - Mod name
    - Package ID
    - Author(s)
    - Description
    - Supported RimWorld versions
    - Visual Studio Project creation (y/n)
        - If "y", it will create a new structure with the following:
            - `About`
            - `Common`
                - Subfolders
            - `Source`
                - Visual Studio Project (`.sln`, `.csproj`, `.cs`, `Properties/AssemblyInfo.cs`)
        - Build output automatically saved to `Common/Assemblies`
4. The application will create the mod folder structure in your RimWorld mods directory.

## Folder Structure Created

### Default Structure:

- About
    - About.xml
    - Preview.png
    - ModIcon.png (if provided)
- Assemblies
- Defs
- Languages
- Patches
- Sounds
- Textures

### If Visual Studio Project is Selected:

- About
- Common
    - Subfolders (`Assemblies`, `Defs`, ...)
- Source
    - Visual Studio Project (`.sln`, `.csproj`, `.cs`, `Properties/AssemblyInfo.cs`)

## Getting Started

1. Go to the [latest release on GitHub](https://github.com/Peko7182/RimWorld-Mod-Structure-Builder/releases)
2. Download the single executable file
3. Run the application
4. Follow the on-screen prompts to create your mod structure

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contributing

Contributions are welcome!

## Acknowledgments

- RimWorld Wiki for mod structure information
- RimWorld modding community for inspiration and guidance