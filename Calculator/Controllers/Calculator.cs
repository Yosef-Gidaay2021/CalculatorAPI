
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Calculator : ControllerBase
    {
       [HttpGet("add")]
       public ActionResult<decimal> Add([FromQuery] decimal left, [FromQuery] decimal right){
           return left + right;
       }

       [HttpGet("subtract")]
       public ActionResult<decimal> Subtract([FromQuery] decimal left, [FromQuery] decimal right){
        return left - right;
       }

       [HttpGet("multiply")]
       public ActionResult<decimal> Multiply([FromQuery] decimal left, [FromQuery] decimal right){

        return left * right;
       }

       [HttpGet("divide")]
       public ActionResult<decimal> Divide([FromQuery] decimal left, [FromQuery] decimal right){

        if(right == 0){
            return BadRequest("Division by zero not allowed");
        }

         return left / right;
       }
       [HttpGet("modulo")]
       public ActionResult<decimal> Modulo([FromQuery] decimal left, [FromQuery] decimal rigth){
       if(rigth==0){
        return BadRequest("Division by zero not allowed");
       }

       return left % rigth;
       }
    
    }
}