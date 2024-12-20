// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Http logs to file system configuration.
/// </summary>
public partial class FileSystemHttpLogsConfig : ProvisionableConstruct
{
    /// <summary>
    /// Maximum size in megabytes that http log files can use.             When
    /// reached old log files will be removed to make space for new ones.
    /// Value can range between 25 and 100.
    /// </summary>
    public BicepValue<int> RetentionInMb 
    {
        get { Initialize(); return _retentionInMb!; }
        set { Initialize(); _retentionInMb!.Assign(value); }
    }
    private BicepValue<int>? _retentionInMb;

    /// <summary>
    /// Retention in days.             Remove files older than X days.
    /// 0 or lower means no retention.
    /// </summary>
    public BicepValue<int> RetentionInDays 
    {
        get { Initialize(); return _retentionInDays!; }
        set { Initialize(); _retentionInDays!.Assign(value); }
    }
    private BicepValue<int>? _retentionInDays;

    /// <summary>
    /// True if configuration is enabled, false if it is disabled and null if
    /// configuration is not set.
    /// </summary>
    public BicepValue<bool> IsEnabled 
    {
        get { Initialize(); return _isEnabled!; }
        set { Initialize(); _isEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isEnabled;

    /// <summary>
    /// Creates a new FileSystemHttpLogsConfig.
    /// </summary>
    public FileSystemHttpLogsConfig()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of FileSystemHttpLogsConfig.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _retentionInMb = DefineProperty<int>("RetentionInMb", ["retentionInMb"]);
        _retentionInDays = DefineProperty<int>("RetentionInDays", ["retentionInDays"]);
        _isEnabled = DefineProperty<bool>("IsEnabled", ["enabled"]);
    }
}
