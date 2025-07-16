namespace MBW.Client.SslLabsLib.Objects;

public class HpkpPin
{
    /// <summary>
    /// The hash function in use, e.g. sha256
    /// </summary>
    public string HashFunction { get; set; } = null!;

    /// <summary>
    /// The fingerprint of the pin, hex encoded
    /// </summary>
    public string Value { get; set; } = null!;
}