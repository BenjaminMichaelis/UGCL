using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace UGCL.Web.Models
{
    public partial class MatchDtoGen : GeneratedDto<UGCL.Data.Models.Match>
    {
        public MatchDtoGen() { }

        private int? _MatchId;
        private int? _Team1Id;
        private UGCL.Web.Models.TeamDtoGen _Team1;
        private int? _Team2Id;
        private UGCL.Web.Models.TeamDtoGen _Team2;
        private System.DateTimeOffset? _MatchDate;
        private int? _Team1Score;
        private int? _Team2Score;

        public int? MatchId
        {
            get => _MatchId;
            set { _MatchId = value; Changed(nameof(MatchId)); }
        }
        public int? Team1Id
        {
            get => _Team1Id;
            set { _Team1Id = value; Changed(nameof(Team1Id)); }
        }
        public UGCL.Web.Models.TeamDtoGen Team1
        {
            get => _Team1;
            set { _Team1 = value; Changed(nameof(Team1)); }
        }
        public int? Team2Id
        {
            get => _Team2Id;
            set { _Team2Id = value; Changed(nameof(Team2Id)); }
        }
        public UGCL.Web.Models.TeamDtoGen Team2
        {
            get => _Team2;
            set { _Team2 = value; Changed(nameof(Team2)); }
        }
        public System.DateTimeOffset? MatchDate
        {
            get => _MatchDate;
            set { _MatchDate = value; Changed(nameof(MatchDate)); }
        }
        public int? Team1Score
        {
            get => _Team1Score;
            set { _Team1Score = value; Changed(nameof(Team1Score)); }
        }
        public int? Team2Score
        {
            get => _Team2Score;
            set { _Team2Score = value; Changed(nameof(Team2Score)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(UGCL.Data.Models.Match obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.MatchId = obj.MatchId;
            this.Team1Id = obj.Team1Id;
            this.Team2Id = obj.Team2Id;
            this.MatchDate = obj.MatchDate;
            this.Team1Score = obj.Team1Score;
            this.Team2Score = obj.Team2Score;
            if (tree == null || tree[nameof(this.Team1)] != null)
                this.Team1 = obj.Team1.MapToDto<UGCL.Data.Models.Team, TeamDtoGen>(context, tree?[nameof(this.Team1)]);

            if (tree == null || tree[nameof(this.Team2)] != null)
                this.Team2 = obj.Team2.MapToDto<UGCL.Data.Models.Team, TeamDtoGen>(context, tree?[nameof(this.Team2)]);

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(UGCL.Data.Models.Match entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(MatchId))) entity.MatchId = (MatchId ?? entity.MatchId);
            if (ShouldMapTo(nameof(Team1Id))) entity.Team1Id = (Team1Id ?? entity.Team1Id);
            if (ShouldMapTo(nameof(Team2Id))) entity.Team2Id = (Team2Id ?? entity.Team2Id);
            if (ShouldMapTo(nameof(MatchDate))) entity.MatchDate = (MatchDate ?? entity.MatchDate);
            if (ShouldMapTo(nameof(Team1Score))) entity.Team1Score = (Team1Score ?? entity.Team1Score);
            if (ShouldMapTo(nameof(Team2Score))) entity.Team2Score = (Team2Score ?? entity.Team2Score);
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override UGCL.Data.Models.Match MapToNew(IMappingContext context)
        {
            var entity = new UGCL.Data.Models.Match();
            MapTo(entity, context);
            return entity;
        }
    }
}
