using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Newtonsoft.Json;
using AutoMapper.Internal;

namespace BusinessLayer
{
    public class JsonConverter : IJsonConverter
    {
        public string Convert(object model)
        {
            var type = model.GetType();

            var sb = new StringBuilder();
            sb.Append("{");

            foreach (var prop in type.GetProperties())
            {
                if (prop.IsPublic() && !Attribute.IsDefined(prop, typeof(MyIgnoreAttribute)))
                {
                    if(prop.PropertyType == typeof(string))
                    {
                        sb.Append($"\"{prop.Name}\": \"{prop.GetValue(model)}\",");
                    }
                    else
                    {
                        sb.Append($"\"{prop.Name}\": {prop.GetValue(model)},");
                    }
                }
            }

            sb.Remove(sb.Length - 1, 1);

            sb.Append("}");

            return sb.ToString();
        }
    }

    public interface IJsonConverter
    {
        string Convert(object model);
    }
}
