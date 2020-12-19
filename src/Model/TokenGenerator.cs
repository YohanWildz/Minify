using System;
using Minify.Interfaces;

namespace Minify.Model
{
    public class TokenGenerator : ITokenGenerator
    {
        public string Generate()
        {
            return Guid.NewGuid().ToString();
        }
    }
}