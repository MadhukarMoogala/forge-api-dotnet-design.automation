/* 
 * Forge Design Automation
 *
 * Generated by [Forge Swagger Codegen](https://git.autodesk.com/forge-ozone/forge-rsdk-codegen)
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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
        /// Gets or Sets Engine
        /// </summary>
        [DataMember(Name="engine", EmitDefaultValue=false)]
        public string Engine { get; set; }

        /// <summary>
        /// Gets or Sets Appbundles
        /// </summary>
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
        public int Version { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

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