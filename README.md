# SR5Initiative

A simple Shadowrun 5E initiative tracker, written in Blazor WebAssembly. Partly intended as a way to learn Blazor in the first place, and also as a tool for my own use in Shadowrun.

A test version of the app can be found [here](https://varr0k-sr5initiative.azurewebsites.net/) - not always guaranteed to be up-to-date!

## Description

* Add/remove combatants to the initiative tracker
* Modify initiative values on the fly
* Next Phase button decrements all initiative values by 10
* Different color highlighting for PCs/allied NPCs/hostile NPCs (optional!) and any combatants with 0 Initiative remaining (not optional!)
* Autoroll initiative for non-player characters
* Tie-breaking handled automatically using Edge/Reaction/Intuition (currently excluding coin-toss!)

**NOTE:** Not exactly a professionally-developed application. Caveat emptor!

## Getting Started

### Dependencies

* .NET 5.0
* Blazor WebAssembly

## Notes

The app is designed to run as a Blazor webapp, and (hopefully!) includes support for Progressive Web App functions - that way, it can be saved to your device of choice for later, offline use.

## Authors

[varr0k](https://github.com/varr0k)

## License

This project is licensed under the MIT License - see the LICENSE.md file for details

## Acknowledgments

* [@DomPizzie](https://twitter.com/dompizzie) for the README template
