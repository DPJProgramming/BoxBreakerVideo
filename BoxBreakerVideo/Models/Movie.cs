using System;
using System.Collections.Generic;

namespace BoxBreakerVideo.Models;

public partial class Movie
{
    public long MovieId { get; set; }

    public string Title { get; set; } = null!;

    public string Genre { get; set; } = null!;

    public string? MovieDescription { get; set; }

    public string? MovieRuntime { get; set; }

    public DateTime ReleaseDate { get; set; }

    public string MaturityRating { get; set; } = null!;

    public string? MoviePoster { get; set; }

    public decimal? MoviePrice { get; set; }

    public virtual ICollection<MemberMovie> MemberMovies { get; } = new List<MemberMovie>();
}
