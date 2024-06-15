
using System;
using System.Collections.Generic;

namespace SecretsAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            SecretRetrievalService service = new SecretRetrievalService();
            List<Secret> secrets = service.GetSecrets();

            foreach (Secret secret in secrets)
            {
                Console.WriteLine($"Secret ID: {secret.Id}, Secret Value: {secret.Value}");
            }
        }
    }
}
