using System.Collections.Generic;
using MBW.Client.SslLabsLib.Enums;

namespace MBW.Client.SslLabsLib.Objects;

public class CertificateChain
{
    /// <summary>
    /// Certificate chain ID
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// List of IDs of each certificate, representing the chain certificates in the order in which they were retrieved from the server
    /// </summary>
    public List<string> CertIds { get; set; } = null!;

    /// <summary>
    /// Trust paths
    /// </summary>
    public List<TrustPath> TrustPaths { get; set; } = null!;

    /// <summary>
    /// Flags indicating the issues with the certificate chain.
    /// </summary>
    public ChainIssues Issues { get; set; }

    /// <summary>
    /// True for certificate obtained only with No Server Name Indication (SNI).
    /// </summary>
    public bool NoSni { get; set; }
}