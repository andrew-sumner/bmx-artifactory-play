﻿using Inedo.BuildMaster;
using Inedo.BuildMaster.Extensibility.Configurers.Extension;
using Inedo.BuildMaster.Web;

[assembly: ExtensionConfigurer(typeof(Inedo.BuildMasterExtensions.Artifactory.ArtifactoryConfigurer))]

namespace Inedo.BuildMasterExtensions.Artifactory
{

    [CustomEditor(typeof(ArtifactoryConfigurerEditor))]
    public class ArtifactoryConfigurer : ExtensionConfigurerBase 
    {
        [Persistent]
        public string Server { get; set; }

        [Persistent]
        public string Username { get; set; }

        [Persistent]
        public string Password { get; set; }

        public override string ToString()
        {
            return string.Empty;
        }
    }
}
