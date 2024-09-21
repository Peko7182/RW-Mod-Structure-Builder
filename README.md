# RimWorld Mod Structure Builder

![App Icon](RW%20Mod%20Structure%20Builder.png)

A simple console application that automates the creation of a RimWorld mod structure based on user inputs.

## Features

- Automatically creates the basic folder structure for a RimWorld mod
- Generates the `About.xml` file with user-provided metadata
- Supports adding mod dependencies, load order, and incompatibilities
- Handles mod preview image and icon
- Provides helpful information about mod structure and file purposes

## How It Works

![Demo GIF](Ussage.gif)

1. Run the application
2. Follow the prompts to enter your mod details:
    - Mod name
    - Package ID
    - Author(s)
    - Description
    - Supported RimWorld versions
    - Optional: mod version, URL, dependencies, etc.
3. Provide paths for your mod preview image and icon
4. The application will create the mod folder structure in your RimWorld mods directory

## Folder Structure Created

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

## Getting Started

1. Go to the [latest release on GitHub](https://github.com/Peko7182/RimWorld-Mod-Structure-Builder/releases)
2. Download the single executable file
3. Run the application
4. Follow the on-screen prompts to create your mod structure

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- RimWorld Wiki for mod structure information
- RimWorld modding community for inspiration and guidance