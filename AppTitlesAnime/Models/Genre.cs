using System;
using System.Collections.Generic;

namespace AppTitlesAnime.Models;

public partial class Genre
{
    public short Id { get; set; }

    public string GenreName { get; set; } = null!;

    // навигационные свойства

    public virtual ICollection<TitlesGanre> TitlesGanres { get; set; } = new List<TitlesGanre>();
}
