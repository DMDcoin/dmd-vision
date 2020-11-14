

namespace DMDVision.Nodes 
{
  public class NodeInfo
  {

    /// Every Node gets and ID, counting from 1.
    /// This ID determines Ports.
    public int NodeID;
    public string MiningAddress;

    public string StakingAddress;

    public string Host = "localhost";

    public string DockerContainerName;

    public byte[] PublicKey;

    public System.Net.IPAddress IPAddress;

  }
}