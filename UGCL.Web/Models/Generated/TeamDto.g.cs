using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace UGCL.Web.Models
{
    public partial class TeamDtoGen : GeneratedDto<UGCL.Data.Models.Team>
    {
        public TeamDtoGen() { }

        private int? _TeamId;
        private int? _Player1Id;
        private UGCL.Web.Models.PersonDtoGen _Player1;
        private int? _Player2Id;
        private UGCL.Web.Models.PersonDtoGen _Player2;

        public int? TeamId
        {
            get => _TeamId;
            set { _TeamId = value; Changed(nameof(TeamId)); }
        }
        public int? Player1Id
        {
            get => _Player1Id;
            set { _Player1Id = value; Changed(nameof(Player1Id)); }
        }
        public UGCL.Web.Models.PersonDtoGen Player1
        {
            get => _Player1;
            set { _Player1 = value; Changed(nameof(Player1)); }
        }
        public int? Player2Id
        {
            get => _Player2Id;
            set { _Player2Id = value; Changed(nameof(Player2Id)); }
        }
        public UGCL.Web.Models.PersonDtoGen Player2
        {
            get => _Player2;
            set { _Player2 = value; Changed(nameof(Player2)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(UGCL.Data.Models.Team obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.TeamId = obj.TeamId;
            this.Player1Id = obj.Player1Id;
            this.Player2Id = obj.Player2Id;
            if (tree == null || tree[nameof(this.Player1)] != null)
                this.Player1 = obj.Player1.MapToDto<UGCL.Data.Models.Person, PersonDtoGen>(context, tree?[nameof(this.Player1)]);

            if (tree == null || tree[nameof(this.Player2)] != null)
                this.Player2 = obj.Player2.MapToDto<UGCL.Data.Models.Person, PersonDtoGen>(context, tree?[nameof(this.Player2)]);

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(UGCL.Data.Models.Team entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(TeamId))) entity.TeamId = (TeamId ?? entity.TeamId);
            if (ShouldMapTo(nameof(Player1Id))) entity.Player1Id = (Player1Id ?? entity.Player1Id);
            if (ShouldMapTo(nameof(Player2Id))) entity.Player2Id = (Player2Id ?? entity.Player2Id);
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override UGCL.Data.Models.Team MapToNew(IMappingContext context)
        {
            var entity = new UGCL.Data.Models.Team();
            MapTo(entity, context);
            return entity;
        }
    }
}
