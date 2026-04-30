# ChemistryApps - Chemistry AR

An augmented reality (AR) mobile application for learning chemistry. Visualize 7 chemical elements and molecular reactions in real-world environments using your mobile device's camera.

## 📱 Features

- **Augmented Reality Visualization**: View 3D molecular models overlaid on real-world surfaces using AR markers
- **Multiple Elements**: Displays 7 chemical elements (atoms) including Hydrogen, Oxygen, and Nitrogen Oxide
- **Audio Support**: Listen to element pronunciations with included audio files
- **Cross-Platform**: Built for both Android (7.0+) and iOS
- **Interactive Models**: Manipulate and interact with 3D molecular structures in AR
- **Educational**: Perfect for chemistry classrooms and self-learning

## 🛠️ Requirements

- **Unity**: 2021.3.28f1 (LTS) or later
- **Android**: 7.0 and later
- **iOS**: Compatible with modern iOS devices
- **AR Capability**: Device must support ARCore (Android) or ARKit (iOS)
- **Marker System**: ArUco markers for AR image tracking

## 📋 Project Structure

```
ChemistryApps/
├── Assets/
│   ├── Audio/                 # Element audio files
│   │   ├── hydrogen.mp3
│   │   ├── nitricOxide.mp3
│   │   └── oxygen.mp3
│   ├── chemistry-ar-main/     # Main AR module
│   │   └── Chemistry AR/
│   ├── Scenes/                # Unity scenes
│   │   └── SampleScene.unity
│   ├── XR/                    # XR settings and loaders
│   │   ├── Loaders/
│   │   └── Settings/
│   ├── Molecule.prefab        # Molecule prefab
│   └── Trigger - R.prefab     # Trigger prefab
├── Packages/                  # Project dependencies
├── ProjectSettings/           # Unity project configuration
├── Library/                   # Generated build data
└── README.md                  # This file
```

## 🚀 Getting Started

### Prerequisites
1. Install [Unity 2021.3.28f1 LTS](https://unity.com/download)
2. **Important**: Ensure your Unity project path contains NO spaces
3. For Android build: Install Android SDK and NDK through Unity Hub
4. For iOS build: Install Xcode

### Opening the Project
1. Clone or download this repository
2. Open Unity Hub
3. Click "Add" and select the `ChemistryApps` folder
4. Wait for Unity to import the project and dependencies
5. Open the `SampleScene` from `Assets/Scenes/`

### Building for Mobile

**For Android:**
1. Go to `File` → `Build Settings`
2. Select `Android` as the target platform
3. Click `Build` and choose an output folder
4. Follow the on-screen prompts to build the APK

**For iOS:**
1. Go to `File` → `Build Settings`
2. Select `iOS` as the target platform
3. Click `Build` to generate the Xcode project
4. Open the generated Xcode project and build from there

## 📚 How to Add New Elements

### Step-by-Step Guide

1. **Generate an AR Marker**
   - Use [ArUco Marker Generator](https://chev.me/arucogen/)
   - Download and print your marker

2. **Create a Card Design** (Optional)
   - Design a card with your marker using [this Figma project](https://github.com/MiroslavShard/chemistry-ar/tree/1.1.0/Chemistry%20AR/Figma)
   - Import the card into the Unity project

3. **Add to Reference Image Library**
   - Open the `ReferenceImageLibrary` file in the project
   - Add your new marker card
   - Set the element name and physical card size

4. **Create a 3D Prefab**
   - Copy an existing element prefab (e.g., Hydrogen)
   - Modify the 3D model to represent your new element
   - Save as a new prefab

5. **Add to Scene**
   - Add the prefab to the scene
   - Register it in the `Object Library`

6. **Verify Naming**
   - Ensure the element name in `ReferenceImageLibrary` matches the `Object Library`
   - Names must be identical for proper tracking

### Handling Multiple Identical Elements
If you want 2+ of the same element on screen, create additional prefabs with numbered names (e.g., `Hydrogen`, `Hydrogen 2`)

## ⚠️ Important Notes

1. **No Spaces in Project Path**: Unity cannot create XR Reference Image Library if the project path contains spaces
2. **Use ArUco Markers**: Do NOT use QR codes for AR image tracking. This project uses ArUco markers for reliable detection
3. **Marker Selection**: Quality markers are essential for consistent AR tracking performance

## 🛠️ Technologies Used

- **Game Engine**: Unity 2021.3.28f1 (LTS)
- **AR Frameworks**: 
  - Google ARCore (Android)
  - Apple ARKit (iOS)
- **3D Graphics**: Unity's built-in rendering pipeline
- **Audio**: Unity Audio System
- **XR Plugin Management**: Unity XR Plugin

## 📁 Key Files and Folders

| Path | Purpose |
|------|---------|
| `Assets/chemistry-ar-main/Chemistry AR/` | Main AR implementation and logic |
| `Assets/Scenes/SampleScene.unity` | Main gameplay scene |
| `Assets/XR/Settings/` | XR configuration and reference libraries |
| `Assets/Molecule.prefab` | Molecule model prefab |
| `ProjectSettings/` | Unity project configuration |

## 🎓 Educational Use

This project is ideal for:
- Chemistry education in classrooms
- Science museums and exhibitions
- Self-paced chemistry learning
- Interactive demonstrations of molecular structures
- Student projects and thesis work

## 🤝 Contributing

Improvements are welcome! Feel free to:
- Add new chemical elements
- Create new molecular reactions
- Improve 3D models and visualizations
- Enhance UI/UX
- Fix bugs or optimize performance

To contribute:
1. Fork the project
2. Create your feature branch
3. Make your improvements
4. Submit a pull request

## 📄 License

This project is based on the original work by [Miroslav Stetsiuk](https://github.com/MiroslavShard/chemistry-ar).

## 👥 Credits

**Original Project**: [Miroslav Stetsiuk](https://github.com/MiroslavShard/chemistry-ar)
- Original Release: 2023
- Instagram: [@miroslavshard](https://www.instagram.com/miroslavshard/)
- Email: miroslavshard@gmail.com

## 📞 Support

For questions about:
- **Original Project**: Contact Miroslav Stetsiuk
- **Local Setup**: Check the troubleshooting section or Unity documentation
- **AR Issues**: Refer to [Google ARCore Docs](https://developers.google.com/ar) or [Apple ARKit Docs](https://developer.apple.com/arkit/)

---

**Made with ❤️ for Science Education**