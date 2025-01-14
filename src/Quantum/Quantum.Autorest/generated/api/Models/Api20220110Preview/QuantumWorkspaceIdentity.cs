// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Quantum.Models.Api20220110Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Quantum.Runtime.Extensions;

    /// <summary>Managed Identity information.</summary>
    public partial class QuantumWorkspaceIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Quantum.Models.Api20220110Preview.IQuantumWorkspaceIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.Quantum.Models.Api20220110Preview.IQuantumWorkspaceIdentityInternal
    {

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Quantum.Models.Api20220110Preview.IQuantumWorkspaceIdentityInternal.PrincipalId { get => this._principalId; set { {_principalId = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Quantum.Models.Api20220110Preview.IQuantumWorkspaceIdentityInternal.TenantId { get => this._tenantId; set { {_tenantId = value;} } }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quantum.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quantum.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quantum.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quantum.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Quantum.Support.ResourceIdentityType? _type;

        /// <summary>The identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quantum.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quantum.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Quantum.Support.ResourceIdentityType? Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="QuantumWorkspaceIdentity" /> instance.</summary>
        public QuantumWorkspaceIdentity()
        {

        }
    }
    /// Managed Identity information.
    public partial interface IQuantumWorkspaceIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Quantum.Runtime.IJsonSerializable
    {
        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quantum.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The principal ID of resource identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get;  }
        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quantum.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant ID of resource.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }
        /// <summary>The identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quantum.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Quantum.Support.ResourceIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Quantum.Support.ResourceIdentityType? Type { get; set; }

    }
    /// Managed Identity information.
    internal partial interface IQuantumWorkspaceIdentityInternal

    {
        /// <summary>The principal ID of resource identity.</summary>
        string PrincipalId { get; set; }
        /// <summary>The tenant ID of resource.</summary>
        string TenantId { get; set; }
        /// <summary>The identity type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Quantum.Support.ResourceIdentityType? Type { get; set; }

    }
}