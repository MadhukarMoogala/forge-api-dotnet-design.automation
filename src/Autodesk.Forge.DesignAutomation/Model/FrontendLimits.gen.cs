/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *
 * Design Automation
 *
 * Generated by [Forge Swagger Codegen](https://git.autodesk.com/forge-ozone/forge-rsdk-codegen)
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Autodesk.Forge.DesignAutomation.Model
{
    /// <summary>
    /// Limits enforced by the frontend.
    /// </summary>
    [DataContract]
    public partial class FrontendLimits 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrontendLimits" /> class.
        /// </summary>
        public FrontendLimits()
        {
        }
        
        /// <summary>
        /// Max permitted size for App/Activity/Workitem json payload in kilobytes. Default is 16KB.
        /// </summary>
        /// <value>Max permitted size for App/Activity/Workitem json payload in kilobytes. Default is 16KB.</value>
        [DataMember(Name="limitPayloadSizeInKB", EmitDefaultValue=false)]
        public int? LimitPayloadSizeInKB { get; set; }

        /// <summary>
        /// Max permitted number of App/Activity versions a client can have at any one time. Default is 100.
        /// </summary>
        /// <value>Max permitted number of App/Activity versions a client can have at any one time. Default is 100.</value>
        [DataMember(Name="limitVersions", EmitDefaultValue=false)]
        public int? LimitVersions { get; set; }

        /// <summary>
        /// Max permitted number of aliases that a client can have at any one time. Default is 100.
        /// </summary>
        /// <value>Max permitted number of aliases that a client can have at any one time. Default is 100.</value>
        [DataMember(Name="limitAliases", EmitDefaultValue=false)]
        public int? LimitAliases { get; set; }

        /// <summary>
        /// Max permitted number of public aliases that a client can have at any one time. Default is 0.
        /// </summary>
        /// <value>Max permitted number of public aliases that a client can have at any one time. Default is 0.</value>
        [DataMember(Name="limitPublicAliases", EmitDefaultValue=false)]
        public int? LimitPublicAliases { get; set; }

        /// <summary>
        /// Max permitted size of an App upload in megabytes.
        /// </summary>
        /// <value>Max permitted size of an App upload in megabytes.</value>
        [DataMember(Name="limitAppUploadSizeInMB", EmitDefaultValue=false)]
        public int? LimitAppUploadSizeInMB { get; set; }

        /// <summary>
        /// Max commulative engine usage by client in a given calendar month. This limit applies to all engines. For example, if the limit is set to 1 hour then 30 minutes of Revit usage and 30 minutes of Inventor usage will reach limit.
        /// </summary>
        /// <value>Max commulative engine usage by client in a given calendar month. This limit applies to all engines. For example, if the limit is set to 1 hour then 30 minutes of Revit usage and 30 minutes of Inventor usage will reach limit.</value>
        [DataMember(Name="limitMonthlyProcessingTimeInHours", EmitDefaultValue=false)]
        public int? LimitMonthlyProcessingTimeInHours { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

}
