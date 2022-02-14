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
    /// An AppBundle is a module that is used by an Activity in order to perform a particular action.
    /// </summary>
    [DataContract]
    public partial class AppBundle 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBundle" /> class.
        /// </summary>
        public AppBundle()
        {
        }
        
        /// <summary>
        /// The URL that points to the zip package for the AppBundle or Engine.
        /// </summary>
        /// <value>The URL that points to the zip package for the AppBundle or Engine.</value>
        [DataMember(Name="package", EmitDefaultValue=false)]
        public string Package { get; set; }

        /// <summary>
        /// The parameters needed to POST an AppBundle.
        /// </summary>
        /// <value>The parameters needed to POST an AppBundle.</value>
        [DataMember(Name="uploadParameters", EmitDefaultValue=false)]
        public UploadAppBundleParameters UploadParameters { get; set; }

        /// <summary>
        /// Name of AppBundle, see the example section.
        /// </summary>
        /// <value>Name of AppBundle, see the example section.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The actual processing engine that runs the WorkItem job and processes the Activity.
        /// </summary>
        /// <value>The actual processing engine that runs the WorkItem job and processes the Activity.</value>
        [DataMember(Name="engine", EmitDefaultValue=false)]
        public string Engine { get; set; }

        /// <summary>
        /// A module referenced by an Activity in order to perform specific functions. Typically this is a DLL or some other form of custom code.
        /// </summary>
        /// <value>A module referenced by an Activity in order to perform specific functions. Typically this is a DLL or some other form of custom code.</value>
        [DataMember(Name="appbundles", EmitDefaultValue=false)]
        public List<string> Appbundles { get; set; }

        /// <summary>
        /// The url/string Settings for a given set of AppBundles.
        /// </summary>
        /// <value>The url/string Settings for a given set of AppBundles.</value>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public Dictionary<string, ISetting> Settings { get; set; }

        /// <summary>
        /// Human readable description of the object.
        /// </summary>
        /// <value>Human readable description of the object.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }

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
