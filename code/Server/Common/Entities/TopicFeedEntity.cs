﻿// <copyright file="TopicFeedEntity.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace SocialPlus.Server.Entities
{
    using Microsoft.CTStore;

    /// <summary>
    /// Topic feed entity class
    /// </summary>
    public class TopicFeedEntity : FeedEntity, ITopicFeedEntity
    {
        /// <summary>
        /// Gets or sets topic handle
        /// </summary>
        public string TopicHandle { get; set; }

        /// <summary>
        /// Gets or sets user handle of the owner of the topic
        /// </summary>
        public string UserHandle { get; set; }

        /// <summary>
        /// Gets or sets app handle of app the topic belongs to
        /// </summary>
        public string AppHandle { get; set; }
    }
}
