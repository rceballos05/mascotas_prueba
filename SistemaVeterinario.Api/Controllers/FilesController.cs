using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaVeterinario.Api.Contracts.Requests;
using SistemaVeterinario.Api.Contracts.Responses;
using SistemaVeterinario.Api.Services;

namespace SistemaVeterinario.Api.Controllers;

[ApiController]
[Route("api/archivos")]
[Authorize]
public sealed class FilesController : ControllerBase
{
    private readonly IFileStorageService storageService;
    private readonly ILogger<FilesController> logger;

    public FilesController(IFileStorageService storageService, ILogger<FilesController> logger)
    {
        this.storageService = storageService;
        this.logger = logger;
    }

    [HttpPost("{clienteId}")]
    [ProducesResponseType(typeof(FileResourceResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<FileResourceResponse>> CreateAsync(string clienteId, [FromBody] CreateFileResourceRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var response = await storageService.EnsureResourceAsync(clienteId, request, cancellationToken);
            return Created(string.Empty, response);
        }
        catch (ArgumentException ex)
        {
            logger.LogWarning(ex, "Error al crear recurso de archivos para el cliente {ClienteId}", clienteId);
            return ValidationProblem(new ValidationProblemDetails
            {
                Title = "Solicitud inválida",
                Detail = ex.Message,
                Status = StatusCodes.Status400BadRequest
            });
        }
        catch (InvalidOperationException ex)
        {
            logger.LogError(ex, "Configuración inválida al crear recurso de archivos");
            return Problem(ex.Message, statusCode: StatusCodes.Status500InternalServerError);
        }
    }
}
