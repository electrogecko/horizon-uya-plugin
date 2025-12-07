using Server.Medius.Models;
using System.Threading.Tasks;

namespace Horizon.Plugin.UYA.CustomModes
{
    public class KothCustomMode : BaseCustomMode
    {
        public override CustomModeId Id => CustomModeId.CMODE_ID_KOTH;
        public override string Name => "KOTH";

        // No payload needed; KOTH logic lives in the patch
        public override Task<Payload> GetPayload(Server.Medius.Models.Game game, ClientObject client, GameMetadata metadata)
        {
            return Task.FromResult<Payload>(null);
        }
    }
}
