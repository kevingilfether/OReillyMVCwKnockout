﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Web.Mvc;


namespace OReilleyMVCwKnockout.Extensions
{
    public static class HtmlHelperExtension
    {
        public static HtmlString HtmlConvertToJson(this HtmlHelper htmlHelper, object model)
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.Indented
            };
            return new HtmlString(JsonConvert.SerializeObject(model, settings));

        }
    }
}