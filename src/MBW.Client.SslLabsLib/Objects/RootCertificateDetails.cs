using System.Collections.Generic;

namespace MBW.Client.SslLabsLib.Objects;

public class RootCertificateDetails
{
    public IList<string> Messages { get; set; } = [];
    public string EncodedCertificate { get; set; } = null!;
}