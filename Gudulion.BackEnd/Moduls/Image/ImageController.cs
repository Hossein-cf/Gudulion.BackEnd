﻿using Gudulion.BackEnd.Controllers;
using Gudulion.BackEnd.DB;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Gudulion.BackEnd.Moduls.Image;

public class ImageController : GenericController<Sweet.Sweet>
{
    private readonly IImageService _imageService;

    public ImageController(MainDbContext context, IImageService imageService) : base(context)
    {
        _imageService = imageService;
    }

    [HttpPost]
    public IActionResult Save([FromBody] ImageWithData image)
    {
        return Ok(_imageService.Save(image));
    }

    [HttpGet]
    public IActionResult Get([FromBody] ImageEntity imageEntity)
    {
        return Ok(_imageService.Get(imageEntity));
      
    }

    [HttpDelete]
    public IActionResult Delete([FromBody] ImageEntity imageEntity)
    {
        _imageService.Delete(imageEntity);
        return Ok();
    }
}

