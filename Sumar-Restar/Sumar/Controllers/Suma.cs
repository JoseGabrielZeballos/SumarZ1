﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Suma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Sumacontroller : ControllerBase
    {
        [HttpGet]
        [Route("Add")]
        public int Add(int a, int b)
        {
            return a + b;
        }
        [HttpPost]
        [Route("Add")]
        public int Add2([FromHeader] int a, [FromHeader] int b)
        {
            return a + b;
        }
        [HttpGet]
        [Route("Multiply")]
        public int MUL1(int a, int b)
        {
            return a * b;
        }
        [HttpPost]
        [Route("Multiply")]
        public int MUL2([FromHeader] int a, [FromHeader] int b)
        {
            return a * b;
        }
    }
}
