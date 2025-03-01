// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Extensions;

    /// <summary>All Customer-managed key encryption properties for the resource.</summary>
    public partial class CustomerManagedKeyEncryption :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.ICustomerManagedKeyEncryption,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.ICustomerManagedKeyEncryptionInternal
    {

        /// <summary>Backing field for <see cref="KeyEncryptionKeyIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.ICustomerManagedKeyEncryptionKeyIdentity _keyEncryptionKeyIdentity;

        /// <summary>
        /// All identity configuration for Customer-managed key settings defining which identity should be used to auth to Key Vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.ICustomerManagedKeyEncryptionKeyIdentity KeyEncryptionKeyIdentity { get => (this._keyEncryptionKeyIdentity = this._keyEncryptionKeyIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.CustomerManagedKeyEncryptionKeyIdentity()); set => this._keyEncryptionKeyIdentity = value; }

        /// <summary>
        /// delegated identity to use for accessing key encryption key Url. Ex: /subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/<resource
        /// group>/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. Mutually exclusive with identityType systemAssignedIdentity
        /// and userAssignedIdentity - internal use only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public string KeyEncryptionKeyIdentityDelegatedIdentityClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.ICustomerManagedKeyEncryptionKeyIdentityInternal)KeyEncryptionKeyIdentity).DelegatedIdentityClientId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.ICustomerManagedKeyEncryptionKeyIdentityInternal)KeyEncryptionKeyIdentity).DelegatedIdentityClientId = value ?? null; }

        /// <summary>Values can be systemAssignedIdentity or userAssignedIdentity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.IdentityType? KeyEncryptionKeyIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.ICustomerManagedKeyEncryptionKeyIdentityInternal)KeyEncryptionKeyIdentity).IdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.ICustomerManagedKeyEncryptionKeyIdentityInternal)KeyEncryptionKeyIdentity).IdentityType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.IdentityType)""); }

        /// <summary>
        /// user assigned identity to use for accessing key encryption key Url. Ex: /subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/<resource
        /// group>/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. Mutually exclusive with identityType systemAssignedIdentity
        /// and delegatedResourceIdentity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public string KeyEncryptionKeyIdentityUserAssignedIdentityResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.ICustomerManagedKeyEncryptionKeyIdentityInternal)KeyEncryptionKeyIdentity).UserAssignedIdentityResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.ICustomerManagedKeyEncryptionKeyIdentityInternal)KeyEncryptionKeyIdentity).UserAssignedIdentityResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="KeyEncryptionKeyUrl" /> property.</summary>
        private string _keyEncryptionKeyUrl;

        /// <summary>
        /// key encryption key Url, versioned or non-versioned. Ex: https://contosovault.vault.azure.net/keys/contosokek/562a4bb76b524a1493a6afe8e536ee78
        /// or https://contosovault.vault.azure.net/keys/contosokek.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        public string KeyEncryptionKeyUrl { get => this._keyEncryptionKeyUrl; set => this._keyEncryptionKeyUrl = value; }

        /// <summary>Internal Acessors for KeyEncryptionKeyIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.ICustomerManagedKeyEncryptionKeyIdentity Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.ICustomerManagedKeyEncryptionInternal.KeyEncryptionKeyIdentity { get => (this._keyEncryptionKeyIdentity = this._keyEncryptionKeyIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.CustomerManagedKeyEncryptionKeyIdentity()); set { {_keyEncryptionKeyIdentity = value;} } }

        /// <summary>Creates an new <see cref="CustomerManagedKeyEncryption" /> instance.</summary>
        public CustomerManagedKeyEncryption()
        {

        }
    }
    /// All Customer-managed key encryption properties for the resource.
    public partial interface ICustomerManagedKeyEncryption :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IJsonSerializable
    {
        /// <summary>
        /// delegated identity to use for accessing key encryption key Url. Ex: /subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/<resource
        /// group>/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. Mutually exclusive with identityType systemAssignedIdentity
        /// and userAssignedIdentity - internal use only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"delegated identity to use for accessing key encryption key Url. Ex: /subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/<resource group>/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. Mutually exclusive with identityType systemAssignedIdentity and userAssignedIdentity - internal use only.",
        SerializedName = @"delegatedIdentityClientId",
        PossibleTypes = new [] { typeof(string) })]
        string KeyEncryptionKeyIdentityDelegatedIdentityClientId { get; set; }
        /// <summary>Values can be systemAssignedIdentity or userAssignedIdentity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Values can be systemAssignedIdentity or userAssignedIdentity",
        SerializedName = @"identityType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.IdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.IdentityType? KeyEncryptionKeyIdentityType { get; set; }
        /// <summary>
        /// user assigned identity to use for accessing key encryption key Url. Ex: /subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/<resource
        /// group>/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. Mutually exclusive with identityType systemAssignedIdentity
        /// and delegatedResourceIdentity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"user assigned identity to use for accessing key encryption key Url. Ex: /subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/<resource group>/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. Mutually exclusive with identityType systemAssignedIdentity and delegatedResourceIdentity.",
        SerializedName = @"userAssignedIdentityResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string KeyEncryptionKeyIdentityUserAssignedIdentityResourceId { get; set; }
        /// <summary>
        /// key encryption key Url, versioned or non-versioned. Ex: https://contosovault.vault.azure.net/keys/contosokek/562a4bb76b524a1493a6afe8e536ee78
        /// or https://contosovault.vault.azure.net/keys/contosokek.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"key encryption key Url, versioned or non-versioned. Ex: https://contosovault.vault.azure.net/keys/contosokek/562a4bb76b524a1493a6afe8e536ee78 or https://contosovault.vault.azure.net/keys/contosokek.",
        SerializedName = @"keyEncryptionKeyUrl",
        PossibleTypes = new [] { typeof(string) })]
        string KeyEncryptionKeyUrl { get; set; }

    }
    /// All Customer-managed key encryption properties for the resource.
    internal partial interface ICustomerManagedKeyEncryptionInternal

    {
        /// <summary>
        /// All identity configuration for Customer-managed key settings defining which identity should be used to auth to Key Vault.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.ICustomerManagedKeyEncryptionKeyIdentity KeyEncryptionKeyIdentity { get; set; }
        /// <summary>
        /// delegated identity to use for accessing key encryption key Url. Ex: /subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/<resource
        /// group>/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. Mutually exclusive with identityType systemAssignedIdentity
        /// and userAssignedIdentity - internal use only.
        /// </summary>
        string KeyEncryptionKeyIdentityDelegatedIdentityClientId { get; set; }
        /// <summary>Values can be systemAssignedIdentity or userAssignedIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.IdentityType? KeyEncryptionKeyIdentityType { get; set; }
        /// <summary>
        /// user assigned identity to use for accessing key encryption key Url. Ex: /subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/<resource
        /// group>/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. Mutually exclusive with identityType systemAssignedIdentity
        /// and delegatedResourceIdentity.
        /// </summary>
        string KeyEncryptionKeyIdentityUserAssignedIdentityResourceId { get; set; }
        /// <summary>
        /// key encryption key Url, versioned or non-versioned. Ex: https://contosovault.vault.azure.net/keys/contosokek/562a4bb76b524a1493a6afe8e536ee78
        /// or https://contosovault.vault.azure.net/keys/contosokek.
        /// </summary>
        string KeyEncryptionKeyUrl { get; set; }

    }
}