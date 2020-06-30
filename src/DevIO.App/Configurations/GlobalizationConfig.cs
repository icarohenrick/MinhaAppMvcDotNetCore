using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using System.Collections.Generic;
using System.Globalization;

namespace DevIO.App.Configurations
{
    public static class GlobalizationConfig
    {
        public static IApplicationBuilder UseGlobalizationConf(this IApplicationBuilder app)
        {
            var defaultCuture = new CultureInfo("pt-BR");
            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(defaultCuture),
                SupportedCultures = new List<CultureInfo> { defaultCuture },
                SupportedUICultures = new List<CultureInfo> { defaultCuture }
            };

            app.UseRequestLocalization(localizationOptions);

            return app;
        }
    }
}
