using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Shared.Extensions
{
    public static class ObjectExtensions
    {
        public static string ToJSON(this object obj)
        {
            return JsonSerializer.Serialize(obj);
        }
    }
}
