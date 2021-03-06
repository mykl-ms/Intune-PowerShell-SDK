// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.remoteAssistancePartner&quot; objects.</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.remoteAssistancePartner&quot; objects in the &quot;remoteAssistancePartners&quot; collection.</para>
    ///     <para type="description">The remote assist partners.</para>
    ///     <para type="description">Graph call: GET ~/deviceManagement/remoteAssistancePartners</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "DeviceManagement_RemoteAssistancePartners", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.remoteAssistancePartner")]
    [ResourceTypePropertyName("remoteAssistancePartnerODataType")]
    [ResourceReference]
    [Alias("Get-IntuneRemoteAssistancePartner")]
    public class Get_DeviceManagement_RemoteAssistancePartners : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.remoteAssistancePartner&quot; object in the &quot;remoteAssistancePartners&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.remoteAssistancePartner&quot; object in the &quot;remoteAssistancePartners&quot; collection.")]
        public System.String remoteAssistancePartnerId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteAssistancePartner&quot; type.</para>
        ///     <para type="description">Display name of the partner.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onboardingUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteAssistancePartner&quot; type.</para>
        ///     <para type="description">URL of the partner&apos;s onboarding portal, where an administrator can configure their Remote Assistance service.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String onboardingUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onboardingStatus&quot; property, of type &quot;microsoft.graph.remoteAssistanceOnboardingStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteAssistancePartner&quot; type.</para>
        ///     <para type="description">TBD</para>
        /// </summary>
        [ODataType("microsoft.graph.remoteAssistanceOnboardingStatus")]
        [Selectable]
        [Sortable]
        public System.String onboardingStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastConnectionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteAssistancePartner&quot; type.</para>
        ///     <para type="description">Timestamp of the last request sent to Intune by the TEM partner.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastConnectionDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/remoteAssistancePartners/{remoteAssistancePartnerId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.remoteAssistancePartner&quot; object.</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.remoteAssistancePartner&quot; object to the &quot;remoteAssistancePartners&quot; collection.</para>
    ///     <para type="description">The remote assist partners.</para>
    ///     <para type="description">Graph call: POST ~/deviceManagement/remoteAssistancePartners</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "DeviceManagement_RemoteAssistancePartners", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.remoteAssistancePartner")]
    [ODataType("microsoft.graph.remoteAssistancePartner")]
    [ResourceTypePropertyName("remoteAssistancePartnerODataType")]
    [ResourceReference]
    [Alias("New-IntuneRemoteAssistancePartner")]
    public class New_DeviceManagement_RemoteAssistancePartners : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.remoteAssistancePartner&quot; object in the &quot;remoteAssistancePartners&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String remoteAssistancePartnerId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteAssistancePartner&quot; type.</para>
        ///     <para type="description">Display name of the partner.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteAssistancePartner", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onboardingUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteAssistancePartner&quot; type.</para>
        ///     <para type="description">URL of the partner&apos;s onboarding portal, where an administrator can configure their Remote Assistance service.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteAssistancePartner", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;onboardingUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;onboardingUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String onboardingUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onboardingStatus&quot; property, of type &quot;microsoft.graph.remoteAssistanceOnboardingStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteAssistancePartner&quot; type.</para>
        ///     <para type="description">TBD</para>
        ///     <para type="description">
        ///          Valid values: &apos;notOnboarded&apos;, &apos;onboarding&apos;, &apos;onboarded&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.remoteAssistanceOnboardingStatus")]
        [Selectable]
        [ValidateSet(@"notOnboarded", @"onboarding", @"onboarded")]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteAssistancePartner", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;onboardingStatus&quot; property, of type &quot;microsoft.graph.remoteAssistanceOnboardingStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;onboardingStatus&quot; property, of type &quot;microsoft.graph.remoteAssistanceOnboardingStatus&quot;.")]
        public System.String onboardingStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastConnectionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteAssistancePartner&quot; type.</para>
        ///     <para type="description">Timestamp of the last request sent to Intune by the TEM partner.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteAssistancePartner", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastConnectionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastConnectionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastConnectionDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/remoteAssistancePartners/{remoteAssistancePartnerId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.remoteAssistancePartner&quot;.</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.remoteAssistancePartner&quot; object in the &quot;remoteAssistancePartners&quot; collection.</para>
    ///     <para type="description">The remote assist partners.</para>
    ///     <para type="description">Graph Call: PATCH ~/deviceManagement/remoteAssistancePartners</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "DeviceManagement_RemoteAssistancePartners", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.remoteAssistancePartner")]
    [ODataType("microsoft.graph.remoteAssistancePartner")]
    [ResourceTypePropertyName("remoteAssistancePartnerODataType")]
    [Alias("Update-IntuneRemoteAssistancePartner")]
    public class Update_DeviceManagement_RemoteAssistancePartners : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.remoteAssistancePartner&quot; object in the &quot;remoteAssistancePartners&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.remoteAssistancePartner&quot; object in the &quot;remoteAssistancePartners&quot; collection.")]
        public System.String remoteAssistancePartnerId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteAssistancePartner&quot; type.</para>
        ///     <para type="description">Display name of the partner.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteAssistancePartner", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onboardingUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteAssistancePartner&quot; type.</para>
        ///     <para type="description">URL of the partner&apos;s onboarding portal, where an administrator can configure their Remote Assistance service.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteAssistancePartner", HelpMessage = @"The &quot;onboardingUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;onboardingUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String onboardingUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onboardingStatus&quot; property, of type &quot;microsoft.graph.remoteAssistanceOnboardingStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteAssistancePartner&quot; type.</para>
        ///     <para type="description">TBD</para>
        ///     <para type="description">
        ///          Valid values: &apos;notOnboarded&apos;, &apos;onboarding&apos;, &apos;onboarded&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.remoteAssistanceOnboardingStatus")]
        [Selectable]
        [ValidateSet(@"notOnboarded", @"onboarding", @"onboarded")]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteAssistancePartner", HelpMessage = @"The &quot;onboardingStatus&quot; property, of type &quot;microsoft.graph.remoteAssistanceOnboardingStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;onboardingStatus&quot; property, of type &quot;microsoft.graph.remoteAssistanceOnboardingStatus&quot;.")]
        public System.String onboardingStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastConnectionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteAssistancePartner&quot; type.</para>
        ///     <para type="description">Timestamp of the last request sent to Intune by the TEM partner.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteAssistancePartner", HelpMessage = @"The &quot;lastConnectionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastConnectionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastConnectionDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/remoteAssistancePartners/{remoteAssistancePartnerId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.remoteAssistancePartner&quot; object.</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.remoteAssistancePartner&quot; object from the &quot;remoteAssistancePartners&quot; collection.</para>
    ///     <para type="description">The remote assist partners.</para>
    ///     <para type="description">Graph Call: DELETE ~/deviceManagement/remoteAssistancePartners/remoteAssistancePartnerId</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "DeviceManagement_RemoteAssistancePartners", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.remoteAssistancePartner")]
    [ResourceTypePropertyName("remoteAssistancePartnerODataType")]
    [Alias("Remove-IntuneRemoteAssistancePartner")]
    public class Remove_DeviceManagement_RemoteAssistancePartners : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.remoteAssistancePartner&quot; object in the &quot;remoteAssistancePartners&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.remoteAssistancePartner&quot; object in the &quot;remoteAssistancePartners&quot; collection.")]
        public System.String remoteAssistancePartnerId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/remoteAssistancePartners/{remoteAssistancePartnerId}";
        }
    }

    /// <summary>
    ///     <para type="description">The action &quot;microsoft.graph.beginOnboarding&quot;, which exists on the type &quot;microsoft.graph.remoteAssistancePartner&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    ///     <para type="description">Graph Call: POST ~/deviceManagement/remoteAssistancePartners/beginOnboarding</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "DeviceManagement_RemoteAssistancePartners_BeginOnboarding", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.remoteAssistancePartner")]
    [ResourceTypePropertyName("remoteAssistancePartnerODataType")]
    [Alias("Invoke-IntuneRemoteAssistancePartnerBeginOnboarding")]
    public class Invoke_DeviceManagement_RemoteAssistancePartners_BeginOnboarding : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.remoteAssistancePartner&quot; object in the &quot;remoteAssistancePartners&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.remoteAssistancePartner&quot; object in the &quot;remoteAssistancePartners&quot; collection.")]
        public System.String remoteAssistancePartnerId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/remoteAssistancePartners/{remoteAssistancePartnerId}/beginOnboarding";
        }
    }

    /// <summary>
    ///     <para type="description">The action &quot;microsoft.graph.disconnect&quot;, which exists on the type &quot;microsoft.graph.remoteAssistancePartner&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    ///     <para type="description">Graph Call: POST ~/deviceManagement/remoteAssistancePartners/disconnect</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "DeviceManagement_RemoteAssistancePartners_Disconnect", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.remoteAssistancePartner")]
    [ResourceTypePropertyName("remoteAssistancePartnerODataType")]
    [Alias("Invoke-IntuneRemoteAssistancePartnerDisconnect")]
    public class Invoke_DeviceManagement_RemoteAssistancePartners_Disconnect : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.remoteAssistancePartner&quot; object in the &quot;remoteAssistancePartners&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.remoteAssistancePartner&quot; object in the &quot;remoteAssistancePartners&quot; collection.")]
        public System.String remoteAssistancePartnerId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/remoteAssistancePartners/{remoteAssistancePartnerId}/disconnect";
        }
    }
}