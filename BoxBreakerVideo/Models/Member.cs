using System;
using System.Collections.Generic;

namespace BoxBreakerVideo.Models;

public partial class Member
{
    public int MemberId { get; set; }

    public string MemberFname { get; set; } = null!;

    public string MemberLname { get; set; } = null!;

    public string MemberEmail { get; set; } = null!;

    public string MemberPhone { get; set; } = null!;

    public string MemberAddress { get; set; } = null!;

    public string MemberPassword { get; set; } = null!;

    public virtual ICollection<MemberMovie> MemberMovies { get; } = new List<MemberMovie>();
}
