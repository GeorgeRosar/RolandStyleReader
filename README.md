TomiSoft Roland Style Reader
============================

An open-source project that helps reading (not writing or editing yet) Roland arranger keyboards' style files.
For documentation, see Documentation.chm file.

Requirements
------------
This library requires Microsoft .NET Framework 4 or compatible Mono Framework. No other libraries required.

Usage
-----
1. Rebuild the solution in Release build mode
2. Add "Roland Style Reader.dll" as reference to your project from "Roland Style Reader/Roland Style Reader/bin/Release" directory
3. In your .cs file, add "using TomiSoft.RolandStyleReader;" line
4. Enjoy using RolandStyle class

Example
-------
A simple example is available in the "StyleDemo" project. Note that this project still under development. In the
example the Midi-dot-net library is used for playback the style. The Midi-dot-net library requires Microsoft Windows Multimedia API (winmm.dll), that is only available for Microsoft Windows platform. Because of this, the example application can only run on Microsoft Windows.

For more information about Midi-dot-net and license, see
https://code.google.com/p/midi-dot-net/

Known issues
------------
See issues tab.

Contact
-------
Author: Sinku Tamás (sinkutamas@gmail.com)

Warranty
--------
This library comes with absolutely no warranty. The author does not take responsibility for any damages or data loss.

Licensing
---------
Licensed under GNU GPL v3. See LICENSE for more details.
