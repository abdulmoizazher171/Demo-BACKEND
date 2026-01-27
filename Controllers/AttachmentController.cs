using ERP_BACKEND.constracts;
using ERP_BACKEND.dtos;
using ERP_BACKEND.interfaces;
namespace ERP_BACKEND.services;
using ERP_BACKEND.interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
[Authorize]

public class AttachmentController : ControllerBase
{
    private readonly IAttachment _attachmentService;

    public AttachmentController(IAttachment attachmentService)
    {
        _attachmentService = attachmentService;
    }

      

    [HttpGet("{id}")]
   public async Task<ActionResult<IEnumerable<Attachment>>> GetAllAttachments([FromRoute]int id)
    {
        var attachments = await _attachmentService.GetAllAttachementsAsync(id);
        return Ok(attachments);
    }

    [HttpPost("upload")]
    public async Task<IActionResult> UploadImage([FromForm] IFormFile file, 
    [FromForm] int assetId)
    {
        if (file == null || file.Length == 0) return BadRequest("No file uploaded");

            var attachment = await _attachmentService.UploadAttachmentAsync(file, assetId);
    // 1. Define the folder path
        return attachment != null ? Ok(attachment) : BadRequest("File upload failed");
    }
}
