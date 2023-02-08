using System;
using System.Collections.Generic;

namespace GOTBoardGame.Models;

public partial class Card
{
    public int CardId { get; set; }

    public string? CharacterName { get; set; }

    public string? House { get; set; }

    public int? CombatStrength { get; set; }

    public bool? Starred { get; set; }

    public int? Sword { get; set; }

    public int? Tower { get; set; }

    public string? AbilityDescription { get; set; }

    public string? Quote { get; set; }
}
