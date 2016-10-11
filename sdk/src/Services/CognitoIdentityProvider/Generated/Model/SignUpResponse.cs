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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The response from the server for a registration request.
    /// </summary>
    public partial class SignUpResponse : AmazonWebServiceResponse
    {
        private CodeDeliveryDetailsType _codeDeliveryDetails;
        private bool? _userConfirmed;

        /// <summary>
        /// Gets and sets the property CodeDeliveryDetails.
        /// </summary>
        public CodeDeliveryDetailsType CodeDeliveryDetails
        {
            get { return this._codeDeliveryDetails; }
            set { this._codeDeliveryDetails = value; }
        }

        // Check to see if CodeDeliveryDetails property is set
        internal bool IsSetCodeDeliveryDetails()
        {
            return this._codeDeliveryDetails != null;
        }

        /// <summary>
        /// Gets and sets the property UserConfirmed. 
        /// <para>
        /// A response from the server indicating that a user registration has been confirmed.
        /// </para>
        /// </summary>
        public bool UserConfirmed
        {
            get { return this._userConfirmed.GetValueOrDefault(); }
            set { this._userConfirmed = value; }
        }

        // Check to see if UserConfirmed property is set
        internal bool IsSetUserConfirmed()
        {
            return this._userConfirmed.HasValue; 
        }

    }
}