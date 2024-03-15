using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mission10_Whisenant.Data;

public partial class BowlingLeagueContext : DbContext
{
    public BowlingLeagueContext(DbContextOptions<BowlingLeagueContext> options)
        : base(options)
    {
    }

    public DbSet<Bowler> Bowlers { get; set; }

    public DbSet<Team> Teams { get; set; }
}


