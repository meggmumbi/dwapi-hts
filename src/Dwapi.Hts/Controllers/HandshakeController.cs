using System;
using System.Linq;
using System.Threading.Tasks;
using Dwapi.Hts.Core.Interfaces.Repository;
using Dwapi.Hts.Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Internal;
using Serilog;

namespace Dwapi.Hts.Controllers
{
    [Route("api/hts/[controller]")]
    [ApiController]
    public class HandshakeController : ControllerBase
    {
        private readonly IManifestRepository _manifestRepository;
        private readonly ILiveSyncService _liveSyncService;

        public HandshakeController(IManifestRepository manifestRepository, ILiveSyncService liveSyncService)
        {
            _manifestRepository = manifestRepository;
            _liveSyncService = liveSyncService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Guid session)
        {
            try
            {
                await _manifestRepository.EndSession(session);
                var handshakes = _manifestRepository
                    .GetSessionHandshakes(session)
                    .ToList();
                await _liveSyncService.SyncHandshake(handshakes);
                return Ok(session);
            }
            catch (Exception e)
            {
                Log.Error(e, "handshake error");
                return StatusCode(500, e.Message);
            }
        }
    }
}
