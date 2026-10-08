namespace WordSystem;

using TileSystem;

class Word
{

  public string DisplayWord = "";

  public Word(Tile[] tiles)
  {
    DisplayWord = JoinTilesToString(tiles);
  }


  private string JoinTilesToString(Tile[] tiles)
  {
    string word = "";
    foreach (var tile in tiles)
    {
      word += tile.letter;
    }
    return word;
  }

}