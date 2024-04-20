
using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Api;
using IntelliTect.Coalesce.Api.Behaviors;
using IntelliTect.Coalesce.Api.Controllers;
using IntelliTect.Coalesce.Api.DataSources;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Mapping.IncludeTrees;
using IntelliTect.Coalesce.Models;
using IntelliTect.Coalesce.TypeDefinition;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using UGCL.Web.Models;

namespace UGCL.Web.Api
{
    [Route("api/Match")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class MatchController
        : BaseApiController<UGCL.Data.Models.Match, MatchDtoGen, UGCL.Data.AppDbContext>
    {
        public MatchController(CrudContext<UGCL.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<UGCL.Data.Models.Match>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<MatchDtoGen>> Get(
            int id,
            DataSourceParameters parameters,
            IDataSource<UGCL.Data.Models.Match> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<MatchDtoGen>> List(
            ListParameters parameters,
            IDataSource<UGCL.Data.Models.Match> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<UGCL.Data.Models.Match> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<MatchDtoGen>> Save(
            [FromForm] MatchDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<UGCL.Data.Models.Match> dataSource,
            IBehaviors<UGCL.Data.Models.Match> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("bulkSave")]
        [Authorize]
        public virtual Task<ItemResult<MatchDtoGen>> BulkSave(
            [FromBody] BulkSaveRequest dto,
            [FromQuery] DataSourceParameters parameters,
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromServices] IBehaviorsFactory behaviorsFactory)
            => BulkSaveImplementation(dto, parameters, dataSourceFactory, behaviorsFactory);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<MatchDtoGen>> Delete(
            int id,
            IBehaviors<UGCL.Data.Models.Match> behaviors,
            IDataSource<UGCL.Data.Models.Match> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
