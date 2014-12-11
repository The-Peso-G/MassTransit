﻿// Copyright 2007-2014 Chris Patterson
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.Courier.InternalMessages
{
    using System;
    using Contracts;


    class ActivityExceptionImpl :
        ActivityException
    {
        public ActivityExceptionImpl(string activityName, HostInfo host, Guid activityTrackingNumber, DateTime timestamp, TimeSpan duration,
            ExceptionInfo exceptionInfo)
        {
            ActivityTrackingNumber = activityTrackingNumber;

            Timestamp = timestamp;
            Duration = duration;
            Name = activityName;
            Host = host;
            ExceptionInfo = exceptionInfo;
        }

        public Guid ActivityTrackingNumber { get; private set; }
        public DateTime Timestamp { get; private set; }
        public TimeSpan Duration { get; private set; }
        public string Name { get; private set; }
        public HostInfo Host { get; private set; }
        public ExceptionInfo ExceptionInfo { get; private set; }
    }
}