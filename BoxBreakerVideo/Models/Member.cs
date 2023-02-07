using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BoxBreakerVideo.Models;

public partial class Member
{
    [Key]
    public int MemberId { get; set; }

    public string MemberFname { get; set; } = null!;

    public string MemberLname { get; set; } = null!;

    public string MemberEmail { get; set; } = null!;

    public string MemberPhone { get; set; } = null!;

    public string MemberAddress { get; set; } = null!;

    public string MemberPassword { get; set; } = null!;

    public virtual ICollection<MemberMovie> MemberMovies { get; } = new List<MemberMovie>();
}
