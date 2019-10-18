using RandomTeam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomTeam.DAL
{
   public interface ITeamRepository
    {
        Team GetTeams();
    }
}
