/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OpsItemInvalidParameterException Object
    /// </summary>  
    public class OpsItemInvalidParameterExceptionUnmarshaller : IErrorResponseUnmarshaller<OpsItemInvalidParameterException, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public OpsItemInvalidParameterException Unmarshall(JsonUnmarshallerContext context)
        {
            return this.Unmarshall(context, new Amazon.Runtime.Internal.ErrorResponse());
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="errorResponse"></param>
        /// <returns></returns>
        public OpsItemInvalidParameterException Unmarshall(JsonUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse)
        {
            context.Read();

            OpsItemInvalidParameterException unmarshalledObject = new OpsItemInvalidParameterException(errorResponse.Message, errorResponse.InnerException,
                errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ParameterNames", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ParameterNames = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }

        private static OpsItemInvalidParameterExceptionUnmarshaller _instance = new OpsItemInvalidParameterExceptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OpsItemInvalidParameterExceptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}