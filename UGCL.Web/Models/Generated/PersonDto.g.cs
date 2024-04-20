using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace UGCL.Web.Models
{
    public partial class PersonDtoGen : GeneratedDto<UGCL.Data.Models.Person>
    {
        public PersonDtoGen() { }

        private int? _PersonId;
        private string _Name;
        private System.DateTimeOffset? _BirthDate;

        public int? PersonId
        {
            get => _PersonId;
            set { _PersonId = value; Changed(nameof(PersonId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }
        public System.DateTimeOffset? BirthDate
        {
            get => _BirthDate;
            set { _BirthDate = value; Changed(nameof(BirthDate)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(UGCL.Data.Models.Person obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.PersonId = obj.PersonId;
            this.Name = obj.Name;
            this.BirthDate = obj.BirthDate;
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(UGCL.Data.Models.Person entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(PersonId))) entity.PersonId = (PersonId ?? entity.PersonId);
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
            if (ShouldMapTo(nameof(BirthDate))) entity.BirthDate = BirthDate;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override UGCL.Data.Models.Person MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new UGCL.Data.Models.Person()
            {
                Name = Name,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(PersonId))) entity.PersonId = (PersonId ?? entity.PersonId);
            if (ShouldMapTo(nameof(BirthDate))) entity.BirthDate = BirthDate;

            return entity;
        }
    }
}
