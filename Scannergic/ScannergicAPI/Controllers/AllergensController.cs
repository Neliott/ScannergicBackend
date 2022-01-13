﻿using Microsoft.AspNetCore.Mvc;
using ScannergicAPI.Repositories;
using ScannergicAPI.Entities;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using MySql.Data.MySqlClient;

namespace ScannergicAPI.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/allergens")]
    [ApiController]
    public class AllergensController : ControllerBase
    {
        private AllergenRepository repository;

        public AllergensController()
        {
            repository = new AllergenRepository();
        }
        /// <summary>
        /// Returns a list of all the allergens as a JSON
        /// </summary>
        /// <returns>List of allergens or http error code</returns>
        [HttpGet]
        public ActionResult<AllergenContainer> GetAllergens()
        {
            try
            {
                return repository.GetAllergens();
            }
            catch (MySqlException)
            {
                return StatusCode(500);
            }
        }

        public ActionResult<AllergenContainer> GetAllergensByProdct(long productNumber)
        {
            try
            {
                throw new System.NotImplementedException();
            }
            catch (MySqlException)
            {
                return StatusCode(500);
            }
        }
    }
}
