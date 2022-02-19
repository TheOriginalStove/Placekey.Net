using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Placekey.Core;

public interface IPlacekeyApiClient
{
    /// <summary>
    /// Operations related to grabbing placekeys
    /// </summary>
    IPlacekeyClient Placekey { get; }

    ILineageClient Lineage { get; }

}
