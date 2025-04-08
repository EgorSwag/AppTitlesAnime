using System;
using System.Collections.Generic;

namespace AppTitlesAnime.Models;

public partial class AnimeTitle
{
    public short Duration { get; set; }

    public int Id { get; set; }

    public string OriginalName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public short IdType { get; set; }

    public short CountSeries { get; set; }

    public string Studio { get; set; } = null!;

    public string? Poster { get; set; }

    public string? Description { get; set; }



    // навигационные свойства
    public virtual Type Type { get; set; } = null!;

    public virtual ICollection<TitlesGanre> TitlesGanres { get; set; } = new List<TitlesGanre>();

    public virtual ICollection<TitlesStatus> TitlesStatuses { get; set; } = new List<TitlesStatus>();
}
