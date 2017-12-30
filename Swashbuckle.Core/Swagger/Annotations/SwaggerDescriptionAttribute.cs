using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Swashbuckle.Swagger.Annotations
{
    public class SwaggerDescriptionAttribute : Attribute
    {
        public SwaggerDescriptionAttribute(string description = null, string summary = null)
        {
            this.Description = description;
            this.Summary = summary;
        }

        public string Description { get; set; }
        public string Summary { get; set; }
    }
}
