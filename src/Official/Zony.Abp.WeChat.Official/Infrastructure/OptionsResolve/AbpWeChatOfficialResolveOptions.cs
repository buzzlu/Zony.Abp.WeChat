﻿using System.Collections.Generic;
using JetBrains.Annotations;

namespace Zony.Abp.WeChat.Official.Infrastructure.OptionsResolve
{
    public class AbpWeChatOfficialResolveOptions
    {
        [NotNull] public List<IWeChatOfficialOptionsResolveContributor> WeChatOfficialOptionsResolveContributors { get; }

        public AbpWeChatOfficialResolveOptions()
        {
            WeChatOfficialOptionsResolveContributors = new List<IWeChatOfficialOptionsResolveContributor>
            {
                new ConfigurationOptionsResolveContributor()
            };
        }
    }
}