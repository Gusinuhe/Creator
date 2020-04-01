﻿using Innoactive.Creator.Core.Configuration;

namespace Innoactive.CreatorEditor
{
    /// <summary>
    /// Will setup a <see cref="RuntimeConfigurator"/> when none is existent in scene.
    /// </summary>
    public class RuntimeConfigurationSetup : SceneSetup
    {
        /// <inheritdoc/>
        public override void Setup()
        {
            if (RuntimeConfigurator.Exists == false)
            {
                RuntimeConfigurator configurator = RuntimeConfigurator.Instance;
            }
        }
    }
}