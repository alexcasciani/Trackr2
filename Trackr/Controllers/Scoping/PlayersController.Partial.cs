﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Telerik.OpenAccess.FetchOptimization;
using TrackrModels;
using Telerik.OpenAccess;

namespace Trackr
{
    public partial class PlayersController : OpenAccessBaseApiController<TrackrModels.Player, TrackrModels.ClubManagement>, IScopableController<int>
    {
        private class PlayersScopeController : IScopable<Player, int>
        {
            public List<int> SelectIDListByScopeAssignment(ScopeAssignment scopeAssignment, Expression<Func<Player, bool>> preFilter)
            {
                using (ClubManagement cm = new ClubManagement())
                {
                    List<int> IDs = new List<int>();

                    switch (scopeAssignment.Scope.ScopeName)
                    {
                        case "Club": // highest level
                            //List<int> clubTeamIDs = cm.Programs.Where(i => i.ClubID == scopeAssignment.ResourceID).Include<Program>(i => i.Teams).SelectMany(i => i.Teams).Select(i => i.TeamID).Distinct().ToList();
                            //IDs.AddRange(cm.Players.Include<Player>(i=>i.TeamPlayers).Where(i => clubTeamIDs.Contains(i.player)).Select(i => i.TeamPlayerID));
                            break;

                        case "Program":
                            //List<int> programTeamIDs = cm.Teams.Where(i => i.ProgramID == scopeAssignment.ResourceID).Select(i => i.TeamID).Distinct().ToList();
                            //IDs.AddRange(cm.TeamPlayers.Where(i => programTeamIDs.Contains(i.TeamID)).Select(i => i.TeamPlayerID).Distinct());
                            break;

                        case "Team":
                            //IDs.AddRange(cm.TeamPlayers.Where(i => i.TeamID == scopeAssignment.ResourceID).Select(i => i.TeamPlayerID).Distinct());
                            break;
                    }

                    return IDs;
                }
            }
        }

        public Player GetScopedEntity(int UserID, string permission, int primaryKey)
        {
            return GetScopedEntity(UserID, permission, primaryKey, new FetchStrategy());
        }

        public Player GetScopedEntity(int UserID, string permission, int primaryKey, FetchStrategy fetch)
        {
            List<int> playerIDs = ScopeController<PlayersScopeController, Player, int>.GetScopedIDList(UserID, permission, i => i.PlayerID==primaryKey);
            return GetWhere(i => playerIDs.Contains(i.PlayerID), fetch).FirstOrDefault();
        }

        public IEnumerable<Player> GetScopedEntities(int UserID, string permission)
        {
            return GetScopedEntities(UserID, permission, new FetchStrategy());
        }

        public IEnumerable<Player> GetScopedEntities(int UserID, string permission, FetchStrategy fetch)
        {
            List<int> playerIDs = ScopeController<PlayersScopeController, Player, int>.GetScopedIDList(UserID, permission, i => true == true);
            return GetWhere(i => playerIDs.Contains(i.PlayerID), fetch);
        }

        public List<int> GetScopedIDs(int UserID, string permission)
        {
            return ScopeController<PlayersScopeController, Player, int>.GetScopedIDList(UserID, permission, i => true == true);
        }

        public bool IsUserScoped(int UserID, string permission, int entityID)
        {
            return ScopeController<PlayersScopeController, Player, int>.IsUserScoped(UserID, permission, entityID);
        }
    }
}