# Alphapet – structure study

A study of how to structure a Scrabble-like word game ("Alphapet") in C# (.NET 10). Most classes are empty skeletons; the focus is on how the code is organised and how the pieces relate.

## Layout

Each domain concept has its own folder and its own namespace (`<Name>System`):

| Folder | Namespace | Purpose |
|---|---|---|
| `Bag/` | `BagSystem` | The bag of tiles to draw from |
| `Board/` | `BoardSystem` | The game board; `Board/Square/` holds the board's squares and `SquareScore` |
| `Dictionary/` | `DictionarySystem` | Word list (loaded from JSON via Newtonsoft.Json) used to validate words |
| `Player/` | `PlayerSystem` | Player, plus `PlayerHistory`, `PlayerRegister` and `PlayerScore` |
| `Rack/` | `RackSystem` | A player's rack of tiles |
| `Score/` | `ScoreSystem` | Shared scoring type |
| `Tile/` | `TileSystem` | `Tile` (a letter and its points, a `record`) and `TileScore` |
| `Word/` | `WordSystem` | `Word`, built from an array of `Tile`s |

`Program.cs` is the entry point.

## Design ideas

- **Service-oriented structure:** `Player` is meant to be the API for its folder. It forwards to the underlying classes (`PlayerScore`, `PlayerHistory`, ...) and exposes only what other classes should use.
- **Layered scoring:** each level has its own `*Score` class that wraps the shared `Score`: tile score → square score → word/move score → player score.

## Status

Mostly scaffolding. Implemented so far: `Tile`, `Word` (joins tiles into a string) and a stub `Dictionary` that reads a hard-coded JSON word list.

## Run

```
dotnet run
```
