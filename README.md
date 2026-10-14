# TouchPad Editor

A Windows desktop app (C#, WinForms, .NET Framework 4.6.1) for designing the button layout of an Arduino touchscreen controller such as the [RotoCop touchpad](https://github.com/EveAeternam/RotoTouch-OS).

## What it does
- **Layout:** pick portrait or landscape (240 × 320 / 320 × 240), the grid's rows and columns, spacing and background colour, with a warning when the grid can't fit every button.
- **Buttons:** add buttons, set their colour and the key or text each one sends, and preview the result in a separate window.
- **Firmware:** load a `.fw` package from [TouchPad-Firmwares](https://github.com/EveAeternam/TouchPad-Firmwares), read its version and assembly instructions, and check GitHub for a newer release.
- **Device:** list serial ports and auto-detect the board.

Status: 2018 prototype. Flashing the board from the app and saving or loading configurations were never wired up; use the Arduino IDE to upload. Not maintained.

## Build
Open `TouchPad UI Editor.sln` in Visual Studio and build.
