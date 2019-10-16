using RandomTeam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomTeam.DAL.Abstract
{
   public interface ITeamDal
    {
        Team GetTeams();
    }
}
