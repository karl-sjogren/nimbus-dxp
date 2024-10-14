namespace Nimbus.Core.Models;

public class DeploymentHistory {
    public DateTimeOffset StartedAt { get; set; }
    public DateTimeOffset? CompletedAt { get; set; }
    public string? Status { get; set; }
    public string? SourcePackage { get; set; }
    public string? TargetEnvironment { get; set; }
    public string? StartedBy { get; set; }
}
