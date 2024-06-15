
using System;
using System.Collections.Generic;

namespace SecretsAnalyser.Services
{
    public class SecretRetrievalService
    {
        public List<Secret> GetSecrets()
        {
            // Simplified secret retrieval logic
            return new List<Secret>
            {
                new Secret { Id = 1, Value = "Secret1" },
                new Secret { Id = 2, Value = "Secret2" }
            };
        }
    }
}
