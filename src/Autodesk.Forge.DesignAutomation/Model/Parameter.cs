/* 
 * Forge Design Automation
 *
 * Generated by [Forge Swagger Codegen](https://git.autodesk.com/design-automation/forge-rsdk-codegen)
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
    /// Parameter
    /// </summary>
    [DataContract]
    public partial class Parameter 
    {
        /// <summary>
        /// Request method (get, put, patch or post).
        /// </summary>
        /// <value>Request method (get, put, patch or post).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerbEnum
        {
            
            /// <summary>
            /// Enum Get for value: get
            /// </summary>
            [EnumMember(Value = "get")]
            Get = 1,
            
            /// <summary>
            /// Enum Head for value: head
            /// </summary>
            [EnumMember(Value = "head")]
            Head = 2,
            
            /// <summary>
            /// Enum Put for value: put
            /// </summary>
            [EnumMember(Value = "put")]
            Put = 3,
            
            /// <summary>
            /// Enum Post for value: post
            /// </summary>
            [EnumMember(Value = "post")]
            Post = 4,
            
            /// <summary>
            /// Enum Patch for value: patch
            /// </summary>
            [EnumMember(Value = "patch")]
            Patch = 5,
            
            /// <summary>
            /// Enum Read for value: read
            /// </summary>
            [EnumMember(Value = "read")]
            Read = 6
        }

        /// <summary>
        /// Request method (get, put, patch or post).
        /// </summary>
        /// <value>Request method (get, put, patch or post).</value>
        [DataMember(Name="verb", EmitDefaultValue=false)]
        public VerbEnum Verb { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Parameter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Parameter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Parameter" /> class.
        /// </summary>
        /// <param name="Zip">The parameter references a zip file. This is how this is interpreted in various scenarios: 1. verb&#x3D;&#x3D;get implies that the byte stream should be unzipped to a folder designated by localName. 2. verb&#x3D;&#x3D;put, patch, post the contents of the file or folder designated by localName will be zipped and sent. 3. Any other verb values result in an error. Default is false. (default to false).</param>
        /// <param name="Ondemand">The parameter will be accessed by the appbundle on demand and should not be used by the system. Default is false. (default to false).</param>
        /// <param name="Verb">Request method (get, put, patch or post). (required).</param>
        /// <param name="Description">The description of the parameter..</param>
        /// <param name="Required">Specifies whether the corresponding WorkItem Argument is required. Default is false. (default to false).</param>
        /// <param name="LocalName">The file or folder where the contents of an UrlArgument are placed. Note that this may be different than the &#x60;localName&#x60; for input arguments when [Content-Disposition](http://www.w3.org/Protocols/rfc2616/rfc2616-sec19.html#sec19.5.1) header is specifified by the server. For &#x60;zip&#x60; &#x3D; &#x60;true&#x60; this is a folder name..</param>
        public Parameter(bool Zip = false, bool Ondemand = false, VerbEnum Verb = default(VerbEnum), string Description = default(string), bool Required = false, string LocalName = default(string))
        {
            this.Zip = Zip;
            this.Ondemand = Ondemand;
            this.Verb = Verb;
            this.Description = Description;
            this.Required = Required;
            this.LocalName = LocalName;
        }
        
        /// <summary>
        /// The parameter references a zip file. This is how this is interpreted in various scenarios: 1. verb&#x3D;&#x3D;get implies that the byte stream should be unzipped to a folder designated by localName. 2. verb&#x3D;&#x3D;put, patch, post the contents of the file or folder designated by localName will be zipped and sent. 3. Any other verb values result in an error. Default is false.
        /// </summary>
        /// <value>The parameter references a zip file. This is how this is interpreted in various scenarios: 1. verb&#x3D;&#x3D;get implies that the byte stream should be unzipped to a folder designated by localName. 2. verb&#x3D;&#x3D;put, patch, post the contents of the file or folder designated by localName will be zipped and sent. 3. Any other verb values result in an error. Default is false.</value>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public bool Zip { get; set; }

        /// <summary>
        /// The parameter will be accessed by the appbundle on demand and should not be used by the system. Default is false.
        /// </summary>
        /// <value>The parameter will be accessed by the appbundle on demand and should not be used by the system. Default is false.</value>
        [DataMember(Name="ondemand", EmitDefaultValue=false)]
        public bool Ondemand { get; set; }


        /// <summary>
        /// The description of the parameter.
        /// </summary>
        /// <value>The description of the parameter.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether the corresponding WorkItem Argument is required. Default is false.
        /// </summary>
        /// <value>Specifies whether the corresponding WorkItem Argument is required. Default is false.</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool Required { get; set; }

        /// <summary>
        /// The file or folder where the contents of an UrlArgument are placed. Note that this may be different than the &#x60;localName&#x60; for input arguments when [Content-Disposition](http://www.w3.org/Protocols/rfc2616/rfc2616-sec19.html#sec19.5.1) header is specifified by the server. For &#x60;zip&#x60; &#x3D; &#x60;true&#x60; this is a folder name.
        /// </summary>
        /// <value>The file or folder where the contents of an UrlArgument are placed. Note that this may be different than the &#x60;localName&#x60; for input arguments when [Content-Disposition](http://www.w3.org/Protocols/rfc2616/rfc2616-sec19.html#sec19.5.1) header is specifified by the server. For &#x60;zip&#x60; &#x3D; &#x60;true&#x60; this is a folder name.</value>
        [DataMember(Name="localName", EmitDefaultValue=false)]
        public string LocalName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

}