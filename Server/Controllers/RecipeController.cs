﻿using GeniusChef.Server.Data;
using GeniusChef.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeniusChef.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class RecipeController : ControllerBase
    {
        [HttpPost, Route("GetRecipeIdeas")]
        public async Task<ActionResult<List<Idea>>> GetRecipeIdeas(RecipeParms recipeParms)
        {
             return SampleData.RecipeIdeas;
        }

    }
}
