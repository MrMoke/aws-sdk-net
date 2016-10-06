/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SourceDetail Marshaller
    /// </summary>       
    public class SourceDetailMarshaller : IRequestMarshaller<SourceDetail, JsonMarshallerContext> 
    {
        public void Marshall(SourceDetail requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEventSource())
            {
                context.Writer.WritePropertyName("EventSource");
                context.Writer.Write(requestObject.EventSource);
            }

            if(requestObject.IsSetMessageType())
            {
                context.Writer.WritePropertyName("MessageType");
                context.Writer.Write(requestObject.MessageType);
            }

        }

        public readonly static SourceDetailMarshaller Instance = new SourceDetailMarshaller();

    }
}