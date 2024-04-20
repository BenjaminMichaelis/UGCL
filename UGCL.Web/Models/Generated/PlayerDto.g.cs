using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace UGCL.Web.Models
{
    public partial class PlayerDtoGen : GeneratedDto<UGCL.Data.Models.Player>
    {
        public PlayerDtoGen() { }

        private int? _PlayerId;
        private string _Name;

        public int? PlayerId
        {
            get => _PlayerId;
            set { _PlayerId = value; Changed(nameof(PlayerId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(UGCL.Data.Models.Player obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.PlayerId = obj.PlayerId;
            this.Name = obj.Name;
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(UGCL.Data.Models.Player entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(PlayerId))) entity.PlayerId = (PlayerId ?? entity.PlayerId);
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override UGCL.Data.Models.Player MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new UGCL.Data.Models.Player()
            {
                Name = Name,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(PlayerId))) entity.PlayerId = (PlayerId ?? entity.PlayerId);

            return entity;
        }
    }
}
