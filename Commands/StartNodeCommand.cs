



using System.Diagnostics;

namespace DMDVision.Commands 
{
  public class StartNodeCommand : TargetedCommand
  {
    public override string Execute(CommandContext context)
    {
      var nodeInfo = context.NodeInfos[this.TargetAddress];
      //NodeInfo
      var container = nodeInfo.DockerContainerName;

      var port = 30300 + nodeInfo.NodeID;

      //check node config path here.
      if ( context.TestnetRootDirectory.Exists)
      {
        throw new System.InvalidOperationException("Wrong configured TestnetRootDirectory: " + context.TestnetRootDirectory.FullName);
      }

      System.IO.Path.Combine(context.TestnetRootDirectory.FullName, "");

      //echo $PORT
      var cmd  = $"docker run --name {nodeInfo.DockerContainerName} -p 172.17.0.1:{port}:{port}/tcp -p 172.17.0.1:{port}:{port}/udp -v $(pwd)/nodes/node${nodeInfo.NodeID}:/node open-ethereum --config node.toml";

      Process p = System.Diagnostics.Process.Start(cmd);
      p.WaitForExit(10000);

      return "Node started!!";
    }
  }

}
