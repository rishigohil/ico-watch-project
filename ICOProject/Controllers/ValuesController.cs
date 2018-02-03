using System.Collections.Generic;
using ICOBusinessLayer.Contract;
using ICOBusinessLayer.DataModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ICOProject.Controllers
{
  [Produces("application/json")]
  [Route("api/[controller]")]
  public class ValuesController : Controller
  {
    private readonly IExchangeService _exchangeService;

    public ValuesController(IExchangeService exchangeService)
    {
      _exchangeService = exchangeService;
    }

    /// <summary>
    /// Web Service to get star ico's.
    /// </summary>
    /// <returns>Action result containing token data object.</returns>
    [HttpGet]
    [Route("icos")]
    public IActionResult GetICOs()
    {
      try
      {
        return Ok(_exchangeService.GetStarIcos());
      }
      catch (System.Exception ex)
      {
        return BadRequest(ex.InnerException);
      }
      
    }

    /// <summary>
    /// Web service to get ico scam results.
    /// </summary>
    /// <param name="icoName"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("icos/{icoName}")]
    public IActionResult GetIcoScamResult(string icoName)
    {
      if (string.IsNullOrEmpty(icoName))
      {
        return BadRequest("Invalid paramters.");
      }

      return Ok(_exchangeService.GetIcoScamStatus(icoName));
    }
  }
}
