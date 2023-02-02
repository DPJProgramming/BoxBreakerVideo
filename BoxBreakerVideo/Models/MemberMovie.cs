﻿using System;
using System.Collections.Generic;

namespace BoxBreakerVideo.Models;

public partial class MemberMovie
{
    public long MovieId { get; set; }

    public int MemberId { get; set; }

    public DateTime CheckoutDate { get; set; }

    public DateTime DueDate { get; set; }

    public virtual Member Member { get; set; } = null!;

    public virtual Movie Movie { get; set; } = null!;
}
