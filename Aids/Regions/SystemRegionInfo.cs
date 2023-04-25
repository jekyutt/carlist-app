using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using SemestriProject.Aids.Extensions;
using SemestriProject.Aids.Methods;

namespace SemestriProject.Aids.Regions {

    public static class SystemRegionInfo {

        public static bool IsCountry(RegionInfo r)
            => Safe.Run(() => r.ThreeLetterISORegionName.IsWord(), false);

        public static List<RegionInfo> GetRegions() {
            return Safe.Run(() => {
                var cultures = SystemCultureInfo.GetSpecific();
                var regions = Lists.Convert(cultures, SystemCultureInfo.ToRegionInfo);
                regions = Lists.Distinct(regions);
                var list = regions.ToList();
                removeAllButCountries(list);
                regions = Lists.OrderBy(list.ToArray(), p => p.EnglishName);

                return regions.ToList();
            }, new List<RegionInfo>());
        }

        private static void removeAllButCountries(IList<RegionInfo> cultures) {
            for (var i = cultures.Count; i > 0; i--) {
                var c = cultures[i - 1];

                if (c != null) continue;
                cultures.RemoveAt(i - 1);
            }
        }

    }

}


