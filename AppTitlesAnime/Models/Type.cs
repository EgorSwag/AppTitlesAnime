using System;
using System.Collections.Generic;

namespace AppTitlesAnime.Models;

public partial class Type
{
    public short Id { get; set; }

    public string TypeName { get; set; } = null!;

    // навигационные свойства

    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
