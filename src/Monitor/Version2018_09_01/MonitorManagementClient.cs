// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Version2018_09_01
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// Monitor Management Client
    /// </summary>
    public partial class MonitorManagementClient : ServiceClient<MonitorManagementClient>, IMonitorManagementClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// The Azure subscription Id.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IAutoscaleSettingsOperations.
        /// </summary>
        public virtual IAutoscaleSettingsOperations AutoscaleSettings { get; private set; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        public virtual IOperations Operations { get; private set; }

        /// <summary>
        /// Gets the IAlertRuleIncidentsOperations.
        /// </summary>
        public virtual IAlertRuleIncidentsOperations AlertRuleIncidents { get; private set; }

        /// <summary>
        /// Gets the IAlertRulesOperations.
        /// </summary>
        public virtual IAlertRulesOperations AlertRules { get; private set; }

        /// <summary>
        /// Gets the ILogProfilesOperations.
        /// </summary>
        public virtual ILogProfilesOperations LogProfiles { get; private set; }

        /// <summary>
        /// Gets the IDiagnosticSettingsOperations.
        /// </summary>
        public virtual IDiagnosticSettingsOperations DiagnosticSettings { get; private set; }

        /// <summary>
        /// Gets the IDiagnosticSettingsCategoryOperations.
        /// </summary>
        public virtual IDiagnosticSettingsCategoryOperations DiagnosticSettingsCategory { get; private set; }

        /// <summary>
        /// Gets the IActionGroupsOperations.
        /// </summary>
        public virtual IActionGroupsOperations ActionGroups { get; private set; }

        /// <summary>
        /// Gets the IActivityLogAlertsOperations.
        /// </summary>
        public virtual IActivityLogAlertsOperations ActivityLogAlerts { get; private set; }

        /// <summary>
        /// Gets the IActivityLogsOperations.
        /// </summary>
        public virtual IActivityLogsOperations ActivityLogs { get; private set; }

        /// <summary>
        /// Gets the IEventCategoriesOperations.
        /// </summary>
        public virtual IEventCategoriesOperations EventCategories { get; private set; }

        /// <summary>
        /// Gets the ITenantActivityLogsOperations.
        /// </summary>
        public virtual ITenantActivityLogsOperations TenantActivityLogs { get; private set; }

        /// <summary>
        /// Gets the IMetricDefinitionsOperations.
        /// </summary>
        public virtual IMetricDefinitionsOperations MetricDefinitions { get; private set; }

        /// <summary>
        /// Gets the IMetricsOperations.
        /// </summary>
        public virtual IMetricsOperations Metrics { get; private set; }

        /// <summary>
        /// Gets the IMetricBaselineOperations.
        /// </summary>
        public virtual IMetricBaselineOperations MetricBaseline { get; private set; }

        /// <summary>
        /// Gets the IMetricAlertsOperations.
        /// </summary>
        public virtual IMetricAlertsOperations MetricAlerts { get; private set; }

        /// <summary>
        /// Gets the IMetricAlertsStatusOperations.
        /// </summary>
        public virtual IMetricAlertsStatusOperations MetricAlertsStatus { get; private set; }

        /// <summary>
        /// Gets the IScheduledQueryRulesOperations.
        /// </summary>
        public virtual IScheduledQueryRulesOperations ScheduledQueryRules { get; private set; }

        /// <summary>
        /// Gets the IMetricNamespacesOperations.
        /// </summary>
        public virtual IMetricNamespacesOperations MetricNamespaces { get; private set; }

        /// <summary>
        /// Gets the IVMInsightsOperations.
        /// </summary>
        public virtual IVMInsightsOperations VMInsights { get; private set; }

        /// <summary>
        /// Initializes a new instance of the MonitorManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling MonitorManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        protected MonitorManagementClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the MonitorManagementClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected MonitorManagementClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the MonitorManagementClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected MonitorManagementClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the MonitorManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected MonitorManagementClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the MonitorManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected MonitorManagementClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the MonitorManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public MonitorManagementClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MonitorManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling MonitorManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public MonitorManagementClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MonitorManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public MonitorManagementClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MonitorManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public MonitorManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MonitorManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public MonitorManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            AutoscaleSettings = new AutoscaleSettingsOperations(this);
            Operations = new Operations(this);
            AlertRuleIncidents = new AlertRuleIncidentsOperations(this);
            AlertRules = new AlertRulesOperations(this);
            LogProfiles = new LogProfilesOperations(this);
            DiagnosticSettings = new DiagnosticSettingsOperations(this);
            DiagnosticSettingsCategory = new DiagnosticSettingsCategoryOperations(this);
            ActionGroups = new ActionGroupsOperations(this);
            ActivityLogAlerts = new ActivityLogAlertsOperations(this);
            ActivityLogs = new ActivityLogsOperations(this);
            EventCategories = new EventCategoriesOperations(this);
            TenantActivityLogs = new TenantActivityLogsOperations(this);
            MetricDefinitions = new MetricDefinitionsOperations(this);
            Metrics = new MetricsOperations(this);
            MetricBaseline = new MetricBaselineOperations(this);
            MetricAlerts = new MetricAlertsOperations(this);
            MetricAlertsStatus = new MetricAlertsStatusOperations(this);
            ScheduledQueryRules = new ScheduledQueryRulesOperations(this);
            MetricNamespaces = new MetricNamespacesOperations(this);
            VMInsights = new VMInsightsOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<RuleDataSource>("odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<RuleDataSource>("odata.type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<RuleCondition>("odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<RuleCondition>("odata.type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<RuleAction>("odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<RuleAction>("odata.type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<MetricAlertCriteria>("odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<MetricAlertCriteria>("odata.type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<MultiMetricCriteria>("criterionType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<MultiMetricCriteria>("criterionType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<Action>("odata.type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<Action>("odata.type"));
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
