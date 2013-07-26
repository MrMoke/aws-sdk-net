/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePipeline operation.
    /// 
    /// </summary>
    public partial class UpdatePipelineRequest : AmazonWebServiceRequest
    {
        private string id;
        private string name;
        private string inputBucket;
        private string role;
        private Notifications notifications;
        private PipelineOutputConfig contentConfig;
        private PipelineOutputConfig thumbnailConfig;

        /// <summary>
        /// 
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{13}-\w{6}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// 
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 40</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// 
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^(\w|\.|-){1,255}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string InputBucket
        {
            get { return this.inputBucket; }
            set { this.inputBucket = value; }
        }

        // Check to see if InputBucket property is set
        internal bool IsSetInputBucket()
        {
            return this.inputBucket != null;
        }

        /// <summary>
        /// 
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^arn:aws:iam::\w{12}:role/.+$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this.role != null;
        }

        /// <summary>
        /// The Amazon Simple Notification Service (Amazon SNS) topic or topics to notify in order to report job status. <important>To receive
        /// notifications, you must also subscribe to the new topic in the Amazon SNS console.</important>
        ///  
        /// </summary>
        public Notifications Notifications
        {
            get { return this.notifications; }
            set { this.notifications = value; }
        }

        // Check to see if Notifications property is set
        internal bool IsSetNotifications()
        {
            return this.notifications != null;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public PipelineOutputConfig ContentConfig
        {
            get { return this.contentConfig; }
            set { this.contentConfig = value; }
        }

        // Check to see if ContentConfig property is set
        internal bool IsSetContentConfig()
        {
            return this.contentConfig != null;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public PipelineOutputConfig ThumbnailConfig
        {
            get { return this.thumbnailConfig; }
            set { this.thumbnailConfig = value; }
        }

        // Check to see if ThumbnailConfig property is set
        internal bool IsSetThumbnailConfig()
        {
            return this.thumbnailConfig != null;
        }

    }
}
    