using DPA.SHOPPING.DOMAIN.Core.Entities;
using DPA.SHOPPING.DOMAIN.Core.Interfaces;
using DPA.SHOPPING.DOMAIN.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;

namespace DPA.Shopping.API.Controllers
{
    [Route("api/[controller]")]
    
    public class FavoriteController : ControllerBase
    {
        private readonly IFavoriteRepository _favoriteRepository;

        public FavoriteController(IFavoriteRepository favoriteRepository)
        {
            _favoriteRepository = favoriteRepository;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _favoriteRepository.GetAll();
            return Ok(result);



        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _favoriteRepository.GetById(id);
            if (result == null)

                return NotFound();

            return Ok(result);


        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Favorite favorite)
        {
            var result = await _favoriteRepository.Insert(favorite);
            if (!result)
                return BadRequest(result);
            return Ok(result);

        }

        [HttpPut]

        public async Task<IActionResult> Update([FromBody] Favorite favorite)
        {
            var result = await _favoriteRepository.Update(favorite);
            if (!result)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _favoriteRepository.Delete(id);
            if (!result)
                return NotFound(result);

            return Ok(result);
        }


    }
}
