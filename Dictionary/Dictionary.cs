
namespace DictionarySystem;

using Newtonsoft.Json;
using System.Collections.ObjectModel;
using WordSystem;

class Dictionary
{

  private Object? wordlist;

  public Dictionary()
  {
    ReadWordList();
  }

  private void ReadWordList()
  {
    wordlist = JsonConvert.DeserializeObject("{\"words:\":[\"dog\", \"cog\"]}");
  }

}
