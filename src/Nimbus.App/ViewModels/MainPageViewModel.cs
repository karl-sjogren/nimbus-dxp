using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Nimbus.Core.Models;

namespace Nimbus.App.ViewModels;

public partial class MainPageViewModel : ObservableObject {
    [ObservableProperty]
    private bool _isLoading = false;

    public MainPageViewModel() {
#pragma warning disable RS0030 // Do not use banned APIs
        _deployments.Add(new DeploymentHistory {
            StartedAt = DateTimeOffset.Now.AddMinutes(-10),
            CompletedAt = DateTimeOffset.Now.AddMinutes(-8),
            Status = "Succeeded",
            SourcePackage = "v1.0.0",
            TargetEnvironment = "Production",
            StartedBy = "John Doe"
        });

        _deployments.Add(new DeploymentHistory {
            StartedAt = DateTimeOffset.Now,
            CompletedAt = DateTimeOffset.Now.AddMinutes(5),
            Status = "Failed",
            SourcePackage = "v1.0.1",
            TargetEnvironment = "Staging",
            StartedBy = "Jane Doe"
        });
#pragma warning restore RS0030 // Do not use banned APIs

        Deployments = [.. _deployments];
    }

    private readonly ICollection<DeploymentHistory> _deployments = [];

    public ObservableCollection<DeploymentHistory> Deployments { get; }
}
