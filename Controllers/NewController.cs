using Microsoft.AspNetCore.Mvc;

namespace mashrahAskingQendpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{
     [HttpGet]
    [Route("Askingquestions")]
    public string Askingquestions(){
     return "what is your name" ;  
    }
    }
   
     

    