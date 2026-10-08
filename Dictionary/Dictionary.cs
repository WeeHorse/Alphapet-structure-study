
namespace DictionarySystem;

using Newtonsoft.Json;
using System.Collections.ObjectModel;
using WordSystem;

// Note that this class is DictionarySystem.Dictionary, but... (below)
class Dictionary
{

  private const string WordListPath = "wordlists/swedish-words.json";

  // Note that this class is the build in C# Dictionary (compared to this class, see above...)
  // Thus we can have two different classes that happen to have the same name
  private System.Collections.Generic.Dictionary<string, List<string>>? wordlist;

  public Dictionary()
  {
    ReadWordList();
  }

  private void ReadWordList()
  {
    var json = File.ReadAllText(WordListPath);
    wordlist = JsonConvert.DeserializeObject<System.Collections.Generic.Dictionary<string, List<string>>>(json);
  }

}
